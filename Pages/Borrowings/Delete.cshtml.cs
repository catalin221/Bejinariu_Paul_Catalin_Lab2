﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Bejinariu_Paul_Catalin_Lab2.Data;
using Bejinariu_Paul_Catalin_Lab2.Models;

namespace Bejinariu_Paul_Catalin_Lab2.Pages.Borrowings
{
    public class DeleteModel : PageModel
    {
        private readonly Bejinariu_Paul_Catalin_Lab2.Data.Bejinariu_Paul_Catalin_Lab2Context _context;

        public DeleteModel(Bejinariu_Paul_Catalin_Lab2.Data.Bejinariu_Paul_Catalin_Lab2Context context)
        {
            _context = context;
        }

        [BindProperty]
      public Borrowing Borrowing { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Borrowing == null)
            {
                return NotFound();
            }

            var borrowing = await _context.Borrowing.
                Include(b => b.Member).
                Include(b => b.Book).
                FirstOrDefaultAsync(m => m.ID == id);

            if (borrowing == null)
            {
                return NotFound();
            }
            else 
            {
                Borrowing = borrowing;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null || _context.Borrowing == null)
            {
                return NotFound();
            }
            var borrowing = await _context.Borrowing.FindAsync(id);

            if (borrowing != null)
            {
                Borrowing = borrowing;
                _context.Borrowing.Remove(Borrowing);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
