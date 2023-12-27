class Program
{
    static void Main(string[] args)
    {
        University university = new University();
        try
        {
            Console.Write("Введите название университета: ");
            university.Name = Console.ReadLine();
            Console.Write("Введите количество зачисленных студентов: ");
            university.EnrolledStudents = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите количество выпускников: ");
            university.Graduates = Convert.ToDouble(Console.ReadLine());
        }
        catch (Exception err)
        {
            Console.WriteLine(err.Message);
        }

        Console.WriteLine($"Университет: {university.Name} | Q = {university.Q():F2}");

        SU su = new SU();
        try
        {
            Console.Write("Введите название специализированного университета: ");
            su.Name = Console.ReadLine();
            Console.Write("Введите количество зачисленных студентов: ");
            su.EnrolledStudents = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите количество выпускников: ");
            su.Graduates = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите процент выпускников, работающих по специальности: ");
            su.EmploymentRate = Convert.ToDouble(Console.ReadLine());
        }
        catch (Exception err)
        {
            Console.WriteLine(err.Message);
        }

        Console.WriteLine($"Специализированный университет: {su.Name} | Q = {su.Q():F2}");
    }
}
public class University
{
    public string Name { get; set; }
    public double EnrolledStudents { get; set; }
    public double Graduates { get; set; }

    public University(string name, double enrolledStudents, double graduates)
    {
        Name = name;
        EnrolledStudents = enrolledStudents;
        Graduates = graduates;
    }

    public University()
    {
        Name = "";
        EnrolledStudents = 0;
        Graduates = 0;
    }

    public double Q()
    {
        return Graduates / EnrolledStudents;
    }
}

public class SU : University
{
    public double EmploymentRate { get; set; }

    public SU(string name, double enrolledStudents, double graduates, double employmentRate)
        : base(name, enrolledStudents, graduates)
    {
        EmploymentRate = employmentRate;
    }

    public SU()
    {
        EmploymentRate = 0;
    }

    public new double Q()
    {
        return EmploymentRate * base.Q();
    }
}

