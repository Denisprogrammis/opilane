﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangle
{
    class Triangle
    {
        public double a;
        public double b;
        public double c;
        public double h;
        public string Answer;

        public Triangle(double A, double B, double C)
        {
            a = A;
            b = B;
            c = C;
        }

        public Triangle()
        {
     
        }

        public Triangle(double A, double H)
        {
            a = A;
            h = H;
        }

        public string outputA()
        {
            return Convert.ToString(a);
        }

        public string outputB()
        {
            return Convert.ToString(b);
        }

        public string outputC()
        {
            return Convert.ToString(c);
        }

        public string outputH()
        {
            return Convert.ToString(h);
        }
        public string TriangleType()
        {
            double l, k;
            l = c * c;
            k = (a * a) + (b * b);
            if (l == k)
            {
                Answer = "Прямоугольный";
                
            }
            if (l < k)
            {
                Answer = "Остроугольный";
            }
            if (l > k)
            {
                Answer = "Тупоугольный";
            }
            return Convert.ToString(Answer);
        }
        public double Hypotenuse()
        {
            double o;
            o = (a * a) + (b * b);
            c = Math.Sqrt(o);
            return c;
        }

        public double Perimeter()
        {
            double p = 0;
            p = a + b + c;
            return p;
        }

        public double Surface()
        {
            double s = 0;
            double p = 0;
            p = (a + b + c) / 2;
            s = Math.Sqrt((p * (p - a) * (p - b) * (p - c)));
            return s;
        }
        
        public double GetSetA
        {
            get
            {return a;}
            set
            { a = value; }
        }

        public double GetSetB
        {
            get
            { return b; }
            set
            { b = value; }
        }

        public double GetSetC
        {
            get
            { return c; }
            set
            { c = value; }
        }

        public double GetSetH
        {
            get
            { return h; }
            set
            { h = value; }
        }

        public bool ExistTriangle
        {
            get
            {
                if ((a < b + c) && (b < a + c) && (c < a + b))
                    return true;
                    else return false;
            }
        }
    }
}
