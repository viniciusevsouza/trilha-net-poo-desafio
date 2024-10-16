using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Nokia n1 = new Nokia("912345678", "Nokia Teste", "123456789123456", 64);

Console.WriteLine("Smartphone Nokia");
n1.Ligar();
n1.ReceberLigacao();
n1.InstalarAplicativo("Nokia teste");

Iphone i1 = new Iphone("922345678", "Iphone Teste", "223456789123456", 128);

Console.WriteLine("\n");
Console.WriteLine("Smartphone iPhone");
i1.Ligar();
i1.ReceberLigacao();
i1.InstalarAplicativo("Iphone teste");