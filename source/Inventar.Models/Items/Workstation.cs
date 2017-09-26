using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Inventar.Models.Items
{
    public class Workstation : IEntity
    {
        private ICollection<Issue> issues;

        public Workstation()
        {
            this.issues = new HashSet<Issue>();
        }

        [Key]
        public int Id { get; set; }

        public string Brand { get; set; }

        public int RamInMb { get; set; }

        public int HddInGb { get; set; }

        public string Processor { get; set; }

        public int ProcessorCount { get; set; }

        public string VideoCard { get; set; }

        public string UserId { get; set; }

        public virtual User User { get; set; }

        public virtual ICollection<Issue> Issues
        {
            get { return this.issues; }
            set { this.issues = value; }
        }
    }
}
