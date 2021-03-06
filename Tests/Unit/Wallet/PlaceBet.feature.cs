﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:1.9.0.77
//      SpecFlow Generator Version:1.9.0.0
//      Runtime Version:4.0.30319.34209
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace AFT.RegoV2.Tests.Unit.Wallet
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "1.9.0.77")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("Place bet")]
    [NUnit.Framework.CategoryAttribute("Unit")]
    public partial class PlaceBetFeature
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "PlaceBet.feature"
#line hidden
        
        [NUnit.Framework.TestFixtureSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Place bet", "", ProgrammingLanguage.CSharp, new string[] {
                        "Unit"});
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
        [NUnit.Framework.DescriptionAttribute("Can not place invalid amount bet")]
        [NUnit.Framework.TestCaseAttribute("0", null)]
        [NUnit.Framework.TestCaseAttribute("-100", null)]
        public virtual void CanNotPlaceInvalidAmountBet(string amount, string[] exampleTags)
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Can not place invalid amount bet", exampleTags);
#line 4
this.ScenarioSetup(scenarioInfo);
#line 5
    testRunner.Given("a wallet with no transactions", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 6
    testRunner.When(string.Format("I place ${0} bet", amount), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 7
    testRunner.Then("Invalid amount exception is thrown", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Can not place bet greater than playable balance")]
        public virtual void CanNotPlaceBetGreaterThanPlayableBalance()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Can not place bet greater than playable balance", ((string[])(null)));
#line 13
this.ScenarioSetup(scenarioInfo);
#line 14
    testRunner.Given("I deposited $100", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 15
    testRunner.When("I place $200 bet", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 16
    testRunner.Then("Insufficient funds exception is thrown", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Placing bet creates transaction")]
        public virtual void PlacingBetCreatesTransaction()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Placing bet creates transaction", ((string[])(null)));
#line 18
this.ScenarioSetup(scenarioInfo);
#line 19
    testRunner.Given("I deposited $150", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 20
        testRunner.And("I issued $50 bonus to Bonus balance", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 21
    testRunner.When("I place $200 bet", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 22
    testRunner.Then("BetPlaced transaction should be created", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 23
        testRunner.And("transaction main balance amount should be $-150", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 24
        testRunner.And("transaction bonus balance amount should be $-50", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 25
        testRunner.And("Main balance should be $0", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 26
        testRunner.And("Bonus balance should be $0", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 27
        testRunner.And("3 TransactionProcessed events should be sent", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Can place several sub-bets")]
        public virtual void CanPlaceSeveralSub_Bets()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Can place several sub-bets", ((string[])(null)));
#line 29
this.ScenarioSetup(scenarioInfo);
#line 30
    testRunner.Given("I deposited $100", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 31
    testRunner.When("I place $50 bet", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 32
        testRunner.And("I place $50 bet", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 33
    testRunner.Then("2 BetPlaced transactions should be created", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
