using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Razor.Runtime.TagHelpers;
using Microsoft.AspNetCore.Razor.TagHelpers;
using MVCTagHelper.ViewModels;

namespace MVCTagHelper.TagHelpers
{
    // You may need to install the Microsoft.AspNetCore.Razor.Runtime package into your project
    [HtmlTargetElement(Attributes = "medewerker-card-view-model")]
    public class MedewerkerCardTagHelper : TagHelper
    {
        public MedewerkerCard MedewerkerCardViewModel { get; set; }
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            string medewerker = $"Naam van de medewerker: {MedewerkerCardViewModel.MedewerkerNaam}";
            string afdeling = $"Afdeling: {MedewerkerCardViewModel.AfdelingNaam}";
            string medewerkerId = $"De medewerkerId: {MedewerkerCardViewModel.MedewerkerId}";

            output.TagName = "div";
            var tag = CardDiv(medewerker, afdeling, medewerkerId);
            output.Content.SetHtmlContent(tag);
        }

        private TagBuilder CardDiv(string title, string title2, string title3)
        {
            var tag = new TagBuilder("div");
            tag.InnerHtml.AppendHtml(CardH4(title));
            tag.InnerHtml.AppendHtml(CardP(title2));
            tag.InnerHtml.AppendHtml(CardP2(title3));
            return tag;
        }

        private TagBuilder CardH4(string title)
        {
            var tag = new TagBuilder("h4");
            tag.InnerHtml.Append(title);
            return tag;
        }

        private TagBuilder CardP(string title)
        {
            var tag = new TagBuilder("p");
            tag.Attributes["class"] = "card-position";
            tag.InnerHtml.Append(title);
            return tag;
        }

        private TagBuilder CardP2(string title)
        {
            var tag = new TagBuilder("p");
            tag.Attributes["class"] = "card-description";
            tag.InnerHtml.Append(title);
            return tag;
        }
    }
}
