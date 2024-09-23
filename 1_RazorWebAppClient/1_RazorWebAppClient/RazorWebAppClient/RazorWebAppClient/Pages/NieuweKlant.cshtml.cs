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
            Data.Databank.AddKlant(naam);
            Response.Redirect("KlantenLocatieOverzicht");
        }
    }
}
