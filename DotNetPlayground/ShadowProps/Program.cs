using Microsoft.EntityFrameworkCore;
using ShadowProps;
using ShadowProps.Models;

//using DatabaseContext dbContext = new();
#region CourseCreation
//ICollection<Student> students = dbContext.Students.ToArray();
//Course testCourse = new()
//{
//    Name = "Test Course",
//    Description = "Test description",
//    Students = students
//};

//dbContext.Courses.Add(testCourse);
#endregion
#region StudentCreation
//Student firstStudent = new()
//{
//    Name = "First student",
//    Email = "FirstStudent@test.com"
//};

//Student secondStudent = new()
//{
//    Name = "Second student",
//    Email = "SecondStudent@test.com"
//};

//Student thirdStudent = new()
//{
//    Name = "Third student",
//    Email = "SecondStudent@test.com"
//};
//dbContext.Students.AddRange(firstStudent, secondStudent, thirdStudent);
#endregion
//dbContext.SaveChanges();

#region Setting a shadow property
//Student student = dbContext.Students.First();

//dbContext.Entry(student).Property("ShadowProperty").CurrentValue = "It's a shadow property!";
#endregion
#region Reading from a shadow property
//Student? student = dbContext.Students.Where(student => EF.Property<string>(student, "ShadowProperty") != null).FirstOrDefault();

//if (student is not null)
//{
//    Console.WriteLine(dbContext.Entry(student).Property("ShadowProperty").CurrentValue);
//}
#endregion