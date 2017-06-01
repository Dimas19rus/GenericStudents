using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class Graduate:IStudent
    {
        public Dictionary<DateTime, int> Marks { get; set; }
        public void Prize(List<IStudent> students, int awart)
        {
            if (students.Contains(this))
                Console.WriteLine("Я аспирант, я работаю в командоре");
        }
    }
}