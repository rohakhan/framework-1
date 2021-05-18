using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
namespace FrameWork1
{
    class Game 
    {

        public int x;
        
        public  Game(int x)
        {
            this.x = x;
        }
        public void AddGameobjects(GameObject gO)
        {
            gO.pb.Top = gO.pb.Top + this.x;
        }

    }
}
