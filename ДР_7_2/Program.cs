namespace ДР_7_2
{
    internal class Program
    {
        
        static void StruktTaker(MyStruct myStruct)
        {
            myStruct.change = "changed";
        }
        static void ClassTaker(MyClass myClass)
        {
            myClass.change = "changed";
        }
        static void Main(string[] args)
        {
            MyClass myClass = new MyClass();
            MyStruct myStruct = new MyStruct();

            Console.WriteLine("1 Class: " + myClass.change);
            Console.WriteLine("1 Struct: " + myStruct.change);
            Console.WriteLine();

            ClassTaker(myClass);
            StruktTaker(myStruct);

            Console.WriteLine("2 Class: " + myClass.change);
            Console.WriteLine("2 Struct: " + myStruct.change);
            Console.WriteLine();

            myClass.change = "not changed";
            myStruct.change = "not changed";

            Console.WriteLine("3 Class: " + myClass.change);
            Console.WriteLine("3 Struct: " + myStruct.change);
            Console.WriteLine();

            ClassTaker(myClass);
            StruktTaker(myStruct);

            Console.WriteLine("4 Class: " + myClass.change);
            Console.WriteLine("4 Struct: " + myStruct.change);
            Console.WriteLine();

            Console.ReadLine();
        }
    }
}