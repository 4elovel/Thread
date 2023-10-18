internal class Program
{
    private static void Main(string[] args)
    {
        static void ToDo()
        {
            List<string> list = new List<string> { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "a", "b", "c", "d", "e", "f" };
            foreach (string s in list)
            {
                Console.Write($"{s} ");
            }
        }
        Thread thread = new Thread(ToDo);
        thread.Start();
    }
}