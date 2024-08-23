using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SummonCreaturesApp
{
    public class SummonedCreature
    {
        //プロパティの設定
        public string Name {  get; set; }
        public int Level {  get; set; }

        //コンストラクタの設定
        public SummonedCreature(string name, int level)
        {
            Name = name;
            Level =level;
        }

        //Attackメソッドの設定
        public string Attack()
        {
            return $"{Name}がレベル{Level}で攻撃をした！";
        }
    }
}
