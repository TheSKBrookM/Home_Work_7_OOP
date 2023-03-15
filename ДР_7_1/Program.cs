

namespace ДР_7_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var train = new Train[5];

            ClassTrain.AddInArray(train);

            Console.WriteLine();

            ClassTrain.Sort(train);

            ClassTrain.Show(train);

            Console.WriteLine();

            Console.Write("Train number: ");
            int number = Int32.Parse(Console.ReadLine());

            Console.WriteLine();

            ClassTrain.Find(train, number);

            Console.ReadKey();
        }
    }
}