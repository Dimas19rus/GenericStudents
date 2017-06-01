using System;
using System.Collections.Generic;
using System.Linq;

namespace ClassLibrary
{
    public delegate void Del(List<IStudent> students,int award);

    public class Deanery<T1> where T1 : IMarks
{

    private readonly List<IMarks> _students = new List<IMarks>();

    public void Registration(IMarks obj)
    {
        _students.Add(obj);
        if (obj is IStudent)
            Awart += ((IStudent) obj).Prize;
    }

    public void CheckingForTheAward(DateTime date, int awart)
    {
        List<IStudent> students =
            (from student in _students
                let y =
                    student.Marks.Where(x => Math.Abs((date - x.Key).Days) <= 31)
                        .ToDictionary(p => p.Key, p => p.Value)
                        .Values.ToList()
                where (y.Count != 0 ? y.Average() : 0) >= 4.5 && student is IStudent
                select (IStudent) student).ToList();
        AwartInvoke(students, awart);
    }

    public void AwartInvoke(List<IStudent> students, int awart)
    {
        Awart?.Invoke(students, awart);
    }

    private event Del Awart;
}


}





            //List<IStudent> students = new List<IStudent>();

            //foreach (T student in _students)
            //{

            //    List<int> y = student.Marks.Where(x => Math.Abs((date - x.Key).Days) <= 31).ToDictionary(p => p.Key, p => p.Value).Values.ToList();
            //    if ((y.Count != 0 ? y.Average() : 0) >= 4.5 && student is IStudent)
            //    {
            //        students.Add((IStudent)student);
            //    }

            //}