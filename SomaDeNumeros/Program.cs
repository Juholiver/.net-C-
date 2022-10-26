
namespace SomaDeNumeros
{
    class Program
    {
        static void Main(string[] args)
        {
            int inicio = 1, final = 8, soma = 0;

            //Percorrer todos valores entre 1 e 1000 e somar estes valores
            for (int i=inicio; i<= final; i++)
            {
                //vai somando todos os valores
                soma = soma + i;
            }

            //Apresenta o resultado na tela
            Console.WriteLine(String.Format("O resultado da soma é: {0}", soma));

            //Aguarda até que uma tecla seja acionada
            Console.ReadLine();
        }
    }
}
