using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SummonCreaturesApp_UserControl
{
    public class SummonedCreature
    {
        public string Name { get; }
        public int Level { get; }

        public SummonedCreature(string name, int level)
        {
            Name = name;
            Level = level;
        }

        public string Attack()
        {
            return $"{Name}がレベル{Level}で攻撃しました";
        }

        public override string ToString()
        {
            return $"{Name} (レベル{Level})";
        }
    }
}
