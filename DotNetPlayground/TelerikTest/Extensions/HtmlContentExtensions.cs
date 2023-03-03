using Microsoft.AspNetCore.Html;
using System.Text.Encodings.Web;

namespace TelerikTest.Extensions;

public static class HtmlContentExtensions
{
    public static string ToHtmlString(this IHtmlContent content)
    {
        using StringWriter writer = new();
        content.WriteTo(writer, HtmlEncoder.Default);

        return writer.ToString();
    }
}
