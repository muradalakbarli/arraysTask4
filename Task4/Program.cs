class Task
{
    static void Main()

    {
        Task1();
        Task2();
        Task3();
        Task4();

    }

    static void Task1()
    {
        int a = 3;
        int b = 6;

        if ((a + b) % 2 == 0)
        {
            Console.WriteLine("Cem cut ededdir");
        }

        else
        {
            Console.WriteLine("Cem tek ededdir");
        }
    }


    static void Task2()
    {
        int[] ededler = { 13, 90, 45, 33, 87, 22, 10, 78, 65, 99 };

        for (int i = 0; i < ededler.Length; i++)
        {
            if (ededler[i] % 2 == 0)
            {
                Console.WriteLine("Cut eded" + " " + ededler[i] + " ");
            }

        }

    }


    static void Task3()
    {
        int[] ededler = { 13, 90, 45, 33, 87, 22, 10, 78, 65, 99 };

        for (int i = 0; i < ededler.Length; i++)
        {
            if (ededler[i] % 2 == 1)
            {
                Console.WriteLine("Tek eded" + " " + ededler[i] + " ");
            }

        }

    }

    static void Task4()
    {
        int a = 1482;
        string aString = a.ToString();

        if (aString.Length == 4)
        {
            int cem = 0;
            foreach (char digitChar in aString)
            {
                int digit = digitChar - '0';
                cem += digit;
            }

            Console.WriteLine($"Reqemlerin cemi: {cem}");
        }

        else
        {
            Console.WriteLine("Eded 4 reqemli deyil");
        }

    }

}




