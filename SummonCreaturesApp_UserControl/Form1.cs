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
    }
}
