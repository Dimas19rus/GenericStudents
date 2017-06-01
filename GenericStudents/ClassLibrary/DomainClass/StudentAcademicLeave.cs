using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class StudentAcademicLeave:IDisciple
    {
        public Dictionary<DateTime, int> Marks { get; set; }
    }
}