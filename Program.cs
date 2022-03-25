string fraseDigitada, fraseElada;
            
            Console.Write("Digite uma flase: ");
            fraseDigitada = Console.ReadLine()!;

            fraseElada = fraseDigitada
                .Replace("r", "l")
                .Replace("R", "L");

            Console.WriteLine(fraseElada);


