using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assgn3
{
    internal class Car
    {
        int carno;
        string carName, carType;
        readonly double carcost = 500000;
        

        public Car(int carno, string carName, string carcompany)
        {
            this.carno = carno;
            this.carName = carName;
            this.carType = carcompany;


            //this.carcost = carcost;

            Console.WriteLine($" carno is:-  {carno}, car namee is:-  {carName}, car Type is:-  {carcompany}, car cost is:-  {carcost}");
        }

        public Car(double cost)
        {
            carcost = cost;
            Console.WriteLine("After changing");
            Console.WriteLine($" carno is : {carno}, car name is {carName}, car Type is {carType}, car cost is {carcost}");
        }
        public void displaycardetails()
        {
            Console.WriteLine("Before changing");
            Console.WriteLine($" carno is : {carno}, car namee is {carName}, car Type is {carType}, car cost is {carcost}");

        }
    }
}
