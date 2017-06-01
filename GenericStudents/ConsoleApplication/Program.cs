using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary;

namespace ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Deanery<IDisciple> deanery = new Deanery<IDisciple>();

            Bachelor b1 = new Bachelor { Marks = new Dictionary<DateTime, int> { { new DateTime(2017, 04, 02), 5 }, { new DateTime(2017, 02, 05), 3 }, { new DateTime(2017, 04, 01), 5 }, { new DateTime(2017, 03, 27), 4 } } };
            Bachelor b2 = new Bachelor { Marks = new Dictionary<DateTime, int> { { new DateTime(2017, 04, 02), 4 }, { new DateTime(2017, 03, 05), 5 }, { new DateTime(2017, 04, 01), 3 }, { new DateTime(2017, 03, 27), 3 } } };
            Graduate g1 = new Graduate { Marks = new Dictionary<DateTime, int> { { new DateTime(2017, 04, 02), 5 }, { new DateTime(2017, 03, 11), 3 }, { new DateTime(2017, 04, 01), 5 }, { new DateTime(2017, 03, 27), 4 } } };
            Graduate g2 = new Graduate { Marks = new Dictionary<DateTime, int> { { new DateTime(2017, 04, 02), 4 }, { new DateTime(2017, 02, 05), 5 }, { new DateTime(2017, 04, 01), 5 }, { new DateTime(2017, 03, 27), 4 } } };
            Master m1 = new Master { Marks = new Dictionary<DateTime, int> { { new DateTime(2017, 04, 02), 5 }, { new DateTime(2017, 02, 05), 3 }, { new DateTime(2017, 04, 01), 5 }, { new DateTime(2017, 03, 27), 4 } } };
            Master m2 = new Master { Marks = new Dictionary<DateTime, int> { { new DateTime(2017, 04, 02), 5 }, { new DateTime(2017, 04, 05), 5 }, { new DateTime(2017, 04, 01), 5 }, { new DateTime(2017, 03, 27), 4 } } };
            StudentAcademicLeave s1 = new StudentAcademicLeave { Marks = new Dictionary<DateTime, int> { { new DateTime(2017, 04, 02), 5 }, { new DateTime(2017, 02, 05), 3 }, { new DateTime(2017, 04, 01), 5 }, { new DateTime(2017, 03, 27), 4 } } };

            
            deanery.Registration(b1);
            deanery.Registration(b2);
            deanery.Registration(g1);
            deanery.Registration(g2);
            deanery.Registration(m1);
            deanery.Registration(m2);
            deanery.Registration(s1);

            deanery.CheckingForTheAward(new DateTime(2017,04,16),5000);
            Console.ReadKey();

        }
    }
}
