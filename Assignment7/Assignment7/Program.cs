class ForLoop
{
    static void Main()
    {
        int i = 1;
        while (i <= 10)
        {
            System.Console.Write(i + " ");
            i++;
        }
        System.Console.WriteLine();

        i = 1;
        do
            
        { 
            System.Console.Write(i + " ");
            i++;
        } while (i <= 10);

        System.Console.WriteLine();

        for (i = 1; i<= 10; i++)
        {
            System.Console.Write(i + " ");
        }
        System.Console.WriteLine();
        i = 10;
        while (i >= 1)
        {
            System.Console.Write(i + " ");
            i--;
        }
        System.Console.WriteLine();
        for (i = 10; i > 0; i--)
        {
            System.Console.Write(i + " ");
        }
        System.Console.WriteLine();
        for (i = 10; i > 0; i--)
        {
            System.Console.Write(i + " ");
            if (i==3) {
                break;
                    }
        }
        System.Console.WriteLine();

        System.Console.ReadKey();
    }
   
}

