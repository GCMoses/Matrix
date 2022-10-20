namespace Matrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Matrix text
            Console.ForegroundColor = ConsoleColor.Green;
            Random rand = new Random();

           
            String matrix = "";

            Console.Write("Welcome to the Matrix...");
            Console.ReadKey();

            for (int i = 0; i < 2000000; i++)
            {
                if (i % 2 == 0)
                {
                    matrix = "";
                    for (int j = 0; j < 1288; j++)
                    {
                        int n = rand.Next(5);
                        if (n < 2)
                        {
                            matrix += n.ToString();
                        }
                        else
                        {
                            matrix += " ";
                        }
                    }
                }
                //create pattern
                Console.WriteLine(matrix);
            }
            Console.WriteLine("End of screen...");
            Console.Write("Press any key to exit...");
            Console.ReadKey();
        }
    }
}