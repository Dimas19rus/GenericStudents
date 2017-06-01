using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public interface IStudent:IMarks // Студент (школота с стипендией)
    {
        void Prize(List<IStudent> students, int awart);
    }
}