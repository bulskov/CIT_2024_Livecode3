using System.Linq;


var query = Data.GetPersonData();

var q2 = query.Join(
    Data.GetCourses(),
    p => p.CourseId,
    c => c.Id,
    (p, c) => new { p.Name, CourseName = c.Name, p.Age });

foreach(var e in q2)
{
    Console.WriteLine(e);
}
