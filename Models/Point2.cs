using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Drawing;

namespace Web.Models
{
    public class Point2
    {

        //public int X
        //{
        //    get
        //    {
        //        return x;
        //    }
        //}

        //public int Y
        //{
        //    get
        //    {
        //        return y;
        //    }
        //}

        //public int Z
        //{
        //    get
        //    {
        //        return z;
        //    }
        //}

        //public int RndTochki(int count)
        //{
        //    Random rnd = new Random();
        //    int[] points = new int [count];
        //    for (int i = 0; i < count; i++)
        //    {
        //        points[i] = (rnd.Next(10, 20));
        //        points.Add(new []
        //    }
        //    return points;




        public List<int> Massiv(int n = 600)
        {
            List<int> Tochki = new List<int>();
            Random ran = new Random();
            for (int i = 0; i < 600; i++)
            { if (i==0)
                {
                Tochki.Add(ran.Next(-140, 150));
                }
              else
                {
                Tochki.Add(Tochki[i-1]+ ran.Next(-1, 2));
                }
            }
            return Tochki;
        }
    }
}