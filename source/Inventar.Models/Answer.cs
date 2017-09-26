using System;
using System.ComponentModel.DataAnnotations;

namespace Inventar.Models
{
    public class Answer : IEntity
    {
        public Answer()
        {
            this.Id = Guid.NewGuid();
        }

        [Key]
        public Guid Id { get; set; }

        public string Content { get; set; }

        public DateTime AnsweredOn { get; set; }

        public string Title { get; set; }

        public int IssueId { get; set; }

        public virtual Issue Issue { get; set; }

        public string UserId { get; set; }

        public virtual User User { get; set; }
    }
}
