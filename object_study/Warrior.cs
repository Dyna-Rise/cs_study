using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace object_study
{
    internal class Warrior : Player
    {
        public Warrior(string name) : base(name)
        {
            hp = 120;
            attack = 20;
            JobSet("戦士");
        }

        public void HardAttack()
        {
            Console.WriteLine("両手持ち攻撃！");
        }

    }
}
