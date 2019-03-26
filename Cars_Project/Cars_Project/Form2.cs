using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cars_Project
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'база_данни1DataSet1.IdCars' table. You can move, or remove it, as needed.
            this.idCarsTableAdapter1.Fill(this.база_данни1DataSet1.IdCars);
            // TODO: This line of code loads data into the 'база_данни1DataSet.IdCars' table. You can move, or remove it, as needed.
            this.idCarsTableAdapter.Fill(this.база_данни1DataSet.IdCars);

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 frm = new Form3();
            frm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 frm = new Form1();
            frm.Show();
        }
    }
}
