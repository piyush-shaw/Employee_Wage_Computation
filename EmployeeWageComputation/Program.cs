using EmployeeWageComputation;
class Program
{
    static void Main(string[] args)
    {
        EmpWageBuilderObject dMart = new EmpWageBuilderObject("DMart", 25, 22, 80);
        EmpWageBuilderObject reliance = new EmpWageBuilderObject("Reliance", 30, 23, 76);
        EmpWageBuilderObject bigbasket = new EmpWageBuilderObject("BigBasket", 40, 24, 85);
        dMart.computeEmpWage();
        reliance.computeEmpWage();
        bigbasket.computeEmpWage();
        Console.WriteLine(dMart.toString());
        Console.WriteLine(reliance.toString());
        Console.WriteLine(bigbasket.toString()); ;
    }

}
   
    
