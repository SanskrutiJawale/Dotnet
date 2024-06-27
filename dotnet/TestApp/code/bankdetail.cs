using System;

class bankdetail
{
    static void Main(string[] args)
    {
        const string correctPin = "1234"; // Example PIN
        double balance = 1000.00; // Initial balance
        string pin;

        Console.Write("Enter your PIN: ");
        pin = Console.ReadLine();

        if (pin != correctPin)
        {
            Console.WriteLine("Incorrect PIN. Access denied.");
            return;
        }

        bool quit = false;

        while (!quit)
        {
            Console.WriteLine("\nMenu:");
            Console.WriteLine("1. Display Balance");
            Console.WriteLine("2. Cash Deposit");
            Console.WriteLine("3. Cash Withdrawal");
            Console.WriteLine("4. Quit");
            Console.Write("Select an option: ");

            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.WriteLine($"Your current balance is: ${balance}");
                    break;

                case 2:
                    Console.Write("Enter the amount to deposit: ");
                    double deposit = double.Parse(Console.ReadLine());
                    if (deposit > 0)
                    {
                        balance += deposit;
                        Console.WriteLine($"Successfully deposited ${deposit}. New balance is: ${balance}");
                    }
                    else
                    {
                        Console.WriteLine("Invalid amount. Deposit must be greater than 0.");
                    }
                    break;

                case 3:
                    Console.Write("Enter the amount to withdraw: ");
                    double withdrawal = double.Parse(Console.ReadLine());
                    if (withdrawal > 0 && withdrawal <= balance)
                    {
                        balance -= withdrawal;
                        Console.WriteLine($"Successfully withdrew ${withdrawal}. New balance is: ${balance}");
                    }
                    else
                    {
                        Console.WriteLine("Invalid amount. Withdrawal must be greater than 0 and less than or equal to the current balance.");
                    }
                    break;

                case 4:
                    quit = true;
                    Console.WriteLine("Thank you for using our service. Goodbye!");
                    break;

                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    break;
            }
        }
    }
}
Item[] allItems = {
    new Item(1, "ShevBhaji", 50),
    new Item(2, "PavBhaji", 60),
    new Item(3, "MisalPav", 40),
    new Item(4, "VadaPav", 20),
    new Item(5, "Poha", 30)
};
Console.WriteLine("Welcome to the restaurant");
Bill bill = new Bill();
while (true)
{
    Console.WriteLine("1. Add Item to Bill");
    Console.WriteLine("2. Print Bill");
    Console.WriteLine("3. Exit");
    Console.WriteLine("Enter your choice");
    int choice = int.Parse(Console.ReadLine());
    if (choice == 1)
    {
        Console.WriteLine("Enter the item id");
        int id = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the quantity");
        int quantity = int.Parse(Console.ReadLine());
        Item item = null;
        foreach (Item i in allItems)
        {
            if (i.Id == id)
            {
                item = i;
                break;
            }
        }
        if (item == null)
        {
            Console.WriteLine("Invalid Item Id");
        }
        else
        {
            bill.AddItem(item, quantity);
            Console.WriteLine("Item added to the bill");
        }
    }
    else if (choice == 2)
    {
        bill.PrintBill();
    }
    else if (choice == 3)
    {
        break;
    }
    else
    {
        Console.WriteLine("Invalid Choice");
    }
}
