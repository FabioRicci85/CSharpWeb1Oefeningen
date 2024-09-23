using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorWebAppClient.Pages
{
    public class NieuweLocatieModel : PageModel
    {
        public void OnGet()
        {
        }
        public void OnPost() 
        {
            string postcode = Request.Form["PostCode"];
            string city = Request.Form["Gemeente"];
            Data.Databank.AddLocation(postcode, city);
            Response.Redirect("Locaties");
        }
    }
}
