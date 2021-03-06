﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:1.9.3.0
//      SpecFlow Generator Version:1.9.0.0
//      Runtime Version:4.0.30319.18449
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace AFT.RegoV2.GameApi.Tests.Integration.Scenarios
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "1.9.3.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("Dopamine Game Api")]
    [NUnit.Framework.CategoryAttribute("Integration")]
    public partial class DopamineGameApiFeature
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "DopamineGameApi.feature"
#line hidden
        
        [NUnit.Framework.TestFixtureSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Dopamine Game Api", "Calling Dopamine Game API", ProgrammingLanguage.CSharp, new string[] {
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
        [NUnit.Framework.DescriptionAttribute("Get and validate authentication token")]
        public virtual void GetAndValidateAuthenticationToken()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Get and validate authentication token", ((string[])(null)));
#line 5
this.ScenarioSetup(scenarioInfo);
#line 6
 testRunner.Given("I get authentication token for player \"testplayer\" with password \"123456\" for gam" +
                    "e \"Roulette\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 7
 testRunner.When("I call to validate token", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 8
  testRunner.Then("I will receive successful validation result", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Get playable balance")]
        public virtual void GetPlayableBalance()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Get playable balance", ((string[])(null)));
#line 10
this.ScenarioSetup(scenarioInfo);
#line 11
 testRunner.Given("I get authentication token for player \"testplayer\" with password \"123456\" for gam" +
                    "e \"Roulette\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 12
  testRunner.And("I validate the token", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 13
  testRunner.And("the player \"testplayer\" main balance is $11 and bonus balance is $3", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 14
 testRunner.When("I get balance", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 15
  testRunner.Then("the player\'s playable balance will be $14", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Place bet when playable balance is $0")]
        public virtual void PlaceBetWhenPlayableBalanceIs0()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Place bet when playable balance is $0", ((string[])(null)));
#line 17
this.ScenarioSetup(scenarioInfo);
#line 18
 testRunner.Given("I get authentication token for player \"testplayer\" with password \"123456\" for gam" +
                    "e \"Roulette\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 19
  testRunner.And("I validate the token", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 20
  testRunner.And("the player \"testplayer\" main balance is $0 and bonus balance is $0", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 21
 testRunner.When("I bet $5", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 22
  testRunner.Then("I will get error code \"InsufficientFunds\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 23
 testRunner.When("I get balance", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 24
  testRunner.Then("the player\'s playable balance will be $0", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 26
  testRunner.And("requested bet will not be recorded", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 27
  testRunner.And("place bet response balance will equal requested balance", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Place bet when playable balance is insufficient")]
        public virtual void PlaceBetWhenPlayableBalanceIsInsufficient()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Place bet when playable balance is insufficient", ((string[])(null)));
#line 29
this.ScenarioSetup(scenarioInfo);
#line 30
 testRunner.Given("I get authentication token for player \"testplayer\" with password \"123456\" for gam" +
                    "e \"Roulette\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 31
  testRunner.And("I validate the token", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 32
  testRunner.And("the player \"testplayer\" main balance is $10 and bonus balance is $0", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 33
 testRunner.When("I bet $15", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 34
  testRunner.Then("I will get error code \"InsufficientFunds\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 35
 testRunner.When("I get balance", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 36
  testRunner.Then("the player\'s playable balance will be $10", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 38
  testRunner.And("requested bet will not be recorded", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 39
  testRunner.And("place bet response balance will equal requested balance", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Place bet when playable balance is sufficient")]
        public virtual void PlaceBetWhenPlayableBalanceIsSufficient()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Place bet when playable balance is sufficient", ((string[])(null)));
#line 41
this.ScenarioSetup(scenarioInfo);
#line 42
 testRunner.Given("I get authentication token for player \"testplayer\" with password \"123456\" for gam" +
                    "e \"Roulette\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 43
  testRunner.And("I validate the token", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 44
  testRunner.And("the player \"testplayer\" main balance is $10 and bonus balance is $10", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 45
 testRunner.When("I bet $15", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 46
  testRunner.Then("I will get error code \"NoError\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 47
 testRunner.When("I get balance", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 48
  testRunner.Then("the player\'s playable balance will be $5", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 49
  testRunner.And("requested bet will be recorded", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 50
  testRunner.And("place bet response balance will equal requested balance", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Place and win bet")]
        public virtual void PlaceAndWinBet()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Place and win bet", ((string[])(null)));
#line 52
this.ScenarioSetup(scenarioInfo);
#line 53
 testRunner.Given("I get authentication token for player \"testplayer\" with password \"123456\" for gam" +
                    "e \"Roulette\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 54
  testRunner.And("I validate the token", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 55
  testRunner.And("the player \"testplayer\" main balance is $20 and bonus balance is $0", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 56
 testRunner.When("I bet $15", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 57
  testRunner.Then("I will get error code \"NoError\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 58
 testRunner.When("I win $25", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 59
  testRunner.Then("I will get error code \"NoError\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 60
 testRunner.When("I get balance", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 61
  testRunner.Then("the player\'s playable balance will be $30", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 62
  testRunner.And("requested bet will be recorded", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Place and \"win\" less than what was placed")]
        public virtual void PlaceAndWinLessThanWhatWasPlaced()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Place and \"win\" less than what was placed", ((string[])(null)));
#line 64
this.ScenarioSetup(scenarioInfo);
#line 65
 testRunner.Given("I get authentication token for player \"testplayer\" with password \"123456\" for gam" +
                    "e \"Roulette\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 66
  testRunner.And("I validate the token", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 67
  testRunner.And("the player \"testplayer\" main balance is $20 and bonus balance is $0", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 68
 testRunner.When("I bet $15", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 69
  testRunner.Then("I will get error code \"NoError\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 70
 testRunner.When("I win $5", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 71
  testRunner.Then("I will get error code \"NoError\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 72
 testRunner.When("I get balance", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 73
  testRunner.Then("the player\'s playable balance will be $10", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 74
  testRunner.And("requested bet will be recorded", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Place and lose bet")]
        public virtual void PlaceAndLoseBet()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Place and lose bet", ((string[])(null)));
#line 76
this.ScenarioSetup(scenarioInfo);
#line 77
 testRunner.Given("I get authentication token for player \"testplayer\" with password \"123456\" for gam" +
                    "e \"Roulette\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 78
  testRunner.And("I validate the token", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 79
  testRunner.And("the player \"testplayer\" main balance is $20 and bonus balance is $0", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 80
 testRunner.When("I bet $15", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 81
  testRunner.Then("I will get error code \"NoError\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 82
 testRunner.When("I lose the bet", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 83
  testRunner.Then("I will get error code \"NoError\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 84
 testRunner.When("I get balance", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 85
  testRunner.Then("the player\'s playable balance will be $5", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 86
  testRunner.And("requested bet will be recorded", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Get free bet")]
        public virtual void GetFreeBet()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Get free bet", ((string[])(null)));
#line 88
this.ScenarioSetup(scenarioInfo);
#line 89
 testRunner.Given("I get authentication token for player \"testplayer\" with password \"123456\" for gam" +
                    "e \"Roulette\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 90
  testRunner.And("I validate the token", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 91
  testRunner.And("the player \"testplayer\" main balance is $20 and bonus balance is $0", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 92
 testRunner.When("I get free bet for $15", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 93
  testRunner.Then("I will get error code \"NoError\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 94
 testRunner.When("I get balance", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 95
  testRunner.Then("the player\'s playable balance will be $35", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 96
  testRunner.And("requested bet will be recorded", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Settle batch of bets")]
        public virtual void SettleBatchOfBets()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Settle batch of bets", ((string[])(null)));
#line 98
this.ScenarioSetup(scenarioInfo);
#line 99
 testRunner.Given("I get authentication token for player \"testplayer\" with password \"123456\" for gam" +
                    "e \"Roulette\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 100
  testRunner.And("I validate the token", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 101
  testRunner.And("the player \"testplayer\" main balance is $20 and bonus balance is $0", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        "Amount"});
            table1.AddRow(new string[] {
                        "5.0"});
            table1.AddRow(new string[] {
                        "5.0"});
            table1.AddRow(new string[] {
                        "5.0"});
#line 102
 testRunner.When("I place bets for amount:", ((string)(null)), table1, "When ");
#line 107
  testRunner.Then("I will get error code \"NoError\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 108
 testRunner.When("I get balance", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 109
  testRunner.Then("the player\'s playable balance will be $5", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table2 = new TechTalk.SpecFlow.Table(new string[] {
                        "Type",
                        "Amount"});
            table2.AddRow(new string[] {
                        "WIN",
                        "10.0"});
            table2.AddRow(new string[] {
                        "LOSE",
                        "0.0"});
            table2.AddRow(new string[] {
                        "WIN",
                        "2.0"});
#line 110
 testRunner.When("I settle the following bets:", ((string)(null)), table2, "When ");
#line 116
  testRunner.Then("I will get error code \"NoError\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 117
 testRunner.When("I get balance", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 119
  testRunner.Then("the player\'s playable balance will be $17", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 120
  testRunner.And("requested bets will be recorded", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Getting bet history")]
        public virtual void GettingBetHistory()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Getting bet history", ((string[])(null)));
#line 122
this.ScenarioSetup(scenarioInfo);
#line 123
 testRunner.Given("I get authentication token for player \"testplayer\" with password \"123456\" for gam" +
                    "e \"Roulette\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 124
  testRunner.And("I validate the token", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 125
  testRunner.And("the player \"testplayer\" main balance is $100 and bonus balance is $0", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 126
 testRunner.When("I bet $15", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 127
  testRunner.Then("I will get error code \"NoError\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 128
 testRunner.When("I bet $5", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 129
  testRunner.Then("I will get error code \"NoError\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 130
 testRunner.When("I get history", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 131
  testRunner.Then("I will see the bet IDs in the history", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Cancel transaction of placing bet")]
        public virtual void CancelTransactionOfPlacingBet()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Cancel transaction of placing bet", ((string[])(null)));
#line 133
this.ScenarioSetup(scenarioInfo);
#line 134
 testRunner.Given("I get authentication token for player \"testplayer\" with password \"123456\" for gam" +
                    "e \"Roulette\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 135
  testRunner.And("I validate the token", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 136
  testRunner.And("the player \"testplayer\" main balance is $100 and bonus balance is $0", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 137
 testRunner.When("I bet $15", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 138
  testRunner.Then("I will get error code \"NoError\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 139
 testRunner.When("I cancel the last transaction", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 140
  testRunner.Then("I will get error code \"NoError\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 141
 testRunner.When("I get balance", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 142
  testRunner.Then("the player\'s playable balance will be $100", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
