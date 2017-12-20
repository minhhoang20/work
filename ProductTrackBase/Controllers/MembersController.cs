using ProductTrack.Models;
using System;
using System.Linq;
using System.Web.Mvc;

namespace ProductTrack.Controllers
{
    public class MembersController : Controller
    {
        ProductTrackContext _context;

        public MembersController(ProductTrackContext context)
        {
            _context = context;
        }

        public MembersController()
        {
            var factory = new ProductTrackContextFactory();
            var args = new string[] { "ProductTrackEntities" };
            _context = factory.CreateDbContext(args);
        }

        public ViewResult Index()
        {
            var members = _context.Members.ToList();
            return View(members);
        }

        // GET: Members/Details/dlewis
        public ViewResult Details(string user_id)
        {
            var member = _context.Members.Where(m => m.MemberUserId == user_id).FirstOrDefault();
            return View(member);
        }

        // GET: Members/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Members/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                var member = new Member();
                UpdateModel<Member>(member);
                _context.Members.Add(member);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Members/Edit/5
        public ActionResult Edit(string user_id)
        {
            var member = _context.Members.Where(m => m.MemberUserId == user_id).FirstOrDefault();
            return View(member);
        }

        // POST: Members/Edit/5
        [HttpPost]
        public ActionResult Edit(string user_id, FormCollection collection)
        {
            try
            {
                var member = _context.Members.Where(m => m.MemberUserId == user_id).FirstOrDefault();
                UpdateModel<Member>(member);
                _context.SaveChanges();

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Members/Delete/5
        public ActionResult Delete(string user_id)
        {
            var member = _context.Members.Where(m => m.MemberUserId == user_id).FirstOrDefault();
            return View(member);
        }

        // POST: Members/Delete/5
        [HttpPost]
        public ActionResult Delete(string user_id, FormCollection collection)
        {
            try
            {
                var member = _context.Members.Where(m => m.MemberUserId == user_id).FirstOrDefault();
                _context.Members.Remove(member);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
