#pragma checksum "C:\Users\fabri\source\repos\Finanzas\Finanzas\Views\Shared\_Layout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "871d2fba0fc0eb99070039a80fd6e5d9f016bc90"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__Layout), @"mvc.1.0.view", @"/Views/Shared/_Layout.cshtml")]
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
#line 1 "C:\Users\fabri\source\repos\Finanzas\Finanzas\Views\_ViewImports.cshtml"
using Finanzas;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\fabri\source\repos\Finanzas\Finanzas\Views\_ViewImports.cshtml"
using Finanzas.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"871d2fba0fc0eb99070039a80fd6e5d9f016bc90", @"/Views/Shared/_Layout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"74b0823034fc119d6124be997945a5148fe05b51", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__Layout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/panel.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/bootstrap4/bootstrap.min.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/bootstrap4/bootstrap.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/panel.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/logo.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("50"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<!DOCTYPE html>\r\n\r\n<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "871d2fba0fc0eb99070039a80fd6e5d9f016bc905888", async() => {
                WriteLiteral("\r\n    <meta name=\"viewport\" content=\"width=device-width\" />\r\n    <title>PBO Digital | ");
#nullable restore
#line 10 "C:\Users\fabri\source\repos\Finanzas\Finanzas\Views\Shared\_Layout.cshtml"
                    Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("</title>\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "871d2fba0fc0eb99070039a80fd6e5d9f016bc906489", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "871d2fba0fc0eb99070039a80fd6e5d9f016bc907667", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "871d2fba0fc0eb99070039a80fd6e5d9f016bc908845", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
    <script src=""https://code.jquery.com/jquery-3.5.1.min.js"" integrity=""sha256-9/aliU8dGd2tb6OSsuzixeV4y/faTqgFtohetphbbj0="" crossorigin=""anonymous""></script>
    <script src=""https://kit.fontawesome.com/984a46be28.js"" crossorigin=""anonymous""></script>
    <script src=""https://cdn.ckeditor.com/ckeditor5/23.0.0/classic/ckeditor.js""></script>
    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "871d2fba0fc0eb99070039a80fd6e5d9f016bc9010381", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
    <script>
        !function (g, s, q, r, d) {
            r = g[r] = g[r] || function () {
                (r.q = r.q || []).push(
                    arguments)
            }; d = s.createElement(q); q = s.getElementsByTagName(q)[0];
            d.src = '//d1l6p2sc9645hc.cloudfront.net/tracker.js'; q.parentNode.
                insertBefore(d, q)
        }(window, document, 'script', '_gs');

        _gs('GSN-411377-Y');
        _gs('set', 'anonymizeIP', true);
    </script>
");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "871d2fba0fc0eb99070039a80fd6e5d9f016bc9012673", async() => {
                WriteLiteral("\r\n\r\n    <header class=\"header_nav\">\r\n        <a href=\"#\" class=\"logo\">");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "871d2fba0fc0eb99070039a80fd6e5d9f016bc9013010", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("<span style=\"color:black; text-decoration-style:none;\">Panel</span></a>\r\n    </header>\r\n    <header class=\"header_main\">\r\n        <span class=\"title\">");
#nullable restore
#line 38 "C:\Users\fabri\source\repos\Finanzas\Finanzas\Views\Shared\_Layout.cshtml"
                       Write(ViewBag.Title);

#line default
#line hidden
#nullable disable
                WriteLiteral("</span>\r\n        <span class=\"date\"><i class=\"fa fa-calendar\"></i> ");
#nullable restore
#line 39 "C:\Users\fabri\source\repos\Finanzas\Finanzas\Views\Shared\_Layout.cshtml"
                                                     Write(DateTime.Now.ToLongDateString());

#line default
#line hidden
#nullable disable
                WriteLiteral("</span>\r\n        <a class=\"title text-danger\"");
                BeginWriteAttribute("href", " href=\"", 1782, "\"", 1821, 1);
#nullable restore
#line 40 "C:\Users\fabri\source\repos\Finanzas\Finanzas\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 1789, Url.Action("Logout","identity"), 1789, 32, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">Cerrar Sesión</a>\r\n\r\n    </header>\r\n    <nav>\r\n        <ul>\r\n");
#nullable restore
#line 45 "C:\Users\fabri\source\repos\Finanzas\Finanzas\Views\Shared\_Layout.cshtml"
              
                string actionName = this.ViewContext.RouteData.Values["action"].ToString();
                string controllerName = this.ViewContext.RouteData.Values["controller"].ToString();
            

#line default
#line hidden
#nullable disable
                WriteLiteral("            <li><a");
                BeginWriteAttribute("href", " href=\"", 2127, "\"", 2161, 1);
#nullable restore
#line 49 "C:\Users\fabri\source\repos\Finanzas\Finanzas\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 2134, Url.Action("Index","home"), 2134, 27, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("><i class=\"fas fa-columns\"></i>Inicio</a></li>\r\n            <li><a");
                BeginWriteAttribute("href", " href=\"", 2228, "\"", 2266, 1);
#nullable restore
#line 50 "C:\Users\fabri\source\repos\Finanzas\Finanzas\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 2235, Url.Action("Index","Clientes"), 2235, 31, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("><i class=\"fas fa-user\"></i>Mis Clientes</a></li>\r\n            <li><a");
                BeginWriteAttribute("href", " href=\"", 2336, "\"", 2378, 1);
#nullable restore
#line 51 "C:\Users\fabri\source\repos\Finanzas\Finanzas\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 2343, Url.Action("Index","Movimientoes"), 2343, 35, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("><i class=\"fas fa-book\"></i>Movimientos</a></li>\r\n            <li><a");
                BeginWriteAttribute("href", " href=\"", 2447, "\"", 2493, 1);
#nullable restore
#line 52 "C:\Users\fabri\source\repos\Finanzas\Finanzas\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 2454, Url.Action("Index","Linea_de_Credito"), 2454, 39, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("><i class=\"far fa-comment\"></i>Lineas de Credito</a></li>\r\n            <li><a");
                BeginWriteAttribute("href", " href=\"", 2571, "\"", 2604, 1);
#nullable restore
#line 53 "C:\Users\fabri\source\repos\Finanzas\Finanzas\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 2578, Url.Action("Help","Home"), 2578, 26, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@"><i class=""fa fa-arrow-left""></i>Ayuda</a></li>
            <li><a href=""#""><i class=""far fa-edit""></i>Configuración</a></li>
        </ul>
        <div class=""upgradeContainer"">
            <svg class=""folderIcon"" xmlns=""http://www.w3.org/2000/svg"" xmlns:xlink=""http://www.w3.org/1999/xlink"" data-name=""Layer 1"" width=""729.47"" height=""695.09"" viewBox=""0 0 729.47 695.09"">
                <defs>
                    <linearGradient id=""fc2ce546-a06c-4acb-8cca-fc7989cc5e45"" x1=""611.98"" y1=""687.2"" x2=""611.98"" y2=""258.73"" gradientUnits=""userSpaceOnUse"">
                        <stop offset=""0"" stop-color=""#dce1ff"" stop-opacity=""0.25"" />
                        <stop offset=""0.54"" stop-color=""#dce1ff"" stop-opacity=""0.12"" />
                        <stop offset=""1"" stop-color=""#dce1ff"" stop-opacity=""0.1"" />
                    </linearGradient>
                    <linearGradient id=""8de405ef-36e0-4554-af41-d0565e95cbca"" x1=""410.91"" y1=""358.56"" x2=""452.61"" y2=""86.08"" gradientTransform=""matrix(1.01, 0.13, -0");
                WriteLiteral(@".13, 1.02, 62.29, -41.05)"" xlink:href=""#fc2ce546-a06c-4acb-8cca-fc7989cc5e45"" />
                    <linearGradient id=""90a47f5c-11a4-432e-bbe5-e819485e2974"" x1=""597.01"" y1=""453.03"" x2=""597.01"" y2=""138.64"" gradientTransform=""translate(140.76 -189.73) rotate(20.42)"" xlink:href=""#fc2ce546-a06c-4acb-8cca-fc7989cc5e45"" />
                    <linearGradient id=""c3d8783b-6f33-4c65-b7a9-7a0b4c25dfb1"" x1=""756.62"" y1=""488.3"" x2=""772.25"" y2=""249.01"" gradientTransform=""matrix(0.26, 0.99, -1.02, 0.25, 910.43, -476.82)"" xlink:href=""#fc2ce546-a06c-4acb-8cca-fc7989cc5e45"" />
                    <linearGradient id=""1441cd83-913d-413c-98d4-824021df009a"" x1=""310"" y1=""695.09"" x2=""310"" y2=""203.86"" xlink:href=""#fc2ce546-a06c-4acb-8cca-fc7989cc5e45"" />
                    <linearGradient id=""4913d3bc-5f66-46f4-9c65-3645c89ed5d3"" x1=""545.79"" y1=""695.81"" x2=""545.79"" y2=""464.64"" gradientUnits=""userSpaceOnUse"">
                        <stop offset=""0"" stop-color=""#b3b3b3"" stop-opacity=""0.25"" />
                        <stop of");
                WriteLiteral(@"fset=""0.54"" stop-color=""#b3b3b3"" stop-opacity=""0.1"" />
                        <stop offset=""1"" stop-color=""#b3b3b3"" stop-opacity=""0.05"" />
                    </linearGradient>
                    <linearGradient id=""0cf8a40c-444c-472e-8722-d672ac4b1674"" x1=""310.8"" y1=""580.62"" x2=""310.8"" y2=""375.85"" xlink:href=""#4913d3bc-5f66-46f4-9c65-3645c89ed5d3"" />
                    <clipPath id=""f4edd298-8257-4895-a91b-ae15b3b0d94f"" transform=""translate(-235.26 -102.45)"">
                        <rect x=""400.07"" y=""483.3"" width=""291.69"" height=""194.01"" rx=""8.85"" ry=""8.85"" fill=""#fff"" />
                    </clipPath>
                </defs>
                <title>folder</title>
                <polygon points=""618.97 687.2 513.53 687.2 513.53 258.73 710.42 258.73 618.97 687.2"" fill=""url(#fc2ce546-a06c-4acb-8cca-fc7989cc5e45)"" />
                <polygon points=""613.72 687.2 510.37 687.2 510.37 258.73 703.35 258.73 613.72 687.2"" fill=""#3961e5"" />
                <rect x=""249.88"" y=""158.45"" width=""439.19"" he");
                WriteLiteral(@"ight=""168.85"" transform=""translate(-283.32 32.9) rotate(-15.62)"" fill=""url(#8de405ef-36e0-4554-af41-d0565e95cbca)"" />
                <rect x=""254.32"" y=""160.66"" width=""431.85"" height=""163.44"" transform=""translate(-283.15 33.09) rotate(-15.62)"" fill=""#eef2fd"" />
                <rect x=""367.9"" y=""230.63"" width=""108.65"" height=""8.29"" transform=""translate(-282.88 19.88) rotate(-15.62)"" fill=""#eef2fd"" />
                <rect x=""376.82"" y=""262.55"" width=""108.65"" height=""8.29"" transform=""translate(-291.14 23.46) rotate(-15.62)"" fill=""#fff"" />
                <rect x=""371.14"" y=""237.71"" width=""174.6"" height=""8.29"" transform=""translate(-283.45 29.89) rotate(-15.62)"" fill=""#fff"" />
                <circle cx=""329.58"" cy=""277.88"" r=""19.34"" transform=""translate(-297.9 -3.47) rotate(-15.62)"" fill=""#fff"" />
                <rect x=""376.38"" y=""210.25"" width=""441.26"" height=""171.17"" transform=""translate(-300.97 124.47) rotate(-20.42)"" fill=""url(#90a47f5c-11a4-432e-bbe5-e819485e2974)"" />
                <rect x=""381");
                WriteLiteral(@".03"" y=""214.81"" width=""431.85"" height=""163.44"" transform=""translate(-301.21 124.5) rotate(-20.42)"" fill=""#eef2fd"" />
                <rect x=""494.14"" y=""288.83"" width=""108.65"" height=""8.29"" transform=""translate(-303.02 107.35) rotate(-20.42)"" fill=""#eef2fd"" />
                <rect x=""505.71"" y=""319.89"" width=""108.65"" height=""8.29"" transform=""translate(-313.13 113.34) rotate(-20.42)"" fill=""#fff"" />
                <rect x=""497.85"" y=""292.85"" width=""174.6"" height=""8.29"" transform=""matrix(0.94, -0.35, 0.35, 0.94, -302.12, 120.41)"" fill=""#fff"" />
                <circle cx=""459.76"" cy=""343.69"" r=""19.34"" transform=""translate(-326.29 79.59) rotate(-20.42)"" fill=""#fff"" />
                <rect x=""646.89"" y=""150.88"" width=""172.17"" height=""440.14"" transform=""translate(3.97 925.06) rotate(-79.9)"" fill=""url(#c3d8783b-6f33-4c65-b7a9-7a0b4c25dfb1)"" />
                <rect x=""515.81"" y=""288.22"" width=""431.85"" height=""163.44"" transform=""translate(-159.05 -225.04) rotate(10.1)"" fill=""#eef2fd"" />
                <rec");
                WriteLiteral(@"t x=""687.63"" y=""287.92"" width=""8.29"" height=""108.65"" transform=""translate(-1.75 860.83) rotate(-79.9)"" fill=""#eef2fd"" />
                <rect x=""681.81"" y=""320.56"" width=""8.29"" height=""108.65"" transform=""translate(-38.67 882.02) rotate(-79.9)"" fill=""#fff"" />
                <rect x=""717.18"" y=""277.05"" width=""8.29"" height=""174.6"" transform=""translate(0.86 908.15) rotate(-79.9)"" fill=""#fff"" />
                <circle cx=""589.6"" cy=""340.88"" r=""19.34"" transform=""translate(-84.66 759.11) rotate(-79.9)"" fill=""#fff"" />
                <polygon points=""171.78 253.69 100.61 203.86 2.07 203.86 2.07 253.69 2.07 278.1 2.07 695.09 617.93 695.09 617.93 253.69 171.78 253.69"" fill=""url(#1441cd83-913d-413c-98d4-824021df009a)"" />
                <polygon points=""174.44 258.73 104.36 210.36 7.34 210.36 7.34 258.73 7.34 282.43 7.34 687.2 613.72 687.2 613.72 258.73 174.44 258.73"" fill=""#5172ef"" />
                <path d=""M711.54,688.53a7.25,7.25,0,0,1-7.21,7.28H387.26a7.25,7.25,0,0,1-7.21-7.28V471.93a7.25,7.25,0,0,1,7.21-");
                WriteLiteral(@"7.28H704.33a7.25,7.25,0,0,1,7.21,7.28"" transform=""translate(-235.26 -102.45)"" fill=""url(#4913d3bc-5f66-46f4-9c65-3645c89ed5d3)"" />
                <path d=""M707.81,685a7,7,0,0,1-7,7H391.05a7,7,0,0,1-7-7V475.62a7,7,0,0,1,7-7H700.77a7,7,0,0,1,7,7"" transform=""translate(-235.26 -102.45)"" fill=""#fff"" />
                <g id=""114cebd5-d8fe-4021-8e49-fe55d7dac6be"" data-name=""&lt;Rectangle&gt;"">
                    <rect x=""161.12"" y=""375.85"" width=""299.37"" height=""204.76"" rx=""8.85"" ry=""8.85"" fill=""#eef2fd"" />
                </g>
                <rect x=""164.8"" y=""380.84"" width=""291.69"" height=""194.01"" rx=""8.85"" ry=""8.85"" fill=""#fff"" />
                <g clip-path=""url(#f4edd298-8257-4895-a91b-ae15b3b0d94f)"">
                    <path d=""M383.84,675.53l81.44-93.31a16.21,16.21,0,0,1,22.94-1.5L511,600.84a16.21,16.21,0,0,0,21.16.25l69.7-58.58A16.21,16.21,0,0,1,624.3,544l85.53,94.14a16.21,16.21,0,0,1,4.15,9.47l3.3,37.13a16.21,16.21,0,0,1-16.15,17.65H396.06a16.21,16.21,0,0,1-16.2-15.72h0A16.21,16.21,0,0,1,383.84");
                WriteLiteral(@",675.53Z"" transform=""translate(-235.26 -102.45)"" fill=""#5e81f4"" />
                </g>
                <circle cx=""199.93"" cy=""411.95"" r=""18.06"" fill=""#eef2fd"" />
            </svg>
            <span>Upgrade to <b>PRO</b> for more resources.</span>
            <a href=""#"">Upgrade</a>
        </div>
    </nav>
    <main style=""height:auto"">

        ");
#nullable restore
#line 118 "C:\Users\fabri\source\repos\Finanzas\Finanzas\Views\Shared\_Layout.cshtml"
   Write(RenderBody());

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n    </main>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
