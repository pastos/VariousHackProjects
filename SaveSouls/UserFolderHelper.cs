using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SoulSaver
{
    public class UserFolderHelper
    {
        public static string AppDataFolder
        {
            get
            {
                return Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            }
        }

        public static string DocumentsFolder
        {
            get
            {
                return Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            }
        }
    }
}
