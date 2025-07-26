class Program

{







    static void sum()

    {

        int num1, num2;



        Console.WriteLine("enter two numbers");

        num1 = int.Parse(Console.ReadLine());

        num2 = int.Parse(Console.ReadLine());

        Console.WriteLine($"the sum is  {num1 + num2}");





    }



    static void mult()

    {

        int num1, num2;



        Console.WriteLine("enter two numbers");

        num1 = int.Parse(Console.ReadLine());

        num2 = int.Parse(Console.ReadLine());

        Console.WriteLine($"the mult is  {num1 * num2}");

    }





    static void sub()

    {

        int num1, num2;



        Console.WriteLine("enter two numbers");

        num1 = int.Parse(Console.ReadLine());

        num2 = int.Parse(Console.ReadLine());

        Console.WriteLine($"the sub is  {num1 - num2}");





    }



    static void div()

    {

        int num1, num2;



        Console.WriteLine("enter two numbers");

        num1 = int.Parse(Console.ReadLine());

        num2 = int.Parse(Console.ReadLine());

        Console.WriteLine($"the div is  {num1 / num2}");





    }



















    static void Main(string[] args)

    {



        Console.WriteLine("Please choose a letter ");



        Console.WriteLine("a. add");

        Console.WriteLine("b.sub ");

        Console.WriteLine("c. mult");

        Console.WriteLine("d. div");

        Console.WriteLine("e. exit");

        string letter = Console.ReadLine();



        while (letter != "e" || letter != "E")

        {

            if (letter == "e" || letter == "E")

                return;

            switch (letter)

            {



                case "a":

                case "A":

                    sum();

                    break;

                case "b":

                case "B":

                    sub();

                    break;



                case "c":

                case "C":

                    mult();

                    break;

                case "d":

                case "D":

                    div();

                    break;



                default:

                    Console.WriteLine("not valid choice");

                    break;

            }

            Console.WriteLine("a. add");

            Console.WriteLine("b.sub ");

            Console.WriteLine("c. mult");

            Console.WriteLine("d. div");

            Console.WriteLine("e. exit");

            letter = Console.ReadLine();







        }





    }

}