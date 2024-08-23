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
    public partial class Form1 : Form
    {
        private List<SummonedCreature> summonedCreatures = new List<SummonedCreature>();
        public Form1()
        {
            InitializeComponent();
        }

        private void summonButton_Click(object sender, EventArgs e)
        {
            if (creatureNameTextBox.Text != "")
            {
                string name = creatureNameTextBox.Text;
                SummonedCreature creature = summonControl.Summon(name);
                summonedCreatures.Add(creature);
                summonControl.DisplayCreature(creature);
                actionResultLabel.Text = $"{name}が召喚されました！";
            }
            else
            {
                MessageBox.Show("クリーチャーの名前を入力してください");
                return;
            }
        }
    }
}
