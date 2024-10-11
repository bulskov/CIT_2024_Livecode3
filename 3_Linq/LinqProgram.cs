using System.Linq;
using System.Runtime.InteropServices;




var query = Data.GetPersonData();

var q2 = query.Join(
    Data.GetCourses(),
    p => p.CourseId,
    c => c.Id,
    (p, c) => new { p.Name, CourseName = c.Name, p.Age });

var data = q2.ToList();

foreach(var e in query.Select((x, i) => i))
{
    Console.WriteLine(e);
}


static class LinqExt {
    public static IEnumerable<T> MyWhere<T>(this IEnumerable<T> source, Func<T, bool> fn)
    {
        foreach (var e in source)
        {
            if (fn(e))
            {
                yield return e;
            }
        }
    }

    public static IEnumerable<U> MySelect<T,U>(this IEnumerable<T> source, Func<T,U> fn)
    {
        foreach(var e in source)
        {
            yield return fn(e);
        }
    }
}
