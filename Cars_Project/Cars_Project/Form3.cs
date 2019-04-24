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
using System.Data.OleDb;

namespace Cars_Project
{
    public partial class Form3 : Form
    {
        private String carID;
        //String path = @"C:\Users\User\source\repos\atev40\Cars_Project\Cars_Project\Cars_Project\Images\";
        String path = @"C:\Users\ACER\source\repos\Cars_Project3\Cars_Project\Cars_Project\Images\";
        OleDbConnection connection;
        OleDbCommand command;

        private void ConnectTo()
        {
            //connection = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0; Data Source =C:\Users\User\source\repos\atev40\Cars_Project\Cars_Project\Cars_Project\База данни1.accdb");
          connection = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0; Data Source =C:\Users\ACER\source\repos\Cars_Project3\Cars_Project\Cars_Project\База данни1.accdb");
            command = connection.CreateCommand();
        }



        public Form3()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        public Form3(String carID)
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            this.carID = carID;
        }


        private void Form3_Load(object sender, EventArgs e)
        {
            butBack.Size = new Size(100, 100);
            GraphicsPath Gcircle6 = new GraphicsPath();
            Gcircle6.AddEllipse(0,24,100, 50);
            this.butBack.Region = new Region(Gcircle6);
            loadCarInfo(carID);
        }

        private void loadCarInfo(String carID)
        {
            ConnectTo();
            command.CommandText = "SELECT * FROM IdCars WHERE ID=" + carID;
            command.CommandType = CommandType.Text;

            command.Connection = connection;

            connection.Open();
            

            OleDbDataReader dataReader = command.ExecuteReader();

            while (dataReader.Read())
            {
                label1.Text = dataReader["Brand"].ToString();
                label2.Text = dataReader["Model"].ToString();
                label3.Text = dataReader["ProdYear"].ToString();
                label4.Text = dataReader["Engine"].ToString();
                label5.Text = dataReader["Fuel"].ToString();
                label6.Text = dataReader["Doors"].ToString();
                label7.Text = dataReader["Condition"].ToString();
                label8.Text = dataReader["Price"].ToString();

                path += dataReader["Image"].ToString();
                Image carPic = Image.FromFile(path);
                pictureBox1.Image = carPic;
            }

            dataReader.Close();
            connection.Close();
        }


        private void tabPage1_Click(object sender, EventArgs e)
        {


        }

        

        private void butBack_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            this.Hide();
            form2.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
