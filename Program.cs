using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
System.Console.WriteLine("-------------------------------");
System.Console.WriteLine("-------------Nokia-------------");
System.Console.WriteLine("-------------------------------");

Smartphone Nokia = new Nokia("81999999999", "Nokia 110 4G", "123456789012345", 128);
Nokia.Ligar();
Nokia.InstalarAplicativo("Telegram");

System.Console.WriteLine("-------------------------------");
System.Console.WriteLine("-- Instalação realizada 100%---");
System.Console.WriteLine("-------------------------------");
System.Console.WriteLine("\n");

System.Console.WriteLine("-------------------------------");
System.Console.WriteLine("------------Iphone-------------");
System.Console.WriteLine("-------------------------------");

Smartphone Iphone = new Iphone("81988888888", "iPhone 13 Pro Max", "987654321098765", 128);
Iphone.Ligar();
Iphone.InstalarAplicativo("Telegram");
System.Console.WriteLine("-------------------------------");
System.Console.WriteLine("-- Instalação realizada 100%---");
System.Console.WriteLine("-------------------------------");