namespace Target
{
    class Program
    {
        static void Main(string[] args)
        {
            InvertendoString();
        }

        static void InvertendoString()
        {
            Console.Write("Digite a string: ");
            string texto = Console.ReadLine();

            string stringNormal = "", stringInvertida = "";

            char[] arrayDeCaracteres = texto.ToCharArray();
            int tamanho = arrayDeCaracteres.Length;

            int i = 0;
            foreach (char caractere in texto)
            {
                arrayDeCaracteres[i] = arrayDeCaracteres[tamanho - 1 - i];

                arrayDeCaracteres[tamanho - 1 - i] = caractere;

                i++;

                if (i >= tamanho / 2)
                {
                    break;
                }
            }

            stringNormal = new string(texto.ToCharArray());

            stringInvertida = new string(arrayDeCaracteres);

            Console.WriteLine($"A string normal é {stringNormal} e invertida é {stringInvertida}");
        }
    }

}
