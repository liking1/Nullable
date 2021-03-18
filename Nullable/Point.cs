using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nullable
{
    public class Point_
    {
        private double? point;
        private DateTime datePoint = new DateTime();

        public double? Point
        {
            get => point;
            set
            {
                if (value == null)
                {
                    this.point = 0;
                    return;
                }
                this.point = value;
            }
        }

        public DateTime DatePoint
        {
            get => datePoint;
            set
            {
                if (value == null)
                {
                    datePoint = new DateTime();
                    return;
                }
                this.datePoint = value;
            }
        }
        public Point_(DateTime datePoint, double? point = null)
        {
            DatePoint = datePoint;
            Point = point;
        }
        public override string ToString()
        {
            return $"Date point:{datePoint}\n Point: {point}";
        }
    }
}
