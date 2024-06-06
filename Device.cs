using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace HW_13_06
{
    internal abstract class Device
    {
        protected string _name;
        protected string _sound;
        protected string _desc;

        public Device(string name, string sound, string desc)
        {
            _name = name;
            _sound = sound;
            _desc = desc;
        }
        public abstract void Sound();
        public abstract void Show();
        public abstract void Desc();

    }

    internal class Kettle : Device
    {
        
        public Kettle() : base("kettle", "pshh", "for kettle") { }
        public override void Sound() 
        {
            Console.WriteLine($"my sound {_sound}");
        }
        public override void Show() {
            Console.WriteLine($"my name:{_name}");
        }
        public override void Desc()
        {
            Console.WriteLine($"this is {_name}, my sound {_sound}");
        }
    }

    internal class Microwave:Device
    {
        public Microwave() : base("Microwave", "mmmmmmm", "for microwave") { }
        public override void Sound()
        {
            Console.WriteLine($"my sound {_sound}");
        }
        public override void Show()
        {
            Console.WriteLine($"my name:{_name}");
        }
        public override void Desc()
        {
            Console.WriteLine($"this is {_name}, my sound {_sound}");
        }
    }
    
    internal class Steamboat:Device
    {
        public Steamboat() : base("boat", "bigPSHHH", "for boat") { }
        public override void Sound()
        {
            Console.WriteLine($"my sound {_sound}");
        }
        public override void Show()
        {
            Console.WriteLine($"my name:{_name}");
        }
        public override void Desc()
        {
            Console.WriteLine($"this is {_name}, my sound {_sound}");
        }

        

    }
    internal class Car : Device
    {
        public Car() : base("car", "vrum", "for car") { }
        public override void Sound()
        {
            Console.WriteLine($"my sound {_sound}");
        }
        public override void Show()
        {
            Console.WriteLine($"my name:{_name}");
        }
        public override void Desc()
        {
            Console.WriteLine($"this is {_name}, my sound {_sound}");
        }
    }


}
