using System;
using System.Globalization;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

//connection database
public static class ConnectionMySql
{
    public static string server = "localhost";
    public static string database = "cevherorderdb";
    public static string user = "root";
    public static string password = "pass";
    public static int port = 3306; // MySQL varsayılan portu

    public static string connectionString = $"Server={server};Port={port};Database={database};User={user};Password={password};";
    
    public static MySqlConnection GetConnection()
    {
        MySqlConnection connection = new MySqlConnection(connectionString);
        return connection;
    }
};

public static class addtodatabase
{
    //take information from textbox inputs
    public static void orderforminfo(TextBox textbox1)
    {


    }
    //take information from datagridview
    public static void orderformproducts()
    {

    }

};