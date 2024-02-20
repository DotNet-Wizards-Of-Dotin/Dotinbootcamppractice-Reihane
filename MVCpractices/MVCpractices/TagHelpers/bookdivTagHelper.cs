using Microsoft.AspNetCore.Razor.TagHelpers;

namespace MVCpractices.TagHelpers
{
    public class bookdivTagHelper : TagHelper
    {
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "div";
            output.TagMode = TagMode.StartTagAndEndTag;
            output.Attributes.SetAttribute("class","info");
        }



    }
}