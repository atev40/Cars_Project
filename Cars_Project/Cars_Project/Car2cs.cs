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

namespace Cars_Project
{
    class Vechile
    {
        OleDbConnection connection;
        OleDbCommand command;
        private void ConnectTo()
        {
            connection = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0; Data Source =C:\Users\ACER\source\repos\Cars_Project3\Cars_Project\Cars_Project\База данни1.accdb");
            command = connection.CreateCommand();
        }
        public Vechile()
        {
            ConnectTo();
        }
        public void Insert(Car c)
        {
            try
            {

                command.CommandText = "INSERT INTO IdCar(Brand, Model, Year, Engine, Fuel, Doors, Condition, Price, Image)" +
                    " VALUES ("


                   + "'" + c.Brand + "'" + "," + "'" + c.Model + "'" + "," + "'" + c.Year + "'" + "," + "'" + c.Engine + "'" + "," + "'" + c.Fuel + "'" + "," + "'" + c.Doors + "'" + "," + "'" + c.Condition + "'" + "," + "'" + c.Price + "'" + "," + "'" + c.Image + "'" + ")";

                command.CommandType = CommandType.Text;
                command.Connection = connection;
                connection.Open();
                command.ExecuteNonQuery();
            }


            catch (Exception)
            {

                MessageBox.Show("Incorrect data! Please enter again!");
            }
            finally
            {
                if (connection != null)
                {
                    connection.Close();
                }

            }
        }
        public void Update(Car c)
        {
            try
            {
                command.CommandText = "Update IdCars SET Name=" +
                   "'" + c.Brand + "'" + "," + "Model=" + "'" + c.Model + "'" + "," + "Year =" +
                    "'" + c.Year + "'" + "," + "Engine =" + "'" + c.Engine + "'" + "," + "Fuel =" + "'" + c.Fuel + "'" +
                   "," + "Doors=" + "'" + c.Doors + "'" + ","+ " Condition=" + c.Condition + "'" + "," + " Price=" + c.Price + "'" + "," 
                   + " Image=" + c.Image + "'" + "," + " Where ID =" + c.ID;


                command.CommandType = CommandType.Text;
                command.Connection = connection;
                connection.Open();
                command.ExecuteNonQuery();
            }
            catch (Exception)
            {

                MessageBox.Show("Incorrect data! Please enter again!");
            }
            finally
            {
                if (connection != null)
                {
                    connection.Close();
                }
            }
        }
        public void Delete(Car c)
        {
            try
            {
                command.CommandText = "DELETE FROM IdCars WHERE ID=" + c.ID;
                command.CommandType = CommandType.Text;
                command.Connection = connection;
                connection.Open();
                command.ExecuteNonQuery();
            }
            catch (Exception)
            {

                MessageBox.Show("Incorrect data! Please enter again!");
            }
            finally
            {
                if (connection != null)
                {
                    connection.Close();
                }
            }
        }
        public DataTable SelectAll()
        {
            DataTable dataTable = new DataTable();
            try
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "SELECT* FROM IdCars";
                OleDbDataAdapter dataAdapter = new OleDbDataAdapter(command);
                dataTable = new DataTable();
                dataAdapter.Fill(dataTable);
            }
            catch (Exception)
            {

                MessageBox.Show("Incorrect data! Please enter again!");
            }
            finally
            {
                if (connection != null)
                {
                    connection.Close();
                }
            }
            return dataTable;
        }
    }
}
        
   