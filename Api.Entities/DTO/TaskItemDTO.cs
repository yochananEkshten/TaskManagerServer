using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using System.ComponentModel.DataAnnotations;


namespace Api.Entities
{
    public  class TaskItemDTO
    {
        [Range(1, int.MaxValue)]   
        public int? Id { get; set; }
        [Required]
        [MaxLength(100)]
        public string Name { get; set; } = string.Empty;

        [MaxLength(200)]
        public string? Description { get; set; }

        public bool IsCompleted { get; set; }

        [Required]
        public TaskLevel? TaskLevel { get; set; }

        public DateTime? DueDate { get; set; }

        public DateTime? CreatedAt { get; set; }

    }
}
