namespace ProductTrack.Models
{
    using Microsoft.EntityFrameworkCore;
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Member
    {
        public int MemberId { get; set; }
        public string MemberUserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public virtual Team Team { get; set; }
        public List<WorkEntry> WorkEntries()
        {
            var factory = new ProductTrackContextFactory();
            var entries = new List<WorkEntry>();
            var args = new string[] { "ProductTrackEntities" };
            using (var context = factory.CreateDbContext(args))
            {
                entries = context.WorkEntries
                    .Where(e => e.Member.Equals(this)).ToList();
            }
            return entries;
        }
    }
}
