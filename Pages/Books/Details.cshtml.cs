using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using mihu_daniela_lab8_.Data;
using mihu_daniela_lab8_.Models;

namespace mihu_daniela_lab8_.Pages.Books
{
    public class DetailsModel : PageModel
    {
        private readonly mihu_daniela_lab8_.Data.mihu_daniela_lab8_Context _context;

        public DetailsModel(mihu_daniela_lab8_.Data.mihu_daniela_lab8_Context context)
        {
            _context = context;
        }

        public Book Book { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Book = await _context.Book.FirstOrDefaultAsync(m => m.ID == id);

            if (Book == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
