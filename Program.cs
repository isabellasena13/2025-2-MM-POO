// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Televisao tv = new Televisao(55f);
Console.WriteLine($"A tv tem o tamanho {tv.Tamanho}");

tv.Ligar();

tv.ProximoCanal();
Console.WriteLine($"Canal {tv.Canal}");

tv.IrParaCanal(100);
Console.WriteLine($"Canal {tv.Canal}");

tv.CanalAnterior();
Console.WriteLine($"Canal {tv.Canal}");

tv.AumentarVolume();
Console.WriteLine($"Volume {tv.Volume}");

tv.DiminuirVolume();
Console.WriteLine($"Volume {tv.Volume}");

tv.AtivarMudo();
tv.DesativarMudo();

tv.Desligar();



