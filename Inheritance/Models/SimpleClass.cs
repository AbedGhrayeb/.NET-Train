namespace Inheritance.Models
{
    internal class SimpleClass

    {
        public class Baseclass
        {
            public string Name = "From Base";
        }
        public class SubClass : Baseclass
        {
            //new value from sub class override origenal value from baseclass
            public new string Name = "From Sub Class";
        }
    }
}
