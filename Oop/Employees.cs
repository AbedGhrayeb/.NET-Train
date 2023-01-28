namespace Oop
{
    internal class Employees
    {
        private readonly int _id;
        private readonly string _fName;
        private readonly string _lName;
        private Employees(int id, string fName, string lName)
        {
            this._id = id;
            this._fName = fName;
            this._lName = lName;
        }
        //to use privet constaractor method must be static & return type
        public static Employees Ini(int _id, string f_name, string l_name)
        {
            return new Employees(_id, f_name, l_name);
        }

        public string DisplayName()
        {
            return $"Employee Id: {_id}, Name: {_fName} {_lName}";
        }
    }
}
