using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace magic8ball
{
    public partial class Form1 : Form
    {
        private Engine engine;

        public Form1()
        {
            InitializeComponent();

            this.engine = new Engine(this);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string answer = engine.GetSubject();
            btAnswer.Text = answer;
        }
    }
}
