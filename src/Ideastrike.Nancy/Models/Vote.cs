using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ideastrike.Nancy.Models
{
    public class Vote
    {
        public int Value { get; set; }

        [Key, ForeignKey("User"), Column(Order = 0)]
        public Guid UserId { get; set; }

        [Key, ForeignKey("Idea"), Column(Order = 1)]
        public int IdeaId { get; set; }

        public DateTime? Time { get; set; }

        public virtual User User { get; set; }

        public virtual Idea Idea { get; set; }
    }
}