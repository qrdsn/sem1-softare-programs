using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dinosaur {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
            KeyPreview = true;

            Coin coin = new Coin(this.Width, this.Height);

            var picture = new PictureBox {
                Name = "pictureBox",
                Size = new Size(coin.value, coin.value),
                Location = new Point(coin.location[0], coin.location[1]),
                Image = Image.FromFile("images/coin.png")
            };

            this.Controls.Add(picture);
        }

        private void button1_Click(object sender, EventArgs e) {
            Coin coin = new Coin(this.Width, this.Height);

            var image = new PictureBox {
                Size = new Size(coin.value*5, coin.value*5),
                Location = new Point(coin.location[0], coin.location[1]),
                Image = Image.FromFile("images/coin.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };

            this.Controls.Add(image);
        }

        private void button2_Click(object sender, EventArgs e) {

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e) {
            int x = pictureBox1.Location.X;
            int y = pictureBox1.Location.Y;

            if (e.KeyCode == Keys.D) x += 10;
            else if (e.KeyCode == Keys.A) x -= 10;
            else if (e.KeyCode == Keys.W) y -= 10;
            else if (e.KeyCode == Keys.S) y += 10;

            pictureBox1.Location = new Point(x, y);
        }

        private void timer1_Tick(object sender, EventArgs e) {
            if (pictureBox1.Bounds.IntersectsWith(pictureBox2.Bounds)) {
                //They have collided
                Console.WriteLine("intsersected");
            }
        }
    }
}
