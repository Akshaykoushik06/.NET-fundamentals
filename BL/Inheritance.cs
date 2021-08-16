using System;
using System.Collections.Generic;
using System.Text;

namespace BL
{
    public enum PersonGender
    {
        Male,Female
    }
    public class Person
    {
        public string name { get; set; }
        public string Aadhar { get; set; }
        public int Age { get; set; }
        public PersonGender Gender { get; set; }

        public int Walks(float distance)
        {
            int totalSteps = (int)(distance * 1000f);
            return totalSteps;
        }
        protected double GetFinancialAssets()
        {
            return 10000000d;
        }

        public virtual void Works()
        {
            Console.WriteLine("5 AM - 9PM: Regular home chores");
        }

        public virtual void Works(string task, bool status)
        {
            Console.WriteLine($"Working on {task}");
        }
    }
    //public class Employee: Person {
    //    public override void Works()
    //    {
    //        base.Works();
    //        Console.WriteLine("This is from the overriden method");
    //    }

    //    public override void Works(string task, bool status)
    //    {
    //        // base.Works(task, status);
    //        DateTime today = DateTime.Now.Date;
    //        Console.WriteLine("### STANDUP REPORT ###");
    //        Console.WriteLine($"{this.name} Work status for {today}");
    //        Console.WriteLine($"Deliverable: {task} | Status: {status}");
    //    }
    //}
}
