using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleAppQueue
{
    class Program
    {
        /**
         * Problem is
         * Keep some students (first name, last name) in a queue and show them using for each loop 
         *  
         * you need to keep objects of user defined type in a Queue 
         **/

        public class StudentClass
        {
            public string firstname;
            public string lastname;

            public string Fullname()
            {
               return firstname +" "+  lastname;
            }
        }

        
        static void Main(string[] args)
        {
            StudentClass astudent = new StudentClass();
            astudent.firstname = "Minhaz";
            astudent.lastname = "Ahmed";

            StudentClass bstudent = new StudentClass();

            bstudent.firstname = "Mamun";
            bstudent.lastname = "Molla";

            Queue<StudentClass> myQueue = new Queue<StudentClass>();

            myQueue.Enqueue(astudent);
            myQueue.Enqueue(bstudent);

            foreach (var item in myQueue)
            {
                Console.WriteLine("full name is " + item.Fullname());
            }
            Console.ReadKey();

            
        }
    }
}
