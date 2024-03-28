using Classes.Classes;

namespace Classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student("ali", "aliyev", "ab106", 70, true);

            student.GetInfo();
            student.CheckGraduate();
            student.GetDiplomDegree();
            
        }
    }
}