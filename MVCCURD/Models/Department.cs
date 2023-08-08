using System.ComponentModel.DataAnnotations;

namespace MVCCURD.Models
{
    public class Department
    {
        [Key]
        public int Id { get; set; }
        [Required]  
        public string Departments { get; set; }
    
    }
}
