namespace Target
{
    class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Digite um número: ");
            int numero = Convert.ToInt32(Console.ReadLine());

            if (VerificarNumeroInFibonacci(numero))
            {
                Console.WriteLine($"O número {numero} pertence a sequência de fibonacci!\n");
            }
            else
            {
                Console.WriteLine($"O número {numero} não pertence a sequência de fibonacci!\n");
            }


            Fibonacci();
        }

        public static void Fibonacci()
        {

            int numeroAnterior = 0, numeroAtual = 1, fibonacci;

            Console.WriteLine("A sequência de Fibonacci é :");

            for (int i = 0; i < 10; i++)
            {
                fibonacci = numeroAnterior + numeroAtual;

                Console.WriteLine(fibonacci);

                numeroAnterior = numeroAtual;

                numeroAtual = fibonacci;
            }

        }

        public static bool VerificarNumeroInFibonacci(int numero)
        {
            int numeroAnterior = 0, numeroAtual = 1;

            for (int i = 0; i < 10; i++)
            {
                if (numeroAtual == numero)
                {
                    return true;
                }

                int fibonacci = numeroAnterior + numeroAtual;

                numeroAnterior = numeroAtual;
                numeroAtual = fibonacci;
            }

            return false;
        }
    }
}