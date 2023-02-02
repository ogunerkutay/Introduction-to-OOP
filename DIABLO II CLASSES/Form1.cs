using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DIABLO_II_CLASSES
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Sorceress sorceress = new Sorceress();
            sorceress.FrozenOrb();


            /* AncientArmor ancientArmor = new AncientArmor();
             * ancientArmor.ArmorType = ArmorType.Armors;
             * ancientArmor.Type = TypeEnum.Heavy;
             * ancientArmor.Name = "Bilmemkimin çok acayip ancient armor'ı";
             * ancientArmor.MaxDurability = 100;
             * 
             * BattleStaff battleStaff = new BattleStaff();
             * battleStaff.Name = "Gandalf'ın Asası";
             * battleStaff.MaxDurability = 100;
             * battleStaff.CurrentDurability = battleStaff.MaxDurability;
             * 
             * battleStaff.Hit();
            battleStaff.Hit();
            battleStaff.Hit();
            battleStaff.Hit();
            battleStaff.Hit();

             * battleStaff.Hit();
            Console.WriteLine($"Current durability of the gandalf's staff battlestaff.currentdurability")
             *
             *
             *blacksmith.Repair(battlestaff)
             *
             *Console.Writeline(current durability bla bla )
             *
             *
             *
             *
             *
             *
            */

        }
    }
}
