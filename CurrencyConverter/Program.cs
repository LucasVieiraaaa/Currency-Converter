using System;
class Currency
{
    public string input = "";
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
                    isaNumber = true;
                }
                else if (inp.Length > 4)
                {
                    isaNumber = false;
                    Console.Write("\t\t Item inserted is to long ");
                }
                else if(inp.Length <= 0)
                {
                    isaNumber = false;
                    Console.Write("\t\t Item inserted is to short ");
                }
                else
                {
                    isaNumber = false;
                    Console.WriteLine($"Try again, {input} is not a number ");
                }
            }
        }
        catch
        {
            throw new Exception("Error");
        }
    }

    public static void Converter()
    {
        
    }
}

class Action {
    public static void Main()
    {
        Currency currency = new Currency();
        currency.Input();
    }
}
