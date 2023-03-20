using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace laba2
{
    public partial class Form1 : Form
    {
        IShapeFactory creator;
        public Graphics device;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            creator = new SquareFactory();
            Shape shape = creator.CreateShape();
            shape.Draw(pictureBox1.CreateGraphics(), new Point(0, 0));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            creator = new CircleFactory();
            Shape shape = creator.CreateShape();
            shape.Draw(pictureBox2.CreateGraphics(), new Point(0, 0));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            creator = new LineFactory();
            Shape shape = creator.CreateShape();
            shape.Draw(pictureBox3.CreateGraphics(), new Point(0, 0));
        }
    }
}
