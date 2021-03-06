﻿
using FARegistryWEB.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace FARegistryWEB.Pages
{
    public class ShowDetailsModel : PageModel
    {
        private readonly FARegistryWEB.Data.RegistryContext _context;

        public ShowDetailsModel(FARegistryWEB.Data.RegistryContext context)
        {
            _context = context;
        }

        public RegistryRecord RegistryRecord { get; set; }
        public bool ShowMap { get; set; }
        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            RegistryRecord = await _context.RegistryRecords.FirstOrDefaultAsync(m => m.Id == id);

            if (RegistryRecord == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
