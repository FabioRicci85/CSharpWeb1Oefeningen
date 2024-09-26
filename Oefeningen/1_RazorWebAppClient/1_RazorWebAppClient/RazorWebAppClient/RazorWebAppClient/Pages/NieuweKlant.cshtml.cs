using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorWebAppClient.Pages
{
    public class NieuweKlantModel : PageModel
    {
        public void OnGet()
        {
        }
        public void OnPost()
        {
            string naam = Request.Form["KlantNaam"];
            int idLocatie = int.Parse(Request.Form["SelectLocatie"]);
            Data.Databank.AddKlant(naam, idLocatie);
            Response.Redirect("KlantenLocatieOverzicht");
        }
    }
}
