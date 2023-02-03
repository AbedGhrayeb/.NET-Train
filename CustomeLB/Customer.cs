namespace CustomeLB
{
    public class Empolyee
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        //composition is type of relationshio between classes
        //note: must be intilize or check null befor clall it
        public Insurance EmployeeInsurance { get; set; }

        public Empolyee()
        {
            EmployeeInsurance= new Insurance { PlolicyId=-1,CompanyName="N/A"};
        }
        //becuse just this class only use Insurance, you can use it as nested class
        public class Insurance
        {
            public int PlolicyId { get; set; }
            public string? CompanyName { get; set; }
        }
    }
  
    public class Department
    {
        public int Id { get; set; }
        public string? Name { get; set; }
    }
}
