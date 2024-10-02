using System;
using SampleSecureCoding.Models;
namespace SampleSecureCoding.Data;

public interface IStudent
{
    IEnumerable<Student> GetStudents();
    Student AddStudent(Student student);
    Student UpdateStudent(Student student);
    void DeleteStudent(string nim);
}
