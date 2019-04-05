using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Drawing.Drawing2D;

namespace Cars_Project
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            button2.Size = new Size(200, 200);
            GraphicsPath Gcircle = new GraphicsPath();
            Gcircle.AddEllipse(0, 50, 200,100);
            this.button2.Region = new Region(Gcircle);

            button1.Size = new Size(200, 200);
            GraphicsPath Gcircle2 = new GraphicsPath();
            Gcircle2.AddEllipse(0, 50, 200, 100);
            this.button1.Region = new Region(Gcircle2);



        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 frm = new Form2();
            frm.Show();
        }

        private void button2_Click(object sender, EventArgs e)

        {
            Application.Exit();
                }
 
       
    }
}
    

        

           
    
    
    




