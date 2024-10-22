using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Generador_ideas.Models.Idea; // Asegúrate de que el namespace sea correcto
using Generador_ideas.Models.InputParameter; // Asegúrate de que el namespace sea correcto
using Generador_ideas.Models.IdeaHistory; // Asegúrate de que el namespace sea correcto

namespace Generador_ideas.Models.User
{
    public class User
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int UserId { get; set; }
        [Required]
        [MaxLength(50)]
        public string Name { get; set; } = null!;

        [Required]
        [MinLength(6)]
        public string Password { get; set; } = null!;

        public ICollection<Idea> Ideas { get; set; } = new List<Idea>(); // Relación con Idea

        public ICollection<InputParameter> InputParameters { get; set; } = new List<InputParameter>(); // Relación con InputParameter

        public ICollection<IdeaHistory> IdeaHistories { get; set; } = new List<IdeaHistory>(); // Relación con IdeaHistory
    }
}
