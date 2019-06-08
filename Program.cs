using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_03_Exe19
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("QUESTIONÁRIO DE OPINIÃO DE UM FILME NO CINEMA");
            double ID, x, A, B, C, D, E, TID, MI;
            char OP;
            int cont;
            cont = 0;
            A = 0;
            B = 0;
            C = 0;
            D = 0;
            E = 0;
            TID = 0;
            do
            {
                do
                {
                    Console.Write("\nDigite a idade do {0}o espectador: ", cont + 1);
                    ID = double.Parse(Console.ReadLine());
                    x = (int)ID;
                    x = ID - x;
                }
                while (ID == 0 || x != 0);

                if (ID < 0)
                {
                    Console.WriteLine("IDADE INVÁLIDA!!!");
                    Console.WriteLine("FIM DA PESQUISA\n");
                    break;
                }

                do
                {
                    Console.WriteLine("Qual sua opinião sobre o filme?");
                    Console.Write("A - Ótimo\nB - Bom\nC - Regular\nD - Ruim\nE - Péssimo\n");
                    Console.Write("Digite sua opinião: ");
                    OP = char.Parse(Console.ReadLine().ToUpper());
                }
                while (OP != 'A' && OP != 'B' && OP != 'C' && OP != 'D' && OP != 'E');

                switch (OP)
                {
                    case 'A':
                        A = A + 1;
                        break;
                    case 'B':
                        B = B + 1;
                        break;
                    case 'C':
                        C = C + 1;
                        break;
                    case 'D':
                        D = D + 1;
                        break;
                    case 'E':
                        E = E + 1;
                        break;
                }
                cont++;
                TID = TID + ID;
            }
            while (ID > 0);

            A = A / cont;
            B = B / cont;
            C = C / cont;
            D = D / cont;
            E = E / cont;
            MI = TID / cont;
            Console.WriteLine("\n{0} pessoas assistiram o filme", cont);
            Console.WriteLine("A média de idade das pessoas que assistiram o filme é de {0} anos", MI);
            Console.WriteLine("{0:p1} consideraram o filme ÓTIMO", A);
            Console.WriteLine("{0:p1} consideraram o filme BOM", B);
            Console.WriteLine("{0:p1} consideraram o filme REGULAR", C);
            Console.WriteLine("{0:p1} consideraram o filme RUIM", D);
            Console.WriteLine("{0:p1} consideraram o filme PÉSSIMO", E);
            Console.ReadKey();
        }
    }
}
