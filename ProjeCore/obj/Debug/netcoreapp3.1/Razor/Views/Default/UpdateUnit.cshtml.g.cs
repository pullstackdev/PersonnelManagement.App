#pragma checksum "C:\Users\Guest_F\Desktop\studies\youtube\murat_yucedag_100derste_aspnetcoremvc\CoreDepartman\ProjeCore\Views\Default\UpdateUnit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "547b9c9e8d4f9e204fdedfaa0e9b5bbf5438f99c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Default_UpdateUnit), @"mvc.1.0.view", @"/Views/Default/UpdateUnit.cshtml")]
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
#line 1 "C:\Users\Guest_F\Desktop\studies\youtube\murat_yucedag_100derste_aspnetcoremvc\CoreDepartman\ProjeCore\Views\_ViewImports.cshtml"
using ProjeCore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Guest_F\Desktop\studies\youtube\murat_yucedag_100derste_aspnetcoremvc\CoreDepartman\ProjeCore\Views\_ViewImports.cshtml"
using ProjeCore.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"547b9c9e8d4f9e204fdedfaa0e9b5bbf5438f99c", @"/Views/Default/UpdateUnit.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7f6887fc2a081498e457a98abd035f4ecf5faaf7", @"/Views/_ViewImports.cshtml")]
    public class Views_Default_UpdateUnit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ProjeCore.Models.Birim>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Guest_F\Desktop\studies\youtube\murat_yucedag_100derste_aspnetcoremvc\CoreDepartman\ProjeCore\Views\Default\UpdateUnit.cshtml"
  
    ViewData["Title"] = "UpdateUnit";
    Layout = "~/Views/Shared/_TestLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n");
#nullable restore
#line 14 "C:\Users\Guest_F\Desktop\studies\youtube\murat_yucedag_100derste_aspnetcoremvc\CoreDepartman\ProjeCore\Views\Default\UpdateUnit.cshtml"
 using (Html.BeginForm("UpdateUnit", "Default", FormMethod.Post))
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <b>Unit ID</b>\r\n");
#nullable restore
#line 17 "C:\Users\Guest_F\Desktop\studies\youtube\murat_yucedag_100derste_aspnetcoremvc\CoreDepartman\ProjeCore\Views\Default\UpdateUnit.cshtml"
Write(Html.TextBoxFor(x => x.BirimID, new { @class = "form-control", @readonly="@readonly" } ));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n    <b>Unit Name</b>\r\n");
#nullable restore
#line 20 "C:\Users\Guest_F\Desktop\studies\youtube\murat_yucedag_100derste_aspnetcoremvc\CoreDepartman\ProjeCore\Views\Default\UpdateUnit.cshtml"
Write(Html.TextBoxFor(x => x.BirimAd, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n    <button class=\"btn btn-primary\">Update</button>\r\n");
#nullable restore
#line 23 "C:\Users\Guest_F\Desktop\studies\youtube\murat_yucedag_100derste_aspnetcoremvc\CoreDepartman\ProjeCore\Views\Default\UpdateUnit.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ProjeCore.Models.Birim> Html { get; private set; }
    }
}
#pragma warning restore 1591