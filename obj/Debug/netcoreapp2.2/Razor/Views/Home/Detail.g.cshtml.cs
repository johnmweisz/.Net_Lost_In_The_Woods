#pragma checksum "/Users/johnweisz/Desktop/C#/LostInTheWoods/Views/Home/Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c68cd613c4c881f27c49ec90be0ba593e423838b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Detail), @"mvc.1.0.view", @"/Views/Home/Detail.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Detail.cshtml", typeof(AspNetCore.Views_Home_Detail))]
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
#line 1 "/Users/johnweisz/Desktop/C#/LostInTheWoods/Views/_ViewImports.cshtml"
using LostInTheWoods;

#line default
#line hidden
#line 2 "/Users/johnweisz/Desktop/C#/LostInTheWoods/Views/_ViewImports.cshtml"
using LostInTheWoods.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c68cd613c4c881f27c49ec90be0ba593e423838b", @"/Views/Home/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5b9ba960125634dc0fdf3d0e3fb0f83ed2ab9064", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<LostInTheWoods.Models.Trail>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(38, 19, true);
            WriteLiteral("    <p>Trail Name: ");
            EndContext();
            BeginContext(58, 10, false);
#line 3 "/Users/johnweisz/Desktop/C#/LostInTheWoods/Views/Home/Detail.cshtml"
              Write(Model.Name);

#line default
#line hidden
            EndContext();
            BeginContext(68, 25, true);
            WriteLiteral("</p>\n    <p>Description: ");
            EndContext();
            BeginContext(94, 17, false);
#line 4 "/Users/johnweisz/Desktop/C#/LostInTheWoods/Views/Home/Detail.cshtml"
               Write(Model.Description);

#line default
#line hidden
            EndContext();
            BeginContext(111, 20, true);
            WriteLiteral("</p>\n    <p>Length: ");
            EndContext();
            BeginContext(132, 12, false);
#line 5 "/Users/johnweisz/Desktop/C#/LostInTheWoods/Views/Home/Detail.cshtml"
          Write(Model.Length);

#line default
#line hidden
            EndContext();
            BeginContext(144, 28, true);
            WriteLiteral(" Miles</p>\n    <p>Altitude: ");
            EndContext();
            BeginContext(173, 15, false);
#line 6 "/Users/johnweisz/Desktop/C#/LostInTheWoods/Views/Home/Detail.cshtml"
            Write(Model.Elevation);

#line default
#line hidden
            EndContext();
            BeginContext(188, 35, true);
            WriteLiteral(" change in Feet.</p>\n    <p>Added: ");
            EndContext();
            BeginContext(224, 16, false);
#line 7 "/Users/johnweisz/Desktop/C#/LostInTheWoods/Views/Home/Detail.cshtml"
         Write(Model.Created_At);

#line default
#line hidden
            EndContext();
            BeginContext(240, 30, true);
            WriteLiteral("</p>\n    <a href=\"/\">Back</a>\n");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<LostInTheWoods.Models.Trail> Html { get; private set; }
    }
}
#pragma warning restore 1591
