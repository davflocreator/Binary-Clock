using System;
internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Introdu timpul in formatul HH:MM:SS:");
        string intTimp = Console.ReadLine();

        int linii = 4;
        int coloane = 6;

        int[,] binaryClock = ConvertToBinaryClock(intTimp, linii, coloane);

        DisplayBinaryClock(binaryClock, linii, coloane);
    }

    static int[,] ConvertToBinaryClock(string timp, int linii, int coloane)
    {
        int[,] binaryClock = new int[linii, coloane];

        for (int coloana = 0; coloana < coloane; coloana++)
        {
            int indexAjustat = (coloana > 2) ? coloana + 2 : coloana;

            int cifra = Convert.ToInt32(timp[indexAjustat] - '0');

            for (int rand = linii - 1; rand >= 0; rand--)
            {
                binaryClock[rand, coloana] = cifra % 2;
                cifra /= 2;
            }
        }

        return binaryClock;
    }

    static void DisplayBinaryClock(int[,] ceas, int linii, int coloane)
    {
        Console.WriteLine("H H M M S S");

        for (int i = 0; i < linii; i++)
        {
            for (int j = 0; j < coloane; j++)
            {
                Console.Write((i == 0 && (j == 0 || j == 2 || j == 4)) ? "  " : ceas[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}