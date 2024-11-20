using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoStructureA03
{
    internal class Program
    {
        // Globals, Enums, Structures
        private struct Student
        {
            public int iStudentID;
            public string sFirstName;
            public string sLastName;

            // Constructor
            public Student(int istudentid, string sfirstname, string slastname)
            {
                iStudentID = istudentid;
                sFirstName = sfirstname;
                sLastName = slastname;
            }

            public override string ToString()
            {
                return "Student Id " + iStudentID + ": " + sFirstName + " " + sLastName;
            }
        }

        static void Main(string[] args)
        {
            Student LowID = new Student();
            Student HighID = new Student();

            /*
            Student[] StudArray = new Student[5] {new Student(43, "Joe", "Smith"),
                                                  new Student(34, "Sam", "Spade"),
                                                  new Student(87, "Gary", "Gold"),
                                                  new Student(8, "Chuck", "James"),
                                                  new Student(97, "Harry", "Knuckles")};
            */

            int[] iIdArray = { 43, 34, 87, 8, 97 };
            string[] sFirstName = { "Joe", "Sam", "Gary", "Chuck", "Harry" };
            string[] sLastName = { "Smith", "Spade", "Gold", "James", "Knuckles" };
            Student[] StudArray = new Student[iIdArray.Length];
            for (int i = 0; i < iIdArray.Length; i++)
            {
                StudArray[i] = new Student(iIdArray[i], sFirstName[i], sLastName[i]);
            }

            Console.WriteLine(StudArray[1].iStudentID);
            StudArray[1].iStudentID = 12;                      // change individual member value
            Console.WriteLine(StudArray[1].iStudentID);         // dusplay individual member

            Console.WriteLine(StudArray[1].ToString());         // entire Struct
            HighID = MaxID(StudArray);                          // passing and receiving structs
            Console.WriteLine(HighID.ToString());
            LowID = MinID(StudArray);
            Console.WriteLine(LowID.ToString());

            Console.WriteLine("Press any key");
            Console.ReadKey();
        }

        // methods
        static Student MaxID(Student[] sArray)
        {
            Student stud = new Student();
            int max = -1;

            for(int i = 0; i < sArray.Length; i++)
            {
                if (sArray[i].iStudentID > max)
                {
                    max = sArray[i].iStudentID;
                    stud = sArray[i];
                }

            }
            return stud;
        }

        static Student MinID(Student[] sArray)
        {
            Student stud = new Student();
            int min = 9999;

            for (int i = 0; i < sArray.Length; i++)
            {
                if (sArray[i].iStudentID < min)
                {
                    min = sArray[i].iStudentID;
                    stud = sArray[i];
                }

            }
            return stud;
        }

    }
}
