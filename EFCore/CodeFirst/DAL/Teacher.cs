
namespace CodeFirst.DAL
{
    public class Teacher
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public List<Student> Students { get; set; } = new List<Student>(); // Navigation property to related students
    }
}
