#pragma checksum "E:\2018Project\ERP项目\SoaProJect\FytSoa.Web\Pages\FytAdmin\Sale\ReturnValidation.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6ac6203efd632f3c4a5bacee5fd8f060f158c797"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(FytSoa.Web.Pages.FytAdmin.Sale.Pages_FytAdmin_Sale_ReturnValidation), @"mvc.1.0.razor-page", @"/Pages/FytAdmin/Sale/ReturnValidation.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/FytAdmin/Sale/ReturnValidation.cshtml", typeof(FytSoa.Web.Pages.FytAdmin.Sale.Pages_FytAdmin_Sale_ReturnValidation), null)]
namespace FytSoa.Web.Pages.FytAdmin.Sale
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "E:\2018Project\ERP项目\SoaProJect\FytSoa.Web\Pages\_ViewImports.cshtml"
using FytSoa.Web;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6ac6203efd632f3c4a5bacee5fd8f060f158c797", @"/Pages/FytAdmin/Sale/ReturnValidation.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"21c44af9864cf57cf01e8fd1fe389a8e352e148c", @"/Pages/_ViewImports.cshtml")]
    public class Pages_FytAdmin_Sale_ReturnValidation : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("from-app"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("layui-form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("text/javascript"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/themes/js/modules/vue.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "E:\2018Project\ERP项目\SoaProJect\FytSoa.Web\Pages\FytAdmin\Sale\ReturnValidation.cshtml"
  
    ViewData["Title"] = "返货效验";
    Layout = "~/Pages/FytAdmin/_Layout.cshtml";

#line default
#line hidden
            BeginContext(157, 236, true);
            WriteLiteral("<style>\r\n    .layui-btn .layui-icon {\r\n        vertical-align: middle;\r\n        top: -2px;\r\n        position: relative;\r\n    }\r\n</style>\r\n<div id=\"app\">\r\n    <div class=\"layui-form list-search\" style=\"margin:0px 12px 0 12px;\">\r\n        ");
            EndContext();
            BeginContext(393, 718, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "aa353b35381441729a050cf8df34e125", async() => {
                BeginContext(442, 528, true);
                WriteLiteral(@"
            <div class=""layui-inline"">
                <input class=""layui-input"" id=""Code"" name=""Code"" autocomplete=""off"" placeholder=""条形码"">
            </div>
            <div class=""layui-inline"">
                <input class=""layui-input"" id=""Count"" name=""Count"" value=""1"" autocomplete=""off"" placeholder=""数量"">
            </div>
            <div class=""layui-inline"">
                <button class=""layui-btn"" lay-submit="""" lay-filter=""submit"">立即提交</button>
                <button type=""button"" class=""layui-btn"" ");
                EndContext();
                BeginContext(971, 133, true);
                WriteLiteral("@click=\"validation\" style=\"margin-left:100px;\"><i class=\"layui-icon layui-icon-read\"></i> 确定对比</button>\r\n            </div>\r\n        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1111, 733, true);
            WriteLiteral(@"
    </div>
    <div class=""list-wall"" style=""padding-top:0px;"">
        <table class=""layui-table fyt-table"">
            <thead>
                <tr>
                    <th width=""60""><span>序号</span></th>
                    <th><span>条形码</span></th>
                    <th width=""100""><span>数量</span></th>
                    <th width=""60""><span>操作</span></th>
                </tr>
            </thead>
            <tbody>
                <tr v-for=""it,index in tabList"">
                    <td align=""center"">{{index+1}}</td>
                    <td>{{it.Code}}</td>
                    <td><input type=""number"" v-model=""it.Count"" class=""layui-input"" style=""height:26px;"" /></td>
                    <td><i ");
            EndContext();
            BeginContext(1845, 181, true);
            WriteLiteral("@click=\"delTableRow(index)\" class=\"layui-icon layui-icon-close\" style=\"cursor:pointer\"></i></td>\r\n                </tr>\r\n            </tbody>\r\n        </table>\r\n    </div>\r\n</div>\r\n");
            EndContext();
            BeginContext(2026, 73, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b12fc119374a4c89a67acb9961e24878", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2099, 615, true);
            WriteLiteral(@"
<script>
    var vm = new Vue({
        el: '#app',
        data: {
            tabList: [
                //{ 'Code': 'abc', 'Count': '1' }
            ],
        },
        methods: {
            delTableRow: function (index) {
                this.tabList.splice(index,1);
            },
            validation: function () { 
                console.log(this.tabList);
            }
        }
    });
    layui.config({
        base: '/themes/js/modules/'
    }).use(['layer', 'jquery', 'common', 'form'], function () {
        var form = layui.form, $ = layui.$, os = layui.common,order=""");
            EndContext();
            BeginContext(2715, 15, false);
#line 71 "E:\2018Project\ERP项目\SoaProJect\FytSoa.Web\Pages\FytAdmin\Sale\ReturnValidation.cshtml"
                                                                Write(Model.orderGuid);

#line default
#line hidden
            EndContext();
            BeginContext(2730, 1379, true);
            WriteLiteral(@""";
        $(""#Code"").focus();
        /*$(""#Code"").keyup(function () {
            if ($(""#Code"").val().length == 16) {
                var isEx = false;
                for (var i = 0; i < vm.tabList.length; i++) {
                    if (vm.tabList[i].Code == $(""#Code"").val()) {
                        isEx = true;
                        vm.tabList[i].Count = parseInt(vm.tabList[i].Count) + parseInt($(""#Count"").val());
                    }
                }
                if (!isEx) {
                    vm.tabList.push({ 'Code': $(""#Code"").val(), 'Count': $(""#Count"").val() });
                }
                $(""#Code"").val('');
                $(""#Code"").focus();
        });*/
        //对比提交
        form.on('submit(submit)', function (data) {
            var isEx = false;
            for (var i = 0; i < vm.tabList.length; i++) {
                if (vm.tabList[i].Code == data.field.Code) {
                    isEx = true;
                    vm.tabList[i].Count = ");
            WriteLiteral(@"parseInt(vm.tabList[i].Count) + parseInt($(""#Count"").val());
                }
            }
            if (!isEx) {
                vm.tabList.push({ 'Code': data.field.Code, 'Count': data.field.Count });
            }
            $(""#Code"").val('');
            $(""#Code"").focus();
            return false;
        });
    });
</script>

");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<FytSoa.Web.Pages.FytAdmin.Sale.ReturnValidationModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<FytSoa.Web.Pages.FytAdmin.Sale.ReturnValidationModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<FytSoa.Web.Pages.FytAdmin.Sale.ReturnValidationModel>)PageContext?.ViewData;
        public FytSoa.Web.Pages.FytAdmin.Sale.ReturnValidationModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591