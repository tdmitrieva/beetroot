// This is a system generated file (G2). It reflects the Starcounter App Template defined in the file "ViewModels\CorporationList.json"
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
using Tatiana.Repositories;
#pragma warning disable 0108
#pragma warning disable 1591

namespace Tatiana.ViewModels {
using __Corporat__ = global::Tatiana.ViewModels.CorporationList;
using __Json__ = global::Starcounter.Json;
using __TObject__ = global::Starcounter.Templates.TObject;
using __Json1__ = global::Starcounter.Json.JsonByExample;
using __CoSchema__ = global::Tatiana.ViewModels.CorporationList.JsonByExample.Schema;
using __TString__ = global::Starcounter.Templates.TString;
using __Corporat1__ = global::Tatiana.ViewModels.CorporationList.JsonByExample;
using __Corporat2__ = global::Tatiana.ViewModels.CorporationList.Input;
using __CoTitle__ = global::Tatiana.ViewModels.CorporationList.Input.Title;
using s = Starcounter;
using st = Starcounter.Templates;
using _ScTemplate_ = Starcounter.Templates.Template;
using _GEN1_ = System.Diagnostics.DebuggerNonUserCodeAttribute;
using _GEN2_ = System.CodeDom.Compiler.GeneratedCodeAttribute;

#line hidden
public partial class CorporationList : __Json__ {
    #line hidden
    [_GEN2_("Starcounter","2.0")]
    public static __CoSchema__ DefaultTemplate = new __CoSchema__();
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public CorporationList() { }
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public CorporationList(__CoSchema__ template) { Template = template; }
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
                Title = Add<__TString__>("Title");
                Title.DefaultValue = "";
                Title.SetCustomAccessors((_p_) => { return ((__Corporat__)_p_).__bf__Title__; }, (_p_, _v_) => { ((__Corporat__)_p_).__bf__Title__ = (System.String)_v_; }, false);
            }
            public override object CreateInstance(s.Json parent) { return new __Corporat__(this) { Parent = parent }; }
            public __TString__ Title;
        }
        #line default
    }
    #line default
    #line hidden
    private System.String __bf__Title__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.String Title {
    #line 2 "ViewModels\CorporationList.json"
        get {
        #line hidden
            return Template.Title.Getter(this); }
        #line 2 "ViewModels\CorporationList.json"
        set {
        #line hidden
            Template.Title.Setter(this, value); } }
        #line default
    
    #line hidden
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public static class Input {
        
        #line hidden
        public class Title : Input<__Corporat__, __TString__, string> {
        }
        #line default
    }
    #line default
}
#line default

#line hidden
[_GEN1_][_GEN2_("Starcounter","2.0")]
public class CorporationList_json : s::TemplateAttribute {
}
#line default
}
#pragma warning restore 1591
#pragma warning restore 0108
