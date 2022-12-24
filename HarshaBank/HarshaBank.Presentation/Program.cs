class Program
{
    static void Main()
    {
        //display title
        System.Console.WriteLine("************Harsha Bank************");
        System.Console.WriteLine("::Login Page::");

        //declare variables to store username and password
        String userName = null, password = null;

        //read userName from keyboard
        System.Console.WriteLine("Username:");
        userName = System.Console.ReadLine();

        if (userName != "")
        {
            //read password from keyboard only if userName is entered
            System.Console.WriteLine("Password:");
            password = System.Console.ReadLine();
        }

        //check userName and password
        if (userName == "system" && password == "manager")
        {
            // declare variable to store menu choice
            int mainMenuChoice = -1;
            do
            {
                

                //Show main menu
                System.Console.WriteLine("\n:::Main Menu:::");
                System.Console.WriteLine("1. Customers");
                System.Console.WriteLine("2. Accounts");
                System.Console.WriteLine("3. Funds Transfer");
                System.Console.WriteLine("4. Funds Transfer Statement");
                System.Console.WriteLine("5. Account Statement");
                System.Console.WriteLine("0. Exit");

                System.Console.Write("Enter Choice: ");
                mainMenuChoice = int.Parse(System.Console.ReadLine());

                switch (mainMenuChoice)
                {
                    case 1: CustomersMenu();
                        break;
                    case 2: AccountsMenu();
                        break;
                    case 3: //TODO: DISPLAY FUNDS TRANSFER MENU
                        break;
                    case 4: //TODO: DISPLAY FUNDS TRANSFER STATEMENT MENU
                        break;
                    case 5: //TODO: DISPLAY ACCOUNT STATEMENT MENU
                        break;

                }
            } while (mainMenuChoice != 0);

        }
        else {
            System.Console.WriteLine("Invalid username or password");
        }

        //about to exit
        System.Console.WriteLine("Thank You. Visit Again!");
        System.Console.ReadKey();

    }
    static void CustomersMenu()
    {
        //variable to store CustomersMenuChoice
        int customerMenuChoice = -1;
        do
        {
            System.Console.WriteLine("\n:::Customers Menu:::");
            System.Console.WriteLine("1. Add Customer");
            System.Console.WriteLine("2. Delete Customer");
            System.Console.WriteLine("3. Update Customer");
            System.Console.WriteLine("4. View Customers");
            System.Console.WriteLine("0. Back to Main Menu");

            switch (customerMenuChoice)
            {
                case 1://TODO: Add Customer
                   break;
                case 2: //TODO: Delete Customer
                    break;
                case 3: //TODO: Update Customer
                    break;
                case 4: //TODO: View Customers
                    break;

            }

            System.Console.Write("Enter Choice: ");
            customerMenuChoice = int.Parse(System.Console.ReadLine());
        } while (customerMenuChoice != 0);
            }
    static void AccountsMenu()
    {
        //variable to store AccountsMenuChoice
        int accountsMenuChoice = -1;
        do
        {
            System.Console.WriteLine("\n:::Accounts Menu:::");
            System.Console.WriteLine("1. Add Account");
            System.Console.WriteLine("2. Delete Account");
            System.Console.WriteLine("3. Update Account");
            System.Console.WriteLine("4. View Accounts");
            System.Console.WriteLine("0. Back to Main Menu");

            switch (accountsMenuChoice)
            {
                case 1://TODO: Add Account
                    break;
                case 2: //TODO: Delete Account
                    break;
                case 3: //TODO: Update Account
                    break;
                case 4: //TODO: View Accounts
                    break;

            }

            System.Console.Write("Enter Choice: ");
            accountsMenuChoice = int.Parse(System.Console.ReadLine());
        } while (accountsMenuChoice != 0);
    }
}

