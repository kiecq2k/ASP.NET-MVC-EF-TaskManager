using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ToDoList.Models
{
    [Table("Tasks")]
    public class TaskModel
    {

        [Key]
        public int TaskId { get; set; }

        [Display(Name="Nazwa")]
        [Required(ErrorMessage = "Pole Nazwa jest wymagane.")]
        [MaxLength(50,ErrorMessage = "Maksymalna dlugosc nazwy wynosi 50 znaków.")]
        public string Name { get; set; }

        [Display(Name="Opis")]
        [MaxLength(2000,ErrorMessage = "Maksymalna dlugosc opisu wynosi 2000 znaków.")]
        public string Description { get; set; }

        public bool Done { get; set; }

        public TaskModel(string Name,string Description)
        {
            this.Name = Name;
            this.Description = Description;
            this.Done = false;
        }
        public TaskModel()
        {
        }
        public TaskModel(TaskModel taskModel)
        {
            this.Name = taskModel.Name;
            this.Description = taskModel.Description;
        }
    }
}
