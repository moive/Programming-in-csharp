// See https://aka.ms/new-console-template for more information
using Exercices;
using Method3.Linq;
using Operations;
using Programming_in_csharp;
using System.Configuration;
using System.Data.SqlClient;

var message = ConfigurationManager.AppSettings["message"];
Console.WriteLine(message);

var builder = new SqlConnectionStringBuilder();
builder.DataSource = @"MVELASQUEZ";
builder.InitialCatalog = "Prueba";
builder.IntegratedSecurity = true;

var connectionString = builder.ToString();

Console.ReadKey();