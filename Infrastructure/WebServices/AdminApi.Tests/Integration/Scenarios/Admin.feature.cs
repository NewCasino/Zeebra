﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:1.9.0.77
//      SpecFlow Generator Version:1.9.0.0
//      Runtime Version:4.0.30319.42000
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace AFT.RegoV2.AdminApi.Tests.Integration.Scenarios
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "1.9.0.77")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("Admin")]
    [NUnit.Framework.CategoryAttribute("Integration")]
    public partial class AdminFeature
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "Admin.feature"
#line hidden
        
        [NUnit.Framework.TestFixtureSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Admin", "  As a user, I can manage country, culture, currency", ProgrammingLanguage.CSharp, new string[] {
                        "Integration"});
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [NUnit.Framework.TestFixtureTearDownAttribute()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        [NUnit.Framework.SetUpAttribute()]
        public virtual void TestInitialize()
        {
        }
        
        [NUnit.Framework.TearDownAttribute()]
        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioSetup(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioStart(scenarioInfo);
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Get country by code")]
        public virtual void GetCountryByCode()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Get country by code", ((string[])(null)));
#line 12
this.ScenarioSetup(scenarioInfo);
#line 13
    testRunner.Given("I am logged in and have access token", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 14
    testRunner.When("New country is created", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 15
    testRunner.Then("Country by code is visible to me", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Save country data")]
        public virtual void SaveCountryData()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Save country data", ((string[])(null)));
#line 17
this.ScenarioSetup(scenarioInfo);
#line 18
    testRunner.Given("I am logged in and have access token", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 19
    testRunner.Then("Country data is successfully saved", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Delete country")]
        public virtual void DeleteCountry()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Delete country", ((string[])(null)));
#line 21
this.ScenarioSetup(scenarioInfo);
#line 22
    testRunner.Given("I am logged in and have access token", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 23
    testRunner.When("New country is created", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 24
    testRunner.Then("Country is successfully deleted", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Get culture by code")]
        public virtual void GetCultureByCode()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Get culture by code", ((string[])(null)));
#line 32
this.ScenarioSetup(scenarioInfo);
#line 33
    testRunner.Given("I am logged in and have access token", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 34
    testRunner.When("New culture is created", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 35
    testRunner.Then("Culture by code is visible to me", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Activate culture")]
        public virtual void ActivateCulture()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Activate culture", ((string[])(null)));
#line 37
this.ScenarioSetup(scenarioInfo);
#line 38
    testRunner.Given("I am logged in and have access token", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 39
    testRunner.When("New culture is created", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 40
    testRunner.Then("Culture is successfully activated", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Deactivate culture")]
        public virtual void DeactivateCulture()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Deactivate culture", ((string[])(null)));
#line 42
this.ScenarioSetup(scenarioInfo);
#line 43
    testRunner.Given("I am logged in and have access token", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 44
    testRunner.When("New culture is created", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 45
    testRunner.Then("Culture is successfully deactivated", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Save culture data")]
        public virtual void SaveCultureData()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Save culture data", ((string[])(null)));
#line 47
this.ScenarioSetup(scenarioInfo);
#line 48
    testRunner.Given("I am logged in and have access token", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 49
    testRunner.Then("Culture data is successfully saved", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Get currency by code")]
        public virtual void GetCurrencyByCode()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Get currency by code", ((string[])(null)));
#line 57
this.ScenarioSetup(scenarioInfo);
#line 58
    testRunner.Given("I am logged in and have access token", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 59
    testRunner.When("New currency is created", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 60
    testRunner.Then("Currency by code is visible to me", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Activate currency")]
        public virtual void ActivateCurrency()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Activate currency", ((string[])(null)));
#line 62
this.ScenarioSetup(scenarioInfo);
#line 63
    testRunner.Given("I am logged in and have access token", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 64
    testRunner.When("New currency is created", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 65
    testRunner.Then("Currency is successfully activated", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Deactivate currency")]
        public virtual void DeactivateCurrency()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Deactivate currency", ((string[])(null)));
#line 67
this.ScenarioSetup(scenarioInfo);
#line 68
    testRunner.Given("I am logged in and have access token", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 69
    testRunner.When("New currency is created", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 70
    testRunner.Then("Currency is successfully deactivated", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Save currency data")]
        public virtual void SaveCurrencyData()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Save currency data", ((string[])(null)));
#line 72
this.ScenarioSetup(scenarioInfo);
#line 73
    testRunner.Given("I am logged in and have access token", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 74
    testRunner.Then("Currency data is successfully saved", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Can not execute permission protected admin methods")]
        public virtual void CanNotExecutePermissionProtectedAdminMethods()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Can not execute permission protected admin methods", ((string[])(null)));
#line 78
this.ScenarioSetup(scenarioInfo);
#line 79
    testRunner.Given("I am logged in and have access token", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 80
    testRunner.Then("I can not execute protected admin methods with insufficient permissions", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
