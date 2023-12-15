using System.ComponentModel.DataAnnotations;

namespace MeuTodo.ViewsModels
{
    public class CreateTodoViewModel
    {
        [Required]
        public string Title { get; set; }
    }
}