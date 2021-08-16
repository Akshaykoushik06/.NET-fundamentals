using System;
using System.Collections.Generic;
using BL;

namespace First
{
    delegate void Compute(int n1, int n2);
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");
            // Console.WriteLine("Enter your name");
            // var name = Console.ReadLine();
            // var x = 100.0012;
            // Console.WriteLine("Hello " + name);
            // Console.WriteLine($" {sizeof(x)}, x.GetType()");
            // WorkWithClasses();

            // Person PersonObj = new Person();
            //Console.WriteLine(PersonObj.Walks(10));

            //FactoryUsingInterface();
            //Car obj = new Car(new Engine());
            //Console.WriteLine(obj.e.engineType);
            //WithCollection();
            //WithDelegates();
            WithBuiltinDelegates();

        }

        private static void WithBuiltinDelegates()
        {
            // delegateObj (Action | Func | Predicate) = () = {}
            Action<string, string> Concatenate = (s1, s2) => Console.WriteLine($"Concatenated String: {s1 + s2}");
            Func<int, int, int> Calculate = (n1, n2) => n1 + n2;
            Calculate += (n1, n2) => n1 - n2;

            Predicate<string> isEmpty = (s) => s == "";

            // Invoke
            Concatenate("Akshay", " Koushik");
            Console.WriteLine(Calculate(100, 200));
            Console.WriteLine($"Is Empty: {isEmpty("Hello")}");

            // Call function which takes a delegate as parameter
            ExecuteUserAction(Concatenate);
        }

        private static void ExecuteUserAction(Action<string, string> pFun)
        {
            pFun("asdad", " asdasd");
        }

        private static void WithDelegates()
        {
            // instantiation
            Compute objCompute = Add;
            objCompute += Sub;

            // invoke delegate
            objCompute(100, 200);
        }

        private static void Sub(int n1, int n2)
        {
            Console.WriteLine(n1 - n2);
        }

        private static void Add(int n1, int n2)
        {
            Console.WriteLine(n1 + n2);
        }

        private static void WithCollection()
        {
            int[] ints = { 10, 20, 30, 40, 50 };
            ints[2] = 90;
            Console.WriteLine("### Printing ARRAY ###");
            foreach (int num in ints)
            {
                Console.WriteLine(num);
            }

            // Expandable array = List
            List<int> lst = new List<int>() { 10, 20, 30, 40, 50 };
            lst.Add(100);
            lst[2] = 9999;
            Console.WriteLine("### Printing LIST ###");
            foreach (int num in lst)
            {
                Console.WriteLine(num);
            }

            List<Person> people = new List<Person>() { new Person() { name = "Akshay" }, new Person() { name = "Koushik" } };
            people.Add(new Person() { name = "Pinkman" });

            foreach (Person person in people)
            {
                Console.WriteLine($"Name:{person.name}");
            }
        }
        private static void FactoryUsingInterface()
        {
            Console.WriteLine("Enter your role as Employee | Client | Vendor:");
            string input = Console.ReadLine();
            IContract contract = null;
            contract = DecideWhoSignsIt(input, contract);
            contract.Sign();
        }

        private static IContract DecideWhoSignsIt(string input, IContract contract)
        {
            switch (input.Trim().ToLower())
            {
                case "employee":
                    contract = new Employee() {Name="Ramesh", EmpId=10001 };
                    break;
                case "client":
                    contract = new Client() { Brand = "Diamler", Location = "Bangalore" };
                    break;
                case "vendor":
                    contract = new Vendor() { Name = "ABC Consultant", VendorType = "Recruitment" };
                    break;
                default:
                    break;
            }
            return contract;
        }

        private static void WorkWithClasses()
        {
            customType obj = new customType();
            obj.name = 10;
            Console.WriteLine($"{obj.name}, {obj.x}");

        }
    }

    class customType
    {
        public static int MyStaticProperty { get; set; }

        private int myVar;

        public int name
        {
            get { return myVar; }
            set { myVar = value; }
        }

        public int x => 1001 * 2 - 100;

        private int var2;

        public int y
        {
            // get { return var2; }
            set { var2 = 100; }
        }


    }
}
