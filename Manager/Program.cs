// See https://aka.ms/new-console-template for more information
using System;
using System.Data;
using System.Data.SqlClient;


class Program
{
    static void Main()
    {
        string connectionString = "Data Source=SRV2\\PUPILS;Initial Catalog=325953446_Products;Integrated Security=True";

        DataAccess da = new DataAccess();

        da.insertCategory(connectionString);


    }
}


