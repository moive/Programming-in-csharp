// See https://aka.ms/new-console-template for more information
using Exercices;
using Method3.Linq;
using Operations;
using Programming_in_csharp;
using System.Configuration;

var message = ConfigurationManager.AppSettings["message"];
Console.WriteLine(message);
Console.ReadKey();