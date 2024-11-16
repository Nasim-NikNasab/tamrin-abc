using System;
static class KeyBoard
{
    public static char GetYesOrNo()
    {
        char key;
        do
        {
            key = Console.ReadKey(true).KeyChar;
        } while (key != 'y' && key != 'n' && key != 'Y' && key != 'N');
        Console.WriteLine(key);
        return key;
    }
}

internal class Program
{
    static bool IsPalindrome(string number)
    {
        int length = number.Length;
        for (int i = 0; i < length / 2; i++)
        {
            if (number[i] != number[length - i - 1])
            {
                return false;
            }
        }
        return true;
    }
    private static void Main(string[] args)
    {
        Console.WriteLine("which one? (a) (b) (c)");
        string? answer = Console.ReadLine();
        switch (answer)
        {
            case "a":
                Console.WriteLine("enter number");
                string? n1 = Console.ReadLine();
                int n1_int = Convert.ToInt32(n1);
                if (n1_int < 2)
                {
                    Console.WriteLine("it is not");
                }
                if (n1_int < 1000)
                {
                    bool is_prime = true;
                    if (n1_int >= 2)
                    {
                        for (int c = 2; c <= n1_int / 2; c++)
                        {
                            if (n1_int % c == 0)
                            {
                                is_prime = false;
                                break;
                            }
                        }
                        if (is_prime)
                        {
                            Console.WriteLine($"{n1_int} is a prime number.");
                        }
                        else
                        {
                            Console.WriteLine($"{n1_int} is not a prime number.");
                        }

                    }
                }
                if (n1_int >= 1000)
                {
                    bool is_prime = false;
                    for (int i = 2; i <= Math.Sqrt(n1_int); i++)
                    {
                        if (n1_int % i == 0 && n1_int == i)
                        {
                            is_prime = true;
                            break;
                        }
                    }
                    if (is_prime)
                    {
                        Console.WriteLine($"{n1_int} is a prime number.");
                    }
                    else
                    {
                        Console.WriteLine($"{n1_int} is not a prime number.");
                    }

                }
                break;
            case "b":
                Console.Write("enter namber: ");
                string? input = Console.ReadLine();
                if (IsPalindrome(input))
                {
                    Console.WriteLine($" {input} is.");
                }
                else
                {
                    Console.WriteLine($" {input} is not.");
                }
                break;
            case "c":
                Console.Write("are you hungry?");
                string r = "";
                bool IsContinue = true;

                do
                {

                    r = r + KeyBoard.GetYesOrNo().ToString().ToLower();

                    switch (r)
                    {
                        case "y":
                            Console.Write("is it middle of the day?");
                            break;
                       
                        case "yy":
                            Console.Write("eat lunch.");
                            break;
                        case "yn":
                            Console.Write("is it after 6 pm?");
                            IsContinue = false;
                            break;
                        case "yny":
                            Console.Write("eat dinner");
                            IsContinue = false;
                            break;
                        case "ynn":
                            Console.Write("eat snack");
                            IsContinue = false;
                            break;
                        case "n":
                            Console.Write("do you have any job to do?");
                            break;
                        case "ny":
                            Console.Write("do it");
                            IsContinue = false;
                            break;
                        case "nn":
                            Console.Write("did you exercise?");
                            
                            break;
                        case "nny":
                            Console.Write("watch tv.");
                            IsContinue = false;
                            break;
                        case "nnn":
                            Console.Write("go to gym.");
                            IsContinue = false;
                            break;
                            default:
                            throw new Exception();
                    }

                } while (IsContinue);
                Console.WriteLine();
                Console.WriteLine("The End!");
                break;
        }
    }
}
