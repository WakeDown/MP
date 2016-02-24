using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32;

namespace Угадай_мелодию
{
    static class Victorina
    {
        static public List<string> list = new List<string>();
        static public int gameDuration = 60; 
        static public int musicDuration = 10;
        static public bool rondomstar = false;
        static public string lastFolder = " ";
        static public bool allDirectories = false;
        static public void ReadMusic()
        {
            try {
                string[] music = System.IO.Directory.GetFiles(lastFolder, "*.mp3", allDirectories ? System.IO.SearchOption.AllDirectories : System.IO.SearchOption.TopDirectoryOnly);
                list.Clear();
                list.AddRange(music);
            }
            catch { }
        }

        static string regKeyName = "Software\\MyCompanyName\\Угадайка";
        public static void WriteParam()
        {
            RegistryKey rk = null;
            try
            {
                rk = Registry.CurrentUser.CreateSubKey(regKeyName);
                if (rk == null) return;
                rk.SetValue("LastFolder", lastFolder);
                rk.SetValue("Random", rondomstar);
                rk.SetValue("gameDuration", gameDuration);
                rk.SetValue("musicDuration", musicDuration);
                rk.SetValue("allDirectories", allDirectories);
            }
            finally
            {
                if (rk != null) rk.Close();
            }
        }
        public static void ReadParam()
        {
            RegistryKey rk = null;
            try
            {
                rk = Registry.CurrentUser.CreateSubKey(regKeyName);
                if (rk != null)
                {
                    lastFolder = (string)rk.GetValue("LastFolder");
                    gameDuration = (int)rk.GetValue("GameDuration");
                    rondomstar = Convert.ToBoolean(rk.GetValue("Random"));
                    musicDuration = (int)rk.GetValue("musicDuration");
                    allDirectories = Convert.ToBoolean(rk.GetValue("allDirectories"));
                }
            }
            finally
            {
                if (rk != null) rk.Close();
            }
        }
    }
}

