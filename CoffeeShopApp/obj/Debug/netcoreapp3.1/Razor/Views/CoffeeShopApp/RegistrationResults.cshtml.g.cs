#pragma checksum "C:\Users\there\source\repos\CoffeeShopApp\CoffeeShopApp\Views\CoffeeShopApp\RegistrationResults.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "613a7366d29a2cf7f0aed8fb0de12af5eea610c3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_CoffeeShopApp_RegistrationResults), @"mvc.1.0.view", @"/Views/CoffeeShopApp/RegistrationResults.cshtml")]
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
#line 1 "C:\Users\there\source\repos\CoffeeShopApp\CoffeeShopApp\Views\_ViewImports.cshtml"
using CoffeeShopApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\there\source\repos\CoffeeShopApp\CoffeeShopApp\Views\_ViewImports.cshtml"
using CoffeeShopApp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"613a7366d29a2cf7f0aed8fb0de12af5eea610c3", @"/Views/CoffeeShopApp/RegistrationResults.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"33479ae7daa2bc01bea2466d33dcc7c588e95329", @"/Views/_ViewImports.cshtml")]
    public class Views_CoffeeShopApp_RegistrationResults : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CoffeeShopApp.Models.CoffeeShopApp.RegistrationResultsViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<ul class=\"list-group\">\r\n");
#nullable restore
#line 8 "C:\Users\there\source\repos\CoffeeShopApp\CoffeeShopApp\Views\CoffeeShopApp\RegistrationResults.cshtml"
     foreach (var user in Model.Users)
     {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <li class=\"list-group-item\">\r\n            <p>Welcome: ");
#nullable restore
#line 11 "C:\Users\there\source\repos\CoffeeShopApp\CoffeeShopApp\Views\CoffeeShopApp\RegistrationResults.cshtml"
                   Write(user.UsersFirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 11 "C:\Users\there\source\repos\CoffeeShopApp\CoffeeShopApp\Views\CoffeeShopApp\RegistrationResults.cshtml"
                                        Write(user.UsersLastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        </li>\r\n");
#nullable restore
#line 13 "C:\Users\there\source\repos\CoffeeShopApp\CoffeeShopApp\Views\CoffeeShopApp\RegistrationResults.cshtml"
     }

#line default
#line hidden
#nullable disable
            WriteLiteral("</ul>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CoffeeShopApp.Models.CoffeeShopApp.RegistrationResultsViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
