using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SampleWinForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Button myButton = new Button();
            myButton.Name = "myButton1";
            myButton.Text = "Click me";
            myButton.Click += MyButton_Click;
            myButton.Click += MyButton_ClickOnceMore;
            myButton.Click += (sender, e) => { MessageBox.Show("this is from lambda"); };
            this.Controls.Add(myButton);
        }

        private void MyButton_ClickOnceMore(object sender, EventArgs e)
        {
            MessageBox.Show("myButton.Click invoked");
        }

        private void MyButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("myButton.Click invoked");
        }
    }
}
