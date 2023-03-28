namespace DiamantedeLetras.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {


           
            Console.WriteLine(" DIAMANTE DE LETRAS ");
            Console.WriteLine();

            char letra = ' ';
            bool letraValida = false;

            while (!letraValida)
            {
                Console.Write("Insira uma letra maiúscula: ");
                string input = Console.ReadLine();

                if (char.TryParse(input, out letra) && char.IsUpper(letra))
                {
                    letraValida = true;
                }
                else
                {
                    Console.WriteLine("A letra inserida não é válida. Tente novamente.");
                }
            }

            int numLetras = letra - 'A' + 1;

            for (int i = 0; i < numLetras; i++)
            {
                for (int j = 0; j < numLetras - i - 1; j++)
                {
                    Console.Write(" ");
                }

                Console.Write((char)('A' + i));

                if (i > 0)
                {
                    for (int j = 0; j < i * 2 - 1; j++)
                    {
                        Console.Write(" ");
                    }

                    Console.Write((char)('A' + i));
                }

                Console.WriteLine();
            }

            for (int i = numLetras - 2; i >= 0; i--)
            {
                for (int j = 0; j < numLetras - i - 1; j++)
                {
                    Console.Write(" ");
                }

                Console.Write((char)('A' + i));

                if (i > 0)
                {
                    for (int j = 0; j < i * 2 - 1; j++)
                    {
                        Console.Write(" ");
                    }

                    Console.Write((char)('A' + i));
                }

                Console.WriteLine();
            }



        }
    }
}