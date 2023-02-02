using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Compression;

namespace ZIP_OLUSTUR_SIL
{
    internal class Program
    {//Masaüstünde yeni bir klasör ve içine bir text dosyası oluşturan ve bu klasörü zip'leyerek istenen başka bir klasör içine taşıdıktan sonra ziplenen orjinal dosyayı silen console uygulamasını yazınız
        static void Main(string[] args)
        {
            DirectoryInfo di1 = null;
            string path1 = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\yeniklasor1\";
            string path2 = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\yeniklasor2\";
            if (!Directory.Exists(path1))
            {
               di1 = Directory.CreateDirectory(path1);
                
            }
            if (!Directory.Exists(path2))
            {
                DirectoryInfo di2 = Directory.CreateDirectory(path2);

            }
            if (!File.Exists(path1 + "Person.txt"))
            {

                System.IO.FileStream _fs;
                StreamWriter _strWrite = null;
                _fs = new System.IO.FileStream(path1 + "Person.txt", FileMode.CreateNew, FileAccess.Write);
                _strWrite = new StreamWriter(_fs);
                _strWrite.WriteLine("Maraba Televole");
                _strWrite.Close();
                _strWrite = null;
                _fs.Close();
            }

            if (!File.Exists(path2 + "result.zip"))
            {
                string startPath = path1;
                string zipPath = path2 + "result.zip";
                ZipFile.CreateFromDirectory(startPath, zipPath);
                di1.Delete(true);
            }








        }
    }
}
