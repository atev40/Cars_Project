using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;


namespace Cars_Project
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }


        private void Form3_Load(object sender, EventArgs e)
        {
            button1.Size = new Size(100, 100);// za tezi chisla govorq
            GraphicsPath Gcircle6 = new GraphicsPath();
            Gcircle6.AddEllipse(0,24,100, 50);
            this.button1.Region = new Region(Gcircle6);


        }
        private void tabPage1_Click(object sender, EventArgs e)
        {


        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            this.Hide();
            form2.Show();
        }
    }
}
