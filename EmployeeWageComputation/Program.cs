namespace EmployeeWageComputation
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("WELCOME THE EMPLOYEE WAGE PROGRAM");
            Random random = new Random(); //Random method
            int empAttaindance = random.Next(2);//0 or 1 print

            if (empAttaindance == 0) // if condition is true then excu. statement
            {
                Console.WriteLine("Employee is Absent");
            }
            else
            {
                Console.WriteLine("Employee is Present");
            }
            Console.ReadLine();
        }


    }
}