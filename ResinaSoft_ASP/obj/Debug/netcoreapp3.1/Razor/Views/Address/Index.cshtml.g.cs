#pragma checksum "C:\Users\YusufPC\source\repos\ResinaSoft_asp\ResinaSoft_ASP\Views\Address\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e39d6ef85d35f70c56943535de47a4ccd7fbe70d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Address_Index), @"mvc.1.0.view", @"/Views/Address/Index.cshtml")]
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
#line 1 "C:\Users\YusufPC\source\repos\ResinaSoft_asp\ResinaSoft_ASP\Views\_ViewImports.cshtml"
using ResinaSoft_ASP;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\YusufPC\source\repos\ResinaSoft_asp\ResinaSoft_ASP\Views\_ViewImports.cshtml"
using ResinaSoft_ASP.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e39d6ef85d35f70c56943535de47a4ccd7fbe70d", @"/Views/Address/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9b42d9c5188907e4198189e46476981cb9e19e3e", @"/Views/_ViewImports.cshtml")]
    public class Views_Address_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ResinaSoft_ASP.ViewModels.AddressViewModel.AddressViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\YusufPC\source\repos\ResinaSoft_asp\ResinaSoft_ASP\Views\Address\Index.cshtml"
  
    Layout = "~/Views/Shared/_Layout.cshtml";
    ViewData["Title"] = "Address Of The Person";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>");
#nullable restore
#line 8 "C:\Users\YusufPC\source\repos\ResinaSoft_asp\ResinaSoft_ASP\Views\Address\Index.cshtml"
Write(ViewBag.PersonName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n<hr/>\r\n<br />\r\n<a class=\"upButtonPerson\">\r\n    ");
#nullable restore
#line 12 "C:\Users\YusufPC\source\repos\ResinaSoft_asp\ResinaSoft_ASP\Views\Address\Index.cshtml"
Write(Html.ActionLink("Add New Address", "Create", new { id = ViewBag.PersonId }, new { @class = "upButtonPerson" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</a>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n\r\n            <th>\r\n                ");
#nullable restore
#line 19 "C:\Users\YusufPC\source\repos\ResinaSoft_asp\ResinaSoft_ASP\Views\Address\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.AddressType));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 22 "C:\Users\YusufPC\source\repos\ResinaSoft_asp\ResinaSoft_ASP\Views\Address\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 25 "C:\Users\YusufPC\source\repos\ResinaSoft_asp\ResinaSoft_ASP\Views\Address\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.CityId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 28 "C:\Users\YusufPC\source\repos\ResinaSoft_asp\ResinaSoft_ASP\Views\Address\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Address));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 35 "C:\Users\YusufPC\source\repos\ResinaSoft_asp\ResinaSoft_ASP\Views\Address\Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n\r\n            <td>\r\n                ");
#nullable restore
#line 40 "C:\Users\YusufPC\source\repos\ResinaSoft_asp\ResinaSoft_ASP\Views\Address\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.AddressType));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 43 "C:\Users\YusufPC\source\repos\ResinaSoft_asp\ResinaSoft_ASP\Views\Address\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 46 "C:\Users\YusufPC\source\repos\ResinaSoft_asp\ResinaSoft_ASP\Views\Address\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.CityId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 49 "C:\Users\YusufPC\source\repos\ResinaSoft_asp\ResinaSoft_ASP\Views\Address\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Address));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td class=\"otherAction\">\r\n                ");
#nullable restore
#line 52 "C:\Users\YusufPC\source\repos\ResinaSoft_asp\ResinaSoft_ASP\Views\Address\Index.cshtml"
           Write(Html.ActionLink("Edit", "Edit", new { id = item.Id }, new { @class = "otherAction" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td class=\"otherAction\">\r\n                ");
#nullable restore
#line 55 "C:\Users\YusufPC\source\repos\ResinaSoft_asp\ResinaSoft_ASP\Views\Address\Index.cshtml"
           Write(Html.ActionLink("Delete", "Delete", new { id = item.Id }, new { @class = "otherAction" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 58 "C:\Users\YusufPC\source\repos\ResinaSoft_asp\ResinaSoft_ASP\Views\Address\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ResinaSoft_ASP.ViewModels.AddressViewModel.AddressViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
