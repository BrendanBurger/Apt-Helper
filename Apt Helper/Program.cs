﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apt_Finder
{
    class Program


    {
        public static int[] nums = new int[5];
        public static List<Apartment> apts = new List<Apartment>();


        static void Main(string[] args)
        {

            foreach (int i in nums)
            {
                Console.Out.WriteLine(i);
            }




            for (int i = 0; i < 30; i++)
            {
                Console.WriteLine("Street name");
                String temp = Console.ReadLine();
                Apartment a = new Apartment(temp);

                Console.WriteLine("enter work commute max: 10");
                int temp2 = Int32.Parse(Console.ReadLine());
                a.commute = temp2;


                Console.WriteLine("enter price max:10");
                temp2 = Int32.Parse(Console.ReadLine());
                a.price = temp2;


                Console.WriteLine("enter yard max:5");
                temp2 = Int32.Parse(Console.ReadLine());
                a.yard = temp2;


                Console.WriteLine("enter schools max:7");
                temp2 = Int32.Parse(Console.ReadLine());
                a.schools = temp2;


                Console.WriteLine("enter Looks max:10 ");
                temp2 = Int32.Parse(Console.ReadLine());
                a.looks_in = temp2;


                Console.WriteLine("enter utils max:7");
                temp2 = Int32.Parse(Console.ReadLine());
                a.utils = temp2;


                Console.WriteLine("enter parking max:7");
                temp2 = Int32.Parse(Console.ReadLine());
                a.parking = temp2;


                Console.WriteLine("enter rooms max:7    2*PER");
                temp2 = Int32.Parse(Console.ReadLine());
                a.rooms = temp2;


                Console.WriteLine("enter bonus max:5");
                temp2 = Int32.Parse(Console.ReadLine());
                a.bonus = temp2;


                Console.WriteLine("enter neighborhood max:7");
                temp2 = Int32.Parse(Console.ReadLine());
                a.neighborhood = temp2;


                Console.WriteLine("enter hills max:5");
                temp2 = Int32.Parse(Console.ReadLine());
                a.hills = temp2;


                Console.WriteLine("enter starting max :7");
                temp2 = Int32.Parse(Console.ReadLine());
                a.starting = temp2;


                Console.WriteLine("enter floors max :2");
                temp2 = Int32.Parse(Console.ReadLine());
                a.floors = temp2;


                Console.WriteLine("enter crime max :5");
                temp2 = Int32.Parse(Console.ReadLine());
                a.crime = temp2;


                Console.WriteLine("enter house max:1");
                temp2 = Int32.Parse(Console.ReadLine());
                a.house = temp2;

                Console.WriteLine("enter square space max:5");
                temp2 = Int32.Parse(Console.ReadLine());
                a.sqrSpace = temp2;

                a.computeScore();
                a.print();
                apts.Add(a);
            }


            List<Apartment> Top = apts.OrderByDescending(p => p.score).ToList();


            for (int i = 0; i < Top.Count; i++)
            {
                Console.WriteLine(Top.ElementAt(i).name + " " + Top.ElementAt(i).score);
            }
            Console.ReadLine();
        }


    }

}



