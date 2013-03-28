using Carros.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace Carros.Controllers
{
    public class CarroController : Controller
    {
        private ListaDeCarros CarrosEsportivos()
        {
            ListaDeCarros carros = new ListaDeCarros();
            carros.Carros.Add(new Carro() { 
                    nome = "Ferrari",
                    descricao = "A Ferrari FF acaba de ser revelada. Se trata do primeiro modelo da marca a ter "+
                                "tração integral. Além disso, ele conta com um motor dianteiro V12. Se trata de "+
                                "um modelo GT de quatro lugares que não só substitui a 612 mas também atrai um "+
                                "novo tipo de cliente, daquele que gosta de percorrer caminhos mais difíceis que "+
                                "exigem tração integral. ste modelo revolucionário (dentro da marca) tem um novo "+
                                "chassi com entre-eixos maior, além de suspensão independente que incorpora a "+
                                "última geração de amortecedores ajustáveis, além de freios de cerâmica da Brembo.",

                    urlFoto = "http://www.livroandroid.com.br/livro/carros/esportivos/Ferrari_FF.png",
                    urlInformacao = "http://www.ferrari.com/English/GT_Sport%20Cars/CurrentRange/FF/Pages/FF.aspx"
                }
            );
            carros.Carros.Add(new Carro()
            {
                nome = "AUDI GT Spyder",
                descricao = "O mais novo modelo limitado a 333 unidades que vem para preencher a lacuna de modelo top de linha, vaga desde que o cupê do mesmo modelo, há um ano atrás, esgotou todos os pedidos ainda ano passado. O segredo do baixo peso é fazer uso de fibra de carbono para boa parte dos painéis de carroceria, e fibra de vidro para os bancos concha. Além disso, o teto da capota é tecido e se retrai em 19 segundos, podendo-se recolhe-lo andando em velocidades de até 50km/h.",
                urlFoto = "http://www.livroandroid.com.br/livro/carros/esportivos/Audi_Spyder.png",
                urlInformacao = "http://www.audi.com.br/br/brand/pt.html"
            }
            );
            carros.Carros.Add(new Carro()
            {
                nome = "Porsche Panamera",
                descricao = "O Porsche Panamera é um modelo coupé de 4 portas de porte grande lançado pela Porsche em 2009. Tem motorização dianteira V6 e V8 feitos em Stuttgart, a carroçaria é fornecida já pintada pela fábrica da VW localizada em Hanover, e a montagem final ocorre em Leipzig. Treze cores e combinações de materiais podem ser escolhidas para o interior do Panamera. As versões são S, 4S e Turbo. Nas duas versões mais 'fracas', o porta-malas tem capacidade para 445 litros, ao passo que na Turbo estamos falando de 432 litros.",
                urlFoto = "http://www.livroandroid.com.br/livro/carros/esportivos/Porsche_Panamera.png",
                urlInformacao = "http://www.porsche.com.br/"
            }
            );
            return carros;
        }

        private ListaDeCarros CarrosLuxo() {
            ListaDeCarros carros = new ListaDeCarros();
            carros.Carros.Add(new Carro() { 
                    nome = "Bugatti Veyron",
                    descricao = "O carro custa US $ 3,8 milhões e está disponível em edições limitadas. Bugatti fabricados apenas cinco destes carros e é um dos carros mais caros do mundo. O carro possui um motor muito potente e uma velocidade máxima de 250 mph. A Bugatti cumpriu cada uma das promessas que fez para o Veyron. Ele atende todos os critérios estabelecidos por Piëch quando ele foi anunciado e o faz com autoridade. Luxuoso, elegante, marcante, exclusivo, loucamente caro e enlouquecedoramente rápido, o Veyron estabelece um novo patamar para os veículos Grand Touring.",
                    urlFoto = "http://www.livroandroid.com.br/livro/carros/luxo/Bugatti_Veyron.png",
                    urlInformacao = "http://www.bugatti.com/en/veyron-16.4/design.html"
                }
            );
            carros.Carros.Add(new Carro()
            {
                nome = "Ferrari Enzo",
                descricao = "Preço de US $ 1,5 milhão, Ferrari Enzo tem fascinado muitos amantes do desporto automóvel em todo o mundo. O carro possui um motor de 12 cilindros. Apenas 399 carros foram produzidos sempre e Michael Schumacher não se esqueça de comprar um. A tecnologia de Fórmula 1 fez este lindo carro de luxo uma escolha favorita entre os amantes de carros Ferrari. Características como a aerodinâmica poderosa, o corpo de fibra de carbono e os discos de freio de cerâmica de carbono torná-lo especial entre todos os carros de luxo.",
                urlFoto = "http://www.livroandroid.com.br/livro/carros/luxo/Ferrari_Enzo.png",
                urlInformacao = "http://www.ferrari.com/English/GT_Sport%20Cars/Classiche/All_Models/Pages/Enzo_Ferrari.aspx"
            }
            );
            carros.Carros.Add(new Carro()
            {
                nome = "Lamborghini Reventon",
                descricao = "Este carro de luxo tem um preço de US $ 1,6 milhões. Esta besta tem um captador de 0-60 milhas em 3,3 segundos e atinge uma velocidade máxima de 211 quilômetros por hora. Lamborghini Reventón parece com o Batmobile e existem apenas 10 deles.",
                urlFoto = "http://www.livroandroid.com.br/livro/carros/luxo/Lamborghini_Reventon.png",
                urlInformacao = "http://www.lamborghini.com/"
            }
            );
            return carros;
        }

        private ListaDeCarros CarrosClassicos()
        {
            ListaDeCarros carros = new ListaDeCarros();
            carros.Carros.Add(new Carro()
            {
                nome = "Tucker 1948",
                descricao = "O Tucker foi realmente uma inovação no mundo do design automóvel, e embora o modelo 1948 foi o único modelo já produzido seu efeito sobre o mundo dos automóveis ainda pode ser sentida até hoje. Preston Tucker e Alex Tremulis projetou o Tucker como uma tentativa de entrar na indústria automotiva, e apesar de apenas um punhado de carros foram produzidos os recursos que estavam presentes naqueles carros eram extremamente inovador para a época.",
                urlFoto = "http://www.livroandroid.com.br/livro/carros/classicos/Tucker.png",
                urlInformacao = "http://hotrodekustom.blogspot.com/2011/04/tucker-torpedo-1948-bi-turbo-estilo.html"
            }
            );
            carros.Carros.Add(new Carro()
             {
                 nome = "Chevrolet Corvette",
                 descricao = "O Chevrolet corvette é também um clássico antigo, encontrado nos salões automobilísticos internacionais, ele foi o primeiro carro produzido inteiramente dos Estados Unidos. O modelo de 1958, pertencente à primeira geração do corvette é um dos mais conhecidos e era uma potência na época em que foi criado. Esse carro clássico chegava a 170 km/h e era bem leve, o que estava se tornando tendência quando ele começou a ser fabricado em 1953.",
                 urlFoto = "http://www.livroandroid.com.br/livro/carros/classicos/Chevrolet_Corvette.png",
                 urlInformacao = "http://www.chevrolet.com/corvette-sports-cars"
             }
             );
            carros.Carros.Add(new Carro()
            {
                nome = "Chevrolet Impala Coupe",
                descricao = "O Impala foi lançado em 1958, como a configuração de acabamento Top de linha da Chevrolet, rebaixando o acabamento Bel Air à posição intermediária de acabamento. O Belair, por sua vez, era o nome da versão Hard Top Coupe (falso conversível) dos Chevrolets fabricados de 1950 até 1952. Em 1953, tornou-se o nome da versão de acabamento Top de Linha da Chevrolet, que ainda contava com o 1-50 e o 2-10, respectivamente, a entrada e intermediária.",
                urlFoto = "http://www.livroandroid.com.br/livro/carros/classicos/Chevrolet_Impala_Coupe.png",
                urlInformacao = "http://en.wikipedia.org/wiki/Chevrolet_Impala"
            }
            );
            return carros;
        }

        public JsonResult GetClassicos()
        {
            return Json(this.CarrosClassicos(), "application/json", Encoding.UTF8, JsonRequestBehavior.AllowGet);
        }

        public JsonResult GetLuxo()
        {
            return Json(this.CarrosLuxo(), "application/json", Encoding.UTF8, JsonRequestBehavior.AllowGet);
        }

        public JsonResult GetEsportivos()
        {            
            return Json(this.CarrosEsportivos(), "application/json", Encoding.UTF8, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public JsonResult Classicos()
        {
            return Json(this.CarrosClassicos(), "application/json", Encoding.UTF8, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public JsonResult Luxo()
        {
            return Json(this.CarrosLuxo(), "application/json", Encoding.UTF8, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public JsonResult Esportivos()
        {
            return Json(this.CarrosEsportivos(), "application/json", Encoding.UTF8, JsonRequestBehavior.AllowGet);
        }
    }
}
