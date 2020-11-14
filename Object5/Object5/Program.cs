namespace Object5
{
    class Program
    {
        static void Main(string[] args)
        {
            Person employee = new Person();
            Person boss = new Person();

            employee.Name = "Employee1";
            employee.Age = 35;
            employee.City = "Big City";

            boss.Name = "Boss1";
            boss.Age = 45;
            boss.City = "Small City";

            Office office = new Office(employee, boss);

            //office.PrintWorkers();
            office.PrintWorkers(employee, boss);


        }
    }
}
