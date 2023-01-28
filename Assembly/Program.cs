using System;

namespace Assemblies
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //var type = typeof(Empolyee);
            //var assembly1 = type.Assembly;
            //var assembly2 = Assembly.GetEntryAssembly();
            //Console.WriteLine(assembly1.FullName);
            //Console.WriteLine(assembly2.FullName);
            //Console.WriteLine(type.Name);

            //reflection
            //Type t1=DateTime.Now.GetType();// get type at runtime
            ////Console.WriteLine(t1);

            //Type t2=typeof(DateTime); //get type at compile time
            ////Console.WriteLine(t2);

            //Console.WriteLine($"Get Full Name: {t1.FullName}");
            //Console.WriteLine($"Get Type Name: {t1.Name}");
            //Console.WriteLine($"Get NameSpace: {t1.Namespace}");
            //Console.WriteLine($"Get Base Type: {t1.BaseType}");
            //Console.WriteLine($"Get Assembly: {t1.Assembly}");
            //Console.WriteLine($"Get Assembly: {t1.IsAbstract}");

            //Type t3 = typeof(int[,]);
            //Console.WriteLine("Is Array", t3.IsArray);
            //Console.WriteLine("Name", t3.Name);


            //var nestedTypes = typeof(Empolyee).GetNestedTypes();
            //Console.WriteLine($"types Length: {typeof(Empolyee).GetNestedTypes().Length}");

            //if (nestedTypes.Length>0)
            //{
            //    for (int i = 0; i < nestedTypes.Length; i++)
            //    {
            //        Console.WriteLine(nestedTypes[i].Name);

            //    }
            //}
            do
            {
                Console.Write("Enemy: ");
                var input = $"{typeof(Program).Assembly.GetName().Name}.{Console.ReadLine()}";
                object obj = null;
                var aName = typeof(Program).Assembly.GetName().Name;
                var enemy = Activator.CreateInstance(aName, input);
                obj = enemy.Unwrap();
                switch (obj)
                {
                    case Goon g:
                        Console.WriteLine(g);
                        break;
                    case Agar a:
                        Console.WriteLine(a);
                        break;
                    case Pixa p:
                        Console.WriteLine(p);
                        break;
                    default:
                        Console.WriteLine("Unkown palyer");
                        break;
                }
            }
            while (true);

        }
    }
    public class Empolyee
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    public class Goon
    {
        public override string ToString()
        {
            return $"{{Speed: {20}, HitPower: {13}, Stringth: {7}}}";
        }
    }
    public class Agar
    {
        public override string ToString()
        {
            return $"{{Speed: {25}, HitPower: {18}, Stringth: {9}}}";
        }
    }
    public class Pixa
    {
        public override string ToString()
        {
            return $"{{Speed: {15}, HitPower: {10}, Stringth: {20}}}";
        }
    }

    public class BankAccount
    {
        private string _accountNo;
        private string _holder;
        private decimal _balance;

        public string AccountNo=> _accountNo;
        public decimal Balance=> _balance;
        private string Holder=> _holder;
        public BankAccount(string accountNo, string holder, decimal balance)
        {
            _accountNo = accountNo;
            _holder = holder;
            _balance = balance;
        }
    }

}
