#pragma checksum "/Users/vishal/Documents/source/repos/DeveloperMovieProject/DeveloperMovieProject/Views/Movie/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b276e306e7c8bbcf5f422117994b8e5d9ff5b805"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(DeveloperMovieProject.Views.Movie.Views_Movie_Index), @"mvc.1.0.view", @"/Views/Movie/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Movie/Index.cshtml", typeof(DeveloperMovieProject.Views.Movie.Views_Movie_Index))]
namespace DeveloperMovieProject.Views.Movie
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b276e306e7c8bbcf5f422117994b8e5d9ff5b805", @"/Views/Movie/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f40b34b6e599a190af8d7486703304aa15ddd2f5", @"/Views/_ViewImports.cshtml")]
    public class Views_Movie_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<DeveloperMovieProject.Models.Movie>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(63, 23, true);
            WriteLiteral("\r\n<h1>Movies</h1>\r\n<h2>");
            EndContext();
            BeginContext(87, 17, false);
#line 6 "/Users/vishal/Documents/source/repos/DeveloperMovieProject/DeveloperMovieProject/Views/Movie/Index.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(104, 13, true);
            WriteLiteral("</h2>\r\n<ul>\r\n");
            EndContext();
#line 8 "/Users/vishal/Documents/source/repos/DeveloperMovieProject/DeveloperMovieProject/Views/Movie/Index.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
            BeginContext(158, 29, true);
            WriteLiteral("        <li>\r\n            <p>");
            EndContext();
            BeginContext(188, 10, false);
#line 11 "/Users/vishal/Documents/source/repos/DeveloperMovieProject/DeveloperMovieProject/Views/Movie/Index.cshtml"
          Write(item.Title);

#line default
#line hidden
            EndContext();
            BeginContext(198, 2, true);
            WriteLiteral(" (");
            EndContext();
            BeginContext(201, 9, false);
#line 11 "/Users/vishal/Documents/source/repos/DeveloperMovieProject/DeveloperMovieProject/Views/Movie/Index.cshtml"
                       Write(item.Year);

#line default
#line hidden
            EndContext();
            BeginContext(210, 22, true);
            WriteLiteral(")</p>\r\n        </li>\r\n");
            EndContext();
#line 13 "/Users/vishal/Documents/source/repos/DeveloperMovieProject/DeveloperMovieProject/Views/Movie/Index.cshtml"
    }

#line default
#line hidden
            BeginContext(239, 7, true);
            WriteLiteral("</ul>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<DeveloperMovieProject.Models.Movie>> Html { get; private set; }
    }
}
#pragma warning restore 1591
