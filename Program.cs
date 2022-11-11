using DesafioPOO.Models;

Console.WriteLine("Smartphone Nokia: ");
Smartphone nokia = new Nokia(numero: "51165", modelo: "Modelo 1", imei: "33333333", memoria: 64);
nokia.Ligar();
nokia.InstalarAplicativo("Instagram");



Console.WriteLine("Smartphone Iphone: ");
Smartphone iphone = new Iphone(numero: "84y843", modelo: "Modelo 8", imei: "99999999", memoria: 128);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Facebook");

