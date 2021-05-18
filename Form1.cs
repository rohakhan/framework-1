using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrameWork1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            


        }

        private void Jet_Click(object sender, EventArgs e)
        {

        }

        private void MainGameTimer(object sender, EventArgs e)
        {
            Game ggame = new Game(5);
            GameObject player = new GameObject(Jet);
            GameObject enemie = new GameObject(enemie1);
            GameObject enemies2 = new GameObject(enemie2);
            GameObject enemies3 = new GameObject(enemie3);
            ggame.AddGameobjects(player);
            ggame.AddGameobjects(enemie);
            ggame.AddGameobjects(enemies2);
            ggame.AddGameobjects(enemies3);
        }
    }
}
