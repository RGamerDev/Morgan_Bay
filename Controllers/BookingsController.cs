using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Morgan_Bay.Models;

namespace Morgan_Bay.Controllers
{
    [Route(""), Route("Home")]
    public class BookingsController : Controller
    {
        private readonly ILogger<BookingsController> _logger;

        private ResortContext _context;

        public BookingsController(ILogger<BookingsController> logger, ResortContext context)
        {
            _logger = logger;
            _context = context;
        }

        [HttpGet, Route(""), Route("Index")]
        public IActionResult Index()
        {
            return View(_context.bookings);
        }

        [HttpGet, Route("Create")]
        public IActionResult Create(int? BookingID, string? Booking_Date, int? Cust_ID, int? Room_Num)
        {
            if (BookingID != null || Booking_Date != null || Cust_ID != null || Room_Num != null)
            {
                _context.bookings.Add(new Booking()
                {
                    BookingID = BookingID ?? 0,
                    Booking_Date = Booking_Date ?? "Unknown",
                    Cust_ID = Cust_ID ?? 0,
                    Room_Num = Room_Num ?? 0
                });

                return RedirectToAction(nameof(Index));
            }

            return View();
        }

        [HttpGet, Route("Delete")]
        public IActionResult Delete(int id)
        {
            return View(_context.bookings.SingleOrDefault<Booking>(a => a.BookingID == id));
        }

        [HttpPost]
        public IActionResult DeleteBooking(int id)
        {
            _context.bookings.RemoveAt(id - 1);
            return View("Index", _context.bookings);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
