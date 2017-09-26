using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventar.Models.Items
{
    public class Laptop : IEntity
    {
        private ICollection<Issue> issues;

        public Laptop()
        {
            this.issues = new HashSet<Issue>();
        }

        [Key]
        public int Id { get; set; }

        public int RamInMb { get; set; }

        public int HddInGb { get; set; }

        public string Processor { get; set; }

        public int BatteryTime { get; set; }

        public int Weight { get; set; }

        public int ScreenSize { get; set; }

        public string UserId { get; set; }

        public virtual User User { get; set; }

        public virtual ICollection<Issue> Issues
        {
            get { return this.issues; }
            set { this.issues = value; }
        }
    }
}
