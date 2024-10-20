using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Razor.Runtime.TagHelpers;
using Microsoft.AspNetCore.Razor.TagHelpers;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using MVCSportStore.ViewModels;

namespace MVCSportStore.TagHelpers
{
    // You may need to install the Microsoft.AspNetCore.Razor.Runtime package into your project
    [HtmlTargetElement(Attributes = "paging-info")]
    public class PageLinkTagHelper : TagHelper
    {
        public PagingInfo PagingInfo{ get; set; }
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "div";
            output.Content.SetHtmlContent(UnorderedList());
        }

       

        private TagBuilder UnorderedList()
        {
            var tag = new TagBuilder("ul");
            tag.Attributes["class"] = "pagination";
            for (int i = 1; i < PagingInfo.PageItems; i++)
            {
                tag.InnerHtml.AppendHtml(ListItem(i));
            }
            return tag;
        }

        private TagBuilder ListItem(int page)
        {
            var tag = new TagBuilder("li");
            tag.Attributes["class"] = "page-item";
            tag.InnerHtml.AppendHtml(HyperLink(page));
            return tag;
        }

        private TagBuilder HyperLink(int page)
        {
            var defaultLink = "btn border border-primary";
            var secundaryLink = "btn border border-secondary";
            var tag = new TagBuilder("a");
            tag.Attributes["class"] = (page == PagingInfo.CurrentPage) ? defaultLink : secundaryLink;
            tag.Attributes["href"] = $"/Home/Index/{page}";
            tag.InnerHtml.Append(page.ToString());
            return tag;
        }


    }
}
