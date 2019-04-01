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
using System.IO;

namespace Cars_Project
{
    public partial class Form2 : Form
    {
        Vechile h = new Vechile();
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        { 
            this.idCarsTableAdapter2.Fill(this.база_данни1DataSet2.IdCars);
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

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];

                textBox6.Text = row.Cells[0].Value.ToString();
                textBox1.Text = row.Cells[1].Value.ToString();
                textBox2.Text = row.Cells[2].Value.ToString();
                textBox3.Text = row.Cells[3].Value.ToString();
                textBox4.Text = row.Cells[4].Value.ToString();
                comboBox2.Text = row.Cells[5].Value.ToString();
                comboBox3.Text = row.Cells[6].Value.ToString();
                comboBox4.Text = row.Cells[7].Value.ToString();
                textBox5.Text = row.Cells[8].Value.ToString();


            }
        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            TabPage t = tabControl1.TabPages[0];
            tabControl1.SelectedTab = t;
            Car c = new Car();
            c.Brand = textBox1.Text;
            c.Model = textBox2.Text;
            c.Year = textBox3.Text;
            c.Engine = textBox4.Text;
            c.Fuel = comboBox2.Text;
            c.Doors = comboBox3.Text;
            c.Condition = comboBox4.Text;
            c.Price= textBox5.Text;
            h.Insert(c);


            DataTable dataTable = h.SelectAll();
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = dataTable;
            dataGridView1.DataSource = bindingSource;
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Car c = new Car();
            c.ID = textBox6.Text;
            c.Brand = textBox1.Text;
            c.Model = textBox2.Text;
            c.Year = textBox3.Text;
            c.Engine = textBox4.Text;
            c.Fuel = comboBox2.Text;
            c.Doors = comboBox3.Text;
            c.Condition = comboBox4.Text;
            c.Price = textBox5.Text;
            h.Update(c);

            DataTable dataTable = h.SelectAll();
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = dataTable;
            dataGridView1.DataSource = bindingSource;
        }

        int selectedRow;
        private void button2_Click(object sender, EventArgs e)
        {
            Car c = new Car();
            c.ID = textBox5.Text;
            h.Delete(c);

            selectedRow = dataGridView1.CurrentCell.RowIndex;
            dataGridView1.Rows.RemoveAt(selectedRow);
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            tabControl1.Visible = true;
            string[] lines = System.IO.File.ReadAllLines("C:\\Users\\ACER\\source\\repos\\Cars_Project3\\Cars_Project\\Cars_Project\\Fuel.txt");
            foreach (string str in lines)
            { comboBox2.Items.Add(str); }
            comboBox2.SelectedIndex = 0;
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            tabControl1.Visible = true;
            string[] lines = System.IO.File.ReadAllLines(" C:\\Users\\ACER\\source\\repos\\Cars_Project3\\Cars_Project\\Cars_Project\\Condition.txt");
            foreach(String str in lines)
            {
                comboBox4.Items.Add(str);
            }
            comboBox4.SelectedIndex = 0;
        }

    }
}
