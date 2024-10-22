using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Generador_ideas.Models.Idea; // Asegúrate de que este espacio de nombres es correcto
using Generador_ideas.Models.User; // Asegúrate de que este espacio de nombres es correcto

namespace Generador_ideas.Models.InputParameter
{
    public class InputParameter
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ParameterId { get; set; }

        public string ParameterName { get; set; } = null!; // Nombre del parámetro

        public int IdeaId { get; set; }

        [ForeignKey(nameof(IdeaId))]
        public Idea Idea { get; set; } = null!; // Relación con Idea

        public int UserId { get; set; }

        [ForeignKey(nameof(UserId))]
        public User User { get; set; } = null!; // Relación con User
    }
}
