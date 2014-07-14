using System;
using System.IO;

namespace FormUI.OperationLayer
{
    public class FileOperation
    {
        static readonly string _picLute = string.Format("{0}\\Picture\\",System .Environment .CurrentDirectory );

       static public void SaveFile(string srcFile)
        {
            
           if (File.Exists(_picLute))
           {
               File.Delete(_picLute);
           }
            if (!File.Exists(_picLute))
            {
                Directory.CreateDirectory(_picLute);
            }


            string desPic = _picLute + "BackGroundPic.jpg";
            File.Copy(srcFile, desPic, true);

        }
        static public string GetFile()
        {
            string[] files = Directory.GetFileSystemEntries(_picLute);
            string desFile = null;
            foreach (var file in files)
            {
                desFile =  file;
            }
            return desFile;
        } 
    }
}