#pragma checksum "E:\Programming\Project\RetentionUnit\RetentionUnit\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1bc1f4a73b6352598ee6dae33ba725576b98cbaf"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1bc1f4a73b6352598ee6dae33ba725576b98cbaf", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"08802ae0aa4ba28b20f84210c7c915115d9aa525", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("needs-validation"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("searchform"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 1 "E:\Programming\Project\RetentionUnit\RetentionUnit\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""py-5 text-center"">
    <h3>Здесь можно вставить логотип</h3>
    <p class=""lead"">
        Ретеншн Юнит. Для сохранения клиента
        Нужен какой-то текст или убрать.
    </p>
</div>
<div class=""row"">
    <div class=""col-md-12"">
        <div id=""content"">
            <div class=""row"">
                <div class=""col-md-12 mb-1"">
                    <h4");
            BeginWriteAttribute("class", " class=\"", 426, "\"", 434, 0);
            EndWriteAttribute();
            WriteLiteral(">Введите данные клиента</h4>\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1bc1f4a73b6352598ee6dae33ba725576b98cbaf5032", async() => {
                WriteLiteral(@"
                        <div class=""row"" id=""searchEvent"">
                            <div class=""invalid-feedback"">Необхдимо указать либо ФИО или Мобильный номер или IBSO-ID</div>
                            <input type=""hidden"" name=""start"" value=""START"" />
                            <div class=""col-md-8 mb-3"">
                                <label for=""fullname"">ФИО Клиента</label>
                                <input type=""text"" class=""form-control"" name=""FullName"" id=""fullname"">
                                <div class=""invalid-feedback"">Ввидете полное ФИО клиента</div>
                            </div>
                            <div class=""col-md-4 mb-3"">
                                <label for=""ibsoid"">IBSO_ID</label>
                                <input type=""text"" class=""form-control"" name=""Ibso"" id=""ibsoid"">
                                <div class=""invalid-feedback"">Ввидете IBSO-ID Клиента</div>
                            </div>
                            <div clas");
                WriteLiteral(@"s=""col-md-6 mb-3"">
                                <label for=""birthdate"">Дата рождения</label>
                                <input type=""text"" class=""form-control"" name=""BirthDate"" id=""birthdate"" data-inputmask=""'mask': '99.99.9999'"">
                                <div class=""invalid-feedback"">Укажите дату рождения</div>
                            </div>
                            <div class=""col-md-6 mb-3"">
                                <label for=""phonenumber"">Номер мобильного телефона</label>
                                <input type=""text"" class=""form-control"" id=""phonenumber"" name=""Phone"" data-inputmask=""'mask': '+7(999)999-99-99'"">
                                <div class=""invalid-feedback"">Укажите номер Мобильного телефона</div>
                            </div>
                            <input type=""hidden"" id=""end"" name=""end"" value=""END"" />
                        </div>
                        <button class=""btn btn-primary"" type=""submit"">ПОИСК</button>
                ");
                WriteLiteral("    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            BeginWriteTagHelperAttribute();
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __tagHelperExecutionContext.AddHtmlAttribute("novalidate", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                </div>
            </div>
            <br />
            <br />
            <div class=""row d-none"" id=""clientInfo"">
                <div class=""col-md-12 alert alert-success"">
                    <h4 class=""mb-3"">Найденные клиенты</h4>
                    <div class=""panel panel-info"">
                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1bc1f4a73b6352598ee6dae33ba725576b98cbaf9291", async() => {
                WriteLiteral(@"
                            <div class=""col-md-12"">
                                <div class=""input-group"">
                                    <div class=""col-md-1"" id=""clientRadio"">
                                    </div>
                                    <div class=""col-md-3"" id=""clientFIO"">
                                    </div>
                                    <div class=""col-md-2"" id=""clientDate"">
                                    </div>
                                    <div class=""col-md-2"" id=""clientPhone"">
                                    </div>
                                    <div class=""col-md-2"" id=""clientPasport"">
                                    </div>
                                    <div class=""col-md-2"" id=""clientBirthPlace"">
                                    </div>
                                </div>
                            </div>
                            <button class=""btn btn-primary"" id=""selectClient"" type=""button"">ВЫБРАТЬ</but");
                WriteLiteral("ton>\r\n                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>
<script>
    var test;
    var test2;
    (function () {
        'use strict';
        window.addEventListener('load', function () {

            var model = {
                appendText: function (div, text, index) {
                    div.append(""<p class=''><label for='clients_"" + index + ""'>"" + text + ""</label></p>"");
                },
                appendRadio: function (div, text, index) {
                    div.append(""<p class=''><label><input type='radio' class='radioClient' name='clients_ibso' value="" + text + "" id='clients_"" + index + ""'></label></p>"");
                },
                clearText: function () {
                    $(""#clientFIO"").empty();
                    $(""#clientDate"").empty();
                    $(""#clientPhone"").empty();
                    $(""#clientPasport"").empty();
                    $(""#clientBirthPlace"").empty();
                },");
            WriteLiteral(@"
                clientSelected: function (params) {
                    $.get(""/Home/SelectedClient"", { ibsoid: params }, function (data) {
                        $('#content').html(data);
                    });
                }
            };

            $("":input"").inputmask();
            $(""#ibsoid"").inputmask(""9999999999999999"", { ""placeholder"": """" });
            $('#birthdate').inputmask({ ""mask"": ""99.99.9999"", ""placeholder"": 'MM.DD.YYYY' });
            $('#selectClient').on('click', function () {
                model.clientSelected($("".radioClient"").val());
            });
            // Fetch all the forms we want to apply custom Bootstrap validation styles to
            var forms = document.getElementsByClassName('needs-validation');
            // Loop over them and prevent submission
            var validation = Array.prototype.filter.call(forms, function (form) {
                form.addEventListener('submit', function (event) {
                    event.preventDefault()");
            WriteLiteral(@";
                    $(""#clientInfo"").addClass(""d-none"");
                    // Loop over them and prevent submission
                    if ($(""#fullname"").val() != '' || $(""#ibsoid"").val() != '' || $(""#phonenumber"").val().replace(/[^0-9]/gi, '').length == 11) {
                        $(""#fullname"").prop('required', false);
                        $(""#ibsoid"").prop('required', false);
                        $(""#phonenumber"").prop('required', false);
                    } else {
                        $(""#fullname"").prop('required', true);
                        $(""#ibsoid"").prop('required', true);
                        $(""#phonenumber"").prop('required', true);
                    }
                    if (form.checkValidity() === false) {
                        event.stopPropagation();
                    } else {
                        var params = JSON.stringify($(""#searchform"").serialize());
                        $.ajax({
                            url: ""/Home/FindClient"",
 ");
            WriteLiteral(@"                           type: ""POST"",
                            data: params,
                            failure: function (errMsg) {
                                alert(errMsg);
                            },
                            success: function (data) {
                                $(""#clientInfo"").removeClass(""d-none"");
                                model.clearText();
                                test2 = data.clients;
                                if (data.clients.length > 1) {
                                    console.log(""multiply"");
                                    $.each(data.clients, function (index, value) {
                                        test = value;
                                        model.appendRadio($(""#clientRadio""), value.ibso, index);
                                        model.appendText($(""#clientFIO""), value.fullName, index);
                                        model.appendText($(""#clientDate""), value.birthDate.slice(0, -9)");
            WriteLiteral(@", index);
                                        model.appendText($(""#clientPhone""), value.phone, index);
                                        model.appendText($(""#clientPasport""), value.passport, index);
                                        model.appendText($(""#clientBirthPlace""), value.birthPlace, index);
                                    });
                                    $(""#clients_0"").prop('checked', true);
                                } else {
                                    console.log(""Single"");
                                    model.clientSelected(value.ibso);
                                }
                            }
                        });
                    }
                    form.classList.add('was-validated');
                }, false);
            });
        }, false);
    })();
</script>");
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
