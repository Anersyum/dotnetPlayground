namespace ShadowProps.Models;

internal sealed class Course
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public ICollection<Student> Students { get; set; } = Array.Empty<Student>();
}

