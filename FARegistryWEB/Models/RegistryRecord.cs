using System.ComponentModel.DataAnnotations;

namespace FARegistryWEB.Models
{
    public class RegistryRecord
    {

        public int Id { get; set; }

        [Display(Name = "Path Number")]
        public string PATHNoNoduSAPH { get; set; }

        [Display(Name = "Title")]
        public string TitleTitre { get; set; }
        [Display(Name = "Province / Territory")]
        public string ProvinceTerritory { get; set; }
        public string ProvinceTerritoire { get; set; }
        [Display(Name = "Latitude")]
        public string LatitudeLatitude { get; set; }
        [Display(Name = "Longitiude")]
        public string LongitudeLongitude { get; set; }
        [Display(Name = "Watershed")]
        public string WatershedNomduBassin { get; set; }
        [Display(Name = "Primary Work")]
        public string PrimaryWork { get; set; }

        public string Ouvrageprincipal { get; set; }
        [Display(Name = "Status")]
        public string Status { get; set; }

        public string Etat { get; set; }
        [Display(Name = "Proponent Organization")]
        public string ProponentOrganization { get; set; }

        public string PromoteurOrganisme { get; set; }
        [Display(Name = "Registry Contact")]
        public string RegistryContactduRegistre { get; set; }
        [Display(Name = "Registry ContactURL")]

        [Url]
        public string ContactURL { get; set; }

        public string URLdecontact { get; set; }
        [Display(Name = "Authorization Date")]
        public string AuthDateDatedeauth { get; set; }
        [Display(Name = "Effective Date")]
        public string EffectiveDateDateenvigueur { get; set; }
        [Display(Name = "Expiry Date")]
        public string ExpiryDateDatedexpire { get; set; }
        [Display(Name = "Authorization Type")]
        public string AuthorizationType { get; set; }

        public string Typedeauthorization { get; set; }
        [Display(Name = "Project Description")]
        public string ProjectDescDescduprojet { get; set; }
        [Display(Name = "Location Description")]
        public string LocationDescAutreinfogeo { get; set; }
        [Display(Name = "Federal Stakeholders")]
        public string FederalStakeholders { get; set; }
        public string Lespartiesprenantesfed { get; set; }
        [Display(Name = "Provincial  Stakeholders")]
        public string ProvincialStakeholders { get; set; }
        public string Lespartiesprenantesprov { get; set; }
        [Display(Name = "Program Activity")]
        public string ProgramActivity { get; set; }
        [Display(Name = "Region")]
        public string REGION { get; set; }

        public string RGION { get; set; }
    }

}

