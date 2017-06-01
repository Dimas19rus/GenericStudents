using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class Bachelor:IStudent
    {
        public Dictionary<DateTime, int> Marks { get; set; }
        public void Prize(List<IStudent> students, int awart)
        {
            if(students.Contains(this))
                Console.WriteLine("Я бакалавр, я голодный");
        }
    }
}