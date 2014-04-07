using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Data.SqlClient;

namespace WindowsFormsApplication4
{
    class DBAdaptor
    {

        private OleDbConnection connection = null;
        private bool ready = false;

        public DBAdaptor()
        {
            if (connection == null) reopenConnection();
            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;" +
            @"Data Source= C:\Users\Tiasa Mondol\Dropbox\Project\AwesomePOS-master\AwesomePOS.accdb;Persist Security Info=False;";
            try
            {
                connection.Open();
                ready = true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Failed to connect to data source!!! " + ex);
            }
        }

        private void reopenConnection()
        {
            if (connection != null) closeConnection();
            connection = new System.Data.OleDb.OleDbConnection();
        }

        public void closeConnection()
        {
            connection.Close();
            connection.Dispose();
            ready = false;
        }

        public DataTypes.Good getItemById(int itemId)
        {
            DataTypes.Good goodey = new DataTypes.Good();
            string sqlStr = @"SELECT * FROM Items WHERE ID = " + itemId;
            OleDbCommand cmd = new OleDbCommand(sqlStr, connection);
            OleDbDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                goodey.id = Convert.ToInt32(reader["ID"].ToString());
                goodey.imageURL = reader["ImageURL"].ToString();
                goodey.name = reader["ProductName"].ToString();
                goodey.price = Convert.ToDouble(reader["Price"].ToString());
            }
            else return null;
            return goodey;
        }

        public List<int> getItemsForOrderId(int orderId)
        {
            List<int> list = new List<int>();
            OleDbCommand cmd = new OleDbCommand("SELECT ProductId FROM OrderItems WHERE OrderId = " + orderId, connection);
            OleDbDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                list.Add(Convert.ToInt32(reader["ProductId"].ToString()));
            }
            return list;
        }

        /*public List<DataTypes.Good> getAllItems()
        {
            List<DataTypes.Good> list = new List<DataTypes.Good>();
            OleDbCommand cmd = new OleDbCommand("SELECT * FROM Items", connection);
            OleDbDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                DataTypes.Good goodey = new DataTypes.Good();
                goodey.id = Convert.ToInt32(reader["ID"].ToString());
                goodey.imageURL = reader["ImageURL"].ToString();
                goodey.name = reader["ProductName"].ToString();
                goodey.price = Convert.ToDouble(reader["Price"].ToString());
                list.Add(goodey);
            }
            return list;
        } */

        public List<DataTypes.Sale> getSales(int skip = 0, int count = 0)
        {
            List<DataTypes.Sale> list = new List<DataTypes.Sale>();

            string sqlString = @"SELECT * FROM Sales ";
            if (skip != 0 || count != 0)
                sqlString += @"WHERE ID BETWEEN " + (skip+1) + " AND " + (skip+count) + " AND ACTIVE = YES";
            else sqlString += @" WHERE ACTIVE = YES";
            OleDbCommand cmd = new OleDbCommand(sqlString, connection);
            OleDbDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                DataTypes.Sale sale = new DataTypes.Sale();
                sale.id = Convert.ToInt32(reader["ID"].ToString());
                sale.name = reader["SaleName"].ToString();
                sale.value = Convert.ToInt32(reader["SaleValue"].ToString());
                list.Add(sale);
            }
            return list;
        }

        public List<DataTypes.Good> getBeverage(int skip = 0, int count = 0)
        {
            List<DataTypes.Good> list = new List<DataTypes.Good>();
            string sqlString;
           // if (skip != 0 || count != 0)
             //   sqlString += @"WHERE ID BETWEEN " + (skip + 1) + " AND " + (skip + count) + " AND Type=" + "\'" + "Beverage" + "\'";
            //else 
            //sqlString += @"WHERE Type="+"\'"+"Beverage"+"\'";

            if (skip != 0) sqlString = @"SELECT TOP " + count + " * FROM Items WHERE ID NOT IN (SELECT TOP " + skip + " ID FROM Items WHERE Type=" + "\'" + "Beverage" + "\'" + ") AND Type=" + "\'" + "Beverage" + "\'";
            else sqlString = @"SELECT TOP " + count + " * FROM Items WHERE Type=" + "\'" + "Beverage" + "\'";
            OleDbCommand cmd = new OleDbCommand(sqlString, connection);
            OleDbDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                DataTypes.Good goodey = new DataTypes.Good();
                goodey.id = Convert.ToInt32(reader["ID"].ToString());
                //goodey.imageURL = reader["ImageURL"].ToString();
                goodey.name = reader["ProductName"].ToString();
                goodey.price = Convert.ToDouble(reader["Price"].ToString());
                list.Add(goodey);
            }
            return list;
        }

         public List<DataTypes.Good> getGoods(int skip = 0, int count = 0)
         {
             List<DataTypes.Good> list = new List<DataTypes.Good>();
             string sqlString ;
             if (skip != 0) sqlString = @"SELECT TOP " + count + " * FROM Items WHERE ID NOT IN (SELECT TOP " + skip + " ID FROM Items WHERE Type=" + "\'" + "Food" + "\'" + ") AND Type=" + "\'" + "Food" + "\'";
             else sqlString = @"SELECT TOP " + count + " * FROM Items WHERE Type=" + "\'" + "Food" + "\'";
             OleDbCommand cmd = new OleDbCommand(sqlString, connection);
             OleDbDataReader reader = cmd.ExecuteReader();
             while (reader.Read())
             {
                 DataTypes.Good goodey = new DataTypes.Good();
                goodey.id = Convert.ToInt32(reader["ID"].ToString());
                goodey.imageURL = reader["ImageURL"].ToString();
                goodey.name = reader["ProductName"].ToString();
                goodey.price = Convert.ToDouble(reader["Price"].ToString());
                list.Add(goodey);
             }
             return list;
         }
         
        public DataTypes.Sale getSaleById(int saleId)
        {
            DataTypes.Sale sale = new DataTypes.Sale();
            string sqlStr = @"SELECT * FROM Sales WHERE ID = " + saleId + " AND Active = YES";
            OleDbCommand cmd = new OleDbCommand(sqlStr, connection);
            OleDbDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                sale.id = Convert.ToInt32(reader["ID"].ToString());
                sale.value = Convert.ToInt32(reader["SaleValue"].ToString());
                sale.name = reader["SaleName"].ToString();
            }
            else return null;
            return sale;
        }

        public bool testConnection()
        {
            return ready;
        }

        internal void saveOrder(List<DataTypes.Good> currentOrder, int saleValue)
        {
            //throw new NotImplementedException();
        }
    }
}
