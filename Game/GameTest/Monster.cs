using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameTest {
    public class Monster {
        private int health = 100;

        public Monster(int initialHealth) { //Constructor //"Method that activates when new object of class created"
            this.health = initialHealth;
        }

        public void LooseHealth(int damage) {
            this.health = this.health - damage;
        }
    }
}
