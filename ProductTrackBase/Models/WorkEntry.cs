namespace ProductTrack.Models
{
    using System;
    using System.Collections.Generic;

    public partial class WorkEntry
    {
        public int WorkEntryId { get; set; }
        public virtual Member Member { get; set; }
        public string Activity { get; set; }
        public Nullable<System.DateTime> DateCompleted { get; set; }
        public Nullable<double> TimeSpent { get; set; }
    }
}
