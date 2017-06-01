using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public interface IMarks
    {
        Dictionary<DateTime, int> Marks { get; set; }
    }
}