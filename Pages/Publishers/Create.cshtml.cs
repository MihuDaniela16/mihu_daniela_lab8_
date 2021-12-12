using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using mihu_daniela_lab8_.Data;
using mihu_daniela_lab8_.Models;

namespace mihu_daniela_lab8_.Pages.Publishers
{
    public class CreateModel : PageModel
    {
        private readonly mihu_daniela_lab8_.Data.mihu_daniela_lab8_Context _context;

        public CreateModel(mihu_daniela_lab8_.Data.mihu_daniela_lab8_Context context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Publisher Publisher { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Publisher.Add(Publisher);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
