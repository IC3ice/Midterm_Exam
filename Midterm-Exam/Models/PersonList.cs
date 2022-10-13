using System.Collections.Generic;
using System;
class PersonList {
    private List<College> collegeList;
    private List<Teacher> teacherList;
    private List<Student> studentList;

    public PersonList() {
        this.collegeList = new List<College>();
        this.teacherList = new List<Teacher>();
        this.studentList = new List<Student>();
    }

    public void AddNewCollege(College college) {
        this.collegeList.Add(college);
    }

    public void AddNewTeacher(Teacher teacher) {
        this.teacherList.Add(teacher);
    }

    public void AddNewStudent(Student student) {
        this.studentList.Add(student);
    }

    public void TotalCollege(){
        int countCollege = collegeList.Count;
        Console.WriteLine("Total participant: {0}",countCollege);
    }

    public void TotalTeacher(){
        int countTeacher = teacherList.Count;
        Console.WriteLine("Total college Teacher: {0}",countTeacher);
    }

    public void TotalStudent(){
        int countstudent = studentList.Count;
        Console.WriteLine("Total college Teacher: {0}",countstudent);
    }

    public void FetchCollegeList() {
        Console.WriteLine("List College");
        Console.WriteLine("************");
        foreach(College personal in this.collegeList) {
            Console.WriteLine("Name {0} {1} {2} ", personal.GetPrefix(),personal.GetName(),personal.GetSurename());
        }
        Console.WriteLine("Type exit to return to menu");
    }

    public void FetchStudentList() {
        Console.WriteLine("List Student");
        Console.WriteLine("************");
        foreach(Student personal in this.studentList) {
            Console.WriteLine("Name {0} {1} {2} ", personal.GetPrefix(),personal.GetName(),personal.GetSurename());
        }
        Console.WriteLine("Type exit to return to menu");
    }

    public void FetchTeacherList() {
        Console.WriteLine("List Teacher");
        Console.WriteLine("************");

        foreach(Teacher personal in this.teacherList) {
            Console.WriteLine("Name {0} {1} {2} ", personal.GetPrefix(),personal.GetName(),personal.GetSurename());
        }
        Console.WriteLine("Type exit to return to menu");
    }
}

