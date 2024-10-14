using System;
class Currency
{
    public string input { get; set; }
    public float BRL { get; set; }
    public float USD { get; set; }
    public float EUR { get; set; }
    public float CAN { get; set; }
    public float CoinValue { get; set; }
    public void Card()
    {
        Console.WriteLine("\t\t  ___________________ \t\t");
        Console.WriteLine("\t\t |                   |\t\t");
        Console.WriteLine("\t\t |        BRL        |\t\t");
        Console.WriteLine("\t\t |        USD        |\t\t");
        Console.WriteLine("\t\t |        EUR        |\t\t");
        Console.WriteLine("\t\t |        CAN        |\t\t");
        Console.WriteLine("\t\t |___________________|\t\t");
    }

    public void Input()
    {
        bool isaNumber = false;
        try
        {
            Card();
            while(isaNumber == false){
                Console.Write("\n\t      Insert your local currency: ");
                string inp = Console.ReadLine();

                if (inp.Length == 3)
                {
                    input = inp.ToLower();
                    Converter(input);
                }
                else if (inp.Length > 4)
                {
                    Console.Write("\t\t Item inserted is to long ");
                }
                else if(inp.Length <= 0)
                {
                    Console.Write("\t\t Item inserted is to short ");
                }
                else
                {
                    Console.WriteLine($"\t\t Try again, {inp} is not a number ");
                }
            }
        }
        catch
        {
            throw new Exception("Error");
        }
    }

    public void Converter(string input)
    {
        float coinValue = 0;

        if (input == "brl")
        {
            CoinValue = 0;
            Card();
            Console.WriteLine("\t     To which currency do you want to convert?");

            string inp = Console.ReadLine();

            if (inp.Length == 3)
            {
                input = inp.ToLower();
            }
            else if (inp.Length > 4)
            {
                Console.Write("\t\t Item inserted is to long ");
            }
            else if (inp.Length <= 0)
            {
                Console.Write("\t\t Item inserted is to short ");
            }
            else
            {
                Console.WriteLine($"\t\t Try again, {inp} is not a number ");
            }

        }
        else if (input == "usd")
        {
            CoinValue = 0;
            Card();
            Console.WriteLine("\t     To which currency do you want to convert?");

            string inp = Console.ReadLine();

            if (inp.Length == 3)
            {
                input = inp.ToLower();
            }
            else if (inp.Length > 4)
            {
                Console.Write("\t\t Item inserted is to long ");
            }
            else if (inp.Length <= 0)
            {
                Console.Write("\t\t Item inserted is to short ");
            }
            else
            {
                Console.WriteLine($"\t\t Try again, {inp} is not a number ");
            }
        }
        else if (input == "eur")
        {
            CoinValue = 0;
            Card();
            Console.WriteLine("\t     To which currency do you want to convert?");

            string inp = Console.ReadLine();

            if (inp.Length == 3)
            {
                input = inp.ToLower();
            }
            else if (inp.Length > 4)
            {
                Console.Write("\t\t Item inserted is to long ");
            }
            else if (inp.Length <= 0)
            {
                Console.Write("\t\t Item inserted is to short ");
            }
            else
            {
                Console.WriteLine($"\t\t Try again, {inp} is not a number ");
            }
        }
        else if (input == "can")
        {
            CoinValue = 0;
            Card();
            Console.WriteLine("\t     To which currency do you want to convert?");

            string inp = Console.ReadLine();

            if (inp.Length == 3)
            {
                input = inp.ToLower();
            }
            else if (inp.Length > 4)
            {
                Console.Write("\t\t Item inserted is to long ");
            }
            else if (inp.Length <= 0)
            {
                Console.Write("\t\t Item inserted is to short ");
            }
            else
            {
                Console.WriteLine($"\t\t Try again, {inp} is not a number ");
            }
        }
        else
        {
            Console.Write("\t\t Invalid Currency ");
        }
    }

    public void Verify(string input)
    {
        if(input.ToLower() == "brl")
        {
            
        }
    }
}

class Action {
    public static void Main()
    {
        Currency currency = new Currency();
        currency.Input();
    }
}
