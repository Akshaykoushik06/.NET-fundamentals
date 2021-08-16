using System;

namespace BL
{
    public class ClassA
    {
        public string strPublic => "I am public";
        private string StrPrivate => "I am private";
        protected string StrProtected => "I am protected";
        internal string StrInternal => "I am internal";

        public void GetC()
        {
            C objC = new C();
            objC.GetB();
        }

        public string AccessPrivateProp()
        {
            return this.StrPrivate;
        }
    }

    internal class B
    {
        public string strPublic => "I am public";
        private string StrPrivate => "I am private";
        protected string StrProtected => "I am protected";
        internal string StrInternal => " am internal";
    }

    internal class C
    {
        private void GetA()
        {
            ClassA objA = new ClassA();
            Console.WriteLine(objA.StrInternal);
            Console.WriteLine(objA.strPublic);
        }

        internal void GetB()
        {
            B objB = new B();
            Console.WriteLine(objB.StrInternal);
            Console.WriteLine(objB.strPublic);
        }

    }
}
