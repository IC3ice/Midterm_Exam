public class Student: Personal{
    private string grade;
    private string school;
    public Student(string prefix,string name, string surename,
    string age,string grade,string allergic,string school,string religion)
    : base (prefix,name,surename,age,allergic,religion){
        this.grade = grade;
        this.school = school;
    }
}