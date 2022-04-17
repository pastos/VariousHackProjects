using System.Drawing;

namespace EmpiresAndPuzzles
{
    public class ScreenCaptureHelper
    {
        #region Private members
        private int _CaptureProgress;
        private Point _Point;

        #endregion

        #region Public properties
        public int CaptureProgress
        {
            get
            {
                return _CaptureProgress;
            }
        }

        public Point Point
        {
            get
            {
                return _Point;
            }
        }
        #endregion



        //code borrowed from https://pastebin.com/SGKbZVHf
        public bool IsInCapturedScreen(Bitmap picToSearchFor, Bitmap picToSearchIn)
        {
            if (picToSearchFor != null && picToSearchIn != null)
            {
                int totalPixelsToSearchFor = picToSearchFor.Height * picToSearchFor.Width;
                int totalPixelsToSearchIn = picToSearchIn.Height * picToSearchIn.Width;
                int totalPixelsCovered = 0;
                //int totalPixelsMatched = 0;

                for (int x = 0; x < picToSearchIn.Width; x++)
                {
                    for (int y = 0; y < picToSearchIn.Height; y++)
                    {
                        totalPixelsCovered++;//= (x + 1) * (y + 1);
                        _CaptureProgress = (int)(100 * ((double)totalPixelsCovered / totalPixelsToSearchIn));
                        bool invalid = false;
                        int k = x, l = y;
                        for (int a = 0; a < picToSearchFor.Width; a++)
                        {
                            l = y;
                            for (int b = 0; b < picToSearchFor.Height; b++)
                            {
                                if (picToSearchFor.GetPixel(a, b) != picToSearchIn.GetPixel(k, l))
                                {
                                    invalid = true;
                                    break;
                                }
                                else
                                {
                                    //totalPixelsMatched++;
                                    l++;
                                    if (l >= picToSearchIn.Height)
                                    {
                                        l = picToSearchIn.Height - 1;
                                    }
                                }
                            }

                            if (invalid)
                            {
                                break;
                            }
                            else
                            {
                                k++;
                                if (k >= picToSearchIn.Width)
                                {
                                    k = picToSearchIn.Width - 1;
                                }
                            }
                        }

                        if (!invalid) // || totalPixelsMatched > totalPixelsToSearchFor * 0.98)
                        {
                            _Point.x = x + picToSearchFor.Width / 2;
                            _Point.y = y + picToSearchFor.Height / 2;
                            return true;
                        }
                    }
                }
            }
            return false;
        }
    }

    public struct Point
    {
        public int x;
        public int y;
    }
}
