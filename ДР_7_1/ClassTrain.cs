using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ДР_7_1
{
    public static class ClassTrain
    {
        public static void AddInArray(Train[] train)
        {
            for (int i = 0; i < train.Length; i++)
            {
                Console.Write("Name of destination station: ");
                string destinationName = Console.ReadLine();

                if (destinationName == null && destinationName == "")
                {
                    Console.WriteLine("You did not write station name!");
                }

                Console.Write("Write train number: ");
                string number = Console.ReadLine();
                int trainNumber = 000000;

                if (number == null && number == "")
                {
                    Console.WriteLine("You did not write train number!");
                }
                else
                {
                    trainNumber = Int32.Parse(number);
                }

                Console.Write("Write time to go: ");
                string date = Console.ReadLine();
                DateTime time;

                if (date == null && date == "")
                {
                    time = DateTime.Now;
                }
                else
                {
                    time = DateTime.Parse(date);
                }

                Console.WriteLine();

                train[i] = new Train(destinationName, trainNumber, time);
            }
        }
        public static void Sort(Train[] trains)
        {
            for (int i = 0; i < trains.Length; i++)
            {
                for (int j = 0; j < trains.Length; j++)
                {
                    Train train1 = trains[i];
                    trains[i] = trains[j];
                    trains[j] = train1;
                }
            }
        }
        public static void Find(Train[] train, int trainNumber)
        {
            bool found = false;
            for (int i = 0; i < train.Length; i++)
            {     
                if (train[i].TrainNumber == trainNumber)
                {
                    Console.WriteLine($"\nTrain number: {train[i].TrainNumber}\nDestination: {train[i].DestinationName}\nDate and time: {train[i].StartTime}\n");
                    found = true;
                }
            }
            if (!found)
            {
                Console.WriteLine($"Train with number - {trainNumber} was not found!");
            }
        }
        public static void Show(Train[] train)
        {
            for (int i = 0; i < train.Length; i++)
            {
                Console.WriteLine($"\nTrain number: {train[i].TrainNumber}\nDestination name: {train[i].DestinationName}\nStart time: {train[i].StartTime}");
            }
        }
    }
}
