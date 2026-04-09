using System.ComponentModel.DataAnnotations;

namespace ConnectDB.Models
{
    public class Student
    {
        [Key]
        public int Id { get; set; }

        [Required] 
        [StringLength(20)] 
        public string StudentCode { get; set; }

        [Required] 
        [StringLength(100)] 
        public string FullName { get; set; }

        public DateTime Birthday { get; set; }
    }
}