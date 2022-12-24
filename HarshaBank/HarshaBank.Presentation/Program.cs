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

        if(userName != "")
        {
            //read password from keyboard only if userName is entered
            System.Console.WriteLine("Password:");
            password = System.Console.ReadLine();
        }

        //chech userName and password
        if(userName == "system" && password == "manager")
        {
            System.Console.WriteLine("TODO: Main Menu Here");
        }

        //about to exit
        System.Console.WriteLine("Thank You. Visit Again!");
        System.Console.ReadKey();

    }
}

