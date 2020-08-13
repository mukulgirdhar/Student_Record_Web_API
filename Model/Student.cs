using System.ComponentModel.DataAnnotations;

namespace Student_Record_Web_API.Model
{
    public class Student
    {
        [Key]
        public int Student_ID { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Mobile { get; set; }
        public string email { get; set; }
    }
}
