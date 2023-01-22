// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

string url = "arquivo.txt";

var stream = new StreamWriter(url);

stream.Write("Texto salvo com sucesso.");

stream.Close();

var ler = new StreamReader(url);

System.Console.WriteLine(ler.ReadLine());
