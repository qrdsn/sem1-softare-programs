using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameTest {
    public class Hero {
        private int numberDefeatedMonsters = 0;

        public Hero() {

        }

        public void Attack(Monster monster, int damage) {
            monster.LooseHealth(damage);
        }
    }
}
