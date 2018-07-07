using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AssignmentGUI
{
    public partial class Input2 : Form
    {
        public Input2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        public double getX1()
        {
            return Convert.ToDouble(X1.Text);
        }
        public double getY1()
        {
            return Convert.ToDouble(Y1.Text);
        }
        public double getRadius()
        {
            return Convert.ToDouble(Radius.Text);
        }
        
    }
}
