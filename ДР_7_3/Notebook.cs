using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace ДР_7_3
{
    public struct Notebook
    {
        string model;
        string madeBy;
        double cost;

        public Notebook(string model, string madeBy, double cost)
        {
            this.model = model;
            this.madeBy = madeBy;
            this.cost = cost;
        }
        public Notebook()
            : this("Nitro 4", "AceR", 45000.00)
        {
        }

        public string Model { get { return model; } private set { model = value; } }
        public string MadeBy { get { return madeBy; } set { madeBy = value; } }
        public double Cost { get { return cost; } private set { cost = value; } }

        public void Show()
        {
            Console.WriteLine($"Model: {Model}\nMade by: {MadeBy}\nCost: {Cost}");
        }
    }
}
