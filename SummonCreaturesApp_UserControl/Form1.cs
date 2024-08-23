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
            var creatureRename =new SummonControl();
        }

        

        private void attackButton_Click(object sender, EventArgs e)
        {
            SummonedCreature selectedCreature = summonControl.SelectedCreature;
            if (selectedCreature != null)
            {
                actionResultLabel.Text = selectedCreature.Attack();
            }
            else
            {
                actionResultLabel.Text = "攻撃するクリーチャーを選択してください。";
            }
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
        public string GetNameText()
        {
            return creatureNameTextBox.Text;
        }
    }
}
