using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object
{
    class Vector
    {
        private int x;
        private int y;

        public int X
        {
            get => x;
            set
            {
                x = value;
            }
        }
        public int Y
        {
            get => y;
            set
            {
                y = value;
            }
        }
        
        
        public static Vector operator +(Vector one, Vector two)
        {
            Vector result = new Vector();
            result.X = one.X + two.X;
            result.Y = one.Y + two.Y;
            return result;
        }
        public static Vector operator +(Vector one, double two)
        {
            Vector result = new Vector();
            result.X = (int)(one.X * two);
            result.Y = (int)(one.Y + two);
            return result;
        }
        public static Vector operator -(Vector one, Vector two)
        {
            Vector result = new Vector();
            result.X = one.X - two.X;
            result.Y = one.Y - two.Y;
            return result;
        }

        //public static double operator *(Vector one, int num)
        //{
        //    Vector result = new Vector();
        //    result.X *= num;
        //    result.Y *= num;
        //    return result;
        //}
        public static double operator *(Vector one, Vector two)
        {
            return one.X * two.X + two.Y * one.Y;
        }
        
        public static bool operator !=(Vector one, Vector two)
        {
            return !(one == two);
        }
        public static bool operator ==(Vector one, Vector two)
        {
            if (one == two)
                return false;
            else
                return true;
        }
        public override bool Equals(object obj)
        {
            Vector vector = obj as Vector;
            if (vector != null)
                return false;
            return vector.Equals(vector);
        }
        
        public override int GetHashCode()
        {
            return base.GetHashCode();
            //return ((decimal)(this.x / this.y)).ToString().GetHashCode();
        }
        //public static implicit operator double(Vector one)// implicit = неявно, explicit = явно
        //{
        //    return (double)one.x / one.y;
        //}
        public static implicit operator Vector(double num)
        {
            return new Vector((int)num, 0);
        }

        public static Vector operator ++(Vector vector)
        {
            return new Vector { x = vector.x + 1, y = vector.y + 1 };
        }
        public static Vector operator --(Vector vector)
        {
            return new Vector { x = vector.x - 1, y = vector.y - 1 };
        }
        public static bool operator true(Vector one)
        {
            if (one.x == 0 && one.y == 0)
            {
                return false;
            }
            return true;
        }
        public static bool operator false(Vector one)
        {
            if (one.x == 0 && one.y == 0)
            {
                return true;
            }
            return false;
        }
        public Vector(int x = 1, int y = 1)
        {
            this.X = x;
            this.Y = y;
        }
        public int GetLength()
        {
            return (int)Math.Sqrt(x * x + y * y);// властивість обчислення довжини вектору
        }
        public override string ToString()
        {
            return $"X : {X}\nY : {Y}";
        }
    }
}
