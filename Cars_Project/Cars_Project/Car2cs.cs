﻿using System;
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
            //connection = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0; Data Source =C:\Users\ACER\source\repos\Cars_Project3\Cars_Project\Cars_Project\База данни1.accdb");
           //  connection = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0; Data Source =C:\Users\User\source\repos\atev40\Cars_Project\Cars_Project\Cars_Project\База данни1.accdb");

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
                String query = "INSERT INTO IdCars (Brand, Model, Engine, Fuel, Doors, Condition, Price) " +
                    "VALUES(@Brand,@Model,@Engine,@Fuel,@Doors,@Condition,@Price)";

                command.CommandType = CommandType.Text;
                command.CommandText = query;
                command.Connection = connection;

                command.Parameters.AddWithValue("@brand", c.Brand);
                command.Parameters.AddWithValue("@model", c.Model);
                //command.Parameters.AddWithValue("@year", c.Year);
                command.Parameters.AddWithValue("@engine", c.Engine);
                command.Parameters.AddWithValue("@fuel", c.Fuel);
                command.Parameters.AddWithValue("@doors", c.Doors);
                command.Parameters.AddWithValue("@condition", c.Condition);
                command.Parameters.AddWithValue("@price", c.Price);
                command.Parameters.AddWithValue("@id", c.ID);


                connection.Open();

                command.ExecuteNonQuery();

                /*command.CommandText = "INSERT INTO IdCars(Brand, Model, Year, Engine, Fuel, Doors, Condition, Price)VALUES ("
                    + "'" + c.Brand + "'" + "," + "'" + c.Model + "'" + "," + "'" + c.Year + "'" + "," + "'" + c.Engine + "'" + "," + "'" + c.Fuel + "'" + "," + "'" + c.Doors + "'" + "," + "'" + c.Condition + "'" + "," + "'" + c.Price + "'" + ")";

                command.CommandType = CommandType.Text;
                command.Connection = connection;
                connection.Open();
                command.ExecuteNonQuery();*/
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
            /*MessageBox.Show(c.ID, "");
            MessageBox.Show(c.Brand, "");
            MessageBox.Show(c.Model, "");
            MessageBox.Show(c.Year, "");
            MessageBox.Show(c.Engine, "");
            MessageBox.Show(c.Fuel, "");
            MessageBox.Show(c.Doors, "");
            MessageBox.Show(c.Condition, "");
            MessageBox.Show(c.Price, "");*/

            String query = @"UPDATE IdCars SET Brand=@brand, Model=@model, Engine=@engine, Fuel=@fuel, Doors=@doors, Condition=@condition, Price=@price WHERE ID=@id";

            //String query = @"UPDATE IdCars SET Brand=@brand, Model=@model, Year=@year WHERE ID=@id";

            try
            {
            command.CommandType = CommandType.Text;
            command.CommandText = query;
            command.Connection = connection;
            //command = new OleDbCommand(query, connection);
                
                    command.Parameters.AddWithValue("@brand", c.Brand);
                    command.Parameters.AddWithValue("@model", c.Model);
                    //command.Parameters.AddWithValue("@year", c.Year);
                    command.Parameters.AddWithValue("@engine", c.Engine);
                    command.Parameters.AddWithValue("@fuel", c.Fuel);
                    command.Parameters.AddWithValue("@doors", c.Doors);
                    command.Parameters.AddWithValue("@condition", c.Condition);
                    command.Parameters.AddWithValue("@price", c.Price);
                    command.Parameters.AddWithValue("@id", c.ID);


                connection.Open();

                command.ExecuteNonQuery();




            //command.CommandText = "Update IdCars SET Brand=" +
            //   "'" + c.Brand + "'" + "," +  "Model=" + "'" + c.Model + "'" + "," + "Year =" + "'" + c.Year + "'" + "," + "Engine =" + "'" + c.Engine + "'" + "," + "Fuel =" + "'" + c.Fuel + "'" +  "," + "Doors=" + c.Doors +  ","+ " Condition=" + "'" + c.Condition + "'" + "," + " Price=" + "'" + c.Price + "'"  +  " Where ID =" + c.ID;




            /*command.CommandType = CommandType.Text;
            command.Connection = connection;
            connection.Open();
            command.ExecuteNonQuery();*/
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
        
   