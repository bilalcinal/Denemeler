#pragma checksum "C:\Users\hbila\OneDrive\Masaüstü\Udemy kurs\UdemyNet\Views\Shared\Components\News\red.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b65808b343a12661f2af24cddd3a9dee54e0a9bb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_News_red), @"mvc.1.0.view", @"/Views/Shared/Components/News/red.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 3 "C:\Users\hbila\OneDrive\Masaüstü\Udemy kurs\UdemyNet\Views\_ViewImports.cshtml"
using UdemyNet.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\hbila\OneDrive\Masaüstü\Udemy kurs\UdemyNet\Views\_ViewImports.cshtml"
using System.IO;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b65808b343a12661f2af24cddd3a9dee54e0a9bb", @"/Views/Shared/Components/News/red.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e66128e475887d8cb7dc6cba5fa917702ac5b718", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared_Components_News_red : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<News>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<ul class=\"list-group\">\r\n\r\n");
#nullable restore
#line 5 "C:\Users\hbila\OneDrive\Masaüstü\Udemy kurs\UdemyNet\Views\Shared\Components\News\red.cshtml"
      foreach (var item in Model)
     {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <li class=\"list-group-item  text-danger\" aria-current=\"true\">");
#nullable restore
#line 7 "C:\Users\hbila\OneDrive\Masaüstü\Udemy kurs\UdemyNet\Views\Shared\Components\News\red.cshtml"
                                                                Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n");
#nullable restore
#line 8 "C:\Users\hbila\OneDrive\Masaüstü\Udemy kurs\UdemyNet\Views\Shared\Components\News\red.cshtml"
     }

#line default
#line hidden
#nullable disable
            WriteLiteral("        \r\n</ul>");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<News>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
