
namespace CodeFirst.DAL
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public List<Teacher> Teachers { get; set; } = new List<Teacher>(); // Navigation property to related teachers

    }
}
