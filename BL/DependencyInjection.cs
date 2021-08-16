using System;
using System.Collections.Generic;
using System.Text;

namespace BL
{
    public class Engine
    {
        public string engineType { get; set; }
    }

    public class Car
    {
        public Engine e { get; set; }
        public Car(Engine engine)
        {
            e = engine;
            engine.engineType = "Diesel";
        }
    }
}
