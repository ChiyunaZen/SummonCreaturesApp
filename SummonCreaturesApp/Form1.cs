﻿using System;
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

        private void attackButton_Click(object sender, EventArgs e)
        {

            if (creatureListBox.SelectedIndex >= 0)
            //creatureListBoxで一つ以上の要素が選択されている場合に実行される処理
            {
                SummonedCreature selectedCreature = summonedCreatures[creatureListBox.SelectedIndex];
                //summondCreatureリスト内の選択している番号の要素を取り出し
                actionResultLabel.Text = selectedCreature.Attack();
                //取り出した要素のAttackメソッドを実行
            }
            else
            {
                actionResultLabel.Text = "攻撃するクリーチャーを選択してください";
            }
        }
    }
}
