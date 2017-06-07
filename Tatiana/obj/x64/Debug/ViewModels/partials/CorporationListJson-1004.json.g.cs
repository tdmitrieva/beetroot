// This is a system generated file (G2). It reflects the Starcounter App Template defined in the file "ViewModels\partials\CorporationListJson.json"
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
using Tatiana.Models;
using Tatiana.Repositories;
#pragma warning disable 0108
#pragma warning disable 1591

namespace Tatiana.ViewModels {
using __Corporat3__ = global::Tatiana.ViewModels.CorporationListJsonItem.Input;
using _ScTemplate_ = Starcounter.Templates.Template;
using st = Starcounter.Templates;
using s = Starcounter;
using __CoHtml__ = global::Tatiana.ViewModels.CorporationListJson.Input.Html;
using __Corporat5__ = global::Tatiana.ViewModels.CorporationListJson.Input;
using __Arr__ = global::Starcounter.Arr<global::Tatiana.ViewModels.CorporationListJsonItem>;
using __Corporat4__ = global::Tatiana.ViewModels.CorporationListJson.JsonByExample;
using __TArray__ = global::Starcounter.Templates.TArray<global::Tatiana.ViewModels.CorporationListJsonItem>;
using __CoAddOffic__ = global::Tatiana.ViewModels.CorporationListJsonItem.Input.AddOfficeTrigger;
using __CoNewOffic__ = global::Tatiana.ViewModels.CorporationListJsonItem.Input.NewOfficeName;
using __CoTitle__ = global::Tatiana.ViewModels.CorporationListJsonItem.Input.Title;
using _GEN1_ = System.Diagnostics.DebuggerNonUserCodeAttribute;
using _GEN2_ = System.CodeDom.Compiler.GeneratedCodeAttribute;
using __TLong__ = global::Starcounter.Templates.TLong;
using __CoSchema1__ = global::Tatiana.ViewModels.CorporationListJsonItem.JsonByExample.Schema;
using __Corporat1__ = global::Tatiana.ViewModels.CorporationListJsonItem;
using __TString__ = global::Starcounter.Templates.TString;
using __CoSchema__ = global::Tatiana.ViewModels.CorporationListJson.JsonByExample.Schema;
using __Json1__ = global::Starcounter.Json.JsonByExample;
using __TObject__ = global::Starcounter.Templates.TObject;
using __Json__ = global::Starcounter.Json;
using __Corporat__ = global::Tatiana.ViewModels.CorporationListJson;
using __Corporat2__ = global::Tatiana.ViewModels.CorporationListJsonItem.JsonByExample;

#line hidden
[_GEN1_][_GEN2_("Starcounter","2.0")]
public class CorporationListJson_json : s::TemplateAttribute {
    
    #line hidden
    public class Corporations : s::TemplateAttribute {
    }
    #line default
}
#line default

#line hidden
public partial class CorporationListJsonItem : __Json__ {
    #line hidden
    [_GEN2_("Starcounter","2.0")]
    public static __CoSchema1__ DefaultTemplate = new __CoSchema1__();
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public CorporationListJsonItem() { }
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public CorporationListJsonItem(__CoSchema1__ template) { Template = template; }
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    protected override _ScTemplate_ GetDefaultTemplate() { return DefaultTemplate; }
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public new __CoSchema1__ Template { get { return (__CoSchema1__)base.Template; } set { base.Template = value; } }
    public override bool IsCodegenerated { get { return true; } }
    #line default
    
    #line hidden
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public static class JsonByExample {
        
        #line hidden
        public class Schema : __TObject__ {
            public Schema()
                : base() {
                InstanceType = typeof(__Corporat1__);
                Properties.ClearExposed();
                Title = Add<__TString__>("Title");
                Title.DefaultValue = "";
                Title.SetCustomAccessors((_p_) => { return ((__Corporat1__)_p_).__bf__Title__; }, (_p_, _v_) => { ((__Corporat1__)_p_).__bf__Title__ = (System.String)_v_; }, false);
                FranchiseOfficesView = Add<__TObject__>("FranchiseOfficesView");
                FranchiseOfficesView.SetCustomAccessors((_p_) => { return ((__Corporat1__)_p_).__bf__FranchiseOfficesView__; }, (_p_, _v_) => { ((__Corporat1__)_p_).__bf__FranchiseOfficesView__ = (__Json__)_v_; }, false);
                NewOfficeName = Add<__TString__>("NewOfficeName$");
                NewOfficeName.DefaultValue = "";
                NewOfficeName.Editable = true;
                NewOfficeName.SetCustomAccessors((_p_) => { return ((__Corporat1__)_p_).__bf__NewOfficeName__; }, (_p_, _v_) => { ((__Corporat1__)_p_).__bf__NewOfficeName__ = (System.String)_v_; }, false);
                AddOfficeTrigger = Add<__TLong__>("AddOfficeTrigger$");
                AddOfficeTrigger.DefaultValue = 0L;
                AddOfficeTrigger.Editable = true;
                AddOfficeTrigger.SetCustomAccessors((_p_) => { return ((__Corporat1__)_p_).__bf__AddOfficeTrigger__; }, (_p_, _v_) => { ((__Corporat1__)_p_).__bf__AddOfficeTrigger__ = (System.Int64)_v_; }, false);
                AddOfficeTrigger.AddHandler((Json pup, Property<Int64> prop, Int64 value) => { return (new Input.AddOfficeTrigger() { App = (CorporationListJsonItem)pup, Template = (TLong)prop, Value = value }); }, (Json pup, Starcounter.Input<Int64> input) => { ((CorporationListJsonItem)pup).Handle((Input.AddOfficeTrigger)input); });
            }
            public override object CreateInstance(s.Json parent) { return new __Corporat1__(this) { Parent = parent }; }
            public __TString__ Title;
            public __TObject__ FranchiseOfficesView;
            public __TString__ NewOfficeName;
            public __TLong__ AddOfficeTrigger;
        }
        #line default
    }
    #line default
    #line hidden
    private System.String __bf__Title__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.String Title {
    #line 5 "ViewModels\partials\CorporationListJson.json"
        get {
        #line hidden
            return Template.Title.Getter(this); }
        #line 5 "ViewModels\partials\CorporationListJson.json"
        set {
        #line hidden
            Template.Title.Setter(this, value); } }
        #line default
    #line hidden
    private __Json__ __bf__FranchiseOfficesView__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public __Json__ FranchiseOfficesView {
    #line 6 "ViewModels\partials\CorporationListJson.json"
        get {
        #line hidden
            return (__Json__)Template.FranchiseOfficesView.Getter(this); }
        #line 6 "ViewModels\partials\CorporationListJson.json"
        set {
        #line hidden
            Template.FranchiseOfficesView.Setter(this, value); } }
        #line default
    #line hidden
    private System.String __bf__NewOfficeName__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.String NewOfficeName {
    #line 7 "ViewModels\partials\CorporationListJson.json"
        get {
        #line hidden
            return Template.NewOfficeName.Getter(this); }
        #line 7 "ViewModels\partials\CorporationListJson.json"
        set {
        #line hidden
            Template.NewOfficeName.Setter(this, value); } }
        #line default
    #line hidden
    private System.Int64 __bf__AddOfficeTrigger__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.Int64 AddOfficeTrigger {
    #line 8 "ViewModels\partials\CorporationListJson.json"
        get {
        #line hidden
            return Template.AddOfficeTrigger.Getter(this); }
        #line 8 "ViewModels\partials\CorporationListJson.json"
        set {
        #line hidden
            Template.AddOfficeTrigger.Setter(this, value); } }
        #line default
    
    #line hidden
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public static class Input {
        
        #line hidden
        public class Title : Input<__Corporat1__, __TString__, string> {
        }
        #line default
        
        #line hidden
        public class NewOfficeName : Input<__Corporat1__, __TString__, string> {
        }
        #line default
        
        #line hidden
        public class AddOfficeTrigger : Input<__Corporat1__, __TLong__, long> {
        }
        #line default
    }
    #line default
}
#line default

#line hidden
public partial class CorporationListJson : __Json__ {
    #line hidden
    [_GEN2_("Starcounter","2.0")]
    public static __CoSchema__ DefaultTemplate = new __CoSchema__();
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public CorporationListJson() { }
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public CorporationListJson(__CoSchema__ template) { Template = template; }
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    protected override _ScTemplate_ GetDefaultTemplate() { return DefaultTemplate; }
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public new __CoSchema__ Template { get { return (__CoSchema__)base.Template; } set { base.Template = value; } }
    public override bool IsCodegenerated { get { return true; } }
    #line default
    
    #line hidden
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public static class JsonByExample {
        
        #line hidden
        public class Schema : __TObject__ {
            public Schema()
                : base() {
                InstanceType = typeof(__Corporat__);
                Properties.ClearExposed();
                Html = Add<__TString__>("Html");
                Html.DefaultValue = "/tatiana/CorporationListJson.html";
                Html.SetCustomAccessors((_p_) => { return ((__Corporat__)_p_).__bf__Html__; }, (_p_, _v_) => { ((__Corporat__)_p_).__bf__Html__ = (System.String)_v_; }, false);
                Corporations = Add<__TArray__>("Corporations", bind:"Corporations");
                Corporations.SetCustomGetElementType((arr) => { return __Corporat1__.DefaultTemplate;});
                Corporations.SetCustomAccessors((_p_) => { return ((__Corporat__)_p_).__bf__Corporations__; }, (_p_, _v_) => { ((__Corporat__)_p_).__bf__Corporations__ = (__Arr__)_v_; }, false);
            }
            public override object CreateInstance(s.Json parent) { return new __Corporat__(this) { Parent = parent }; }
            public __TString__ Html;
            public __TArray__ Corporations;
        }
        #line default
    }
    #line default
    #line hidden
    private System.String __bf__Html__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.String Html {
    #line 2 "ViewModels\partials\CorporationListJson.json"
        get {
        #line hidden
            return Template.Html.Getter(this); }
        #line 2 "ViewModels\partials\CorporationListJson.json"
        set {
        #line hidden
            Template.Html.Setter(this, value); } }
        #line default
    #line hidden
    private __Arr__ __bf__Corporations__;
    #line default
    
    #line hidden
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public static class Input {
        
        #line hidden
        public class Html : Input<__Corporat__, __TString__, string> {
        }
        #line default
    }
    #line default
}
#line default
}
#pragma warning restore 1591
#pragma warning restore 0108
