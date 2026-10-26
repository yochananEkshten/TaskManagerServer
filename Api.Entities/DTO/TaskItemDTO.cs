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

    }
}
