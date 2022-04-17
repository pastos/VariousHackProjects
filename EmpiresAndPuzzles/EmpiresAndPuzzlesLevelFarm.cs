using System.Drawing;

namespace EmpiresAndPuzzles
{
    public class EmpiresAndPuzzlesLevelFarm
    {
        private ExternalWindowHelper exWinHelper;
        private string WindowNameOfGame;

        private int TopBlueStacksBorder = 45;
        private int BottomBlueStacksBorder = 45;
        private double _remainingTimeTillNextAction;
        System.DateTime now = System.DateTime.Now;

        public double TimeTillNextAction
        {
            get
            {
                return _remainingTimeTillNextAction;
            }
        }

        public EmpiresAndPuzzlesLevelFarm(string windowNameOfGame)
        {
            exWinHelper = new ExternalWindowHelper();
            WindowNameOfGame = windowNameOfGame;
        }

        public void NextButton()
        {
            exWinHelper.BringWindowToFront(WindowNameOfGame);
           Rectangle rect = exWinHelper.GetBoundsOfWindow(WindowNameOfGame);

            int windowWidth = rect.Width - rect.X;
            int windowHeight = rect.Height - rect.Y;

            int x = windowWidth / 2 + rect.X;
            int y = windowHeight + rect.Y - (int)(0.16 * windowHeight);

            MouseActions.ClickAtPosition(x, y);
        }

        public void FightButton()
        {
            exWinHelper.BringWindowToFront(WindowNameOfGame);
            Rectangle rect = exWinHelper.GetBoundsOfWindow(WindowNameOfGame);

            int windowWidth = rect.Width - rect.X;
            int windowHeight = rect.Height - rect.Y;

            int x = windowWidth + rect.X - (int)(0.07 * windowWidth);
            int y = windowHeight + rect.Y - (int)(0.07 * windowHeight);

            MouseActions.ClickAtPosition(x, y);
        }

        public void AutoPlayButton()
        {
            exWinHelper.BringWindowToFront(WindowNameOfGame);
            Rectangle rect = exWinHelper.GetBoundsOfWindow(WindowNameOfGame);

            int windowWidth = rect.Width - rect.X;
            int windowHeight = rect.Height - rect.Y;
            int x = 0;

            if (windowWidth > windowHeight)
            {
                x = windowWidth / 2 + rect.X + (int)(0.065 * windowWidth);
            }
            else
            {
                x = windowWidth + rect.X - (int)(0.2 * windowWidth);
            }

            int y = rect.Y + TopBlueStacksBorder + 20;

            MouseActions.ClickAtPosition(x, y);
        }

        public void ReplayButton()
        {
            exWinHelper.BringWindowToFront(WindowNameOfGame);
            Rectangle rect = exWinHelper.GetBoundsOfWindow(WindowNameOfGame);

            int windowWidth = rect.Width - rect.X;
            int windowHeight = rect.Height - rect.Y;

            int x = windowWidth / 2 + rect.X - (int)(0.05 * windowWidth);
            int y = windowHeight + rect.Y - BottomBlueStacksBorder - (int)(0.08 * windowHeight);

            MouseActions.ClickAtPosition(x, y);
        }

        public void FightAnywayButton()
        {
            exWinHelper.BringWindowToFront(WindowNameOfGame);
            Rectangle rect = exWinHelper.GetBoundsOfWindow(WindowNameOfGame);

            int windowWidth = rect.Width - rect.X;
            int windowHeight = rect.Height - rect.Y;

            int x = windowWidth / 2 + rect.X - (int)(0.1 * windowWidth);
            int y = windowHeight / 2 + rect.Y + (int)(0.15 * windowHeight);
            //int y = windowHeight / 2 + rect.Y - BottomBlueStacksBorder + (int)(0.15 * windowHeight);

            MouseActions.ClickAtPosition(x, y);
        }

        public void Wait(double seconds)
        {
            System.DateTime now = System.DateTime.Now;
            System.TimeSpan elapsedTime = System.DateTime.Now - now;

            while (elapsedTime.TotalSeconds <= seconds)
            {
                elapsedTime = System.DateTime.Now - now;
                _remainingTimeTillNextAction = seconds - elapsedTime.TotalSeconds;
                System.Threading.Thread.Sleep(50);
            }
        }

        public void KeepAlive(bool condition)
        {
            exWinHelper.BringWindowToFront(WindowNameOfGame);
            if (condition)
            {
                FightButton();
                //Rectangle rect = exWinHelper.GetBoundsOfWindow(WindowNameOfGame);

                //int windowWidth = rect.Width - rect.X;
                //int windowHeight = rect.Height - rect.Y;

                //int x = windowWidth + rect.X - (int)(0.1 * windowWidth);
                //int y = windowHeight / 2 + rect.Y;

                //MouseActions.ClickAtPosition(x, y);
            }
        }
    }
}
