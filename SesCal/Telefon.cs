using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SesCal
{
    public abstract class Telefon
    {
        private string marka = "default";

        private int fiyat = 0;

        private string zilsesi = "default";

        public virtual string Marka { get => marka;}
        public virtual int Fiyat { get => fiyat;}
        public virtual string Zilsesi { get => zilsesi;}

        public virtual void Oynat()
        {
            using(System.Media.SoundPlayer player = new System.Media.SoundPlayer(Zilsesi + ".wav"))
            {
                player.Play();
            }
            

        }
    }
}
