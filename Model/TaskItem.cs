using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Model.Enums;

namespace Model
{
    [Table("Tasks")]
    public class TaskItem
    {

        [Key]
        public int Id;
        [Required]
        [MaxLength(100)]
        public string Name;
        [MaxLength(200)]
        public string Description;
        [Required]
        public bool IsCompleted { get; set; }
        [Required]
        public TaskLevel TaskLevel { get; set; }
        public DateTime CreatedAt { get; set; }

    }
}
