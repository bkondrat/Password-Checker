using System;

namespace PasswordChecker
{
    class Program
    {
        public static void Main(string[] args)
        {
            int minLength = 8;
            
            Console.WriteLine("Please enter a password: ");
            string password = Console.ReadLine();
            int score = 0;
            if (password.Length >= minLength)
            {
                score++;
            }
            if (password.Any(char.IsUpper))
            {
                score++;
            }
            if (password.Any(char.IsLower))
            {
                score++;
            }
            if (password.Any(char.IsDigit))
            {
                score++;
            }
         
            Console.WriteLine($"Your score is: {score}");
            switch (score)
            {
                case 5:
                case 4:
                    Console.WriteLine("Your password is extremely strong");
                    break;
                case 3:
                    Console.WriteLine("Your password is strong");
                    break;
                case 2:
                    Console.WriteLine("Your password is medium");
                    break;
                case 1:
                    Console.WriteLine("Your password is weak");
                    break;
                default:
                    Console.WriteLine("Your password doesn’t meet any of the standards");
                    break;

            }
        }
    }
}

