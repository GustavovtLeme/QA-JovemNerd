using Nerdcast.Maps;
using Nerdcast.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace Nerdcast.Pages
{
    [Binding]
    class JNPage : JNMaps
    {
        [Given(@"Acessar a pagina ""(.*)""")]
        public void DadoAcessarAPagina(string p0)
        {
            abrirPagina(p0);
            screenshot();            
        }

        [Given(@"clicar em Nerdcast")]
        public void DadoClicarEmNerdcast()
        {
            clickElement(btnNerdcast, 10);
            screenshot();
        }

        [Given(@"selecionar a pesquisa do nerdcast com a palavra ""(.*)""")]
        public void DadoSelecionarAPesquisaDoNerdcastComAPalavra(string p0)
        {
            fillElement(pesquisaNerdcast, p0, 10);
            enterKey(pesquisaNerdcast);
            screenshot();
            
        }

        [Given(@"clicar no Nerdcast (.*)")]
        public void DadoClicarNoNerdcast(int p0)
        {
            clickElement(nerdCast, 10);
            screenshot();
            
        }

        [Given(@"iniciar o nerdcast")]
        public void DadoIniciarONerdcast()
        {
            clickElement(btnPlay, 15);
            screenshot();
            
        }

        [Given(@"pausar o nerdcast")]
        public void DadoPausarONerdcast()
        {
            string timerNerdCast = "";
            do
            {
                timerNerdCast = armazenarTexto(TimerNerdcast, 10);

            } while (!timerNerdCast.Equals("00:00:15"));
            clickElement(btnPause, 10);
            screenshot();
            
        }

        [Then(@"encerrar navegador e gerar PDF do que foi acessado")]
        public void EntaoEncerrarNavegadorEGerarPDFDoQueFoiAcessado()
        {
            encerrarNavegador();
            pdfCreator();
        }


    }
}
