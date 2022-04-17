using System;
using System.Threading;
using System.Windows.Forms;

namespace YouShallNotBreak
{
    public partial class MainForm : Form
    {
        private Thread Thread1;
        private Thread TimerThread;
        private TilePosition[,] CurrentGridTile;
        MousePoint _Point = new MousePoint();
        
        System.Diagnostics.Stopwatch _timer;
        int codeGeneratedCount = 0; //training mode
        int clickDelay = 2;

        public MainForm()
        {
            InitializeComponent();
        }

        #region Button Events

        private void btnStart_Click(object sender, EventArgs e)
        {
            Start();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            Stop();
        }

        bool _isTrainingMode;


        private void btnTrain_Click(object sender, EventArgs e)
        {
            Thread1 = new Thread(new ThreadStart(RunTrainingMode));
            _isTrainingMode = !_isTrainingMode;

            if (_isTrainingMode)
            {
                InputActivityMonitor.HookManager.MouseClick += Mouse_Clicked;
                InputActivityMonitor.HookManager.MouseMove += Mouse_Moved;
            }
            else
            {
                InputActivityMonitor.HookManager.MouseClick -= Mouse_Clicked;
                InputActivityMonitor.HookManager.MouseMove -= Mouse_Moved;
            }

            if (!Thread1.IsAlive)
            {
                Thread1.Start();
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Stop();
        }

        //on global hook
        void Mouse_Clicked(object sender, MouseEventArgs e)
        {
            if (_isTrainingMode)
            {
                if (e.Clicks == 1)
                {
                    CaptureMousePosition(e);
                }
            }
        }

        void Mouse_Moved(object sender, MouseEventArgs e)
        {
            if (_isTrainingMode)
            {
                _Point.X = e.X;
                _Point.Y = e.Y;
            }
        }
        
        void Keyboard_Down(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.B)
            {
                if (clickDelay == 2)
                {
                    clickDelay = 25;
                }
                else
                {
                    clickDelay = 2;
                }
            }
        }

        private void ddlGridSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedText = ddlGridSize.SelectedItem.ToString();
            if (selectedText == "4x4")
            {
                CurrentGridTile = FourByFour();
            }
            else if (selectedText == "5x5")
            {
                CurrentGridTile = FiveByFive();
            }
            else if (selectedText == "6x6")
            {
                CurrentGridTile = SixBySix();
            }
            else if (selectedText == "7x7")
            {
                CurrentGridTile = SevenBySeven();
            }
            else
            {
                CurrentGridTile = FourByFour();
            }
        }

        #endregion

        private void Start()
        {
            TimerThread = new Thread(new ThreadStart(RunTimers));
            Thread1 = new Thread(new ThreadStart(RunSteps));

            InputActivityMonitor.HookManager.KeyDown += Keyboard_Down;

            if (!TimerThread.IsAlive)
            {
                TimerThread.Start();
            }

            if (!Thread1.IsAlive)
            {
                Thread1.Start();
            }
        }

        private void Stop()
        {
            _isTrainingMode = false;
            //numRunningTime.Value = 0;
            _timer.Stop();
            InputActivityMonitor.HookManager.KeyDown -= Keyboard_Down;
        }

        private void RunSteps()
        {
            BringGameToFront();            
            ClickAllOverGrid(CurrentGridTile);
        }

        private void RunTimers()
        {
            decimal runningTime = numRunningTime.Value * 1000;
            _timer = System.Diagnostics.Stopwatch.StartNew();

            long previousMills = _timer.ElapsedMilliseconds;
            long currentMills = _timer.ElapsedMilliseconds;

            while (currentMills < runningTime)
            {
                long millsDifference = currentMills - previousMills;
                if (millsDifference > 999)
                {
                    previousMills = currentMills;
                    DisplayRemainingTime();
                }
                currentMills = _timer.ElapsedMilliseconds;
            }

            //DisplayRemainingTime(); //display it one last time
            Stop();
            
        }

        #region Grids
        private TilePosition[,] FourByFour()
        {
            TilePosition[,] fourByFour = new TilePosition[4, 4];

            fourByFour = new TilePosition[4, 4]
            {
                {new TilePosition(796, 647) ,new TilePosition(908, 647),new TilePosition(1020, 647),new TilePosition(1132, 647)},
                {new TilePosition(776, 713) ,new TilePosition(893, 713),new TilePosition(1010, 713),new TilePosition(1127, 713)},
                {new TilePosition(769, 793) ,new TilePosition(900, 793),new TilePosition(900+131, 793),new TilePosition(900+131+131, 793)},
                {new TilePosition(736, 903) ,new TilePosition(897, 903),new TilePosition(897+161, 903),new TilePosition(897+161+161, 903)}
            };

            return fourByFour;
        }

        private TilePosition[,] FiveByFive()
        {
            TilePosition[,] fiveByFive = new TilePosition[5, 5]
            {
                {new TilePosition(755, 617), new TilePosition(855, 617), new TilePosition(955, 617), new TilePosition(1055, 617),new TilePosition(1155, 617)},
                {new TilePosition(733, 677), new TilePosition(844, 677), new TilePosition(844+111, 677), new TilePosition(844+111+111, 677),new TilePosition(844+111+111+111, 677)},
                {new TilePosition(710, 751), new TilePosition(834, 751), new TilePosition(834+124, 751), new TilePosition(834+124+124, 751),new TilePosition(834+124+124+124, 751)},
                {new TilePosition(680, 842), new TilePosition(818, 842), new TilePosition(818+138, 842), new TilePosition(818+138+138, 842),new TilePosition(818+138+138+138, 842)},
                {new TilePosition(644, 961), new TilePosition(801, 961), new TilePosition(957, 961), new TilePosition(1115, 961),new TilePosition(1273, 961)}
            };

            return fiveByFive;
        }

        private TilePosition[,] SixBySix()
        {
            TilePosition[,] sixBySix = new TilePosition[6, 6]
            {
                {new TilePosition(742,591) ,new TilePosition(822,592) ,new TilePosition(913,590) ,new TilePosition(994,593) ,new TilePosition(1088,591) ,new TilePosition(1168,593)},
                {new TilePosition(726,642) ,new TilePosition(820,634) ,new TilePosition(918,642) ,new TilePosition(1004,641) ,new TilePosition(1090,642) ,new TilePosition(1184,637)},
                {new TilePosition(687,706) ,new TilePosition(804,701) ,new TilePosition(899,695) ,new TilePosition(993,700) ,new TilePosition(1105,695) ,new TilePosition(1211,700)},
                {new TilePosition(687,771) ,new TilePosition(788,767) ,new TilePosition(882,776) ,new TilePosition(1004,771) ,new TilePosition(1120,763) ,new TilePosition(1231,774)},
                {new TilePosition(644,849) ,new TilePosition(768,852) ,new TilePosition(880,847) ,new TilePosition(1022,849) ,new TilePosition(1134,848) ,new TilePosition(1250,849)},
                {new TilePosition(612,957) ,new TilePosition(743,959) ,new TilePosition(891,945) ,new TilePosition(1017,939) ,new TilePosition(1164,943) ,new TilePosition(1297,931)}
            };

            return sixBySix;
        }

        private TilePosition[,] SevenBySeven()
        {
            TilePosition[,] sevenBySeven = new TilePosition[7, 7]
            {
                { new TilePosition(716,569),new TilePosition(794,571) ,new TilePosition(873,570) ,new TilePosition(954,569),new TilePosition(1034,573),new TilePosition(1111,574),new TilePosition(1200,570)},
                { new TilePosition(701,616),new TilePosition(796,614) ,new TilePosition(877,613) ,new TilePosition(965,616),new TilePosition(1048,617),new TilePosition(1128,613),new TilePosition(1205,615)},
                { new TilePosition(686,671),new TilePosition(768,667) ,new TilePosition(863,665) ,new TilePosition(964,666),new TilePosition(1065,669),new TilePosition(1149,670),new TilePosition(1231,664)},
                { new TilePosition(655,731),new TilePosition(748,733) ,new TilePosition(855,730) ,new TilePosition(975,727),new TilePosition(1071,731),new TilePosition(1163,726),new TilePosition(1256,726)},
                { new TilePosition(630,797),new TilePosition(722,799) ,new TilePosition(838,802) ,new TilePosition(953,806),new TilePosition(1101,808),new TilePosition(1199,803),new TilePosition(1324,800)},
                { new TilePosition(590,887),new TilePosition(706,891) ,new TilePosition(825,890) ,new TilePosition(954,890),new TilePosition(1077,889),new TilePosition(1196,884),new TilePosition(1328,891)},
                { new TilePosition(558,990),new TilePosition(679,991) ,new TilePosition(818,993) ,new TilePosition(957,996),new TilePosition(1092,996),new TilePosition(1224,995),new TilePosition(1362,994)}
            };

            return sevenBySeven;
        }
        #endregion

        private void BringGameToFront()
        {
            InputActivityMonitor.ExternalWindowHelper.BringWindowToFront(txtWindowName.Text);
        }

        private void ClickAllOverGrid(TilePosition[,] grid)
        {
            int rows = grid.GetLength(0);
            int cols = grid.GetLength(1);

            long previousMills = _timer.ElapsedMilliseconds;
            long currentMills = _timer.ElapsedMilliseconds;
            long millsDifference = currentMills - previousMills;

            long inverseAbilityStartSecond = (long)(numInverseAbilityStartSecond.Value);
            long inverseAbilityDuration = (long)(numInverseDuration.Value);
            long inverseAbilityStopSecond = inverseAbilityStartSecond - inverseAbilityDuration;

            long inverseAbilityStartSecond2 = (long)(numInverseAbilityStartSecond2.Value);
            long inverseAbilityDuration2 = (long)(numInverseDuration2.Value);
            long inverseAbilityStopSecond2 = inverseAbilityStartSecond2 - inverseAbilityDuration2;

            bool hasInverseAbility = chkHasInverseAbility.Checked;

            while (_timer.IsRunning)
            {
                for (int i = 0; i < rows; i++)
                {
                    for (int k = 0; k < cols; k++)
                    {
                        while (millsDifference < clickDelay)
                        {
                            currentMills = _timer.ElapsedMilliseconds;
                            millsDifference = currentMills - previousMills;
                        }

                        int x = grid[i, k].X;
                        int y = grid[i, k].Y;
                        
                        InputActivityMonitor.MouseActions.ClickAtPosition(x, y);

                        currentMills = _timer.ElapsedMilliseconds;
                        previousMills = currentMills;
                        millsDifference = currentMills - previousMills;
                    }
                }
            }
        }

        private void RunTrainingMode()
        {
            while (_isTrainingMode)
            {
                DisplayMousePosition();
            }
        }


        private void CaptureMousePosition(MouseEventArgs e)
        {
            txtCodeGenerator.Text += "new TilePosition(" + e.X + "," + e.Y + ") ,";
            codeGeneratedCount++;

            if (ddlGridSize.SelectedText.ToString() == "5x5")
            {
                if (codeGeneratedCount == 5)
                {
                    txtCodeGenerator.Text += "\n\r";
                }
            }
            else if (ddlGridSize.SelectedText.ToString() == "6x6")
            {
                if (codeGeneratedCount == 6)
                {
                    txtCodeGenerator.Text += "\n\r";
                }
            }
            else if (ddlGridSize.SelectedText.ToString() == "7x7")
            {
                if (codeGeneratedCount == 7)
                {
                    txtCodeGenerator.Text += "\n\r";
                }
            }
            else
            {
                if (codeGeneratedCount == 4)
                {
                    txtCodeGenerator.Text += "\n\r";
                }
            }
        }

        private void DisplayMousePosition()
        {
            lblCurrentMousePosition.Invoke(new Action(
                                                          () =>
                                                          {
                                                              lblCurrentMousePosition.Text = _Point.X + "," + _Point.Y;
                                                          }
                                                         )
                                              );

        }

        private void DisplayRemainingTime()
        {
            numRunningTime.Invoke(new Action(() =>
                                                    {
                                                        if (numRunningTime.Value > 0)
                                                        {
                                                            numRunningTime.Value -= 1;
                                                        }
                                                    }
                                            )
                                         );
        }
    }

    public class TilePosition
    {
        public int X;
        public int Y;

        public TilePosition(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }
    }

    public struct MousePoint
    {
        public int X;
        public int Y;

        public MousePoint(int x, int y)
        {
            X = x;
            Y = y;
        }
    }
}
