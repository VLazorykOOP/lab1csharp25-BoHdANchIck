static void Task1()
{
    Console.WriteLine("#Task_1\nPlease enter a and b");
    string _a = Console.ReadLine();
    string _b = Console.ReadLine();
    double a, b;

    if (double.TryParse(_a, out a) && double.TryParse(_b, out b))
    { 
        a = double.Parse(_a);
        b = double.Parse(_b);

        Console.WriteLine($"Square of triangle = {(a*b)/2}");
    }
    else
    {
        Console.WriteLine("Invalid input");
    }
    Console.ReadKey();
    ChooseTask();
}
static void Task2()
{
    Console.Write("#Task_2\nPlease enter two-digit number:");
    string _num = Console.ReadLine();
    double num;

    if (double.TryParse(_num, out num) && num > 0 && num < 100)
    {
        num = double.Parse(_num);
        int first = (int)num / 10;
        int second = (int)num - first * 10;

        int result = first.CompareTo(second);
        if (result > 0)
            Console.WriteLine($"{first} > {second}");
        else if (result < 0)
            Console.WriteLine($"{first} < {second}");
        else
            Console.WriteLine($"{first} = {second}");
    }
    else
    {
        Console.WriteLine("Invalid input");
    }
    Console.ReadKey();
    ChooseTask();
}
static void Task3()
{
    try 
    {
        Console.WriteLine("Task_3");
        Console.Write("Enter x: ");
        double x = double.Parse(Console.ReadLine());

        Console.Write("Enter y: ");
        double y = double.Parse(Console.ReadLine());

        bool inCircle = (x * x + y * y) <= 225;

        bool aboveLines = y >= Math.Abs(x);

        if (inCircle && aboveLines)
        {
            Console.WriteLine("Good");
        }
        else
        {
            Console.WriteLine("Not good");
        }
    }
    catch (Exception ex) 
    {
        Console.WriteLine("Problem: " + ex.Message.ToString());
    }
    Console.ReadKey();
    ChooseTask();
}   
static void Task4()
{
    try 
    {
        Console.WriteLine("Task_4");
        Console.Write("Enter m: ");
        int m = int.Parse(Console.ReadLine());

        if (m <= 0)
        {
            Console.WriteLine("Error: m must be greater than 0.");
            return;
        }

        string[] months = {
            "January", "February", "March", "April", "May", "June",
            "July", "August", "September", "October", "November", "December"
        };

        int monthIndex = (m - 1) % 12;
        Console.WriteLine($"Current month: {months[monthIndex]}");
    }
    catch (Exception ex) 
    { 
        Console.WriteLine("Problem: " + ex.Message.ToString()); 
    }
    Console.ReadKey();
    ChooseTask();
}
static void Task5()
{
    try 
    {
        Console.WriteLine("Task_5");
        Console.Write("Enter num1: ");
        double num1 = double.Parse(Console.ReadLine());

        Console.Write("Enter num2: ");
        double num2 = double.Parse(Console.ReadLine());

        double result = num1 * num2;
        Console.WriteLine($"Res: {result}");
    }
    catch (Exception ex) 
    { 
        Console.WriteLine("Problem: " + ex.Message.ToString());
    }
    Console.ReadKey();
    ChooseTask();
}
static void Task6()
{
    try
    {
        Console.WriteLine("Task_6");
        Console.WriteLine("Enter n and m");

        int n = int.Parse(Console.ReadLine());
        int m = int.Parse(Console.ReadLine());
        if ((n + m * m + 1) != 0)
        {
            int res = ((3 / (n + m * m + 1)) + 1) * (m - n);
            Console.WriteLine($"Result: {res}");
        }
        else
        {
            Console.WriteLine("Can't divide by zero!");
        }
       
    }
    catch (Exception ex)
    {
        Console.WriteLine("Problem: " + ex.Message.ToString());
    }
    Console.ReadKey();
    ChooseTask();
}
static void ChooseTask()
{
    Console.WriteLine("0 - Task_1");
    Console.WriteLine("1 - Task_2");
    Console.WriteLine("2 - Task_3");
    Console.WriteLine("3 - Task_4");
    Console.WriteLine("4 - Task_5");
    Console.WriteLine("5 - Task_6\n");
    string _task = Console.ReadLine();
    int task;

    if (int.TryParse(_task, out task) && task >= 0 && task <= 5)
    {
        task = int.Parse(_task);
        switch (task)
        {
            case 0:
                Task1();
                break;
            case 1:
                Task2();
                break;
            case 2:
                Task3();
                break;
            case 3:
                Task4();
                break;
            case 4:
                Task5();
                break;
            case 5:
                Task6();
                break;
            default:
                Console.WriteLine("Invalid input");
                break;
        }
    }
    else
    {
        Console.WriteLine("Invalid input");
    }
    
}


ChooseTask();
Console.ReadKey();