using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace Benefits
{
    
    public partial class Form1 : Form
    {
        decimal oldestChild = 18.10M;
        decimal otherChild = 12.10M;

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            if (numericUpDown1.Value > 0){
                label2.Text = "The number of children you are entitled to is: £" + (otherChild * numericUpDown1.Value + oldestChild - otherChild).ToString();
            }
            else{
                label2.Text = "The number of children you are entitled to is: £0";
            }
        }
    }
}
