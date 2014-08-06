using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.Http.Formatting;
using Projeto.Integracao.Dto.Dto;
namespace Tdd.Projeto
{
    /// <summary>
    /// Summary description for TesteREST
    /// </summary>
    [TestClass]
    public class TesteREST
    {

        private const String TOKEN = "mvc2E9G3SKyb";

        public TesteREST()
        {
               
        }

        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Additional test attributes
        //
        // You can use the following additional attributes as you write your tests:
        //
        // Use ClassInitialize to run code before running the first test in the class
        // [ClassInitialize()]
        // public static void MyClassInitialize(TestContext testContext) { }
        //
        // Use ClassCleanup to run code after all tests in a class have run
        // [ClassCleanup()]
        // public static void MyClassCleanup() { }
        //
        // Use TestInitialize to run code before running each test 
        // [TestInitialize()]
        // public void MyTestInitialize() { }
        //
        // Use TestCleanup to run code after each test has run
        // [TestCleanup()]
        // public void MyTestCleanup() { }
        //
        #endregion

        [TestMethod]
        public void ConsumoInicial()
        {
            String estado = "sp";
            String cargo = "3";

            //Classe de suporte a consumo de HTTP namespace System.Net.Http
            
            HttpClient client = new HttpClient();
            //Adicionando no Header o token e o media type JSON
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            client.DefaultRequestHeaders.Add("App-Token", TOKEN);
            //Fazendo a requisição
            HttpResponseMessage response = client.GetAsync("http://api.transparencia.org.br/api/v1/candidatos?estado=sp&cargo=3").Result;

            //Conferindo código 200 de sucesso
            if (response.IsSuccessStatusCode)
            {
                //Parse de JSON para o objeto Candidato
                //var listaDeCandidatos = response.Content.ReadAsAsync<IList<Candidato>>().Result;
                var listaDeCandidatos = response.Content.ReadAsAsync<IList<CandidatoDto>>().Result;
            }
            else
                //Exibindo a exceção com o código Http respectivo.
                throw new Exception(string.Concat(response.StatusCode.ToString(), " - ", response.ReasonPhrase));
            
        }
    }
}
