#pragma checksum "C:\Users\fabri\source\repos\Finanzas\Finanzas\Views\Clientes\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3bf01163ea9f2c0031298343037a561541b72691"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Clientes_Details), @"mvc.1.0.view", @"/Views/Clientes/Details.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3bf01163ea9f2c0031298343037a561541b72691", @"/Views/Clientes/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"74b0823034fc119d6124be997945a5148fe05b51", @"/Views/_ViewImports.cshtml")]
    public class Views_Clientes_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Finanzas.Models.Movimiento>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\fabri\source\repos\Finanzas\Finanzas\Views\Clientes\Details.cshtml"
  
    ViewData["Title"] = "Movimientos de " + ViewBag.Cliente.Firstname + " " + ViewBag.Cliente.Lastname;
    decimal montoapagar = 0;
    decimal montoAcumulado = 0;


#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Movimientos de ");
#nullable restore
#line 10 "C:\Users\fabri\source\repos\Finanzas\Finanzas\Views\Clientes\Details.cshtml"
              Write(ViewBag.Cliente.Firstname);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h1>

<table class=""table"">
    <thead>
        <tr>
            <th>
                Tipo de Movimiento
            </th>
            <th>
                Montos
            </th>
            <th>
                Intereses
            </th>
            <th>
                Monto a Pagar
            </th>
            <th>
                Fechas
            </th>
        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 33 "C:\Users\fabri\source\repos\Finanzas\Finanzas\Views\Clientes\Details.cshtml"
         foreach (var item in Model)
        {
            var tu = montoAcumulado;
            if (item.Type == 0)
            {
                montoAcumulado = montoAcumulado - item.Monto;
            }
            else
            {
                montoAcumulado = montoAcumulado + item.Monto;
            }
            Cliente e = ViewBag.Cliente;
            decimal i = e.Credito.Interes / 100;
            decimal t = 0;
            if (e.Credito.Tasa == 1)
            {
                if (e.Credito.Year == 0)
                {
                    t = Decimal.Divide((Int32)(DateTime.Now - item.Fecha).TotalDays, 360);
                }
                else
                {

                    t = Decimal.Divide((Int32)(DateTime.Now - item.Fecha).TotalDays, 365);
                }
                if (item.Type == 1)
                {
                    if (e.Credito.Periodo == 0)
                    {
                        montoapagar = Decimal.Round(montoAcumulado * (1 + i * 12 * t), 2);
                    }
                    else
                    {
                        montoapagar = Decimal.Round(montoAcumulado * (1 + i * 6 * t), 2);

                    }
                }
                else
                {
                    montoapagar = montoAcumulado;
                }
            }
            else if (e.Credito.Tasa == 0)
            {
                if (item.Type == 1)
                {
                    if (e.Credito.Periodo == 0) //MENSUAL
                    {
                        switch (e.Credito.Capitalizacion)
                        {
                            case 0:
                                montoapagar = Decimal.Round((decimal)(montoAcumulado * (decimal)(Math.Pow((double)(1 + (i / 30)), (DateTime.Now - item.Fecha).TotalDays) - 1) + montoAcumulado), 2);
                                break;

                            case 1:
                                montoapagar = Decimal.Round((decimal)(montoAcumulado * (decimal)(Math.Pow((double)(1 + ((i / 15) / 30)), (DateTime.Now - item.Fecha).TotalDays) - 1) + montoAcumulado), 2);
                                break;

                            default:
                                montoapagar = Decimal.Round((decimal)(montoAcumulado * (decimal)(Math.Pow((double)(1 + ((i / 30) / 30)), (DateTime.Now - item.Fecha).TotalDays) - 1) + montoAcumulado), 2);

                                break;
                        }
                    }
                    else
                    {
                        switch (e.Credito.Capitalizacion)
                        {
                            case 0:
                                montoapagar = Decimal.Round((decimal)(montoAcumulado * (decimal)(Math.Pow((double)(1 + (i / 60)), (DateTime.Now - item.Fecha).TotalDays) - 1) + montoAcumulado), 2);
                                break;

                            case 1:
                                montoapagar = Decimal.Round((decimal)(montoAcumulado * (decimal)(Math.Pow((double)(1 + ((i / 15) / 60)), (DateTime.Now - item.Fecha).TotalDays) - 1) + montoAcumulado), 2);
                                break;

                            default:
                                montoapagar = Decimal.Round((decimal)(montoAcumulado * (decimal)(Math.Pow((double)(1 + ((i / 30) / 60)), (DateTime.Now - item.Fecha).TotalDays) - 1) + montoAcumulado), 2);

                                break;
                        }
                    }
                }
                else
                {
                    montoapagar = montoAcumulado;
                }

            }
            else
            {
                if (item.Type == 1)
                {
                    if (e.Credito.Periodo == 0) //MENSUAL
                    {
                        montoapagar = Decimal.Round(montoAcumulado * (decimal)((Math.Pow((double)(1 + i), (DateTime.Now - item.Fecha).TotalDays / 30)) - 1) + montoAcumulado, 2);
                    }
                    else
                    {
                        montoapagar = Decimal.Round(montoAcumulado * (decimal)((Math.Pow((double)(1 + i), (DateTime.Now - item.Fecha).TotalDays / 60)) - 1) + montoAcumulado, 2);
                    }
                }
                else
                {
                    montoapagar = montoAcumulado;
                }
            }


#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>\r\n");
#nullable restore
#line 143 "C:\Users\fabri\source\repos\Finanzas\Finanzas\Views\Clientes\Details.cshtml"
                     if (item.Type == 0)
                    {
                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 145 "C:\Users\fabri\source\repos\Finanzas\Finanzas\Views\Clientes\Details.cshtml"
                    Write("Pago");

#line default
#line hidden
#nullable disable
#nullable restore
#line 145 "C:\Users\fabri\source\repos\Finanzas\Finanzas\Views\Clientes\Details.cshtml"
                                 
                    }
                    else
                    {
                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 149 "C:\Users\fabri\source\repos\Finanzas\Finanzas\Views\Clientes\Details.cshtml"
                    Write("Compra");

#line default
#line hidden
#nullable disable
#nullable restore
#line 149 "C:\Users\fabri\source\repos\Finanzas\Finanzas\Views\Clientes\Details.cshtml"
                                   
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 153 "C:\Users\fabri\source\repos\Finanzas\Finanzas\Views\Clientes\Details.cshtml"
               Write(Html.DisplayFor(modelItem => item.Monto));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n");
#nullable restore
#line 156 "C:\Users\fabri\source\repos\Finanzas\Finanzas\Views\Clientes\Details.cshtml"
                     if (item.Type == 1)
                    {
                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 158 "C:\Users\fabri\source\repos\Finanzas\Finanzas\Views\Clientes\Details.cshtml"
                    Write(montoapagar-item.Monto-tu);

#line default
#line hidden
#nullable disable
#nullable restore
#line 158 "C:\Users\fabri\source\repos\Finanzas\Finanzas\Views\Clientes\Details.cshtml"
                                                    
                    }
                    else
                    {
                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 162 "C:\Users\fabri\source\repos\Finanzas\Finanzas\Views\Clientes\Details.cshtml"
                    Write("-----");

#line default
#line hidden
#nullable disable
#nullable restore
#line 162 "C:\Users\fabri\source\repos\Finanzas\Finanzas\Views\Clientes\Details.cshtml"
                                  
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </td>\r\n                <td>\r\n");
#nullable restore
#line 166 "C:\Users\fabri\source\repos\Finanzas\Finanzas\Views\Clientes\Details.cshtml"
                     if (item.Type == 1)
                    {
                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 168 "C:\Users\fabri\source\repos\Finanzas\Finanzas\Views\Clientes\Details.cshtml"
                    Write(montoapagar - tu);

#line default
#line hidden
#nullable disable
#nullable restore
#line 168 "C:\Users\fabri\source\repos\Finanzas\Finanzas\Views\Clientes\Details.cshtml"
                                           
                    }
                    else
                    {
                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 172 "C:\Users\fabri\source\repos\Finanzas\Finanzas\Views\Clientes\Details.cshtml"
                    Write(montoapagar);

#line default
#line hidden
#nullable disable
#nullable restore
#line 172 "C:\Users\fabri\source\repos\Finanzas\Finanzas\Views\Clientes\Details.cshtml"
                                      
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 176 "C:\Users\fabri\source\repos\Finanzas\Finanzas\Views\Clientes\Details.cshtml"
               Write(Html.DisplayFor(modelItem => item.Fecha));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n");
#nullable restore
#line 178 "C:\Users\fabri\source\repos\Finanzas\Finanzas\Views\Clientes\Details.cshtml"
                  
                    montoAcumulado = montoapagar;
                

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tr>\r\n");
#nullable restore
#line 182 "C:\Users\fabri\source\repos\Finanzas\Finanzas\Views\Clientes\Details.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n    <tfoot>\r\n        <tr>\r\n");
#nullable restore
#line 186 "C:\Users\fabri\source\repos\Finanzas\Finanzas\Views\Clientes\Details.cshtml"
              
                var montobasico = Model.Where(d => d.Type == 1).Sum(d => d.Monto) - Model.Where(d => d.Type == 0).Sum(d => d.Monto);
            

#line default
#line hidden
#nullable disable
            WriteLiteral("            <th>\r\n                Total:\r\n            </th>\r\n            <th>\r\n                S/");
#nullable restore
#line 193 "C:\Users\fabri\source\repos\Finanzas\Finanzas\Views\Clientes\Details.cshtml"
             Write(montobasico);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                S/");
#nullable restore
#line 196 "C:\Users\fabri\source\repos\Finanzas\Finanzas\Views\Clientes\Details.cshtml"
              Write(montoapagar-montobasico);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                S/");
#nullable restore
#line 199 "C:\Users\fabri\source\repos\Finanzas\Finanzas\Views\Clientes\Details.cshtml"
             Write(montoapagar);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                Hoy: ");
#nullable restore
#line 202 "C:\Users\fabri\source\repos\Finanzas\Finanzas\Views\Clientes\Details.cshtml"
                Write(DateTime.Now.ToShortDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n        </tr>\r\n    </tfoot>\r\n</table>\r\n\r\n<p class=\"text-success\">\r\n    Saldo del Credito Disponible: S/");
#nullable restore
#line 209 "C:\Users\fabri\source\repos\Finanzas\Finanzas\Views\Clientes\Details.cshtml"
                                Write(ViewBag.Cliente.Credito.Credito-montobasico);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</p>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Finanzas.Models.Movimiento>> Html { get; private set; }
    }
}
#pragma warning restore 1591
