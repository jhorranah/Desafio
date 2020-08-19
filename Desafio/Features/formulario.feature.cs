﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (https://www.specflow.org/).
//      SpecFlow Version:3.4.0.0
//      SpecFlow Generator Version:3.4.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace Desafio.Features
{
    using TechTalk.SpecFlow;
    using System;
    using System.Linq;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.4.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("formulario")]
    [NUnit.Framework.CategoryAttribute("Formulário")]
    public partial class FormularioFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
        private string[] _featureTags = new string[] {
                "Formulário"};
        
#line 1 "formulario.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("pt-BR"), "Features", "formulario", "\ta fim de cadastrar um formulário padrão\r\n\teu como usuário\r\n\tgostaria de cadastra" +
                    "r um formulário", ProgrammingLanguage.CSharp, new string[] {
                        "Formulário"});
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [NUnit.Framework.OneTimeTearDownAttribute()]
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
        public virtual void TestTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioInitialize(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioInitialize(scenarioInfo);
            testRunner.ScenarioContext.ScenarioContainer.RegisterInstanceAs<NUnit.Framework.TestContext>(NUnit.Framework.TestContext.CurrentContext);
        }
        
        public virtual void ScenarioStart()
        {
            testRunner.OnScenarioStart();
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        public virtual void FeatureBackground()
        {
#line 7
#line hidden
#line 8
 testRunner.Given("que eu esteja na tela de autenticação", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Dado ");
#line hidden
            TechTalk.SpecFlow.Table table7 = new TechTalk.SpecFlow.Table(new string[] {
                        "Email",
                        "Senha"});
            table7.AddRow(new string[] {
                        "admin@admin.com",
                        "Senha1234"});
#line 9
 testRunner.When("eu preencher os campos de usuário e senha", ((string)(null)), table7, "Quando ");
#line hidden
#line 12
 testRunner.And("clicar no botão para entrar", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "E ");
#line hidden
#line 13
 testRunner.Then("o sistema deverá apresentar a próxima tela", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Então ");
#line hidden
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Cadastro de formulário")]
        [NUnit.Framework.TestCaseAttribute("Teste Joana", "Teste Palavra Chave", "Catalogo Joana", "Bugs", "Financ - Demais Aten", "19 - AUT SLA", "Atendimento Padrão com finais de semana", null)]
        public virtual void CadastroDeFormulario(string nome, string palavra, string catalogos, string nivel1, string atendimento, string sLA, string calendario, string[] exampleTags)
        {
            string[] tagsOfScenario = exampleTags;
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            argumentsOfScenario.Add("Nome", nome);
            argumentsOfScenario.Add("Palavra", palavra);
            argumentsOfScenario.Add("Catalogos", catalogos);
            argumentsOfScenario.Add("Nivel1", nivel1);
            argumentsOfScenario.Add("Atendimento", atendimento);
            argumentsOfScenario.Add("SLA", sLA);
            argumentsOfScenario.Add("Calendario", calendario);
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Cadastro de formulário", null, tagsOfScenario, argumentsOfScenario);
#line 15
this.ScenarioInitialize(scenarioInfo);
#line hidden
            bool isScenarioIgnored = default(bool);
            bool isFeatureIgnored = default(bool);
            if ((tagsOfScenario != null))
            {
                isScenarioIgnored = tagsOfScenario.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((this._featureTags != null))
            {
                isFeatureIgnored = this._featureTags.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((isScenarioIgnored || isFeatureIgnored))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 7
this.FeatureBackground();
#line hidden
#line 16
 testRunner.Given("que eu esteja na tela de cadastro de formulário", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Dado ");
#line hidden
#line 17
 testRunner.And("clicar em cadastrar", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "E ");
#line hidden
#line 18
 testRunner.And(string.Format("preencher a tabela de Informações Principais \"{0}\"", nome), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "E ");
#line hidden
#line 19
 testRunner.And(string.Format("preencher a tabela Palavras Chave \"{0}\"", palavra), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "E ");
#line hidden
#line 20
 testRunner.And(string.Format("Vincular Catalogos \"{0}\"", catalogos), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "E ");
#line hidden
#line 21
 testRunner.And(string.Format("classisficar catalogos \"{0}\"", nivel1), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "E ");
#line hidden
#line 22
 testRunner.And(string.Format("Adicionar Fila \"{0}\"", atendimento), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "E ");
#line hidden
#line 23
 testRunner.And(string.Format("Selecionar SLA \"{0}\"", sLA), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "E ");
#line hidden
#line 24
 testRunner.And(string.Format("Selecionar o calendário \"{0}\"", calendario), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "E ");
#line hidden
#line 25
 testRunner.And("clicar em gravar", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "E ");
#line hidden
#line 26
 testRunner.Then("o sistema deverá mostrar a mensagem de \"Formulário cadastrado com sucesso.\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Então ");
#line hidden
#line 27
 testRunner.And("apresentar o formulario cadastrado", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "E ");
#line hidden
            }
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion