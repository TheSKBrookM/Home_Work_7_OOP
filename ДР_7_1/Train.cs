using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ДР_7_1
{
    public struct Train
    {
        string destinationName;
        int trainNumber;
        DateTime startTime;

        public Train(string destinationName, int trainNumber, DateTime startTime)
        {
            this.destinationName = destinationName;
            this.trainNumber = trainNumber;
            this.startTime = startTime;
        }

        public int TrainNumber 
        {
            get { return trainNumber; }
        }
        public DateTime StartTime
        {
            get { return startTime; }
        }
        public string DestinationName
        {
            get { return destinationName; }
        }
    }
}
