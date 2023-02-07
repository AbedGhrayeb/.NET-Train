using Interfaces.Abstract;

namespace Interfaces.Concrete
{
    internal class Caterpiller : Vehicle, ILoader, IDriver, IMove, IDisplace
    {
        public Caterpiller(string brand, string model, int year) : base(brand, model, year)
        {
        }

        public void Load()
        {
            Console.WriteLine("Load...");
        }

        public void Drive()
        {
            Console.WriteLine("Drive...");
        }

        public void Stop()
        {
            Console.WriteLine("Stop...");
        }

        public void Unload()
        {
            Console.WriteLine("Un-Load...");
        }

        void IMove.Move()
        {
            Console.WriteLine("IMove Move...");
        }

        void IDisplace.Move()
        {
            Console.WriteLine("IDispalce Move...");
        }
    }
}
