using Microsoft.AspNetCore.Razor.TagHelpers;

namespace MVCpractices.TagHelpers
{
    public class ImageViewDetails : TagHelper
    {
        public string src { get; set; } = "";
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "img";
            output.TagMode = TagMode.SelfClosing;
            output.Attributes.SetAttribute("src", src);
            output.Attributes.SetAttribute("class", "Booksize");
            output.Attributes.SetAttribute("title", "");
        }
    }
}
