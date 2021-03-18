using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nullable
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Point_> point = new List<Point_> { new Point_(new DateTime(2021, 3, 12), 5)};
            Point_ point_ = new Point_(new DateTime(2022, 4, 1), 4);
            Student student = new Student(point, "Eugene");
            //Console.WriteLine(student);
            student.AddPoint(point_);
            student.Print();
            Console.WriteLine();
            //student.ChangePointsByDate(new DateTime(2021, 3, 12), new Point_(new DateTime(2021, 3, 12), 1));
            student.CancelPoint(0);
            Console.WriteLine("After canceling point:");
            Console.WriteLine(student.ToString());
            Console.WriteLine();
            Console.WriteLine($"Average mark: {student.GetAverageMark()}");
            
        }
    }
}
