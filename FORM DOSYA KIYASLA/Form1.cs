using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FORM_DOSYA_KIYASLA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string filepath1, filepath2;

        private void button1_Click(object sender, EventArgs e)
        {
            DosyaSec(out filepath1);
            textBox1.Text = filepath1;
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DosyaSec(out filepath2);
            textBox2.Text = filepath2;
        }

        /// <summary>
        /// Dosya seçimi yaptırır ve dosya yolunu out parametre olarak verir
        /// </summary>
        /// <param name="filePath"></param>
        void DosyaSec(out string filePath)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Metin Dosyaları(*txt)|*.txt";
            ofd.ShowDialog();
            filePath = ofd.FileName;
        }

        /// <summary>
        /// Verilen dosya yolundaki dosyayı okur ve küçük karakterlere çevirir, verilen noktalama işaretlerinden arındırarak dizi haline getirir
        /// </summary>
        /// <param name="filePath"></param>
        /// <param name="punctuation"></param>
        /// <returns></returns>
        string[] DosyaOku(string filePath,string punctuation)
        {
            string read = File.ReadAllText(filePath);
            read = read.ToLower();
            var punctuation2 = read.Where(Char.IsPunctuation).Distinct().ToArray();
            string[] fileWorlds = read.Split().Select(x => x.Trim(punctuation2)).ToArray();
            //string[] fileWorlds = read.Split(punctuation.ToCharArray()); //punctuationlardan dolayı alt satıra geçişlerde hatalı çalışıyor
            return fileWorlds;
        }
        /// <summary>
        /// Verilen string[] ifadedeki kelimeleri boşluklardan arındırarak geri döndürür
        /// </summary>
        /// <param name="fileWords"></param>
        /// <returns></returns>
        List<string> DosyaKelimeleriniListele(string[] fileWords)
        {
            List<string> fileWordsWithOutEmptyString = new List<string>();
            foreach (var word in fileWords)
            {
                if (!string.IsNullOrEmpty(word))
                {
                    fileWordsWithOutEmptyString.Add(word);
                }
            }
            return fileWordsWithOutEmptyString;
        }
        /// <summary>
        /// Verilen string[] ifadedeki kelimeleri boşluklardan arındırarak listeler. Tekrar eden kelimeler bulundurmaz.
        /// </summary>
        /// <param name="fileWords"></param>
        /// <returns></returns>
        HashSet<string> UniqueDosyaKelimeleriniListele(string[] fileWords)
        {
            HashSet<string> fileWordsWithOutEmptyString = new HashSet<string>();
            foreach (var word in fileWords)
            {
                if (!string.IsNullOrEmpty(word) && !fileWordsWithOutEmptyString.Contains(word))
                {
                    fileWordsWithOutEmptyString.Add(word);
                }
            }
            return fileWordsWithOutEmptyString;
        }
        
        /// <summary>
        /// Verilen kelime listelerini kıyaslar, Birinci listede olup ikinci hashset'te olmayan kelimeleri, adetleri ile beraber dictionary olarak döner.
        /// </summary>
        /// <param name="firstFile"></param>
        /// <param name="secondFile"></param>
        /// <returns></returns>
        Dictionary<string,int> HangiKelimedenKacTaneVar(List<string> firstFile,HashSet<string> secondFile)
        {
            Dictionary<string,int> wordsAndCount = new Dictionary<string,int>();
            foreach (var word in firstFile)
            {
                if (!secondFile.Contains(word))
                {
                    if (wordsAndCount.ContainsKey(word))
                    {
                        wordsAndCount[word]++;
                    }
                    else
                    {
                        wordsAndCount.Add(word, 1);
                    }
                }
            }
            return wordsAndCount;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string punctuation = " ,.?!;:\"\n";
            
            string[] read1= DosyaOku(filepath1,punctuation);
            string[] read2 = DosyaOku(filepath2, punctuation);

            List<string> firstFileWords = DosyaKelimeleriniListele(read1);
            HashSet<string> secondFileWords = UniqueDosyaKelimeleriniListele(read2);

            Dictionary<string,int> wordsAndCount = HangiKelimedenKacTaneVar(firstFileWords,secondFileWords);
            MetniYazdir(wordsAndCount);

        }



        /// <summary>
        /// metin kutusuna verilen dictionary'deki değerleri yazdırır
        /// </summary>
        /// <param name="wordsAndCount"></param>
        void MetniYazdir(Dictionary<string,int> wordsAndCount)
        {
            string result = string.Empty;

            foreach (var word in wordsAndCount)
            {
                result += $"<<{word.Key}>> ikinci dosyada yoktur. <<{word.Value}>> kez birinci dosyada kullanılmaktadır. \n";
            }
            textBox3.Text = result;
        }
    }
}
