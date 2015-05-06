using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
            static int[] Number = new int[4];           
            static int[] guess = new int[4];
            static int A;
            static int B;

        static void Main(string[] args)
        {
            Random random = new Random(Guid.NewGuid().GetHashCode());

            for (int i = 0; i <= 3; i++)
            {
                Number[i] = random.Next(1, 10);
            }
            while (!GuessCorrect()) 
            {
                A = 0;
                B = 0;
                for (int j = 0; j <= 3; j++)
                {
                    guess[j] = int.Parse(Console.ReadLine());
                }
            CorrectAnswer();
            Console.WriteLine(A + "A" + B + "B");
            }
            Console.WriteLine("答對了");

        }
        public static void CorrectAnswer()
        {
            for (int i = 0; i <= 3; i++)
            {
                if (Number[i] == guess[i])
                {
                    A = A + 1;
                }
            }
            }
        public static bool GuessCorrect()
        {
            return A == 4;
        }

        }
    }

