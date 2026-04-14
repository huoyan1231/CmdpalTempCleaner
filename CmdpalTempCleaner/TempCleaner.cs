using System;
using System.IO;

namespace CmdpalTempCleaner
{
    public class TempCleaner
    {
        public static void ClearTempFolder()
        {
            string tempPath = Path.GetTempPath();
            DirectoryInfo di = new DirectoryInfo(tempPath);

            if (!di.Exists) return;

            // 1. 删除所有可以删除的文件
            foreach (FileInfo file in di.GetFiles())
            {
                try { file.Delete(); }
                catch (Exception) { continue; }
            }

            // 2. 删除所有可以删除的子文件夹
            foreach (DirectoryInfo dir in di.GetDirectories())
            {
                try { dir.Delete(true); }
                catch (Exception) { continue; }
            }
        }
    }
}