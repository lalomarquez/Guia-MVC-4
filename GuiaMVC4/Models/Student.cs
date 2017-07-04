
namespace GuiaMVC4.Models
{
    public class Student
    {
        public int StudentId { get; set; }
        public string StudentName { get; set; }
        public int Age { get; set; }
        public Gender StudentGender { get; set; }
        public bool isNewlyEnrolled { get; set; }
        public string Password { get; set; }
        public string Description { get; set; }
        public string Gender { get; set; }
    }
    public enum Gender
    {
        Male,
        Female,
        Otro
    }
}