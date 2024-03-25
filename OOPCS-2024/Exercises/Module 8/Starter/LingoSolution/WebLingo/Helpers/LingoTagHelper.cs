using LingoGame;
using Microsoft.AspNetCore.Razor.TagHelpers;
using WebLingo.Device;

namespace WebLingo.Helpers
{
    [HtmlTargetElement("lingo-word")]
    public class LingoTagHelper : TagHelper
    {
        public LingoWord? Word { get; set; }
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            WebDevice device = new WebDevice();
            output.TagName = "div";
            output.Attributes.Add("class", "word");
            Word?.Show(device);
            output.Content.SetHtmlContent(device.ToString());
        }
    }
}
