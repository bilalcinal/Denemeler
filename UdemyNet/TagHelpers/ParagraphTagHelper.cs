using Microsoft.AspNetCore.Razor.TagHelpers;

namespace UdemyNet.TagHelpers
{
    [HtmlTargetElement("paragraph")]
    public class ParagraphTagHelper : TagHelper
    {
        public string ShortDescription { get; set; }
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {   
            output.Content.SetHtmlContent($"<b>Custom Tag Helper work{ShortDescription}</b>");
            base.Process(context, output);
        }
    }
}