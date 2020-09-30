using FARegistryWEB.Data;
using FARegistryWEB.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace FARegistryWEB.Pages
{
    public class TestPageModel : PageModel
    {
        private readonly RegistryContext _db;

        public TestPageModel(RegistryContext db)
        {
            _db = db;
        }
        [BindProperty(SupportsGet = true)]
        public string SearchString { get; set; }

        [BindProperty(SupportsGet = true)]
        public bool ShowMap { get; set; } = true;
        public string CurrentFilter { get; set; }
        public IEnumerable<RegistryRecord> RegistryRecords { get; set; }

        public async Task OnGetAsync(string SearchString)
        {


            var registryrecords = from s in _db.RegistryRecords
                                  select s;


            if (!string.IsNullOrEmpty(SearchString))

            {

                RegistryRecords = registryrecords.Where(s => s.TitleTitre.Contains(SearchString)
                                              || s.ProjectDescDescduprojet.Contains(SearchString)
                                              || s.ProponentOrganization.Contains(SearchString)
                                              || s.ProvinceTerritory.Contains(SearchString)
                                              || s.REGION.Contains(SearchString));

            }
            else

                RegistryRecords = await registryrecords.ToListAsync();
        }
    }
}