using Inventar.Models.Enumerations;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Inventar.Models
{
    public class Issue : IEntity
    {
        private ICollection<Answer> answers;
        private ICollection<Tag> tags;

        public Issue()
        {
            this.answers = new HashSet<Answer>();
            this.tags = new HashSet<Tag>();
        }

        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(100, MinimumLength = 10)]
        public string Title { get; set; }

        public string Content { get; set; }

        public bool Resolved { get; set; }

        public IssueType Type { get; set; }

        public DateTime PostedOn { get; set; }

        public string UserId { get; set; }

        public virtual User User { get; set; }

        public virtual ICollection<Answer> Answers
        {
            get { return this.answers; }
            set { this.answers = value; }
        }

        public virtual ICollection<Tag> Tags
        {
            get { return this.tags; }
            set { this.tags = value; }
        }
    }
}
