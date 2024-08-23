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
        Form1 form1 = new Form1();

        public SummonControl()
        {
            InitializeComponent();
        }

        public SummonedCreature Summon(string name)
        //stringの引数を受け取りSummonedCreature型を返すメソッド
        {
            int level = new Random().Next(0, 101);
            //レベルの値を1-100の間でランダムに生成する
            return new SummonedCreature(name, level);
            //引数の名前とランダム生成したレベルでクリーチャーを生成
        }

        public void DisplayCreature(SummonedCreature creature)
        {
            creatureListBox.Items.Add(creature);
        }

        public int SelectedIndex => creatureListBox.SelectedIndex;
        public SummonedCreature SelectedCreature => creatureListBox.SelectedItem as SummonedCreature;



        private void renameButton_Click(object sender, EventArgs e)
        {
           
            string newName = form1.GetNameText();

            if (newName != "")
            {
                UpdateSelectedItemText(newName);
            }
            else
            {
                MessageBox.Show("名前が入力されていません");
            }
        }

      
        private void UpdateSelectedItemText(string newName)
        {
            if (creatureListBox.SelectedItem != null)
            {
                int selectedIndex = creatureListBox.SelectedIndex;

                creatureListBox.Items[selectedIndex] = newName;
            }
            else
            {
                MessageBox.Show("選択されていません");
            }
        }
    }
}
