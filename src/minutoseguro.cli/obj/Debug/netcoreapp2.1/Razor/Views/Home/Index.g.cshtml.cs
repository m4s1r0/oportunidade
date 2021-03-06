#pragma checksum "C:\wwwroot\minutoseguros\src\minutoseguro.cli\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "50c09e39b91ddc537f8c71b60408d367e23ef26e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
#line 1 "C:\wwwroot\minutoseguros\src\minutoseguro.cli\Views\_ViewImports.cshtml"
using minutoseguro.cli;

#line default
#line hidden
#line 2 "C:\wwwroot\minutoseguros\src\minutoseguro.cli\Views\_ViewImports.cshtml"
using minutoseguro.cli.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"50c09e39b91ddc537f8c71b60408d367e23ef26e", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7c3595339a562807462d0dddcadbc843f6674a2e", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<PostViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(35, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
#line 4 "C:\wwwroot\minutoseguros\src\minutoseguro.cli\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
            BeginContext(84, 479, true);
            WriteLiteral(@"
<div class=""jumbotron"">
    <h1>Feeds Minuto Seguros</h1>
    <p>Esta é a quantificação das 10 palavras mais correntes nos posts do blog https://www.minutoseguros.com.br/blog</p>
    <a class=""btn btn-primary"" href=""https://www.minutoseguros.com.br/blog"">Visitar o blog <span class=""glyphicon glyphicon-link""></span></a>
</div>

<div class=""row"">
    <div class=""col-md-12"">
        <h2>Postagens</h2>
        <table class=""table table-striped"">
            <tbody>
");
            EndContext();
#line 19 "C:\wwwroot\minutoseguros\src\minutoseguro.cli\Views\Home\Index.cshtml"
                  
                    foreach (var post in Model)
                    {
                        var g = Guid.NewGuid().ToString();
                        var headerPnlId = "header-" + g;
                        var wordsPnlId = "words-" + g;
                        

#line default
#line hidden
            BeginContext(859, 114, true);
            WriteLiteral("\r\n                            <tr>\r\n                                <td>\r\n                                    <h4>");
            EndContext();
            BeginContext(974, 10, false);
#line 28 "C:\wwwroot\minutoseguros\src\minutoseguro.cli\Views\Home\Index.cshtml"
                                   Write(post.Title);

#line default
#line hidden
            EndContext();
            BeginContext(984, 157, true);
            WriteLiteral("</h4>\r\n                                    <div>\r\n                                        <span class=\"glyphicon glyphicon-time\"></span> Data da publicação: ");
            EndContext();
            BeginContext(1142, 45, false);
#line 30 "C:\wwwroot\minutoseguros\src\minutoseguro.cli\Views\Home\Index.cshtml"
                                                                                                      Write(post.PublishDate.ToString("dd/MM/yyyy hh:mm"));

#line default
#line hidden
            EndContext();
            BeginContext(1187, 532, true);
            WriteLiteral(@"
                                    </div>
                                    <div class=""panel-group"" id=""accordion"" role=""tablist"" aria-multiselectable=""true"">
                                        <div class=""panel panel-default"">
                                            <div class=""panel-heading"" role=""tab"" id=""headingOne"">
                                                <h4 class=""panel-title"">
                                                    <a role=""button"" data-toggle=""collapse"" data-parent=""#accordion""");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1719, "\"", 1739, 2);
            WriteAttributeValue("", 1726, "#", 1726, 1, true);
#line 36 "C:\wwwroot\minutoseguros\src\minutoseguro.cli\Views\Home\Index.cshtml"
WriteAttributeValue("", 1727, headerPnlId, 1727, 12, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1740, 178, true);
            WriteLiteral(" aria-expanded=\"false\" aria-controls=\"collapseOne\">\r\n                                                        <span class=\"glyphicon glyphicon-align-left\"></span> Texto - <strong>");
            EndContext();
            BeginContext(1919, 21, false);
#line 37 "C:\wwwroot\minutoseguros\src\minutoseguro.cli\Views\Home\Index.cshtml"
                                                                                                                        Write(post.Summary.QtdWords);

#line default
#line hidden
            EndContext();
            BeginContext(1940, 235, true);
            WriteLiteral(" palavra(s)</strong>\r\n                                                    </a>\r\n                                                </h4>\r\n                                            </div>\r\n                                            <div");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 2175, "\"", 2192, 1);
#line 41 "C:\wwwroot\minutoseguros\src\minutoseguro.cli\Views\Home\Index.cshtml"
WriteAttributeValue("", 2180, headerPnlId, 2180, 12, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2193, 206, true);
            WriteLiteral(" class=\"panel-collapse collapse\" role=\"tabpanel\" aria-labelledby=\"headingOne\">\r\n                                                <div class=\"panel-body\">\r\n                                                    ");
            EndContext();
            BeginContext(2400, 22, false);
#line 43 "C:\wwwroot\minutoseguros\src\minutoseguro.cli\Views\Home\Index.cshtml"
                                               Write(Html.Raw(post.Content));

#line default
#line hidden
            EndContext();
            BeginContext(2422, 57, true);
            WriteLiteral("\r\n                                                    <p>");
            EndContext();
            BeginContext(2480, 12, false);
#line 44 "C:\wwwroot\minutoseguros\src\minutoseguro.cli\Views\Home\Index.cshtml"
                                                  Write(post.Creator);

#line default
#line hidden
            EndContext();
            BeginContext(2492, 63, true);
            WriteLiteral("</p>\r\n                                                    <p><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 2555, "\"", 2572, 1);
#line 45 "C:\wwwroot\minutoseguros\src\minutoseguro.cli\Views\Home\Index.cshtml"
WriteAttributeValue("", 2562, post.Link, 2562, 10, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2573, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(2575, 9, false);
#line 45 "C:\wwwroot\minutoseguros\src\minutoseguro.cli\Views\Home\Index.cshtml"
                                                                       Write(post.Link);

#line default
#line hidden
            EndContext();
            BeginContext(2584, 549, true);
            WriteLiteral(@"</a></p>
                                                </div>
                                            </div>
                                        </div>
                                        <div class=""panel panel-default"">
                                            <div class=""panel-heading"" role=""tab"" id=""headingTwo"">
                                                <h4 class=""panel-title"">
                                                    <a class=""collapsed"" role=""button"" data-toggle=""collapse"" data-parent=""#accordion""");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 3133, "\"", 3152, 2);
            WriteAttributeValue("", 3140, "#", 3140, 1, true);
#line 52 "C:\wwwroot\minutoseguros\src\minutoseguro.cli\Views\Home\Index.cshtml"
WriteAttributeValue("", 3141, wordsPnlId, 3141, 11, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3153, 390, true);
            WriteLiteral(@" aria-expanded=""false"" aria-controls=""collapseTwo"">
                                                        <span class=""glyphicon glyphicon-tags""></span> Principais palavras
                                                    </a>
                                                </h4>
                                            </div>
                                            <div");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 3543, "\"", 3559, 1);
#line 57 "C:\wwwroot\minutoseguros\src\minutoseguro.cli\Views\Home\Index.cshtml"
WriteAttributeValue("", 3548, wordsPnlId, 3548, 11, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3560, 240, true);
            WriteLiteral(" class=\"panel-collapse collapse\" role=\"tabpanel\" aria-labelledby=\"headingTwo\">\r\n                                                <div class=\"panel-body\">\r\n                                                    <ul class=\"list-group col-sm-4\">\r\n");
            EndContext();
#line 60 "C:\wwwroot\minutoseguros\src\minutoseguro.cli\Views\Home\Index.cshtml"
                                                          
                                                        foreach (var w in post.Summary.Words)
                                                        {
                                                            

#line default
#line hidden
            BeginContext(4080, 176, true);
            WriteLiteral("\r\n                                                            <li class=\"list-group-item\">\r\n                                                                <span class=\"badge\">");
            EndContext();
            BeginContext(4257, 13, false);
#line 65 "C:\wwwroot\minutoseguros\src\minutoseguro.cli\Views\Home\Index.cshtml"
                                                                               Write(w.Occurrences);

#line default
#line hidden
            EndContext();
            BeginContext(4270, 73, true);
            WriteLiteral("</span>\r\n                                                                ");
            EndContext();
            BeginContext(4344, 7, false);
#line 66 "C:\wwwroot\minutoseguros\src\minutoseguro.cli\Views\Home\Index.cshtml"
                                                           Write(w.Value);

#line default
#line hidden
            EndContext();
            BeginContext(4351, 101, true);
            WriteLiteral("\r\n                                                            </li>\r\n                                ");
            EndContext();
#line 68 "C:\wwwroot\minutoseguros\src\minutoseguro.cli\Views\Home\Index.cshtml"
                                       
                            }
                                                        

#line default
#line hidden
            BeginContext(4551, 359, true);
            WriteLiteral(@"
                                                    </ul>
                                                </div>
                                            </div>
                                        </div>
                                    </div>
                                </td>
                            </tr>
                        ");
            EndContext();
#line 79 "C:\wwwroot\minutoseguros\src\minutoseguro.cli\Views\Home\Index.cshtml"
                               
                    }
                

#line default
#line hidden
            BeginContext(4961, 60, true);
            WriteLiteral("            </tbody>\r\n        </table>\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<PostViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
