using System;

public class Program
{
    public static void Main()
    {
        string[] palavraDuplicadas = { "abracaadabra", "allottee", "assessee", "kelless", "keenness", "alfalggo" };
        string[] palavraFinal = new string[6];

        for (int j = 0; j < palavraDuplicadas.Length; j++)
        {
            string aux = "";
            for (int i = 0; i < palavraDuplicadas[j].Length; i++)
            {
                if (i > 0 && palavraDuplicadas[j][i - 1] == palavraDuplicadas[j][i])
                {
                    continue;
                }
                aux = aux + palavraDuplicadas[j][i].ToString();
            }
            palavraFinal[j] = aux;
        }

        foreach (string duplicadas in palavraDuplicadas)
        {
            Console.Write(duplicadas + " ");
        }
        Console.WriteLine("\n ---------------------------*--------------------------");
        foreach (string final in palavraFinal)
        {
            Console.Write(final + " ");
        }
    }
}
