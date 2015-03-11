using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP123_Lesson9_Part3
{
    public partial class FirstForm : Form
    {
        bool helloLabelFlag = false;

        //Constructor++++++++++++++++++++++++++++++++++++++++++
        public FirstForm()
        {
            InitializeComponent();
        }

        private void Hellolabel_Click(object sender, EventArgs e)
        {
            
        }

        private void ClickMeButton_Click(object sender, EventArgs e)
        {
            if (helloLabelFlag==true)
            {
                Hellolabel.Text = "Hello World!";
                helloLabelFlag = false;
            }

            else
            {
                Hellolabel.Text = "Good Bye!";
                helloLabelFlag = true;
            }
           
            //Console.WriteLine(Hellolabel.Text);
            //Console.ReadKey();
            //Hellolabel.ResetText();
        }
    }
}
