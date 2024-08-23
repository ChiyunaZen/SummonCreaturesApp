using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SummonCreaturesApp_UserControl
{
    public partial class SummonControl : UserControl
    {
        public SummonControl()
        {
            InitializeComponent();
        }

        public SummonedCreature Summon(string name)
        {
            int level = new Random().Next(0, 101);
            return new SummonedCreature(name, level);
        }

        public void DisplayCreature(SummonedCreature creature)
        {
            creatureListBox.Items.Add(creature);
        }

        public int SelectedIndex => creatureListBox.SelectedIndex;
        public SummonedCreature SelectedCreature => creatureListBox.SelectedItem as SummonedCreature;
    }
}
