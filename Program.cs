System.Console.Write("Digite seu nome e sobrenome: ");

string Nome = Console.ReadLine()!;

string PrimeiroNome = Nome.Substring(0, Nome.IndexOf(" "));
string Segundonome = Nome.Substring(Nome.IndexOf(" ") + 1);

System.Console.WriteLine();
    System.Console.WriteLine("Nome completo: " + PrimeiroNome + " " + Segundonome);
System.Console.WriteLine();
    System.Console.WriteLine("Nome de catálogo: " + Segundonome + ", " + PrimeiroNome);
System.Console.WriteLine();
    System.Console.WriteLine("Pressione uma tecla para fechar...");
Console.ReadKey();


