using System;

namespace GameTest {


    public class Game {
        public Game() {
            Hero hero = new Hero();
            Monster monster1 = new Monster(125);
            Monster monster2 = new Monster(100);
        }
    }
}