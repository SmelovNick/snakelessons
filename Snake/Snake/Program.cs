﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point(1, 3, '*');
            p1.Draw();

            Point p2 = new Point(4, 5, '#');
            p2.Draw();

            Point p3 = new Point(9, 4, '/');
            p3.Draw();

            Point p4 = new Point(8, 2, '+');
            p4.Draw();

            Point p5 = new Point(6, 6, '.');
            p5.Draw();

            Point p6 = new Point(2, 7, '0');
            p6.Draw();


            List<int> numList = new List<int>();
            numList.Add(0);
            numList.Add(1);
            numList.Add(2);
            int x = numList[0];
            int y = numList[1];
            int z = numList[2];
            foreach (int i in numList)
            {
                Console.WriteLine();
            }

            numList.Remove(0);

            List<Point> plist = new List<Point>();
            plist.Add(p1);
            plist.Add(p2);
            plist.Add(p3);
            plist.Add(p4);
            plist.Add(p5);
            plist.Add(p6);
            Console.ReadKey();
        }
    }
}
