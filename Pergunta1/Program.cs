namespace Target
{
    class Program
    {
        private static void Main(string[] args)
        {
            int INDICE = 13, SOMA = 0, K = 0;

            while (K < INDICE)
            {
                K += 1;

                SOMA += K;
            }

            Console.WriteLine($"O valor da variavel soma é: {SOMA}");
        }
    }

}