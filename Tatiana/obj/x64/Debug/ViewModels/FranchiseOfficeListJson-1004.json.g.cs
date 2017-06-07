// This is a system generated file (G2). It reflects the Starcounter App Template defined in the file "ViewModels\FranchiseOfficeListJson.json"
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
using __FrName__ = global::Tatiana.ViewModels.FranchiseOfficeListJson.Input.Name;
using _ScTemplate_ = Starcounter.Templates.Template;
using st = Starcounter.Templates;
using s = Starcounter;
using __FrAddTrigg__ = global::Tatiana.ViewModels.FranchiseOfficeListJson.Input.AddTrigger;
using __FrTrend__ = global::Tatiana.ViewModels.FranchiseOfficeListJson.Input.Trend;
using __FrAvgComis__ = global::Tatiana.ViewModels.FranchiseOfficeListJson.Input.AvgComission;
using __FrTotalCom__ = global::Tatiana.ViewModels.FranchiseOfficeListJson.Input.TotalComission;
using __FrSoldHome__ = global::Tatiana.ViewModels.FranchiseOfficeListJson.Input.SoldHomes;
using _GEN1_ = System.Diagnostics.DebuggerNonUserCodeAttribute;
using _GEN2_ = System.CodeDom.Compiler.GeneratedCodeAttribute;
using __Franchis1__ = global::Tatiana.ViewModels.FranchiseOfficeListJson.JsonByExample;
using __TString__ = global::Starcounter.Templates.TString;
using __FrSchema__ = global::Tatiana.ViewModels.FranchiseOfficeListJson.JsonByExample.Schema;
using __Json1__ = global::Starcounter.Json.JsonByExample;
using __TObject__ = global::Starcounter.Templates.TObject;
using __Json__ = global::Starcounter.Json;
using __Franchis__ = global::Tatiana.ViewModels.FranchiseOfficeListJson;
using __Franchis2__ = global::Tatiana.ViewModels.FranchiseOfficeListJson.Input;

#line hidden
[_GEN1_][_GEN2_("Starcounter","2.0")]
public class FranchiseOfficeListJson_json : s::TemplateAttribute {
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
                Name = Add<__TString__>("Name$");
                Name.DefaultValue = "";
                Name.Editable = true;
                Name.SetCustomAccessors((_p_) => { return ((__Franchis__)_p_).__bf__Name__; }, (_p_, _v_) => { ((__Franchis__)_p_).__bf__Name__ = (System.String)_v_; }, false);
                SoldHomes = Add<__TString__>("SoldHomes");
                SoldHomes.DefaultValue = "";
                SoldHomes.SetCustomAccessors((_p_) => { return ((__Franchis__)_p_).__bf__SoldHomes__; }, (_p_, _v_) => { ((__Franchis__)_p_).__bf__SoldHomes__ = (System.String)_v_; }, false);
                TotalComission = Add<__TString__>("TotalComission");
                TotalComission.DefaultValue = "";
                TotalComission.SetCustomAccessors((_p_) => { return ((__Franchis__)_p_).__bf__TotalComission__; }, (_p_, _v_) => { ((__Franchis__)_p_).__bf__TotalComission__ = (System.String)_v_; }, false);
                AvgComission = Add<__TString__>("AvgComission");
                AvgComission.DefaultValue = "";
                AvgComission.SetCustomAccessors((_p_) => { return ((__Franchis__)_p_).__bf__AvgComission__; }, (_p_, _v_) => { ((__Franchis__)_p_).__bf__AvgComission__ = (System.String)_v_; }, false);
                Trend = Add<__TString__>("Trend");
                Trend.DefaultValue = "";
                Trend.SetCustomAccessors((_p_) => { return ((__Franchis__)_p_).__bf__Trend__; }, (_p_, _v_) => { ((__Franchis__)_p_).__bf__Trend__ = (System.String)_v_; }, false);
                AddTrigger = Add<__TString__>("AddTrigger$");
                AddTrigger.DefaultValue = "";
                AddTrigger.Editable = true;
                AddTrigger.SetCustomAccessors((_p_) => { return ((__Franchis__)_p_).__bf__AddTrigger__; }, (_p_, _v_) => { ((__Franchis__)_p_).__bf__AddTrigger__ = (System.String)_v_; }, false);
                AddTrigger.AddHandler((Json pup, Property<String> prop, String value) => { return (new Input.AddTrigger() { App = (FranchiseOfficeListJson)pup, Template = (TString)prop, Value = value }); }, (Json pup, Starcounter.Input<String> input) => { ((FranchiseOfficeListJson)pup).Handle((Input.AddTrigger)input); });
            }
            public override object CreateInstance(s.Json parent) { return new __Franchis__(this) { Parent = parent }; }
            public __TString__ Name;
            public __TString__ SoldHomes;
            public __TString__ TotalComission;
            public __TString__ AvgComission;
            public __TString__ Trend;
            public __TString__ AddTrigger;
        }
        #line default
    }
    #line default
    #line hidden
    private System.String __bf__Name__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.String Name {
    #line 2 "ViewModels\FranchiseOfficeListJson.json"
        get {
        #line hidden
            return Template.Name.Getter(this); }
        #line 2 "ViewModels\FranchiseOfficeListJson.json"
        set {
        #line hidden
            Template.Name.Setter(this, value); } }
        #line default
    #line hidden
    private System.String __bf__SoldHomes__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.String SoldHomes {
    #line 3 "ViewModels\FranchiseOfficeListJson.json"
        get {
        #line hidden
            return Template.SoldHomes.Getter(this); }
        #line 3 "ViewModels\FranchiseOfficeListJson.json"
        set {
        #line hidden
            Template.SoldHomes.Setter(this, value); } }
        #line default
    #line hidden
    private System.String __bf__TotalComission__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.String TotalComission {
    #line 4 "ViewModels\FranchiseOfficeListJson.json"
        get {
        #line hidden
            return Template.TotalComission.Getter(this); }
        #line 4 "ViewModels\FranchiseOfficeListJson.json"
        set {
        #line hidden
            Template.TotalComission.Setter(this, value); } }
        #line default
    #line hidden
    private System.String __bf__AvgComission__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.String AvgComission {
    #line 5 "ViewModels\FranchiseOfficeListJson.json"
        get {
        #line hidden
            return Template.AvgComission.Getter(this); }
        #line 5 "ViewModels\FranchiseOfficeListJson.json"
        set {
        #line hidden
            Template.AvgComission.Setter(this, value); } }
        #line default
    #line hidden
    private System.String __bf__Trend__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.String Trend {
    #line 6 "ViewModels\FranchiseOfficeListJson.json"
        get {
        #line hidden
            return Template.Trend.Getter(this); }
        #line 6 "ViewModels\FranchiseOfficeListJson.json"
        set {
        #line hidden
            Template.Trend.Setter(this, value); } }
        #line default
    #line hidden
    private System.String __bf__AddTrigger__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.String AddTrigger {
    #line 7 "ViewModels\FranchiseOfficeListJson.json"
        get {
        #line hidden
            return Template.AddTrigger.Getter(this); }
        #line 7 "ViewModels\FranchiseOfficeListJson.json"
        set {
        #line hidden
            Template.AddTrigger.Setter(this, value); } }
        #line default
    
    #line hidden
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public static class Input {
        
        #line hidden
        public class Name : Input<__Franchis__, __TString__, string> {
        }
        #line default
        
        #line hidden
        public class SoldHomes : Input<__Franchis__, __TString__, string> {
        }
        #line default
        
        #line hidden
        public class TotalComission : Input<__Franchis__, __TString__, string> {
        }
        #line default
        
        #line hidden
        public class AvgComission : Input<__Franchis__, __TString__, string> {
        }
        #line default
        
        #line hidden
        public class Trend : Input<__Franchis__, __TString__, string> {
        }
        #line default
        
        #line hidden
        public class AddTrigger : Input<__Franchis__, __TString__, string> {
        }
        #line default
    }
    #line default
}
#line default
}
#pragma warning restore 1591
#pragma warning restore 0108
