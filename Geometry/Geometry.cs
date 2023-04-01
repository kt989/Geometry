﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace Geometry
{
    public abstract class Shape
    {

    }

    public class Circle : Shape
    {
        public double radius { get; set; }

        public Circle(double radius)
        {
            this.radius = radius;
        }
        
        public double get_area(double radius)
        {
            double area = 3.14 * radius * radius;
            return area;
        }

    }

    public class Triangle : Shape
    {
        public double x { get; set; }
        public double y { get; set; }
        public double z { get; set; }
        public double area { get; set; }

        public Triangle(double x, double y, double z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        public double get_area(double x, double y, double z)
        {
            double h;
            if (x == y && x == z && y == z)
            {
                h = Math.Sqrt(x * x - 0.25 * x * x);
                area = 0.5 * x * h;
            }
            if (x==y ||y==z||z==x)
            {
                double osnovanie = x==y? z:(x==z?y:x);
                h = Math.Sqrt(osnovanie * osnovanie - 0.25 * x * x);
                area = 0.5 * x * h;
            }
            return area;
        }

    }
}
