using Generador_ideas.Models.IdeaHistories;
using Generador_ideas.Models.InputParameters;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Generador_ideas.Models.Idea
{
    public class Idea
    {
        [Key]
        public int IdeaId { get; set; }

        public string IdeaName { get; set; } = null!;

        public ICollection<InputParameter> InputParameters { get; set; } = new List<InputParameter>(); // Relación con InputParameter

        public ICollection<IdeaHistory> IdeaHistories { get; set; } = new List<IdeaHistory>(); // Relación con IdeaHistory
    }
}
