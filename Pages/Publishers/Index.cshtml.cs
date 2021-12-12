using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using mihu_daniela_lab8_.Data;
using mihu_daniela_lab8_.Models;

namespace mihu_daniela_lab8_.Pages.Publishers
{
    public class IndexModel : PageModel
    {
        private readonly mihu_daniela_lab8_.Data.mihu_daniela_lab8_Context _context;

        public IndexModel(mihu_daniela_lab8_.Data.mihu_daniela_lab8_Context context)
        {
            _context = context;
        }

        public IList<Publisher> Publisher { get;set; }
        public List<Book> Book { get; private set; }
        public async Task OnGetAsync()
        {
            Book = await _context.Book
                .Include(b => b.Publisher)
                .ToListAsync();
        }
    }
}
