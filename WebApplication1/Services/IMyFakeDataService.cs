using System;
using WebApplication1.Models;
namespace WebApplication1.Services
{
    public interface IMyFakeDataService
    {
        List<Student> StudentList { get; }
        List<Instructor> InstructorList { get; }
    }
}