using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nullable
{
    public class Student
    {
        private string name;
        private List<Point_> points = new List<Point_>();
        public string Name
        {
            get => name;
            set
            {
                if (String.IsNullOrWhiteSpace(value))
                {
                    Console.WriteLine("Bad Name");
                    return;
                }
                this.name = value;
            }
        }
        public List<Point_> Points
        {
            get => points;
            set
            {
                this.points = value;
            }
        }
        public Student(List<Point_> points = null, string name = "NoName")
        {
            Points = points;
            Name = name;
        }
        //public override string ToString()
        //{
        //    return $"Name of student {name}";
        //}
        public void Print()
        {
            foreach (var item in points)
            {
                Console.WriteLine(item);
            }
        }
        public void AddPoint(Point_ addPoint)
        {
            points.Add(addPoint);
        }
        public void CancelPoint(int deletePoint)
        {
            if (0 >= deletePoint || deletePoint > points.Count)
            {
                Console.WriteLine("Incorrect mark number");
                return;
            }
            this.points[deletePoint - 1].Point = null;
        }
        //public void ChangePointsByDate(DateTime dateTime, Point_ point1)
        //{
        //    if (points.Count == 0 || dateTime == null || point1 == null)
        //    {
        //        return;
        //    }
        //    points[points.FindIndex(0, e => point1 == e)] = point1;
        //}
        public uint GetAverageMark()
        {
            if (!points.Any())
            {
                Console.WriteLine("No points");
            }
            uint sum = 0;
            foreach (var item in points)
            {
                if (item != null)
                {
                    sum += (uint)item.Point;
                }
            }
            return (uint)(sum / points.Count);
        }
        public override string ToString()
        {
            return $"Student name: {name}, with marks \n{String.Join("\n", points)}";
        }
        
    }
}
