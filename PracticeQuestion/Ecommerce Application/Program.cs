using System;

public class EcommerceShop{
    public string UserName { get; set; }
    public double WalletBalance { get; set; }
    public double TotalPurchaseAmount { get; set; }
}

public class InsufficientWalletBalanceException : Exception{
    public InsufficientWalletBalanceException() 
        : base("Insufficient balance in your digital wallet")
    {
    }
}

public class Program{
    public static EcommerceShop MakePayment(string name, double balance, double amount){
        if (balance < amount){
            throw new InsufficientWalletBalanceException();
        }
        EcommerceShop shop = new EcommerceShop();
        shop.UserName = name;
        shop.WalletBalance = balance;
        shop.TotalPurchaseAmount = amount;

        return shop;
    }

    public static void Main(string[] args){
        Console.WriteLine("Enter name: ");
        string name = Console.ReadLine();
         Console.WriteLine("Enter balance(double): ");
        double balance = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter amount (balance<=amount): ");
        double amount = Convert.ToDouble(Console.ReadLine());

        try{
            EcommerceShop result = MakePayment(name, balance, amount);
            Console.WriteLine("Payment successful");
        }
        catch (InsufficientWalletBalanceException ex){
            Console.WriteLine(ex.Message);
        }
    }
}
