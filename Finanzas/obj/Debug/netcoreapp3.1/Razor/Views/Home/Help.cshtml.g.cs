#pragma checksum "C:\Users\fabri\source\repos\Finanzas\Finanzas\Views\Home\Help.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6b681fb3049195bde6e8303b9650c3686498122b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Help), @"mvc.1.0.view", @"/Views/Home/Help.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6b681fb3049195bde6e8303b9650c3686498122b", @"/Views/Home/Help.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"74b0823034fc119d6124be997945a5148fe05b51", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Help : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\fabri\source\repos\Finanzas\Finanzas\Views\Home\Help.cshtml"
  
    ViewData["Title"] = "Help";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<script>
    const tickets = [];
    const sumbitTicket = document.getElementById(""submitTicket"");
    const searchTicketButton = document.getElementById(""searchTicketButton"");
    const ticketStatus = document.getElementById(""ticketStatus"");
    const errMsg = document.getElementById(""errMsg"");
    const ticketBoxCenter = document.getElementById(""ticketBoxCenter"");
    const confirmation = document.getElementById(""confirmation"");
    const goBack = document.getElementById(""goBack"");
    const deleteTicket = document.getElementById(""deleteTicket"");
    const closeTicket = document.getElementById(""closeTicket"");
    let objectIndex;

    //Object Template
    function Ticket(
        ticketNum,
        timeStamp,
        date,
        issue,
        severity,
        employeeId,
        details
    ) {
        this.ticketNum = ticketNum;
        this.timeStamp = timeStamp;
        this.date = date;
        this.issue = issue;
        this.severity = severity;
        this.employeeId");
            WriteLiteral(@" = employeeId;
        this.details = details;
    }

    sumbitTicket.addEventListener(""click"", () => {
        //Variables
        const issue = document.getElementById(""mainIssue"");
        const employeeId = document.getElementById(""employeeId"");
        const details = document.getElementById(""details"");
        const severity = document.getElementById(""severity"");
        let date = new Date();
        let dateString = date.toDateString();
        let time = date.toLocaleTimeString();

        if (
            issue.value === """" ||
            employeeId.value === """" ||
            details.value === """" ||
            severity.value === """"
        ) {
            errMsg.innerText = `Please fill out all fields.`;
            return;
        }

        //Generate ticket number
        const chars = ""0123456789"";
        const string_length = 10;
        let ticketNum = """";
        for (let i = 0; i < string_length; i++) {
            let rnum = Math.floor(Math.random() * chars.");
            WriteLiteral(@"length);
            ticketNum += chars.substring(rnum, rnum + 1);
        }

        //Create Objects
        const ticket = new Ticket(
            ticketNum,
            time,
            dateString,
            issue.value,
            severity.value,
            employeeId.value,
            details.value
        );

        //Add tickets to array
        tickets.push(ticket);

        //Clear fields
        issue.value = """";
        employeeId.value = """";
        details.value = """";
        severity.value = """";
        ticketBoxCenter.style.display = ""none"";
        confirmation.style.display = ""block"";
        goBack.style.display = ""inline"";
        confirmation.innerText = `Thank you. Your ticket number is ${ticketNum}. Please write it down for your records.`;

        console.log(tickets);
    });

    //Go back button
    goBack.addEventListener(""click"", () => {
        confirmation.innerHTML = """";
        errMsg.innerText = """";
        ticketBoxCenter.style.displ");
            WriteLiteral(@"ay = ""block"";
        confirmation.style.display = ""none"";
        goBack.style.display = ""none"";
    });

    //Search for ticket
    searchTicketButton.addEventListener(""click"", () => {
        const searchTicketInput = document.getElementById(""searchTicketInput"");
        //Check if ticket number matches
        const result = tickets.find(id => id.ticketNum === searchTicketInput.value);
        const newObject = JSON.stringify(result);
        objectIndex = tickets.indexOf(result);

        if (searchTicketInput.value === """") {
            ticketStatus.innerText = `Please enter a ticket number.`;
            deleteTicket.style.display = ""none"";
            closeTicket.style.display = ""none"";
            return;
        }
        if (newObject === undefined) {
            ticketStatus.innerText = `No records found.`;
            closeTicket.style.display = ""none"";
            deleteTicket.style.display = ""none"";
            return;
        } else if (newObject !== undefined) {
    ");
            WriteLiteral(@"        let obj = JSON.parse(newObject);
            ticketStatus.innerHTML = `Ticket# ${obj.ticketNum} was created on ${
                obj.date
                } at ${
                obj.timeStamp
                }. <br><br> Ticket Status: &#9989; Resolved <br><br> Employee ID: ${
                obj.employeeId
                } <br><br> Issue: ${obj.issue} <br><br> Severity: ${
                obj.severity
                } <br><br> Details: ${obj.details}`;
        }
        deleteTicket.style.display = ""inline"";
        closeTicket.style.display = ""inline"";
    });

    //Delete ticket
    deleteTicket.addEventListener(""click"", () => {
        const confirmCancel = confirm(`Are you sure you want to delete this ticket?`);
        if (confirmCancel == true) {
            tickets.splice(objectIndex, 1);
        } else {
            return;
        }
        ticketStatus.innerText = `Ticket deleted!`;
        deleteTicket.style.display = ""none"";
        closeTicket.style.display = ");
            WriteLiteral(@"""none"";
        console.log(tickets);
    });

    //Close ticket
    closeTicket.addEventListener(""click"", () => {
        ticketStatus.innerHTML = """";
        closeTicket.style.display = ""none"";
        deleteTicket.style.display = ""none"";
    });

</script>
<style>
    #ticketBox {
        padding: 1em;
        background: #bdc3c7;
        background-color: lightgrey;
        box-shadow: 0 4px 8px 0 rgba(0, 0, 0, 0.2), 0 6px 20px 0 rgba(0, 0, 0, 0.19);
    }

    #ticketBoxTwo {
        box-shadow: 0 4px 8px 0 rgba(0, 0, 0, 0.2), 0 6px 20px 0 rgba(0, 0, 0, 0.19);
        padding: 1em;
        background-color: lightgrey;
    }

    #confirmation {
        display: none;
    }

    #goBack {
        display: none;
    }

    #deleteTicket {
        display: none;
    }

    #closeTicket {
        display: none;
    }

</style>
    <div class=""container"">
        <div class=""row"">
            <div class=""col-xl-8 mx-auto"">
                <!--Ticket Input Box-->");
            WriteLiteral(@"
                <h2 class=""text-center mt-4"">Mesa de Tickets de Ayuda</h2>
                <div id=""ticketBox"">
                    <div id=""ticketBoxCenter"">
                        <label class=""mt-3"">Problema</label>
                        <input id=""mainIssue"" class=""form-control"">
                        <label class=""mt-3"">Severidad</label>
                        <select id=""severity"" class=""form-control"">
                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6b681fb3049195bde6e8303b9650c3686498122b10158", async() => {
                WriteLiteral("Poca");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6b681fb3049195bde6e8303b9650c3686498122b11143", async() => {
                WriteLiteral("Normal");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6b681fb3049195bde6e8303b9650c3686498122b12130", async() => {
                WriteLiteral("Alta");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6b681fb3049195bde6e8303b9650c3686498122b13115", async() => {
                WriteLiteral("Urgente");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                        </select>
                        <label class=""mt-3"">RUC</label>
                        <input id=""employeeId"" class=""form-control"" type=""number"" maxlength=""12"">
                        <label class=""mt-3"">Detalle</label>
                        <textarea id=""details"" class=""form-control"" rows=""2""></textarea>
                        <div class=""text-center"">
                            <p id=""errMsg"" class=""text-center mt-2""></p>
                            <button id=""submitTicket"" class=""btn btn-secondary text-center mt-2"">ENVIAR</button>
                        </div>
                    </div>
                    <p id=""confirmation"" class=""text-center""></p>
                    <div class=""text-center"">
                        <button id=""goBack"" class=""btn btn-secondary mt-3"">SALIR</button>
                    </div>
                </div>

            </div>
        </div>

    </div>");
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
