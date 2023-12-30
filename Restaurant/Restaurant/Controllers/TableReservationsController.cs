using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Restaurant.Data;
using Restaurant.Models;

namespace Restaurant.Controllers
{
    public class TableReservationsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public TableReservationsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: TableReservations
        public async Task<IActionResult> Index()
        {
              return _context.TableReservations != null ? 
                          View(await _context.TableReservations.ToListAsync()) :
                          Problem("Entity set 'ApplicationDbContext.TableReservations'  is null.");
        }

        // GET: TableReservations/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.TableReservations == null)
            {
                return NotFound();
            }

            var tableReservation = await _context.TableReservations
                .FirstOrDefaultAsync(m => m.ID == id);
            if (tableReservation == null)
            {
                return NotFound();
            }

            return View(tableReservation);
        }

        // GET: TableReservations/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tableReservation = await _context.TableReservations
                .FirstOrDefaultAsync(m => m.ID == id);
            if (tableReservation == null)
            {
                return NotFound();
            }

            return View(tableReservation);
        }

        // POST: TableReservations/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var tableReservation = await _context.TableReservations.FindAsync(id);
            if (tableReservation.ActiveOrDiActive == true)
            {
                tableReservation.ActiveOrDiActive = false;
                _context.Update(tableReservation);
                await _context.SaveChangesAsync();
                //sendemail
                //EmailSend emailSend = new EmailSend();

                //try
                //{
                //    await emailSend.SendEmailAsync(reserveMiz.Email, "کنسل رزرو شما در رستوران", " کاربر محترم " + reserveMiz.NameFamily + " رزروشما  در تاریخ " + reserveMiz.Date + " کنسل گردید با عرض پوزش.");
                //    return RedirectToAction(nameof(Index));
                //}
                //catch
                //{
                    return RedirectToAction(nameof(Index));
                //}
            }
            else
            {
                tableReservation.ActiveOrDiActive = true;
                _context.Update(tableReservation);
                await _context.SaveChangesAsync();
                //sendemail
                //EmailSend emailSend = new EmailSend();
                //try
                //{
                //    await emailSend.SendEmailAsync(reserveMiz.Email, "تایید رزرو شما در رستوران", " کاربر محترم " + reserveMiz.NameFamily + " رزروشما  در تاریخ " + reserveMiz.Date + " تایید گردید  باتشکر.");
                //    return RedirectToAction(nameof(Index));
                //}
                //catch
                //{
                    return RedirectToAction(nameof(Index));
                //}
            }
        }

        private bool TableReservationExists(int id)
        {
          return (_context.TableReservations?.Any(e => e.ID == id)).GetValueOrDefault();
        }
    }
}
