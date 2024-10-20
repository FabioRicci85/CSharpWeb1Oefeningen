using Microsoft.AspNetCore.Razor.Runtime.TagHelpers;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace MVCSportStore.TagHelpers
{
    // You may need to install the Microsoft.AspNetCore.Razor.Runtime package into your project
    [HtmlTargetElement(Attributes = "product-card-view-model")]
    public class ProductCardTagHelper : TagHelper
    {

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {

        }
    }
}
