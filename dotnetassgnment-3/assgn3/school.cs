using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assgn3
{
    internal class school
    {
        int rollno;
        
        string name, stdclass, semister, branch;
        double average;

        

        public void displayresult()
        {
            int[] marks = new int[5];
            marks[0] = 60;
            marks[1] = 90;
            marks[2] = 58;
            marks[3] = 44;
            marks[4] = 75;

            for (int i = 0; i < marks.Length; i++)
            {
                Console.WriteLine(marks[i]);
            }

            double average = marks.Average();
            Console.WriteLine("The average of all subjects : " + average);

            for (int i = 0; i < marks.Length; i++)
            {

                if (marks[i] < 35)
                {
                    Console.WriteLine(marks[i] + " subject is failed");
                }
                else if (marks[i] > 35 && average < 50)
                {
                    Console.WriteLine("student is failed");
                }
                else if (average > 50)
                {
                    Console.WriteLine("student is passed ");
                }
               
            }

        }

        public school(int rollno, String name, string stdclass, string semister, string branch)
        {
            this.rollno = rollno;
            this.name = name;
            this.stdclass = stdclass;
            this.semister = semister;
            this.branch = branch;
            Console.WriteLine($" rollno is:-  {rollno}  , name is:-  {name}  ,student class is:-  {stdclass}  ,semister is :- {semister}  ,branch is:-  {branch} ");

        }
        public void displaydata()
        {
            Console.WriteLine("the result is");

        }
        
      

    }
}

