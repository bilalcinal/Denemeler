#pragma checksum "C:\Users\hbila\OneDrive\Masaüstü\Udemy kurs\UdemyNet\Views\Folder\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c6c3f2544104ce8818671db2e6dff0fcb43144ec"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Folder_List), @"mvc.1.0.view", @"/Views/Folder/List.cshtml")]
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
#line 2 "C:\Users\hbila\OneDrive\Masaüstü\Udemy kurs\UdemyNet\Views\_ViewImports.cshtml"
using UdemyNet.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\hbila\OneDrive\Masaüstü\Udemy kurs\UdemyNet\Views\_ViewImports.cshtml"
using System.IO;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c6c3f2544104ce8818671db2e6dff0fcb43144ec", @"/Views/Folder/List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2e8fb1786d09c0dbb50b1156d8deb94ce26a67aa", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Folder_List : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DirectoryInfo[]>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\hbila\OneDrive\Masaüstü\Udemy kurs\UdemyNet\Views\Folder\List.cshtml"
  
    Layout= "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("<table>\r\n       <thead> \r\n        <tr>\r\n           <th>Ad</th>\r\n           <th>Oluşturulma Zamanı </th>\r\n           <th>Path</th>\r\n        </tr>\r\n        </thead>\r\n       <tbody>\r\n");
#nullable restore
#line 14 "C:\Users\hbila\OneDrive\Masaüstü\Udemy kurs\UdemyNet\Views\Folder\List.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n           <td>");
#nullable restore
#line 17 "C:\Users\hbila\OneDrive\Masaüstü\Udemy kurs\UdemyNet\Views\Folder\List.cshtml"
          Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n           <td>");
#nullable restore
#line 18 "C:\Users\hbila\OneDrive\Masaüstü\Udemy kurs\UdemyNet\Views\Folder\List.cshtml"
          Write(item.CreationTime);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n           <td>");
#nullable restore
#line 19 "C:\Users\hbila\OneDrive\Masaüstü\Udemy kurs\UdemyNet\Views\Folder\List.cshtml"
          Write(item.FullName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>   \r\n");
#nullable restore
#line 21 "C:\Users\hbila\OneDrive\Masaüstü\Udemy kurs\UdemyNet\Views\Folder\List.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n      \r\n      \r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DirectoryInfo[]> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
