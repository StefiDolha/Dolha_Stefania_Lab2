using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Dolha_Stefania_Lab2.Data;
using Dolha_Stefania_Lab2.Models;

namespace Dolha_Stefania_Lab2.Pages.Publishers
{
    public class IndexModel : PageModel
    {
        private readonly Dolha_Stefania_Lab2.Data.Dolha_Stefania_Lab2Context _context;

        public IndexModel(Dolha_Stefania_Lab2.Data.Dolha_Stefania_Lab2Context context)
        {
            _context = context;
        }

        public IList<Publisher> Publisher { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Publisher = await _context.Publisher.ToListAsync();
        }
    }
}
