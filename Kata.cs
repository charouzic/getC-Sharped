using System;
namespace getInShape
{
    public class Kata
    {
        public bool Narcissistic(int value)
        {
            // Code me
            // divide the number by 10, 100, 1000,... up to 10 decimal
            // take the rest of the number after division by 10 (x%10) == takes the last number
            // sum all these numbers 

            // getting the number of digits in the number
            if (value <= 0)
            {
                return false;
            }

            int conditionalValue = value;
            long lenght = 1;
            int count = 1;
            while ((conditionalValue /= 10) >= 1)
            {
                count += 1;
                lenght *= 10;

            }

            int sum = 0;
            for (int i = 1; i <= lenght; i *= 10)
            {
                sum += (int)Math.Pow(value / i % 10, count);
            }

            if (sum == value)
            {
                return true;
            }

            return false;
        }

        public bool CheckCoupon(string enteredCode, string correctCode, string currentDate, string expirationDate)
        {
            //
            if (enteredCode == correctCode)
            {
                DateTime currentD = DateTime.ParseExact(currentDate, "MMMM d, yyyy", CultureInfo.InvariantCulture);
                DateTime expirD = DateTime.ParseExact(expirationDate, "MMMM d, yyyy", CultureInfo.InvariantCulture);

                Console.WriteLine(currentD);
                Console.WriteLine(expirD);

                var hours = (currentD - expirD).TotalHours;

                if (hours <= 24)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
