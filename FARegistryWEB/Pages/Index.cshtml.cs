
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
    public class IndexModel : PageModel
    {
        private readonly RegistryContext _db;

        public IndexModel(RegistryContext db)
        {
            _db = db;
        }
        [BindProperty(SupportsGet = true)]
        public string SearchString { get; set; }



        public string CurrentFilter { get; set; }


        public IEnumerable<RegistryRecord> RegistryRecords{ get; set; }


        public async Task OnGetAsync()
        {
            var registryRecords = from m in _db.RegistryRecords
                         select m;
            
            if (!string.IsNullOrEmpty(SearchString))
            {
                registryRecords = registryRecords.Where(s => s.TitleTitre.Contains(SearchString)
                                              || s.ProjectDescDescduprojet.Contains(SearchString)
                                              || s.ProponentOrganization.Contains(SearchString)
                                              || s.ProvinceTerritory.Contains(SearchString)
                                              || s.REGION.Contains(SearchString));
                //registryRecords = registryRecords.OrderBy(s => s.REGION);
            }

            RegistryRecords = await registryRecords.ToListAsync();
        }
    }
}