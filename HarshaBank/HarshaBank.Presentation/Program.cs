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
                System.Console.WriteLine("\n:::Main Menu Here:::");
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
                    case 1: //TODO: DISPLAY CUSTOMERS MENU
                        break;
                    case 2: //TODO: DISPLAY ACCOUNTS MENU
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
}

