namespace Encapsilation.Models


{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student
            {
               
            };
            student.SetSurname(Console.ReadLine());
            student.SetName(Console.ReadLine());
            student.SetAvgPOint(Convert.ToDouble(Console.ReadLine()));
            
            Console.WriteLine($"Name:{ student.GetName()}\nSurname:{ student.GetSurname()} \nAvgPOint:{student.GetAvgPOint()}");
             

        }
        
    }
}