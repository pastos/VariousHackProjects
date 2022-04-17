using System;
using System.Threading;
using System.Windows.Forms;

namespace EmpiresAndPuzzles
{
    public partial class Form1 : Form
    {
        private Thread Thread1;
        private Thread TimerThread;
        private Thread CountdownToStartThread;

        private EmpiresAndPuzzlesLevelFarm empiresAndPuzzlesLevelFarm;

        private bool hasStartedAtLeastOnce;
        private bool areStepsRunning;
        private bool areTimersRunning;
        private bool hasStartInTheFuture;

        public Form1()
        {
            InitializeComponent();
        }

        #region Events
        private void btnScan_Click(object sender, EventArgs e)
        {
            empiresAndPuzzlesLevelFarm = new EmpiresAndPuzzlesLevelFarm(txtWindowName.Text);
            hasStartInTheFuture = chkStartIn.Checked;
            areStepsRunning = true;
            areTimersRunning = true;

            if (hasStartInTheFuture)
            {
                CountdownToStartThread = new Thread(new ThreadStart(RunCountdownTimerForFutureStart));
                CountdownToStartThread.Start();
            }
            else
            {
                Start();
            }
        }

        private void btnStopAll_Click(object sender, EventArgs e)
        {
            Stop();
        }
        #endregion

        private void Start()
        {
            Thread1 = new Thread(new ThreadStart(RunSteps));
            TimerThread = new Thread(new ThreadStart(RunTimers));

            if (!Thread1.IsAlive)
            {
                Thread1.Start();
            }

            if (!TimerThread.IsAlive)
            {
                TimerThread.Start();
            }
            hasStartedAtLeastOnce = true;
        }

        private void Stop()
        {
            areTimersRunning = false;
            areStepsRunning = false;
            hasStartInTheFuture = false;
        }

        #region Methods that run in threads
        private void RunSteps()
        {
            //if (areStepsRunning)
            {
                bool hasEnoughEnergy = numCurrentWorldEnergy.Value > numEnergyPerFight.Value - 1;

                empiresAndPuzzlesLevelFarm.ReplayButton();
                empiresAndPuzzlesLevelFarm.Wait(1);
                empiresAndPuzzlesLevelFarm.NextButton();
                empiresAndPuzzlesLevelFarm.Wait(4);

                while (hasEnoughEnergy && areStepsRunning)
                {
                    //check it all the time in case we stop it from GUI or hit ESC.
                    //We want to make sure the thread ends its tasks.
                    //if (areStepsRunning)
                    {
                        empiresAndPuzzlesLevelFarm.FightButton();
                        empiresAndPuzzlesLevelFarm.Wait(4);
                        empiresAndPuzzlesLevelFarm.FightAnywayButton();
                        empiresAndPuzzlesLevelFarm.Wait(3);
                        UpdateCurrentEnergy();

                        empiresAndPuzzlesLevelFarm.AutoPlayButton();
                        empiresAndPuzzlesLevelFarm.Wait((double)numSecondsToReplay.Value);

                        empiresAndPuzzlesLevelFarm.ReplayButton();
                        empiresAndPuzzlesLevelFarm.Wait(4);
                    }

                    //check it all the time in case we stop it from GUI or hit ESC.
                    //We want to make sure the thread ends its tasks.
                    //if (areStepsRunning)
                    //{
                    //    empiresAndPuzzlesLevelFarm.AutoPlayButton();
                    //    empiresAndPuzzlesLevelFarm.Wait((double)numSecondsToReplay.Value);
                    //}

                    ////check it all the time in case we stop it from GUI or hit ESC.
                    ////We want to make sure the thread ends its tasks.
                    //if (areStepsRunning)
                    //{
                    //    empiresAndPuzzlesLevelFarm.ReplayButton();
                    //    empiresAndPuzzlesLevelFarm.Wait(6);
                    //}

                    hasEnoughEnergy = numCurrentWorldEnergy.Value > numEnergyPerFight.Value - 1;
                }
                areStepsRunning = false;
            }
        }

        private void RunTimers()
        {
            DateTime now = DateTime.Now;
            DateTime nowSeconds = DateTime.Now;
            int secondsPerEnergy = (int)numMinutesPerEnergy.Value * 60;

            while (areTimersRunning)
            {
                TimeSpan countDown = DateTime.Now - now;
                secondsPerEnergy = (int)numMinutesPerEnergy.Value * 60;

                if (!areStepsRunning) //if steps are not running then keep it alive
                {
                    int requiredEnergyToFight = (int)(numEnergyPerFight.Value - numCurrentWorldEnergy.Value);
                    UpdateCountdown(lblCountdownNextAction, requiredEnergyToFight * secondsPerEnergy - (int)countDown.TotalSeconds);

                    double keepAliveCountdown = (DateTime.Now - nowSeconds).TotalSeconds;
                    if (keepAliveCountdown > (double)numKeepAliveInterval.Value)
                    {
                        nowSeconds = DateTime.Now;
                        empiresAndPuzzlesLevelFarm.KeepAlive(chkKeepAlive.Checked);
                    }
                }
                else
                {
                    UpdateCountdown(lblCountdownNextAction, (int)empiresAndPuzzlesLevelFarm.TimeTillNextAction);
                }

                //to replenish energy
                if (numCurrentWorldEnergy.Value < numTotalWorldEnergy.Value)
                {
                    if (countDown.TotalMinutes >= (double)numMinutesPerEnergy.Value)
                    {
                        now = DateTime.Now;
                        numCurrentWorldEnergy.Invoke(new Action(
                                                                    () => { numCurrentWorldEnergy.Value += 1; }
                                                               )
                                                    );
                    }

                    if (numCurrentWorldEnergy.Value >= numEnergyPerFight.Value)
                    {
                        if (hasStartedAtLeastOnce)
                        {
                            if (!Thread1.IsAlive)
                            {
                                Thread1 = new Thread(new ThreadStart(RunSteps));
                                areStepsRunning = true;
                                Thread1.Start();
                            }
                        }
                    }

                    UpdateCountdown(lblCountdownEnergy, secondsPerEnergy - (int)countDown.TotalSeconds);
                }
                else
                {
                    now = DateTime.Now;
                }
                empiresAndPuzzlesLevelFarm.Wait(1);
            }
        }

        private void RunCountdownTimerForFutureStart()
        {
            DateTime now = DateTime.Now;
            int minutesToStart = (int)numStartInMinutes.Value;
            int secondsToStart = (int)numStartInSeconds.Value;
            int totalSecondsToStart = secondsToStart + minutesToStart * 60;
            int remainingSeconds = totalSecondsToStart;

            while (hasStartInTheFuture && remainingSeconds > 0)
            {
                TimeSpan span = DateTime.Now - now;
                int elapsedSeconds = (int)span.TotalSeconds;
                remainingSeconds = totalSecondsToStart - elapsedSeconds;

                empiresAndPuzzlesLevelFarm.Wait(0.950); //it also sleeps for 50ms inside this method, so a total of 1 second.
                UpdateCountdown(lblCountdownNextAction, remainingSeconds);

                numStartInMinutes.Invoke(new Action(
                                                    () => { numStartInMinutes.Value = remainingSeconds / 60; }
                                                   )
                                        );

                numStartInSeconds.Invoke(new Action(
                                                    () => { numStartInSeconds.Value = remainingSeconds % 60; }
                                                   )
                                        );
            }

            chkStartIn.Invoke(new Action(
                                           () => { chkStartIn.Checked = false; }
                                        )
                             );
            hasStartInTheFuture = false;
            Start();
        }

        private void UpdateCountdown(Label label, int actionTimeInSeconds, int elapsedSeconds)
        {
            int remainingSecondsToEnergy = actionTimeInSeconds - elapsedSeconds;
            string remainingTime = string.Format("{0}:{1}", (remainingSecondsToEnergy / 60).ToString(), (remainingSecondsToEnergy % 60).ToString("0#"));
            label.Invoke(new Action(
                                        () => { label.Text = remainingTime; }
                                        )
                            );
        }

        private void UpdateCountdown(Label label, int remainingSeconds)
        {
            string remainingTime = string.Format("{0}:{1}", (remainingSeconds / 60).ToString(), (remainingSeconds % 60).ToString("0#"));
            label.Invoke(new Action(
                                        () => { label.Text = remainingTime; }
                                        )
                            );
        }

        private void UpdateCurrentEnergy()
        {
            numCurrentWorldEnergy.Invoke(new Action(
                                                    () =>
                                                    {
                                                        if (numCurrentWorldEnergy.Value - numEnergyPerFight.Value >= 0)
                                                        {
                                                            numCurrentWorldEnergy.Value -= numEnergyPerFight.Value;
                                                        }
                                                        else
                                                        {
                                                            numCurrentWorldEnergy.Value = 0;
                                                        }
                                                    }
                                                   )
                                        );
        }
        #endregion
    }
}