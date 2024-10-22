using System.ComponentModel.DataAnnotations;

namespace Generador_ideas.Models.IdeaHistory
{
    public class IdeaHistory
    {
        [Key]
        public int IdeaHistoryId { get; set; }

        public int UserId { get; set; }
        public int IdeaId { get; set; }
        public int ParameterId { get; set; } // Clave foránea a InputParameter
    }
}
