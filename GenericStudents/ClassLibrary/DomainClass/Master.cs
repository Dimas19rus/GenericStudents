using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class Master:IStudent
    {
        public Dictionary<DateTime, int> Marks { get; set; }
        public void Prize(List<IStudent> students, int awart)
        {
            if (students.Contains(this))
                Console.WriteLine("Я магистр, я магистр");
        }
    }
}