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
        String select = "Select ID, Brand,  Model, ProdYear, Engine, Fuel , Doors, Condition, Price from IdCars";

        public Form2()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
           //this.idCarsTableAdapter.Fill(this.база_данни1DataSet4.IdCars);
            butPrevPage.Size = new Size(100, 100);
            GraphicsPath Gcircle = new GraphicsPath();
            Gcircle.AddEllipse(0,24, 100, 50);
            this.butPrevPage.Region = new Region(Gcircle);

            butNextPage.Size = new Size(100, 100);
            GraphicsPath Gcircle2 = new GraphicsPath();
            Gcircle2.AddEllipse(0, 24, 100,50);
            this.butNextPage.Region = new Region(Gcircle2);


            butInsert.Size = new Size(100, 30);
            GraphicsPath Gcircle3 = new GraphicsPath();
            Gcircle3.AddEllipse(0, 0, 90,90);
            this.butInsert.Region = new Region(Gcircle3);

            butUpdate.Size = new Size(100, 30);
            GraphicsPath Gcircle4 = new GraphicsPath();
            Gcircle4.AddEllipse(0, 0,90, 90);
            this.butUpdate.Region = new Region(Gcircle4);

            butDel.Size = new Size(100, 30);
            GraphicsPath Gcircle5 = new GraphicsPath();
            Gcircle5.AddEllipse(0, 0, 90, 90);
            this.butDel.Region = new Region(Gcircle5);


            
            fillDataGrid(select);
        }

        private void fillDataGrid(String query)
        {            
            try
            {
                //OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0; Data Source =C:\Users\User\source\repos\atev40\Cars_Project\Cars_Project\Cars_Project\База данни1.accdb");
               OleDbConnection con = new OleDbConnection(@"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = C:\Users\ACER\source\repos\Cars_Project3\Cars_Project\Cars_Project\База данни1.accdb");
                OleDbCommand command = new OleDbCommand(query, con);
                con.Open();
                OleDbDataReader dr = command.ExecuteReader();
                BindingSource source = new BindingSource();
                source.DataSource = dr;
                dataGridView1.DataSource = source;
                dr.Close();
                con.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Could not receive information from the database!", "Data error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void butNextPage_Click(object sender, EventArgs e)
        {
          
            if (textBox6.Text == "")
            {
                MessageBox.Show("Please choose a car!", "No car chosen", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                carID = int.Parse(textBox6.Text);
                this.Hide();
                Form3 frm = new Form3(carID.ToString());
                frm.Show();
            }
        }

        private void butPrevPage_Click(object sender, EventArgs e)
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

        Vechile h = new Vechile();

        private void butInsert_Click(object sender, EventArgs e)
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

        private void butUpdate_Click(object sender, EventArgs e)
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
        private void butDel_Click(object sender, EventArgs e)
        {
            Car c = new Car();
            c.ID = textBox6.Text;
            h.Delete(c);

            selectedRow = dataGridView1.CurrentCell.RowIndex;
            dataGridView1.Rows.RemoveAt(selectedRow);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            fillDataGrid(select);
            
        }

        

    }
    }
