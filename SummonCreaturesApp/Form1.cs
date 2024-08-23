using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SummonCreaturesApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private List<SummonedCreature> summonedCreatures = new List<SummonedCreature>();

        private void summonButton_Click(object sender, EventArgs e)
        {
            string name = creatureNameTextBox.Text;
            int Level = new Random().Next(1, 101);// ランダムにレベルを設定
            SummonedCreature creature = new SummonedCreature(name, Level);

            summonedCreatures.Add(creature);
            creatureListBox.Items.Add($"{name} (レベル{Level})");
            actionResultLabel.Text = $"{name}が召喚されました!";
        }
    }
}
