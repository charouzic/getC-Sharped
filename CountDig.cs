using System;
namespace getInShape
{
    public class CountDig
    {

        public int NbDig(int n, int d)
        {
            // your code
            // first take all the numbers from 1 up to n where the result of squaring them <= n
            //List<int> digits = new List<int>();
            int count = 0;

            if (d == 0)
            {
                count++;
            }

            for (int i = 1; i <= n; i++)
            {


                int square = i * i;
                while (square > 0)
                {
                    // check if the digit is D
                    if (square % 10 == d)
                    {
                        count++;
                    }
                    square = square / 10;
                }
            }

            return count;

        }
    }
}
