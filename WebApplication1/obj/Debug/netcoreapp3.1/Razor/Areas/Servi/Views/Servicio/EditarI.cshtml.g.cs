#pragma checksum "C:\Users\USUARIO\source\repos\WebApplication1\WebApplication1\Areas\Servi\Views\Servicio\EditarI.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d53f18856e54596abee6c43ddfdeb4bfff8965fc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Servi_Views_Servicio_EditarI), @"mvc.1.0.view", @"/Areas/Servi/Views/Servicio/EditarI.cshtml")]
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
#line 1 "C:\Users\USUARIO\source\repos\WebApplication1\WebApplication1\Areas\Servi\Views\_ViewImports.cshtml"
using WebApplication1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\USUARIO\source\repos\WebApplication1\WebApplication1\Areas\Servi\Views\_ViewImports.cshtml"
using WebApplication1.Areas.Servi.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\USUARIO\source\repos\WebApplication1\WebApplication1\Areas\Servi\Views\_ViewImports.cshtml"
using WebApplication1.Areas.Productos.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\USUARIO\source\repos\WebApplication1\WebApplication1\Areas\Servi\Views\_ViewImports.cshtml"
using WebApplication1.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\USUARIO\source\repos\WebApplication1\WebApplication1\Areas\Servi\Views\_ViewImports.cshtml"
using WebApplication1.Models.Paginador;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d53f18856e54596abee6c43ddfdeb4bfff8965fc", @"/Areas/Servi/Views/Servicio/EditarI.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"555453f3e50c70eccb50fead8e0940adfe163c0c", @"/Areas/Servi/Views/_ViewImports.cshtml")]
    public class Areas_Servi_Views_Servicio_EditarI : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Servicio_Ingredinete>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/template/css/Es.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/Servi/Servicio/Index"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_ValidationScriptsPartial", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationMessageTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<link rel=\"stylesheet\" href=\"https://stackpath.bootstrapcdn.com/bootstrap/4.5.2/css/bootstrap.min.css\" integrity=\"sha384-JcKb8q3iqJ61gNV9KGb8thSsNjpSL0n8PARn9HuZOnIxN0hoP+VmmDGMN5t9UJ0Z\" crossorigin=\"anonymous\">\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "d53f18856e54596abee6c43ddfdeb4bfff8965fc6318", async() => {
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
            WriteLiteral("\r\n\r\n\r\n<div class=\" w-full mt-5 box\">\r\n    <div class=\"intro-y col-span-12 p-5  \" id=\"formulario\">\r\n        <h1 style=\"text-align:center\">EDITAR INGREDIENTES</h1>\r\n\r\n        <!-- BEGIN: Form Layout -->\r\n        <div class=\"intro-y \">\r\n");
#nullable restore
#line 13 "C:\Users\USUARIO\source\repos\WebApplication1\WebApplication1\Areas\Servi\Views\Servicio\EditarI.cshtml"
              int con = 0;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 15 "C:\Users\USUARIO\source\repos\WebApplication1\WebApplication1\Areas\Servi\Views\Servicio\EditarI.cshtml"
             foreach (Servicio_Ingredinete item in Model)
            {
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "C:\Users\USUARIO\source\repos\WebApplication1\WebApplication1\Areas\Servi\Views\Servicio\EditarI.cshtml"
                 if (con == 0)
                {


#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    <div class=""form-row"" id=""Ingrediente"">
                        <div class=""form-group col-md-6"">
                            <label></label>
                            <select class=""input  w-full border  ingrediente"">
                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d53f18856e54596abee6c43ddfdeb4bfff8965fc8770", async() => {
#nullable restore
#line 24 "C:\Users\USUARIO\source\repos\WebApplication1\WebApplication1\Areas\Servi\Views\Servicio\EditarI.cshtml"
                                                                        Write(item.producto.Nombre);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 24 "C:\Users\USUARIO\source\repos\WebApplication1\WebApplication1\Areas\Servi\Views\Servicio\EditarI.cshtml"
                                   WriteLiteral(item.producto.IngredienteId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 26 "C:\Users\USUARIO\source\repos\WebApplication1\WebApplication1\Areas\Servi\Views\Servicio\EditarI.cshtml"
                                 foreach (Producto ser in ViewBag.productos)
                                {

                                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 29 "C:\Users\USUARIO\source\repos\WebApplication1\WebApplication1\Areas\Servi\Views\Servicio\EditarI.cshtml"
                                     if (ser.Estado == "Disponible" && ser.IngredienteId != item.producto.IngredienteId)
                                    {


#line default
#line hidden
#nullable disable
            WriteLiteral("                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d53f18856e54596abee6c43ddfdeb4bfff8965fc11441", async() => {
#nullable restore
#line 32 "C:\Users\USUARIO\source\repos\WebApplication1\WebApplication1\Areas\Servi\Views\Servicio\EditarI.cshtml"
                                                                      Write(ser.Nombre);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 32 "C:\Users\USUARIO\source\repos\WebApplication1\WebApplication1\Areas\Servi\Views\Servicio\EditarI.cshtml"
                                           WriteLiteral(ser.IngredienteId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 33 "C:\Users\USUARIO\source\repos\WebApplication1\WebApplication1\Areas\Servi\Views\Servicio\EditarI.cshtml"

                                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 34 "C:\Users\USUARIO\source\repos\WebApplication1\WebApplication1\Areas\Servi\Views\Servicio\EditarI.cshtml"
                                     
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </select>\r\n");
            WriteLiteral("                        </div>\r\n                        <div class=\"form-group col-md-6\">\r\n                            <label></label>\r\n                            <input");
            BeginWriteAttribute("value", " value=\"", 1828, "\"", 1850, 1);
#nullable restore
#line 42 "C:\Users\USUARIO\source\repos\WebApplication1\WebApplication1\Areas\Servi\Views\Servicio\EditarI.cshtml"
WriteAttributeValue("", 1836, item.cantidad, 1836, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"input w-full border cantidad\" />\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("span", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d53f18856e54596abee6c43ddfdeb4bfff8965fc14573", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationMessageTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper);
#nullable restore
#line 43 "C:\Users\USUARIO\source\repos\WebApplication1\WebApplication1\Areas\Servi\Views\Servicio\EditarI.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => item.cantidad);

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-for", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        </div>\r\n\r\n                    </div>\r\n");
#nullable restore
#line 47 "C:\Users\USUARIO\source\repos\WebApplication1\WebApplication1\Areas\Servi\Views\Servicio\EditarI.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"form-row\"");
            BeginWriteAttribute("id", " id=\"", 2155, "\"", 2200, 2);
            WriteAttributeValue("", 2160, "Ingrediente_", 2160, 12, true);
#nullable restore
#line 50 "C:\Users\USUARIO\source\repos\WebApplication1\WebApplication1\Areas\Servi\Views\Servicio\EditarI.cshtml"
WriteAttributeValue("", 2172, item.producto.IngredienteId, 2172, 28, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                        <div class=\"form-group col-md-6\">\r\n                            <label></label>\r\n                            <select class=\"input  w-full border  ingrediente\">\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d53f18856e54596abee6c43ddfdeb4bfff8965fc17278", async() => {
#nullable restore
#line 54 "C:\Users\USUARIO\source\repos\WebApplication1\WebApplication1\Areas\Servi\Views\Servicio\EditarI.cshtml"
                                                                        Write(item.producto.Nombre);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 54 "C:\Users\USUARIO\source\repos\WebApplication1\WebApplication1\Areas\Servi\Views\Servicio\EditarI.cshtml"
                                   WriteLiteral(item.producto.IngredienteId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 56 "C:\Users\USUARIO\source\repos\WebApplication1\WebApplication1\Areas\Servi\Views\Servicio\EditarI.cshtml"
                                 foreach (Producto ser in ViewBag.productos)
                                {

                                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 59 "C:\Users\USUARIO\source\repos\WebApplication1\WebApplication1\Areas\Servi\Views\Servicio\EditarI.cshtml"
                                     if (ser.Estado == "Disponible" && ser.IngredienteId != item.producto.IngredienteId)
                                    {


#line default
#line hidden
#nullable disable
            WriteLiteral("                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d53f18856e54596abee6c43ddfdeb4bfff8965fc19950", async() => {
#nullable restore
#line 62 "C:\Users\USUARIO\source\repos\WebApplication1\WebApplication1\Areas\Servi\Views\Servicio\EditarI.cshtml"
                                                                      Write(ser.Nombre);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 62 "C:\Users\USUARIO\source\repos\WebApplication1\WebApplication1\Areas\Servi\Views\Servicio\EditarI.cshtml"
                                           WriteLiteral(ser.IngredienteId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 63 "C:\Users\USUARIO\source\repos\WebApplication1\WebApplication1\Areas\Servi\Views\Servicio\EditarI.cshtml"

                                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 64 "C:\Users\USUARIO\source\repos\WebApplication1\WebApplication1\Areas\Servi\Views\Servicio\EditarI.cshtml"
                                     
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </select>\r\n");
            WriteLiteral("                        </div>\r\n                        <div class=\"form-group col-md-6\">\r\n                            <label></label>\r\n                            <input");
            BeginWriteAttribute("value", " value=\"", 3271, "\"", 3293, 1);
#nullable restore
#line 72 "C:\Users\USUARIO\source\repos\WebApplication1\WebApplication1\Areas\Servi\Views\Servicio\EditarI.cshtml"
WriteAttributeValue("", 3279, item.cantidad, 3279, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"input w-full border cantidad\" />\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("span", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d53f18856e54596abee6c43ddfdeb4bfff8965fc23082", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationMessageTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper);
#nullable restore
#line 73 "C:\Users\USUARIO\source\repos\WebApplication1\WebApplication1\Areas\Servi\Views\Servicio\EditarI.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => item.cantidad);

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-for", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        </div>\r\n\r\n                        <input type=\"button\"");
            BeginWriteAttribute("onclick", " onclick=\"", 3513, "\"", 3561, 3);
            WriteAttributeValue("", 3523, "eliminar(", 3523, 9, true);
#nullable restore
#line 76 "C:\Users\USUARIO\source\repos\WebApplication1\WebApplication1\Areas\Servi\Views\Servicio\EditarI.cshtml"
WriteAttributeValue("", 3532, item.producto.IngredienteId, 3532, 28, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3560, ")", 3560, 1, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"button border text-gray-700 btn-block btn-danger\" value=\"eliminar\">\r\n\r\n                    </div>\r\n");
#nullable restore
#line 79 "C:\Users\USUARIO\source\repos\WebApplication1\WebApplication1\Areas\Servi\Views\Servicio\EditarI.cshtml"

                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 80 "C:\Users\USUARIO\source\repos\WebApplication1\WebApplication1\Areas\Servi\Views\Servicio\EditarI.cshtml"
                 
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n    </div>\r\n\r\n    <input type=\"hidden\" id=\"ser\"");
            BeginWriteAttribute("value", " value=\"", 3768, "\"", 3787, 1);
#nullable restore
#line 85 "C:\Users\USUARIO\source\repos\WebApplication1\WebApplication1\Areas\Servi\Views\Servicio\EditarI.cshtml"
WriteAttributeValue("", 3776, ViewBag.id, 3776, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" />

    <div class=""text-right col-12 mt-3"">
        <a data-id='1' class=""button w-24 bg-theme-1 text-white"" href=""#"">Adicionar</a>
    </div>
    <div class=""text-right p-4 mt-5"">

        <button type=""button"" onclick=""editar()"" class=""button w-100 border btn-primary text-gray-700 mr-1""><font style=""vertical-align: inherit;""><font style=""vertical-align: inherit;"">Modificar</font></font></button>


        <br />

        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d53f18856e54596abee6c43ddfdeb4bfff8965fc26817", async() => {
                WriteLiteral("\r\n            <button type=\"button\" class=\"button w-100 border btn-info mr-1\"><font style=\"vertical-align: inherit;\"><font style=\"vertical-align: inherit;\">Volver</font></font></button>\r\n        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </div>\r\n    <br />\r\n</div>\r\n\r\n\r\n\r\n\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n");
                WriteLiteral(@"
    <script>

        function editar() {


            let ingredientes = $("".ingrediente"").map(function () {
                return this.value;
            }).get();

            let cantidades = $("".cantidad"").map(function () {
                return this.value;
            }).get();

            let datos = new FormData();
            datos.append(""ingredientes"", ingredientes.join());
            datos.append(""id"", $(""#ser"").val());
            datos.append(""cantidades"", cantidades.join());

            $.ajax({
                url: ""../GuardarEditarI"",
                method: ""Post"",
                data: datos,
                contentType: false,
                processData: false,
            })

        }

    </script>

    <script>
        $(function () {
            var Ingrediente = $('#Ingrediente').html();
            var divContent = $('#formulario');
            var botaoAdicionar = $('a[data-id=""1""]');
            var i = 2;

            $(botaoAdicionar");
                WriteLiteral(@").click(function () {

                divContent.append(`<div class=""row"" id=""Ingrediente_${i}"">
${Ingrediente}
<input type=""button"" onclick=""eliminar(${i})"" class=""button border text-gray-700 btn-block btn-danger"" value=""eliminar"">

</div>
`);
                i++;
            });
        });

        function eliminar(id) {

            $(""#Ingrediente_"" + id).remove();
        }
    </script>
    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "d53f18856e54596abee6c43ddfdeb4bfff8965fc29794", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
            }
            );
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Servicio_Ingredinete>> Html { get; private set; }
    }
}
#pragma warning restore 1591