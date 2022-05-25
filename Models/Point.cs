using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using static System.Drawing.Point;

namespace Web.Models
{
    public class Point
    {
        public Point()
        {
            Random rnd = new Random();
            int points = rnd.Next(-100, 140);
            y.Add(points);
            for (int i = 1; i < 600; i++)
            {
                int last = y.Last();
                points = rnd.Next(last - 1, last + 2);
                y.Add(points);
            }
        }

        public Point(Point point)
        {
            Random rnd = new Random();
            int points = rnd.Next(point.Y[0]-1, point.Y[0]+2);
            y.Add(points);
            for (int i = 1; i < point.Y.Count; i++)
            {
                if(y.Last() == point.Y[i])
                {
                    points = rnd.Next(y.Last() - 1, y.Last() + 2);
                    y.Add(points);
                }
                else
                {
                    int min = y.Last();
                    int max = point.Y[i];
                    if (y.Last() > point.Y[i])
                    {
                        min = point.Y[i];
                        max = y.Last();
                    }
                    points = rnd.Next(min, max + 1);
                    y.Add(points);
                }
            }
        }

        List<int> x = new List<int>();
        List<int> y = new List<int>();
        List<int> z = new List<int>();

        public List<int> X
        {
            get
            {
                return x;
            }
        }

        public List<int> Y
        {
            get
            {
                return y;
            }
        }

        public List<int> Z
        {
            get
            {
                return z;
            }
        }        
    }
}


