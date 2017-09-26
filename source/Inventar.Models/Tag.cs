using System.Collections.Generic;

namespace Inventar.Models
{
    public class Tag
    {
        private ICollection<Issue> issues;

        public Tag()
        {
            this.issues = new HashSet<Issue>();
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public virtual ICollection<Issue> Issues
        {
            get { return this.issues; }
            set { this.issues = value; }
        }
    }
}
