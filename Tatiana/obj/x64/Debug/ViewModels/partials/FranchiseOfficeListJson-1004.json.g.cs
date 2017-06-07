// This is a system generated file (G2). It reflects the Starcounter App Template defined in the file "ViewModels\partials\FranchiseOfficeListJson.json"
// Version: 1004
// DO NOT MODIFY DIRECTLY - CHANGES WILL BE OVERWRITTEN

using System;
using System.Collections;
using System.Collections.Generic;
using Starcounter.Advanced;
using Starcounter;
using Starcounter.Internal;
using Starcounter.Templates;
using Starcounter.XSON;
#pragma warning disable 0108
#pragma warning disable 1591

namespace Tatiana.ViewModels {
using __FrUrl__ = global::Tatiana.ViewModels.FranchiseOfficeListItemJson.Input.Url;
using _ScTemplate_ = Starcounter.Templates.Template;
using st = Starcounter.Templates;
using s = Starcounter;
using __FrHtml__ = global::Tatiana.ViewModels.FranchiseOfficeListJson.Input.Html;
using __Franchis5__ = global::Tatiana.ViewModels.FranchiseOfficeListJson.Input;
using __Arr__ = global::Starcounter.Arr<global::Tatiana.ViewModels.FranchiseOfficeListItemJson>;
using __Franchis4__ = global::Tatiana.ViewModels.FranchiseOfficeListJson.JsonByExample;
using __TArray__ = global::Starcounter.Templates.TArray<global::Tatiana.ViewModels.FranchiseOfficeListItemJson>;
using __FrTrend__ = global::Tatiana.ViewModels.FranchiseOfficeListItemJson.Input.Trend;
using __FrAvgComis__ = global::Tatiana.ViewModels.FranchiseOfficeListItemJson.Input.AvgComission;
using __FrTotalCom__ = global::Tatiana.ViewModels.FranchiseOfficeListItemJson.Input.TotalComission;
using __FrSoldHome__ = global::Tatiana.ViewModels.FranchiseOfficeListItemJson.Input.SoldHomes;
using __FrKey__ = global::Tatiana.ViewModels.FranchiseOfficeListItemJson.Input.Key;
using _GEN1_ = System.Diagnostics.DebuggerNonUserCodeAttribute;
using _GEN2_ = System.CodeDom.Compiler.GeneratedCodeAttribute;
using __Franchis3__ = global::Tatiana.ViewModels.FranchiseOfficeListItemJson.Input;
using __Franchis2__ = global::Tatiana.ViewModels.FranchiseOfficeListItemJson.JsonByExample;
using __TLong__ = global::Starcounter.Templates.TLong;
using __FrSchema1__ = global::Tatiana.ViewModels.FranchiseOfficeListItemJson.JsonByExample.Schema;
using __Franchis1__ = global::Tatiana.ViewModels.FranchiseOfficeListItemJson;
using __TString__ = global::Starcounter.Templates.TString;
using __FrSchema__ = global::Tatiana.ViewModels.FranchiseOfficeListJson.JsonByExample.Schema;
using __Json1__ = global::Starcounter.Json.JsonByExample;
using __TObject__ = global::Starcounter.Templates.TObject;
using __Json__ = global::Starcounter.Json;
using __Franchis__ = global::Tatiana.ViewModels.FranchiseOfficeListJson;
using __FrName__ = global::Tatiana.ViewModels.FranchiseOfficeListItemJson.Input.Name;

#line hidden
[_GEN1_][_GEN2_("Starcounter","2.0")]
public class FranchiseOfficeListJson_json : s::TemplateAttribute {
    
    #line hidden
    public class FranchiseOffices : s::TemplateAttribute {
    }
    #line default
}
#line default

#line hidden
public partial class FranchiseOfficeListItemJson : __Json__ {
    #line hidden
    [_GEN2_("Starcounter","2.0")]
    public static __FrSchema1__ DefaultTemplate = new __FrSchema1__();
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public FranchiseOfficeListItemJson() { }
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public FranchiseOfficeListItemJson(__FrSchema1__ template) { Template = template; }
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    protected override _ScTemplate_ GetDefaultTemplate() { return DefaultTemplate; }
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public new __FrSchema1__ Template { get { return (__FrSchema1__)base.Template; } set { base.Template = value; } }
    public override bool IsCodegenerated { get { return true; } }
    #line default
    
    #line hidden
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public static class JsonByExample {
        
        #line hidden
        public class Schema : __TObject__ {
            public Schema()
                : base() {
                InstanceType = typeof(__Franchis1__);
                Properties.ClearExposed();
                Name = Add<__TString__>("Name");
                Name.DefaultValue = "";
                Name.SetCustomAccessors((_p_) => { return ((__Franchis1__)_p_).__bf__Name__; }, (_p_, _v_) => { ((__Franchis1__)_p_).__bf__Name__ = (System.String)_v_; }, false);
                Url = Add<__TString__>("Url");
                Url.DefaultValue = "";
                Url.SetCustomAccessors((_p_) => { return ((__Franchis1__)_p_).__bf__Url__; }, (_p_, _v_) => { ((__Franchis1__)_p_).__bf__Url__ = (System.String)_v_; }, false);
                Key = Add<__TString__>("Key");
                Key.DefaultValue = "";
                Key.SetCustomAccessors((_p_) => { return ((__Franchis1__)_p_).__bf__Key__; }, (_p_, _v_) => { ((__Franchis1__)_p_).__bf__Key__ = (System.String)_v_; }, false);
                SoldHomes = Add<__TLong__>("SoldHomes");
                SoldHomes.DefaultValue = 0L;
                SoldHomes.SetCustomAccessors((_p_) => { return ((__Franchis1__)_p_).__bf__SoldHomes__; }, (_p_, _v_) => { ((__Franchis1__)_p_).__bf__SoldHomes__ = (System.Int64)_v_; }, false);
                TotalComission = Add<__TLong__>("TotalComission");
                TotalComission.DefaultValue = 0L;
                TotalComission.SetCustomAccessors((_p_) => { return ((__Franchis1__)_p_).__bf__TotalComission__; }, (_p_, _v_) => { ((__Franchis1__)_p_).__bf__TotalComission__ = (System.Int64)_v_; }, false);
                AvgComission = Add<__TLong__>("AvgComission");
                AvgComission.DefaultValue = 0L;
                AvgComission.SetCustomAccessors((_p_) => { return ((__Franchis1__)_p_).__bf__AvgComission__; }, (_p_, _v_) => { ((__Franchis1__)_p_).__bf__AvgComission__ = (System.Int64)_v_; }, false);
                Trend = Add<__TLong__>("Trend");
                Trend.DefaultValue = 0L;
                Trend.SetCustomAccessors((_p_) => { return ((__Franchis1__)_p_).__bf__Trend__; }, (_p_, _v_) => { ((__Franchis1__)_p_).__bf__Trend__ = (System.Int64)_v_; }, false);
            }
            public override object CreateInstance(s.Json parent) { return new __Franchis1__(this) { Parent = parent }; }
            public __TString__ Name;
            public __TString__ Url;
            public __TString__ Key;
            public __TLong__ SoldHomes;
            public __TLong__ TotalComission;
            public __TLong__ AvgComission;
            public __TLong__ Trend;
        }
        #line default
    }
    #line default
    #line hidden
    private System.String __bf__Name__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.String Name {
    #line 5 "ViewModels\partials\FranchiseOfficeListJson.json"
        get {
        #line hidden
            return Template.Name.Getter(this); }
        #line 5 "ViewModels\partials\FranchiseOfficeListJson.json"
        set {
        #line hidden
            Template.Name.Setter(this, value); } }
        #line default
    #line hidden
    private System.String __bf__Url__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.String Url {
    #line 6 "ViewModels\partials\FranchiseOfficeListJson.json"
        get {
        #line hidden
            return Template.Url.Getter(this); }
        #line 6 "ViewModels\partials\FranchiseOfficeListJson.json"
        set {
        #line hidden
            Template.Url.Setter(this, value); } }
        #line default
    #line hidden
    private System.String __bf__Key__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.String Key {
    #line 7 "ViewModels\partials\FranchiseOfficeListJson.json"
        get {
        #line hidden
            return Template.Key.Getter(this); }
        #line 7 "ViewModels\partials\FranchiseOfficeListJson.json"
        set {
        #line hidden
            Template.Key.Setter(this, value); } }
        #line default
    #line hidden
    private System.Int64 __bf__SoldHomes__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.Int64 SoldHomes {
    #line 8 "ViewModels\partials\FranchiseOfficeListJson.json"
        get {
        #line hidden
            return Template.SoldHomes.Getter(this); }
        #line 8 "ViewModels\partials\FranchiseOfficeListJson.json"
        set {
        #line hidden
            Template.SoldHomes.Setter(this, value); } }
        #line default
    #line hidden
    private System.Int64 __bf__TotalComission__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.Int64 TotalComission {
    #line 9 "ViewModels\partials\FranchiseOfficeListJson.json"
        get {
        #line hidden
            return Template.TotalComission.Getter(this); }
        #line 9 "ViewModels\partials\FranchiseOfficeListJson.json"
        set {
        #line hidden
            Template.TotalComission.Setter(this, value); } }
        #line default
    #line hidden
    private System.Int64 __bf__AvgComission__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.Int64 AvgComission {
    #line 10 "ViewModels\partials\FranchiseOfficeListJson.json"
        get {
        #line hidden
            return Template.AvgComission.Getter(this); }
        #line 10 "ViewModels\partials\FranchiseOfficeListJson.json"
        set {
        #line hidden
            Template.AvgComission.Setter(this, value); } }
        #line default
    #line hidden
    private System.Int64 __bf__Trend__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.Int64 Trend {
    #line 11 "ViewModels\partials\FranchiseOfficeListJson.json"
        get {
        #line hidden
            return Template.Trend.Getter(this); }
        #line 11 "ViewModels\partials\FranchiseOfficeListJson.json"
        set {
        #line hidden
            Template.Trend.Setter(this, value); } }
        #line default
    
    #line hidden
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public static class Input {
        
        #line hidden
        public class Name : Input<__Franchis1__, __TString__, string> {
        }
        #line default
        
        #line hidden
        public class Url : Input<__Franchis1__, __TString__, string> {
        }
        #line default
        
        #line hidden
        public class Key : Input<__Franchis1__, __TString__, string> {
        }
        #line default
        
        #line hidden
        public class SoldHomes : Input<__Franchis1__, __TLong__, long> {
        }
        #line default
        
        #line hidden
        public class TotalComission : Input<__Franchis1__, __TLong__, long> {
        }
        #line default
        
        #line hidden
        public class AvgComission : Input<__Franchis1__, __TLong__, long> {
        }
        #line default
        
        #line hidden
        public class Trend : Input<__Franchis1__, __TLong__, long> {
        }
        #line default
    }
    #line default
}
#line default

#line hidden
public partial class FranchiseOfficeListJson : __Json__ {
    #line hidden
    [_GEN2_("Starcounter","2.0")]
    public static __FrSchema__ DefaultTemplate = new __FrSchema__();
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public FranchiseOfficeListJson() { }
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public FranchiseOfficeListJson(__FrSchema__ template) { Template = template; }
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    protected override _ScTemplate_ GetDefaultTemplate() { return DefaultTemplate; }
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public new __FrSchema__ Template { get { return (__FrSchema__)base.Template; } set { base.Template = value; } }
    public override bool IsCodegenerated { get { return true; } }
    #line default
    
    #line hidden
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public static class JsonByExample {
        
        #line hidden
        public class Schema : __TObject__ {
            public Schema()
                : base() {
                InstanceType = typeof(__Franchis__);
                Properties.ClearExposed();
                Html = Add<__TString__>("Html");
                Html.DefaultValue = "/tatiana/FranchiseOfficeListJson.html";
                Html.SetCustomAccessors((_p_) => { return ((__Franchis__)_p_).__bf__Html__; }, (_p_, _v_) => { ((__Franchis__)_p_).__bf__Html__ = (System.String)_v_; }, false);
                FranchiseOffices = Add<__TArray__>("FranchiseOffices", bind:"FranchiseOffices");
                FranchiseOffices.SetCustomGetElementType((arr) => { return __Franchis1__.DefaultTemplate;});
                FranchiseOffices.SetCustomAccessors((_p_) => { return ((__Franchis__)_p_).__bf__FranchiseOffices__; }, (_p_, _v_) => { ((__Franchis__)_p_).__bf__FranchiseOffices__ = (__Arr__)_v_; }, false);
            }
            public override object CreateInstance(s.Json parent) { return new __Franchis__(this) { Parent = parent }; }
            public __TString__ Html;
            public __TArray__ FranchiseOffices;
        }
        #line default
    }
    #line default
    #line hidden
    private System.String __bf__Html__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.String Html {
    #line 2 "ViewModels\partials\FranchiseOfficeListJson.json"
        get {
        #line hidden
            return Template.Html.Getter(this); }
        #line 2 "ViewModels\partials\FranchiseOfficeListJson.json"
        set {
        #line hidden
            Template.Html.Setter(this, value); } }
        #line default
    #line hidden
    private __Arr__ __bf__FranchiseOffices__;
    #line default
    
    #line hidden
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public static class Input {
        
        #line hidden
        public class Html : Input<__Franchis__, __TString__, string> {
        }
        #line default
    }
    #line default
}
#line default
}
#pragma warning restore 1591
#pragma warning restore 0108
