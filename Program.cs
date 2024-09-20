string NomeUsuario;

Console.Clear();
Console.BackgroundColor = ConsoleColor.White;
Console.ForegroundColor = ConsoleColor.Black;
Console.WriteLine("--- Nome Ninja ---");
Console.ResetColor();

Console.WriteLine();
Console.Write("Digite seu nome: ");

NomeUsuario = Console.ReadLine()!;

NomeUsuario = NomeUsuario.Trim().ToLower()
                         .Replace("a", "KA")
                         .Replace("b", "ZU")
                         .Replace("c", "MI")
                         .Replace("d", "TE")
                         .Replace("e", "KU")
                         .Replace("f", "LU")
                         .Replace("g", "JI")
                         .Replace("h", "RI")
                         .Replace("i", "KI")
                         .Replace("j", "ZUS")
                         .Replace("k", "ME")
                         .Replace("l", "TA")
                         .Replace("m", "RIN")
                         .Replace("n", "TO")
                         .Replace("o", "MO")
                         .Replace("p", "NO")
                         .Replace("q", "KE")
                         .Replace("r", "SHI")
                         .Replace("s", "ARI")
                         .Replace("t", "CHI")
                         .Replace("u", "DO")
                         .Replace("v", "RU")
                         .Replace("w", "MEI")
                         .Replace("x", "NA")
                         .Replace("y", "FU")
                         .Replace("z", "ZI");

Console.WriteLine($"Seu nome ninja é {NomeUsuario.Substring(0,1)}{NomeUsuario.ToLower().Substring(1)}");