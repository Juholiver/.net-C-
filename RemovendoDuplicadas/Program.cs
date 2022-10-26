

    class Program
    {
        static void Main()
        {
            string palavraDuplicadas = "abracadabra; allottee; assessee; kelless; keenness; alfalggo ";
            string palavraFinal = "";
                for (int i = 0; i < palavraDuplicadas.Length; i++)
                {
                    if(i > 0 && palavraDuplicadas[i-1] == palavraDuplicadas[i])
                    {
                        continue;
                    }
                palavraFinal = palavraFinal + palavraDuplicadas[i];
                }
        Console.WriteLine(palavraDuplicadas);
        Console.WriteLine("---------------------------***--------------------------");
        Console.WriteLine(palavraFinal);
        }

           
       
    }
