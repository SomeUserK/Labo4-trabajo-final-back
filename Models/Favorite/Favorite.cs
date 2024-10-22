using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Generador_ideas.Models.Favorites
{
     public class Favorite
    {
        [Key]
        [Column(Order = 0)]
        public int UserId { get; set; }

        [Key]
        [Column(Order = 1)]
        public int IdeaId { get; set; }

        // Navegación
        public User User { get; set; }
        public Idea Idea { get; set; }
    }
}

