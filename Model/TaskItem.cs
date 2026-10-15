using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Model
{
    [Table("Tasks")]
    public class TaskItem
    {

        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(100)]
        public string Name { get; set; }
        [MaxLength(200)]
        public string ?Description { get; set; }
    
        public bool IsCompleted { get; set; }
  
        public TaskLevel TaskLevel { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime ToDu { get; set; }

    }
}
