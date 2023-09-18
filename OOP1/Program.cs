
using System.Diagnostics;
using System.Xml.Linq;


Student student1 = new Student("Victoria", 17, 3.8, 11);
Student student2 = new Student("Sofi", 18, 3.2, 12);
Student student3 = new Student("Andi", 15, 3.0, 9);
Student student4 = new Student("Nicola", 16, 3.5, 10);


enum GradeLevel
{
    Other,
    Freshman,
    Sophomore,
    Junior,
    Senior
}
class Student
{

    private string _name;
    public int age;
    public double GPA;
    public int grade;
    public GradeLevel GLevel;

    public Student()
    {
    }

    public Student(string name, int age, double GPA, int grade)
    {
        this._name = name;
        this.age = age;
        this.GPA = GPA;
        this.grade = grade;

        switch (grade)
        {
            case 9:
                GLevel = GradeLevel.Freshman;
                break;

            case 10:
                GLevel = GradeLevel.Sophomore;
                break;

            case 11:
                GLevel = GradeLevel.Junior;
                break;

            case 12:
                GLevel = GradeLevel.Senior;
                break;

            default:
                GLevel = GradeLevel.Other;
                break;
        }
   

IntroStudent();

    }

    public void IntroStudent()
    {
    Console.WriteLine($"Hello my name is {_name}. I am {age} yo and I am in grade {grade}, which means I am a {GLevel}. I have a GPA of {GPA}.");
    }

}
