using System.Collections.Generic;
using System.Drawing;

namespace gArticCheatSheet
{
    public class FileHelper
    {
        private static readonly FileHelper _instance = new FileHelper();
        public static FileHelper Instance
        {
            get
            {
                return _instance;
            }
        }

        public static string ImageSearchPattern { get; set; } = "*.bmp|*.jpg|*.jpeg|*.gif|*.tiff|*.png";
        public LinkedList<FileProperty<Image>> ImagePropertyCollection { get; private set; }

        // Explicit static constructor to tell C# compiler
        // not to mark type as beforefieldinit
        static FileHelper()
        {

        }

        //Singleton
        private FileHelper()
        {

        }

        public void ScanImageFolder(string folder)
        {
            if (System.IO.Directory.Exists(folder))
            {
                string[] extensionPatterns = ImageSearchPattern.Split('|');
                string[][] imagePathArray = new string[extensionPatterns.Length][];

                for (int i = 0; i < extensionPatterns.Length; i++)
                {
                    imagePathArray[i] = System.IO.Directory.GetFiles(folder, extensionPatterns[i], System.IO.SearchOption.AllDirectories);
                }
                PopulateImageCollection(imagePathArray);
            }
        }

        private void PopulateImageCollection(string[][] imagePathArray)
        {
            ImagePropertyCollection = new LinkedList<FileProperty<Image>>();
            for (int i = 0; i < imagePathArray.Length; i++)
            {
                if (imagePathArray[i].Length > 0)
                {
                    for (int p = 0; p < imagePathArray[i].Length; p++)
                    {
                        Bitmap bmp = new Bitmap(imagePathArray[i][p]);
                        int startIndex = imagePathArray[i][p].LastIndexOf('\\') + 1;
                        int lastIndex = imagePathArray[i][p].LastIndexOf('.');
                        int length = lastIndex - startIndex;
                        string fileName = imagePathArray[i][p].Substring(startIndex, length);
                        FileProperty<Image> fileProperty = new FileProperty<Image>
                        {
                            Name = fileName,
                            Asset = bmp
                        };
                        ImagePropertyCollection.AddLast(fileProperty);
                    }
                }
            }
        }
    }

    public class FileProperty<T>
    {
        public T Asset { get; set; }
        public string Name { get; set; }
    }
}
