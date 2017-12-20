using ProductTrack.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProductTrack.Controllers
{ 
    public class TimeSummaryController : Controller
    {
        // GET: TimeSummary
        public ViewResult Index()
        {
            var factory = new ProductTrackContextFactory();
            var args = new string[] { "ProductTrackEntities" };
            using (var context = factory.CreateDbContext(args))
            {
                var members = context.Members.ToList();
                return View(members);
            }
        }

        public ViewResult Member(string member_user_id)
        {
            // var lbell = new Member { MemberUserId = "lbell", FirstName = "Leveon", LastName = "Bell" };
            // var entry_1 = new WorkEntry { Member = lbell, Activity = "Running", TimeSpent = 12.5 };
            // var entry_2 = new WorkEntry { Member = lbell, Activity = "Catching", TimeSpent = 10.0 };
            var factory = new ProductTrackContextFactory();
            var args = new string[] { "ProductTrackEntities" };
            using (var context = factory.CreateDbContext(args))
            {
                // context.Members.Add(lbell);
                // context.WorkEntries.Add(entry_1);
                // context.WorkEntries.Add(entry_2);
                // ontext.SaveChanges();
                var member = context.Members.
                    Where(m => m.MemberUserId == member_user_id).FirstOrDefault();
                return View(member);
            }
        }
    }
}