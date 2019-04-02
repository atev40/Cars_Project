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
    public partial class Form2 : Form
    {
        int carID;

        public Form2()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            button4.Size = new Size(100, 100);
            GraphicsPath Gcircle = new GraphicsPath();
            Gcircle.AddEllipse(0,24, 100, 50);
            this.button4.Region = new Region(Gcircle);

            button5.Size = new Size(100, 100);
            GraphicsPath Gcircle2 = new GraphicsPath();
            Gcircle2.AddEllipse(0, 24, 100,50);
            this.button5.Region = new Region(Gcircle2);


            button1.Size = new Size(100, 30);
            GraphicsPath Gcircle3 = new GraphicsPath();
            Gcircle3.AddEllipse(0, 0, 90,90);
            this.button1.Region = new Region(Gcircle3);

            button3.Size = new Size(100, 30);
            GraphicsPath Gcircle4 = new GraphicsPath();
            Gcircle4.AddEllipse(0, 0,90, 90);
            this.button3.Region = new Region(Gcircle4);

            button2.Size = new Size(100, 30);
            GraphicsPath Gcircle5 = new GraphicsPath();
            Gcircle5.AddEllipse(0, 0, 90, 90);
            this.button2.Region = new Region(Gcircle5);


            this.idCarsTableAdapter2.Fill(this.база_данни1DataSet2.IdCars);
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (carID <= 0)
            {
                MessageBox.Show("Please choose a car!", "No car chosen", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                this.Hide();
                Form3 frm = new Form3(carID.ToString());
                frm.Show();
            }
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
                //textBox5.Text = row.Cells[0].Value.ToString(); // id

                carID = (int)row.Cells[0].Value;

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
        Vechile h = new Vechile();

        private void button1_Click(object sender, EventArgs e)
        {
            TabPage t = tabControl1.TabPages[0];
            tabControl1.SelectedTab = t;
            Car2 c = new Car2();
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
            Car2 c = new Car2();
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
            Car2 c = new Car2();
            c.ID = textBox5.Text;
            h.Delete(c);

            selectedRow = dataGridView1.CurrentCell.RowIndex;
            dataGridView1.Rows.RemoveAt(selectedRow);
        }
    }
}
