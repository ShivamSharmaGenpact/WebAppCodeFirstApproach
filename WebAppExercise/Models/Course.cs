using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAppExercise.Models
{
    [Table("Course")]
    public class Course
    {
        [Key]
        public int CId { get; set; }
        public string CName { get; set; }
        public double CFee { get; set; }
        public string Status { get; set; }
        public string Technology { get; set; }
    }
}
