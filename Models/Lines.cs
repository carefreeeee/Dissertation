using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web.Models
{
    public class Lines
    {
        public Lines(int count)
        {
            lines.Add(new Point());
            for (int i = 1; i < count; i++)
            {
                Point last = lines.Last();
                lines.Add(new Point(last));
            }
        }

        List<Point> lines = new List<Point>();

        public List<Point> Get2d
        {
            get
            {
                return lines;
            }
        }
    }
}
