#pragma checksum "E:\Programming\Project\RetentionUnit\RetentionUnit\Views\Home\SelectedClient.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "055251403b8c7faf7d92935752c3d0fab7881183"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_SelectedClient), @"mvc.1.0.view", @"/Views/Home/SelectedClient.cshtml")]
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
#line 1 "E:\Programming\Project\RetentionUnit\RetentionUnit\Views\_ViewImports.cshtml"
using RetentionUnit;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\Programming\Project\RetentionUnit\RetentionUnit\Views\_ViewImports.cshtml"
using RetentionUnit.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"055251403b8c7faf7d92935752c3d0fab7881183", @"/Views/Home/SelectedClient.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"08802ae0aa4ba28b20f84210c7c915115d9aa525", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_SelectedClient : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<RetentionUnit.Models.Client>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<div class=""row"">
    <div class=""col-md-12 mb-1"">
        <h4 class=""mb-3"">Данные по клиенту</h4>
        <div class=""row"">
            <div class=""col-md-8 mb-1"">
                <label>ФИО Клиента</label>
                <input type=""text"" class=""form-control"" name=""FullName""");
            BeginWriteAttribute("value", " value=\"", 321, "\"", 344, 1);
#nullable restore
#line 8 "E:\Programming\Project\RetentionUnit\RetentionUnit\Views\Home\SelectedClient.cshtml"
WriteAttributeValue("", 329, Model.FullName, 329, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" disabled>\r\n            </div>\r\n            <div class=\"col-md-4 mb-1\">\r\n                <label>IBSO_ID</label>\r\n                <input type=\"text\" class=\"form-control\" name=\"Ibso\"");
            BeginWriteAttribute("value", " value=\"", 525, "\"", 544, 1);
#nullable restore
#line 12 "E:\Programming\Project\RetentionUnit\RetentionUnit\Views\Home\SelectedClient.cshtml"
WriteAttributeValue("", 533, Model.Ibso, 533, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" disabled>\r\n            </div>\r\n            <div class=\"col-md-4 mb-2\">\r\n                <label>Дата рождения</label>\r\n                <input type=\"text\" class=\"form-control\" name=\"BirthDate\"");
            BeginWriteAttribute("value", " value=\"", 736, "\"", 760, 1);
#nullable restore
#line 16 "E:\Programming\Project\RetentionUnit\RetentionUnit\Views\Home\SelectedClient.cshtml"
WriteAttributeValue("", 744, Model.BirthDate, 744, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" data-inputmask=\"\'mask\': \'99.99.9999\'\" disabled>\r\n            </div>\r\n            <div class=\"col-md-4 mb-2\">\r\n                <label f>Номер мобильного телефона</label>\r\n                <input type=\"text\" class=\"form-control\" name=\"Phone\"");
            BeginWriteAttribute("value", " value=\"", 1000, "\"", 1020, 1);
#nullable restore
#line 20 "E:\Programming\Project\RetentionUnit\RetentionUnit\Views\Home\SelectedClient.cshtml"
WriteAttributeValue("", 1008, Model.Phone, 1008, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" data-inputmask=\"\'mask\': \'+7(999)999-99-99\'\" disabled>\r\n            </div>\r\n            <div class=\"col-md-2 mb-2\">\r\n                <label>Клиент в СТОП Листе</label>\r\n                <input type=\"text\" class=\"form-control\" name=\"StopList\"");
            BeginWriteAttribute("value", " value=\"", 1261, "\"", 1284, 1);
#nullable restore
#line 24 "E:\Programming\Project\RetentionUnit\RetentionUnit\Views\Home\SelectedClient.cshtml"
WriteAttributeValue("", 1269, Model.StopList, 1269, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" disabled>\r\n            </div>\r\n            <div class=\"col-md-6 mb-3\">\r\n                <label>Причина Оттока</label>\r\n                <input type=\"text\" class=\"form-control\" name=\"OttokReason\"");
            BeginWriteAttribute("value", " value=\"", 1479, "\"", 1505, 1);
#nullable restore
#line 28 "E:\Programming\Project\RetentionUnit\RetentionUnit\Views\Home\SelectedClient.cshtml"
WriteAttributeValue("", 1487, Model.OttokReason, 1487, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" disabled>\r\n            </div>\r\n            <div class=\"col-md-6 mb-3\">\r\n                <label>Описание</label>\r\n                <input type=\"text\" class=\"form-control\" name=\"OttokDesc\"");
            BeginWriteAttribute("value", " value=\"", 1692, "\"", 1716, 1);
#nullable restore
#line 32 "E:\Programming\Project\RetentionUnit\RetentionUnit\Views\Home\SelectedClient.cshtml"
WriteAttributeValue("", 1700, Model.OttokDesc, 1700, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" disabled>
            </div>
        </div>
    </div>
    <br />
    <br />
    <div class=""col-md-12 mb-2"">
        <h4>Необходимо пройти опрос</h4>
        <div id=""QuestionField"">

        </div>
        <div id=""AnswerField"" class=""row"">
            <div class=""col-md-3"" id=""AnswerRadio""></div><div id=""AnswerText"" class=""col-md-9""></div>
        </div>
        <button class=""btn btn-primary d-none"" id=""SelectQuestion"" type=""button"">ВЫБРАТЬ</button>
        <button class=""btn btn-primary"" id=""StartQuestions"" type=""button"">НАЧАТЬ</button>
    </div>
</div>
<script>
    var quest;
    (function () {
        'use strict';

        var question = {
            appendQuestion: function (div, text) {
                div.append(""<div class='alert alert-primary'><p>"" + text + ""</p></div>"");
            },
            appendAnswer: function (div, text, id) {
                //div.append(""<p><div class='alert alert-warning'><input type='radio' id='Answer_"" + id + ""' name='AnswerRadio' v");
            WriteLiteral(@"alue="" + id + ""'><label for='Answer_"" + id + ""'>"" + text + ""</label></p></div>"");
                div.find('#AnswerRadio').append(""<div class='alert alert-warning' ><p><label><input type='radio' id='Answer_"" + id + ""' name='AnswerRadio' value="" + id + ""' /></label></p></div>"");
                div.find('#AnswerText').append(""<div class='alert alert-warning'><p><label for='Answer_"" + id + ""'>"" + text + ""</label></p></div>"");
            },
            clearQuestionModel: function () {
                $(""#QuestionField"").empty();
                $(""#AnswerField"").empty();
            },
            questionSelected: function (params) {
                $.post(""/Home/GetQuestion"", { qId: params }, function (data) {
                    quest = data;
                    question.appendQuestion($(""#QuestionField""), data.questionText);
                    $.each(data.answers, function (index, value) {
                        question.appendAnswer($(""#AnswerField""), value.answerText, value.answerId);
   ");
            WriteLiteral(@"                 });
                });
            },
            test: function () {
                console.log(""testtesttest"");
            }
        }
        $(""#StartQuestions"").on('click', function () {
            console.log(""startquestion"");
            $(""#StartQuestions"").addClass(""d-none"");
            $(""#SelectQuestion"").removeClass(""d-none"");
            question.questionSelected(1);
        });
    })();
</script>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RetentionUnit.Models.Client> Html { get; private set; }
    }
}
#pragma warning restore 1591