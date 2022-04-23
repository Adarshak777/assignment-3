using System;using System.Collections.Generic;using System.Linq;using System.Text;using System.Threading.Tasks;namespace assgn3{
    internal class Program
    {
        static void Main(string[] args)
        {
            // student marks program
            school student = new school(1998, "adarsh", "Btech", "5thsem", "civil");            student.displaydata();            student.displayresult();

            // car program

            Car car = new Car(0179, "FERRARI", "SUZUKI");
            car.displaycardetails();
            Car car2 = new Car(500000);

            // Loan amount calculator

            bank ia = new bank();            ia.loanCalculator(200000);            Console.ReadLine();        }
    }
}	