using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces.Abstract
{
    public interface IMove
    {
        //default method for all classes Inherte from this interface
        void Turn() => Console.WriteLine("Turning...");
        void Move();
    }
}
