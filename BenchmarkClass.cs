using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;


namespace PointClass_float
{
    public class BenchmarkClass
    {
        public static float PointDistance(PointClass pointOne, PointClass pointTwo)
        {
            float x = pointOne.X - pointTwo.X;
            float y = pointOne.Y - pointTwo.Y;
            return (float)(Math.Sqrt((x * x) + (y * y)));
        }





        [Benchmark]
        public void TEST_Distance_one()
        {
            PointClass one = new PointClass() {X=291 ,Y=267};
            PointClass two = new PointClass() {X=867,Y=549};
            PointDistance(one, two);
            //Console.WriteLine(PointDistanceShort(one, two));
        }

        [Benchmark]
        public void TEST_Distance_two()
        {
            PointClass one = new PointClass() { X = 403, Y = 980 };
            PointClass two = new PointClass() { X = 567, Y = 134 };
            PointDistance(one, two);
            //Console.WriteLine(PointDistanceShort(one, two));
        }
    }
}
