namespace ДР_7_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Notebook notebook = new Notebook();
            notebook.Show();

            Console.WriteLine();

            Notebook notebook1 = new Notebook("Nitro 5", "Acer", 38999.99);
            notebook1.Show();

            Console.ReadKey();
        }
    }
}