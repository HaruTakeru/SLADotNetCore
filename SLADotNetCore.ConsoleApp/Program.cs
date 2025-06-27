// See https://aka.ms/new-console-template for more information
using Microsoft.Data.SqlClient;
using System.Data;

Console.WriteLine("Hello, World!");
//Console.ReadLine();
//Console.ReadKey();

// mk => markdown

// C# <=> Database
// ADO.NET
// Dapper (ORM)
// EFCore / Entity Framework (ORM)

// nuget

// Ctrl + .

//string connectionString = "Data Source=TMPC0045\\SQLEXPRESS02;Initial Catalog=SLADotNetCore;User ID=sa;Password=root;Encrypt=True;TrustServerCertificate=True;";
//Console.WriteLine("Connection String " + connectionString);
//SqlConnection connection = new SqlConnection(connectionString);

//Console.WriteLine("Connection opening...");
//connection.Open();
//Console.WriteLine("Connection opened !");

//string query = @"SELECT [BlogID]
//      ,[BlogTitle]
//      ,[BlogAuthor]
//      ,[BlogContent]
//      ,[Delete_Flag]
//  FROM [dbo].[Tbl_Blog] WHERE Delete_Flag = 0";
//SqlCommand cmd = new SqlCommand(query, connection);
//SqlDataAdapter adapter = new SqlDataAdapter(cmd);
//DataTable dataTable = new DataTable();
//adapter.Fill(dataTable);

//foreach (DataRow row in dataTable.Rows)
//{
//    Console.WriteLine(row["BlogId"]);
//    Console.WriteLine(row["BlogAuthor"]);
//    Console.WriteLine(row["BlogContent"]);
//    Console.WriteLine(row["Delete_Flag"]);
//}

//Console.WriteLine("Connection closing...");
//connection.Close();
//Console.WriteLine("Connectiong closed !");

string connectionString = "Data Source=TMPC0045\\SQLEXPRESS02;Initial Catalog=SLADotNetCore;User ID=sa;Password=root;Encrypt=True;TrustServerCertificate=True;";
SqlConnection connection = new SqlConnection(connectionString);
connection.Open();
Console.WriteLine("connection opened !");

string query = @"SELECT [BlogID]
      ,[BlogTitle]
      ,[BlogAuthor]
      ,[BlogContent]
      ,[Delete_Flag]
  FROM [dbo].[Tbl_Blog] WHERE Delete_Flag = 0";

SqlCommand cmd = new SqlCommand(query, connection);
SqlDataAdapter adapter = new SqlDataAdapter(cmd);
DataTable dataTb = new DataTable();
adapter.Fill(dataTb);

foreach (DataRow row in dataTb.Rows)
{
    Console.WriteLine(row["BlogId"]);
    Console.WriteLine(row["BlogTitle"]);
    Console.WriteLine(row["BlogAuthor"]);
    Console.WriteLine(row["BlogContent"]);
    Console.WriteLine(row["Delete_Flag"]);
}

connection.Close();
Console.WriteLine("Connectiong Closed !");

Console.ReadKey();

