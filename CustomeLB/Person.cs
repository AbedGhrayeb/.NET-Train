namespace CustomeLB
{
    public class Person
    {
        private string? Id;
        public int Age;
        public string Name { get; set; }
        public Person(string name)
        {
            Name = name;
            Console.WriteLine($"this is from constractor, person name: {name}");
        }

        //call when opject distroy (end of scoop)
        ~Person()
        {
            Console.WriteLine($"this is from constractor");
        }
        public void DoSomeThing()
        {
            InternalPerson internalPerson= new InternalPerson();
            this.Name = internalPerson.Name;
        }
    }

}
