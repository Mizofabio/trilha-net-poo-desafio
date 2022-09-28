using DesafioPOO.Models;

Console.WriteLine("Smartphone Nokia");

Smartphone nokia = new Nokia(numero: "23546798", modelo: "Nokia 110", imei: "01010101254", memoria: 64);
nokia.Ligar();
nokia.InstalarAplicativo("Whatsapp");

Console.WriteLine("\n");

Console.WriteLine("Smartphone Iphone");
Smartphone iphone = new Iphone(numero: "98674532", modelo: "Iphone 13 Pro MAX", imei: "3030302545", memoria: 128);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Telegram");


