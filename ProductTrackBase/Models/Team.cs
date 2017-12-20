namespace ProductTrack.Models
{
    using System;
    using System.Collections.Generic;

    public partial class Team
    {
        public int TeamId { get; set; }
        public string TeamName { get; set; }
        public virtual ICollection<Member> Members { get; set; }
    }
}
