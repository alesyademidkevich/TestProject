#pragma checksum "D:\BSTU\Course4\PI\CP\TestProject\TestProject\Views\UserTest\Result.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ca229715e6e29532c3187a0311f35986701c324e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_UserTest_Result), @"mvc.1.0.view", @"/Views/UserTest/Result.cshtml")]
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
#line 1 "D:\BSTU\Course4\PI\CP\TestProject\TestProject\Views\_ViewImports.cshtml"
using TestProject;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\BSTU\Course4\PI\CP\TestProject\TestProject\Views\_ViewImports.cshtml"
using TestProject.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ca229715e6e29532c3187a0311f35986701c324e", @"/Views/UserTest/Result.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b5793b3861753add5f6e734f58173abd93064819", @"/Views/_ViewImports.cshtml")]
    public class Views_UserTest_Result : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "D:\BSTU\Course4\PI\CP\TestProject\TestProject\Views\UserTest\Result.cshtml"
  
    ViewData["Title"] = "Результат";
    ViewBag.Title = "Результат";

#line default
#line hidden
#nullable disable
            WriteLiteral("<div>\r\n");
#nullable restore
#line 6 "D:\BSTU\Course4\PI\CP\TestProject\TestProject\Views\UserTest\Result.cshtml"
      
        if (@Model.mark <= 35)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <h1> ");
#nullable restore
#line 9 "D:\BSTU\Course4\PI\CP\TestProject\TestProject\Views\UserTest\Result.cshtml"
            Write(Model.mark);

#line default
#line hidden
#nullable disable
            WriteLiteral("% Ну ты и тупой!</h1>\r\n");
#nullable restore
#line 10 "D:\BSTU\Course4\PI\CP\TestProject\TestProject\Views\UserTest\Result.cshtml"
        }
        else if (@Model.mark > 35 && @Model.mark <= 70)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <h1>");
#nullable restore
#line 13 "D:\BSTU\Course4\PI\CP\TestProject\TestProject\Views\UserTest\Result.cshtml"
           Write(Model.mark);

#line default
#line hidden
#nullable disable
            WriteLiteral("% Нормально!</h1>\r\n");
#nullable restore
#line 14 "D:\BSTU\Course4\PI\CP\TestProject\TestProject\Views\UserTest\Result.cshtml"
        }
        else if (@Model.mark > 70)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <h1>");
#nullable restore
#line 17 "D:\BSTU\Course4\PI\CP\TestProject\TestProject\Views\UserTest\Result.cshtml"
           Write(Model.mark);

#line default
#line hidden
#nullable disable
            WriteLiteral("% Красавчик!</h1>\r\n");
#nullable restore
#line 18 "D:\BSTU\Course4\PI\CP\TestProject\TestProject\Views\UserTest\Result.cshtml"
        }
    

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>\r\n\r\n<h1 class=\"page-header text-center\" name=\"Subject\">");
#nullable restore
#line 23 "D:\BSTU\Course4\PI\CP\TestProject\TestProject\Views\UserTest\Result.cshtml"
                                              Write(ViewBag.result.test.Subject);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n<h3 class=\"page-header text-center\" name=\"Mark\">Результат - ");
#nullable restore
#line 24 "D:\BSTU\Course4\PI\CP\TestProject\TestProject\Views\UserTest\Result.cshtml"
                                                       Write(ViewBag.result.Mark);

#line default
#line hidden
#nullable disable
            WriteLiteral("%</h3>\r\n<div id=\"container\">\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ca229715e6e29532c3187a0311f35986701c324e5899", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 27 "D:\BSTU\Course4\PI\CP\TestProject\TestProject\Views\UserTest\Result.cshtml"
           int i = 0;
            int k = 0;
            int a = 0;
            int b = 0;
            int num2 = 0;

#line default
#line hidden
#nullable disable
                WriteLiteral("        <h3 style=\"margin:20px\">Часть A</h3>\r\n");
#nullable restore
#line 33 "D:\BSTU\Course4\PI\CP\TestProject\TestProject\Views\UserTest\Result.cshtml"
         foreach (var test in @ViewBag.result.test.QuestionList)
        {
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 35 "D:\BSTU\Course4\PI\CP\TestProject\TestProject\Views\UserTest\Result.cshtml"
             if (test.Type == "A")
            {
                int num = i + 1;

#line default
#line hidden
#nullable disable
                WriteLiteral("                <h4 class=\"page-header text-center\" style=\"margin:10px\">А ");
#nullable restore
#line 38 "D:\BSTU\Course4\PI\CP\TestProject\TestProject\Views\UserTest\Result.cshtml"
                                                                     Write(num);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h4>\r\n                <div id=\"question\">\r\n                    ");
#nullable restore
#line 40 "D:\BSTU\Course4\PI\CP\TestProject\TestProject\Views\UserTest\Result.cshtml"
               Write(test.Text);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </div>\r\n");
#nullable restore
#line 42 "D:\BSTU\Course4\PI\CP\TestProject\TestProject\Views\UserTest\Result.cshtml"
                 if (test.ImageUrl != null)
                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <div id=\"img\">\r\n                        <img");
                BeginWriteAttribute("src", " src=\"", 1292, "\"", 1312, 1);
#nullable restore
#line 45 "D:\BSTU\Course4\PI\CP\TestProject\TestProject\Views\UserTest\Result.cshtml"
WriteAttributeValue("", 1298, test.ImageUrl, 1298, 14, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" style=\"width:200px; height:140px\" />\r\n                    </div>\r\n");
#nullable restore
#line 47 "D:\BSTU\Course4\PI\CP\TestProject\TestProject\Views\UserTest\Result.cshtml"
                }

#line default
#line hidden
#nullable disable
                WriteLiteral("    <div id=\"answers\" style=\"margin:30px\">\r\n");
#nullable restore
#line 50 "D:\BSTU\Course4\PI\CP\TestProject\TestProject\Views\UserTest\Result.cshtml"
         foreach (var answer in test.AnswerList)
        {
            if (answer.isChecked && answer.isRight)
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                <input type=\"checkbox\"");
                BeginWriteAttribute("id", " id=\"", 1612, "\"", 1619, 1);
#nullable restore
#line 54 "D:\BSTU\Course4\PI\CP\TestProject\TestProject\Views\UserTest\Result.cshtml"
WriteAttributeValue("", 1617, i, 1617, 2, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" checked style=\"color: green\" disabled>\r\n                <lable");
                BeginWriteAttribute("for", " for=\"", 1683, "\"", 1691, 1);
#nullable restore
#line 55 "D:\BSTU\Course4\PI\CP\TestProject\TestProject\Views\UserTest\Result.cshtml"
WriteAttributeValue("", 1689, i, 1689, 2, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("name", " name=\"", 1692, "\"", 1735, 5);
                WriteAttributeValue("", 1699, "QuestionList[", 1699, 13, true);
#nullable restore
#line 55 "D:\BSTU\Course4\PI\CP\TestProject\TestProject\Views\UserTest\Result.cshtml"
WriteAttributeValue("", 1712, i, 1712, 2, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 1714, "].AnswerList[", 1714, 13, true);
#nullable restore
#line 55 "D:\BSTU\Course4\PI\CP\TestProject\TestProject\Views\UserTest\Result.cshtml"
WriteAttributeValue("", 1727, a, 1727, 2, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 1729, "].text", 1729, 6, true);
                EndWriteAttribute();
                BeginWriteAttribute("value", " value=\"", 1736, "\"", 1756, 1);
#nullable restore
#line 55 "D:\BSTU\Course4\PI\CP\TestProject\TestProject\Views\UserTest\Result.cshtml"
WriteAttributeValue("", 1744, answer.Text, 1744, 12, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" checked style=\"color: green\">");
#nullable restore
#line 55 "D:\BSTU\Course4\PI\CP\TestProject\TestProject\Views\UserTest\Result.cshtml"
                                                                                                                         Write(answer.Text);

#line default
#line hidden
#nullable disable
                WriteLiteral("</lable><br />\r\n");
#nullable restore
#line 56 "D:\BSTU\Course4\PI\CP\TestProject\TestProject\Views\UserTest\Result.cshtml"
                a++;
            }
            else if (answer.isChecked && !answer.isRight)
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                <input type=\"checkbox\"");
                BeginWriteAttribute("id", " id=\"", 1964, "\"", 1971, 1);
#nullable restore
#line 60 "D:\BSTU\Course4\PI\CP\TestProject\TestProject\Views\UserTest\Result.cshtml"
WriteAttributeValue("", 1969, i, 1969, 2, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" checked style=\"color: red\" disabled>\r\n                <lable");
                BeginWriteAttribute("for", " for=\"", 2033, "\"", 2041, 1);
#nullable restore
#line 61 "D:\BSTU\Course4\PI\CP\TestProject\TestProject\Views\UserTest\Result.cshtml"
WriteAttributeValue("", 2039, i, 2039, 2, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("name", " name=\"", 2042, "\"", 2085, 5);
                WriteAttributeValue("", 2049, "QuestionList[", 2049, 13, true);
#nullable restore
#line 61 "D:\BSTU\Course4\PI\CP\TestProject\TestProject\Views\UserTest\Result.cshtml"
WriteAttributeValue("", 2062, i, 2062, 2, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 2064, "].AnswerList[", 2064, 13, true);
#nullable restore
#line 61 "D:\BSTU\Course4\PI\CP\TestProject\TestProject\Views\UserTest\Result.cshtml"
WriteAttributeValue("", 2077, a, 2077, 2, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 2079, "].text", 2079, 6, true);
                EndWriteAttribute();
                BeginWriteAttribute("value", " value=\"", 2086, "\"", 2106, 1);
#nullable restore
#line 61 "D:\BSTU\Course4\PI\CP\TestProject\TestProject\Views\UserTest\Result.cshtml"
WriteAttributeValue("", 2094, answer.Text, 2094, 12, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" style=\"color: red\">");
#nullable restore
#line 61 "D:\BSTU\Course4\PI\CP\TestProject\TestProject\Views\UserTest\Result.cshtml"
                                                                                                               Write(answer.Text);

#line default
#line hidden
#nullable disable
                WriteLiteral("</lable><br />\r\n");
#nullable restore
#line 62 "D:\BSTU\Course4\PI\CP\TestProject\TestProject\Views\UserTest\Result.cshtml"
                a++;
            }
            else if (!answer.isChecked && answer.isRight)
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                <input type=\"checkbox\"");
                BeginWriteAttribute("id", " id=\"", 2304, "\"", 2311, 1);
#nullable restore
#line 66 "D:\BSTU\Course4\PI\CP\TestProject\TestProject\Views\UserTest\Result.cshtml"
WriteAttributeValue("", 2309, i, 2309, 2, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" style=\"color: green\" disabled>\r\n                <lable");
                BeginWriteAttribute("for", " for=\"", 2367, "\"", 2375, 1);
#nullable restore
#line 67 "D:\BSTU\Course4\PI\CP\TestProject\TestProject\Views\UserTest\Result.cshtml"
WriteAttributeValue("", 2373, i, 2373, 2, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("name", " name=\"", 2376, "\"", 2419, 5);
                WriteAttributeValue("", 2383, "QuestionList[", 2383, 13, true);
#nullable restore
#line 67 "D:\BSTU\Course4\PI\CP\TestProject\TestProject\Views\UserTest\Result.cshtml"
WriteAttributeValue("", 2396, i, 2396, 2, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 2398, "].AnswerList[", 2398, 13, true);
#nullable restore
#line 67 "D:\BSTU\Course4\PI\CP\TestProject\TestProject\Views\UserTest\Result.cshtml"
WriteAttributeValue("", 2411, a, 2411, 2, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 2413, "].text", 2413, 6, true);
                EndWriteAttribute();
                BeginWriteAttribute("value", " value=\"", 2420, "\"", 2440, 1);
#nullable restore
#line 67 "D:\BSTU\Course4\PI\CP\TestProject\TestProject\Views\UserTest\Result.cshtml"
WriteAttributeValue("", 2428, answer.Text, 2428, 12, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" style=\"color: green\">");
#nullable restore
#line 67 "D:\BSTU\Course4\PI\CP\TestProject\TestProject\Views\UserTest\Result.cshtml"
                                                                                                                 Write(answer.Text);

#line default
#line hidden
#nullable disable
                WriteLiteral("</lable><br />\r\n");
#nullable restore
#line 68 "D:\BSTU\Course4\PI\CP\TestProject\TestProject\Views\UserTest\Result.cshtml"
                a++;
            }
            else
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                <input type=\"checkbox\"");
                BeginWriteAttribute("id", " id=\"", 2599, "\"", 2606, 1);
#nullable restore
#line 72 "D:\BSTU\Course4\PI\CP\TestProject\TestProject\Views\UserTest\Result.cshtml"
WriteAttributeValue("", 2604, i, 2604, 2, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" disabled>\r\n                <lable");
                BeginWriteAttribute("for", " for=\"", 2641, "\"", 2649, 1);
#nullable restore
#line 73 "D:\BSTU\Course4\PI\CP\TestProject\TestProject\Views\UserTest\Result.cshtml"
WriteAttributeValue("", 2647, i, 2647, 2, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("name", " name=\"", 2650, "\"", 2693, 5);
                WriteAttributeValue("", 2657, "QuestionList[", 2657, 13, true);
#nullable restore
#line 73 "D:\BSTU\Course4\PI\CP\TestProject\TestProject\Views\UserTest\Result.cshtml"
WriteAttributeValue("", 2670, i, 2670, 2, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 2672, "].AnswerList[", 2672, 13, true);
#nullable restore
#line 73 "D:\BSTU\Course4\PI\CP\TestProject\TestProject\Views\UserTest\Result.cshtml"
WriteAttributeValue("", 2685, a, 2685, 2, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 2687, "].text", 2687, 6, true);
                EndWriteAttribute();
                BeginWriteAttribute("value", " value=\"", 2694, "\"", 2714, 1);
#nullable restore
#line 73 "D:\BSTU\Course4\PI\CP\TestProject\TestProject\Views\UserTest\Result.cshtml"
WriteAttributeValue("", 2702, answer.Text, 2702, 12, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">");
#nullable restore
#line 73 "D:\BSTU\Course4\PI\CP\TestProject\TestProject\Views\UserTest\Result.cshtml"
                                                                                            Write(answer.Text);

#line default
#line hidden
#nullable disable
                WriteLiteral("</lable><br />\r\n");
#nullable restore
#line 74 "D:\BSTU\Course4\PI\CP\TestProject\TestProject\Views\UserTest\Result.cshtml"
                a++;
            }
        }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    </div>\r\n");
#nullable restore
#line 79 "D:\BSTU\Course4\PI\CP\TestProject\TestProject\Views\UserTest\Result.cshtml"
                a = 0;
                i++;
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 81 "D:\BSTU\Course4\PI\CP\TestProject\TestProject\Views\UserTest\Result.cshtml"
             

        }

#line default
#line hidden
#nullable disable
                WriteLiteral("        <h3 style=\"margin:20px\">Часть B</h3>\r\n");
#nullable restore
#line 85 "D:\BSTU\Course4\PI\CP\TestProject\TestProject\Views\UserTest\Result.cshtml"
         foreach (var test in @ViewBag.result.test.QuestionList)
        {
            k = i;
            if (test.Type == "B")
            {
                num2++;

#line default
#line hidden
#nullable disable
                WriteLiteral("                <h4 class=\"page-header text-center\" style=\"margin:10px\">B ");
#nullable restore
#line 91 "D:\BSTU\Course4\PI\CP\TestProject\TestProject\Views\UserTest\Result.cshtml"
                                                                     Write(num2);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h4>\r\n                <div id=\"question\">\r\n                    ");
#nullable restore
#line 93 "D:\BSTU\Course4\PI\CP\TestProject\TestProject\Views\UserTest\Result.cshtml"
               Write(test.Text);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </div>\r\n");
#nullable restore
#line 95 "D:\BSTU\Course4\PI\CP\TestProject\TestProject\Views\UserTest\Result.cshtml"
                 if (test.ImageUrl != null)
                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <div id=\"img\">\r\n                        <img");
                BeginWriteAttribute("src", " src=\"", 3405, "\"", 3425, 1);
#nullable restore
#line 98 "D:\BSTU\Course4\PI\CP\TestProject\TestProject\Views\UserTest\Result.cshtml"
WriteAttributeValue("", 3411, test.ImageUrl, 3411, 14, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" style=\"width:200px; height:140px\" />\r\n                    </div>\r\n");
#nullable restore
#line 100 "D:\BSTU\Course4\PI\CP\TestProject\TestProject\Views\UserTest\Result.cshtml"
                }

#line default
#line hidden
#nullable disable
                WriteLiteral("    <div id=\"answers\" style=\"margin:30px\">\r\n\r\n        <br />");
#nullable restore
#line 104 "D:\BSTU\Course4\PI\CP\TestProject\TestProject\Views\UserTest\Result.cshtml"
               foreach (var answer in test.AnswerList)
        {
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 106 "D:\BSTU\Course4\PI\CP\TestProject\TestProject\Views\UserTest\Result.cshtml"
             if (answer.Text == answer.UserText)
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                <p>Ответ:</p>\r\n                <input type=\"text\" readonly");
                BeginWriteAttribute("value", " value=\"", 3766, "\"", 3786, 1);
#nullable restore
#line 109 "D:\BSTU\Course4\PI\CP\TestProject\TestProject\Views\UserTest\Result.cshtml"
WriteAttributeValue("", 3774, answer.Text, 3774, 12, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" style=\"border-color:green\">\r\n");
#nullable restore
#line 110 "D:\BSTU\Course4\PI\CP\TestProject\TestProject\Views\UserTest\Result.cshtml"
            }
            else
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                <p>Ответ:</p>\r\n                <input type=\"text\" readonly");
                BeginWriteAttribute("value", " value=\"", 3939, "\"", 3959, 1);
#nullable restore
#line 114 "D:\BSTU\Course4\PI\CP\TestProject\TestProject\Views\UserTest\Result.cshtml"
WriteAttributeValue("", 3947, answer.Text, 3947, 12, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" style=\"border-color:green; color:green\">\r\n                <p>Ваш ответ:</p>\r\n                <input type=\"text\" readonly");
                BeginWriteAttribute("value", " value=\"", 4081, "\"", 4105, 1);
#nullable restore
#line 116 "D:\BSTU\Course4\PI\CP\TestProject\TestProject\Views\UserTest\Result.cshtml"
WriteAttributeValue("", 4089, answer.UserText, 4089, 16, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" style=\"border-color:red; color:red\">\r\n");
#nullable restore
#line 117 "D:\BSTU\Course4\PI\CP\TestProject\TestProject\Views\UserTest\Result.cshtml"

            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 118 "D:\BSTU\Course4\PI\CP\TestProject\TestProject\Views\UserTest\Result.cshtml"
             
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 120 "D:\BSTU\Course4\PI\CP\TestProject\TestProject\Views\UserTest\Result.cshtml"
          
            b++;
            k++;
        

#line default
#line hidden
#nullable disable
                WriteLiteral("    </div>\r\n");
#nullable restore
#line 125 "D:\BSTU\Course4\PI\CP\TestProject\TestProject\Views\UserTest\Result.cshtml"
            }
        }

#line default
#line hidden
#nullable disable
                WriteLiteral("    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    <br />\r\n</div>\r\n");
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