using System;
using System.Collections.Generic;

namespace MyLocalNameSpace
{
    // Base class
    public class Student
    {
        public int Id { get; set; }
    }

    // UG student class
    public class UGStudent : Student
    {
        public int HighSchoolMark { get; set; }
    }

    // PG student class
    public class PGStudent : UGStudent
    {
        public int UGMark { get; set; }
    }
}

class GenericConstraintDemo
{
    // Generic class with constraint:
    // T must be Student or derived from Student
    public class MyGlobalType<T> where T : MyLocalNameSpace.Student
    {
        // List to store items of type T
        public List<T> MyCollection { get; set; } = new List<T>();

        // Add item into list
        public void AddItem(T t)
        {
            MyCollection.Add(t);
        }

        // Show type of object
        public string GetDataType(T t)
        {
            return t.GetType().ToString();
        }

        // Return collection
        public List<T> GetCollection()
        {
            return MyCollection;
        }

        // Check actual object type using "is"
        public string ActBasedOnType(T t)
        {
            if (t is MyLocalNameSpace.PGStudent)
                return "Type is PGStudent";

            if (t is MyLocalNameSpace.UGStudent)
                return "Type is UGStudent";

            return "Type is Student";
        }
    }

    public static void Main(string[] args)
    {
        // Create object of generic class for UGStudent
        MyGlobalType<MyLocalNameSpace.UGStudent> ugData = new MyGlobalType<MyLocalNameSpace.UGStudent>();

        // Create UGStudent object
        MyLocalNameSpace.UGStudent ugStudent = new MyLocalNameSpace.UGStudent()
        {
            Id = 101,
            HighSchoolMark = 92
        };

        // Add UG student to list
        ugData.AddItem(ugStudent);

        Console.WriteLine("✅ Data Type: " + ugData.GetDataType(ugStudent));
        Console.WriteLine("✅ Category: " + ugData.ActBasedOnType(ugStudent));

        Console.WriteLine("\n--------------------------------\n");

        // Create object of generic class for PGStudent
        MyGlobalType<MyLocalNameSpace.PGStudent> pgData = new MyGlobalType<MyLocalNameSpace.PGStudent>();

        // Create PGStudent object
        MyLocalNameSpace.PGStudent pgStudent = new MyLocalNameSpace.PGStudent()
        {
            Id = 201,
            HighSchoolMark = 90,
            UGMark = 85
        };

        // Add PG student to list
        pgData.AddItem(pgStudent);

        Console.WriteLine("✅ Data Type: " + pgData.GetDataType(pgStudent));
        Console.WriteLine("✅ Category: " + pgData.ActBasedOnType(pgStudent));

        Console.WriteLine("\n✅ Program Completed Successfully!");
    }
}
