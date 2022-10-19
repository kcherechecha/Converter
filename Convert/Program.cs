class Converter {
    private decimal dollar;
    private decimal euro;
    public Converter(decimal _dollar, decimal _euro) {
        dollar = _dollar;
        euro = _euro;
    }
    public decimal ConvertToUSD(List<decimal> dollarRate, decimal amount)
    {
        dollar = dollarRate[0];
        Console.Write("Your amount in USD: ");
        return amount/ dollar;
    }
    public decimal ConvertToEUR(List<decimal> dollarRate, decimal amount) {
        euro = dollarRate[1]; 
        Console.Write("Your amount in EUR: ");
        return amount/ euro;
    }
    public decimal USDtoUAH(List<decimal> dollarRate, decimal amount){
        dollar = dollarRate[0];
        Console.Write("Your amount in UAH: ");
        return amount* dollar;
        
    }

    public decimal EURtoUAH(List<decimal> dollarRate, decimal amount) {
        euro = dollarRate[1]; 
        Console.Write("Your amount in UAH: ");
        return amount* euro;
    }
}

internal class Program {
    private static void Main(string[] args)
    {
        decimal dollar;
        decimal euro;
        decimal amount;
        List<decimal> rate = new List<decimal>();
        
        Console.WriteLine("Enter the amount you wish to convert:");
        amount = Convert.ToDecimal(Console.ReadLine());
        while (amount <= 0)
        {
            Console.WriteLine("Note that the amount has to be positive. Try again");
            amount = Convert.ToDecimal(Console.ReadLine());
        }
        
        Console.WriteLine("Enter a currency rate for USD: ");
        dollar = Convert.ToDecimal(Console.ReadLine());
        while (dollar <= 0)
        {
            Console.WriteLine("Note that the coefficient has to be positive. Try again");
            dollar = Convert.ToDecimal(Console.ReadLine());
        }
        rate.Add(dollar);
        
        Console.WriteLine("Enter a currency rate for EUR: ");
        euro = Convert.ToDecimal(Console.ReadLine());
        while (euro <= 0)
        {
            Console.WriteLine("Note that the coefficient has to be positive. Try again");
            euro = Convert.ToDecimal(Console.ReadLine());
        }
        rate.Add(euro);

        while (true)
        {
            int action = 0;
            Console.WriteLine("Choose action 1,2,3,4,5\n1. Convert UAH to USD\n2. Convert UAH to EUR\n3. Convert USD to UAH\n4. Convert EUR to UAH\n5. End");
            try
            {
                action = Int32.Parse(Console.ReadLine());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.WriteLine();
            switch (action)
            {
                case 1:
                    Converter conv = new Converter(dollar, euro);
                    Console.WriteLine(conv.ConvertToUSD(rate, amount) + " USD" + "\n");
                    break;
                case 2:
                    Converter conv1 = new Converter(dollar, euro);
                    Console.WriteLine(conv1.ConvertToEUR(rate, amount) + " EUR" + "\n");
                    break;
                case 3:
                    Converter conv2 = new Converter(dollar, euro);
                    Console.WriteLine(conv2.USDtoUAH(rate, amount) + " UAH" + "\n");
                    break;
                case 4:
                    Converter conv3 = new Converter(dollar, euro);
                    Console.WriteLine(conv3.EURtoUAH(rate, amount) + " UAH" + "\n");
                    break;
                case 5:
                    return;
            }
        }
    }
}