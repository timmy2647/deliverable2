using System;

namespace deliverable_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int heads = 0;
            int tails = 0;
            int counter = 0;
            Random coinflip = new Random();

            Console.WriteLine("Flip the coin how many times? ");
            counter = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < counter; i++)
            {
                int flip = coinflip.Next(1, 3);
                if (flip == 1)
                {
                    heads++;
                }
                else
                {
                    tails++;
                }
            }

            Console.WriteLine("You flipped a coin " + counter
               + "times and you got " + heads + "heads and " + tails + "tails. ");
           
        }
    }

}
    

