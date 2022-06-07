using DiaNamorados.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace DiaNamorados.Controllers
{
    public class HomeController : Controller
    {
        public string motivo = "";
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult Motivos(int I)
        {
            Random randNum = new Random();
            var numero = randNum.Next(223);

            NumeroMotivo(numero);
            ViewData["Motivos"] = motivo;
            return View("Index");
        }

        public string NumeroMotivo(int numero)
        {
            switch (numero)
            {
                case 0:
                    motivo = "Quando vc da um gritin e diz \"EU TÔ MT FELIZ\"";
                    return motivo;

                case 1:
                    motivo = "Quando a gente se abraça e sua cabeça encaixa embaixo da minha";
                    return motivo;

                case 2:
                    motivo = "O jeito fofo que vc me chama de gabi";
                    return motivo;
                    
                case 3:
                   motivo = "Quando vc comenta alguma história engraçada das crianças";
                    return motivo;
                    
                case 4:
                    motivo = "Quando vc imita uma criança da escolinha";
                    return motivo;
                    
                case 5:
                    motivo = "Quando vc diz uma palavra completamente difícil que eu não tenho ideia do significado";
                    return motivo;
                    
                case 6:
                    motivo = "Quando vc ouve Taylor Swift e vc se empolga tanto que não sabe se fala, canta ou ouve KKKKKKK";
                    return motivo;
                    
                case 7:
                    motivo = "Quando vc me manda áudios tocando órgão";
                    return motivo;
                    
                case 8:
                    motivo = "Quando você me manda áudio tocando ukulele (saudades)";
                    return motivo;
                    
                case 9:
                    motivo = "O carinho que você faz no meu cabelo";
                    return motivo;
                    
                case 10:
                    motivo = "O jeito que vc emociona em discussões sobre algo bobo";
                    return motivo;

                case 11:
                    motivo = "Quando você imita uma piada minha";
                    return motivo;

                case 12:
                    motivo = "A sua carinha e sorrisinho quando eu faço algo fofo pra você";
                    return motivo;

                case 13:
                    motivo = "A cara que você faz quando se segura pra não militar alguém da sua família faz um comentário machista/preconceituoso";
                    return motivo;

                case 14:
                    motivo = "A profundidade dos seus olhos e a paz que eles me trazem";
                    return motivo;

                case 15:
                    motivo = "Todas pintinhas que eu pude ver até hoje (principalmente a do nariz)";
                    return motivo;

                case 16:
                    motivo = "O tamanho da sua mãozinha e a pintinha nela";
                    return motivo;

                case 17:
                    motivo = "O jeito que vc faz terapia com todo mundo";
                    return motivo;

                case 18:
                    motivo = "Quando você grita \"VAI FAZER TERAPIA\"";
                    return motivo;

                case 19:
                    motivo = "A risadinha que vc da quando eu te beijo é começo a te cheirar que nem doido";
                    return motivo;

                case 20:
                    motivo = "Quando você fica brava, cruza os braços, enche a boca e começa a andar rápido batendo o pé";
                    return motivo;

                case 21:
                    motivo = "Quando você dorme e começa mastigar durante a noite";
                    return motivo;

                case 22:
                    motivo = "Você dormindo de boca aberta";
                    return motivo;

                case 23:
                    motivo = "Quando eu acordo e já tem 20 mensagens de você falando da sua noite e sobre a escolinha (principalmente quando tem vídeo das crianças)";
                    return motivo;

                case 24:
                    motivo = "A sua cara quando eu faço uma piada imprópria";
                    return motivo;

                case 25:
                    motivo = "Quando você come um prato de salada e começa a dizer toda hora o quanto você ama isso";
                    return motivo;

                case 26:
                    motivo = "Quando você entra no meu quarto antes ou depois da aula saltitando e com um sorrisao";
                    return motivo;

                case 27:
                    motivo = "Quando você tá tocando e dá um grito do nada e diz \"EU AMO ESSE HINO\"";
                    return motivo;

                case 28:
                    motivo = "Quando você vira pra alguém e diz \"EU TE AMO\"";
                    return motivo;

                case 29:
                    motivo = "O jeito que você respira quando tá tentando se acalmar";
                    return motivo;

                case 31:
                    motivo = "O jeito que você tem de querer cuidar de todo mundo";
                    return motivo;

                case 32:
                    motivo = "Quando você fecha a cara numa piada ruim e seu lábio tá querendo rir";
                    return motivo;

                case 33:
                    motivo = "Quando você ora comigo";
                    return motivo;

                case 34:
                    motivo = "Quando você ora pra mim";
                    return motivo;

                case 35:
                    motivo = "Quando você me chama pra orar";
                    return motivo;

                case 36:
                    motivo = "Quando você diz que tá com saudades";
                    return motivo;

                case 37:
                    motivo = "Quando eu ouço a sua glorificação lá de longe";
                    return motivo;

                case 38:
                    motivo = "Quando eu ouço sua voz na igreja cantando";
                    return motivo;

                case 39:
                    motivo = "Quando você começa a cantar uma música e você se empolga muito rápido";
                    return motivo;

                case 40:
                    motivo = "Quando você começa a traduzir o que a Taylor Swift tá querendo dizer";
                    return motivo;

                case 41:
                    motivo = "Quando você põem a mão na boca durante a música e diz \"EU TE ENTENDO TAYLOR, EU TE ENTENDO\"";
                    return motivo;

                case 42:
                    motivo = "Quando você especula e adivinha muitos sentimentos meus";
                    return motivo;

                case 43:
                    motivo = "A carinha que você faz quando boceja";
                    return motivo;

                case 44:
                    motivo = "A cara que você fica quando acabou de acordar";
                    return motivo;

                case 45:
                    motivo = "Seu cabelo e cada curva dele";
                    return motivo;

                case 46:
                    motivo = "Seu cabelo quando você acorda e ele tá cheiao";
                    return motivo;

                case 47:
                    motivo = "Quando você não finaliza o cabelo e ele fica cheiao";
                    return motivo;

                case 48:
                    motivo = "Quando você faz delineado";
                    return motivo;

                case 49:
                    motivo = "O jeito que você se empolga com ideias repentinas";
                    return motivo;

                case 50:
                    motivo = "Quando você beija meu pescocinho";
                    return motivo;

                case 51:
                    motivo = "Quando a gente se abraça e você diz \"Eu amo como a gente se encaixa certinho\"";
                    return motivo;

                case 52:
                    motivo = "Quando você beija minha bochecha e diz \"eu poderia morar aqui\"";
                    return motivo;

                case 53:
                    motivo = "Quando você cheira meu cangote e diz \"eu poderia viver aqui\"";
                    return motivo;

                case 54:
                    motivo = "Quando você faz carinho no meu rosto";
                    return motivo;

                case 55:
                    motivo = "A textura de seda que sua pele tem";
                    return motivo;

                case 56:
                    motivo = "Quando você diz \"te amo de novo\" antes de dormirmos";
                    return motivo;

                case 57:
                    motivo = "Quando você valida meu esforço e diz \"obrigada por tal coisa\"";
                    return motivo;

                case 58:
                    motivo = "Quando você me manda fotos engraçadas sua";
                    return motivo;

                case 59:
                    motivo = "Quando você fica sem reação quando eu te dou um presente";
                    return motivo;

                case 60:
                    motivo = "Quando você gargalha de uma piada inesperada minha";
                    return motivo;

                case 61:
                    motivo = "Quando você aceita fazer minhas loucurinhas";
                    return motivo;

                case 62:
                    motivo = "Quando você tá posicionado pro sol e seus olhos começam a brilhar o castanho escondido neles";
                    return motivo;

                case 63:
                    motivo = "Quando você põem a mão na minha boca pra ficar te dando beijinhos";
                    return motivo;

                case 64:
                    motivo = "A carinha que você faz eu dou um beijinho que você gosta";
                    return motivo;

                case 65:
                    motivo = "A cara que você fica quando eu te dou um beijinho fofo repetino";
                    return motivo;

                case 66:
                    motivo = "Quando você se contorce e começa a dar gritinhos quando eu te faço cócegas";
                    return motivo;

                case 67:
                    motivo = "Quando sua bochecha fica corada";
                    return motivo;

                case 68:
                    motivo = "Quando você tá moscando e começa a morder a boca";
                    return motivo;

                case 69:
                    motivo = "A risada que vc da quando eu erro uma palavra";
                    return motivo;

                case 70:
                    motivo = "O jeito que você me ouve contar uma história completamente inútil sobre algum jogo ou algo assim";
                    return motivo;

                case 71:
                    motivo = "O jeito que você se empolga com minhas empolgações";
                    return motivo;

                case 72:
                    motivo = "O jeito que você tenta me animar quando eu tô desanimado";
                    return motivo;

                case 775:
                    motivo = "O jeito que você finge que não quer algo e quando eu forço um pouco você fala bem rápido e baixinho";
                    return motivo;

                case 74:
                    motivo = "Como você se anima pra editar fotos";
                    return motivo;

                case 76:
                    motivo = "Quando você está finalizando o cabelo e você morde a língua igual eu";
                    return motivo;

                case 77:
                    motivo = "A cara que você fica quando eu faço um comentário inesperado";
                    return motivo;

                case 78:
                    motivo = "Quando a gente fala a mesma coisa ao mesmo tempo";
                    return motivo;

                case 79:
                    motivo = "Quando eu começo a cantar algo e você diz \"EU TAVA CANTANDO ISSO AGORA NA MINHA CABEÇA\"";
                    return motivo;

                case 80:
                    motivo = "A sua carinha quando começa a cantar algo e eu finalizo";
                    return motivo;

                case 81:
                    motivo = "Quando você deita no meu colo e eu posso olhar pro seu rostinho";
                    return motivo;

                case 82:
                    motivo = "A voz engraçadinha e mordida de beiço que você faz quando vê meus gatos";
                    return motivo;

                case 83:
                    motivo = "Quando a gente tá conversando com alguém e você menciona de algo que eu fiz que você gostou muito";
                    return motivo;

                case 84:
                    motivo = "Quando você diz que perdeu a comunhão por eu estar bonito";
                    return motivo;

                case 85:
                    motivo = "Quando você cheira meu pescoço e diz \"muito cheiroso, parabéns\"";
                    return motivo;

                case 86:
                    motivo = "O som da sua voz cantando contralto quando toca na reunião de jovens";
                    return motivo;

                case 87:
                    motivo = "Os cachinhos que você deixa pra frente quando tá de coque";
                    return motivo;

                case 88:
                    motivo = "Quando você relembra uma piada antiga";
                    return motivo;

                case 89:
                    motivo = "A sua carinha de quando eu milito certo e você me da um high five";
                    return motivo;

                case 90:
                    motivo = "O jeito fofo que você tem facilidade em entender uma música só de ouvir a letra";
                    return motivo;

                case 91:
                    motivo = "O jeito fofo que você fala inglês certinho";
                    return motivo;

                case 92:
                    motivo = "Quando eu consigo ouvir sua voz glorificando/manifestando no meio da igreja";
                    return motivo;

                case 93:
                    motivo = "A carinha que você faz quando eu separo o beijo e peço pra ficar admirando o seu rosto";
                    return motivo;

                case 94:
                    motivo = "O jeitinho fofo que você diz que gostou de algo que eu fiz";
                    return motivo;

                case 95:
                    motivo = "O teu talento de escrever poemas incríveis";
                    return motivo;

                case 96:
                    motivo = "O teu talento de criar músicas";
                    return motivo;

                case 97:
                    motivo = "O umbiguinho :3";
                    return motivo;

                case 98:
                    motivo = "Quando você ouve uma música que você conhece num restaurante, pega seu microfone imaginário e começa a cantar junto";
                    return motivo;

                case 99:
                    motivo = "Quando você ouve uma música enquanto a gente tá andando e depois de 15 minutos você canta ela";
                    return motivo;

                case 100:
                    motivo = "Quando seus olhos dizem que me ama";
                    return motivo;

                case 101:
                    motivo = "O sorrisao que você dá quando nossos olhos se encontram durante o recitativo";
                    return motivo;

                case 102:
                    motivo = "Você me mandar vídeos sobre terapia e paternidade e eu vejo o quanto você tá se esforçando";
                    return motivo;

                case 103:
                    motivo = "Quando você começa a saltitar de felicidade";
                    return motivo;

                case 104:
                    motivo = "Quando você abre a porta da sua casa pra mim com um sorrisao";
                    return motivo;

                case 105:
                    motivo = "A carinha de revoltada que você faz quando eu cutuco seu suvaco do nada";
                    return motivo;

                case 106:
                    motivo = "Quando você me abraça por trás";
                    return motivo;

                case 107:
                    motivo = "A cara de braba que você faz quando eu faço uma piada machista";
                    return motivo;

                case 108:
                    motivo = "Quando eu faço uma piada muito ruim e você me olha segurando o riso";
                    return motivo;

                case 109:
                    motivo = "Quando você diz que me ama do nada";
                    return motivo;

                case 110:
                    motivo = "Seu acolhimento quando eu estou mal";
                    return motivo;

                case 111:
                    motivo = "Quando grudamos o nariz um no outro";
                    return motivo;

                case 112:
                    motivo = "Quando damos beijinho de esquimó";
                    return motivo;

                case 113:
                    motivo = "Os memes educativos que você me manda";
                    return motivo;

                case 114:
                    motivo = "Quando você ri comigo";
                    return motivo;

                case 115:
                    motivo = "Quando você paga algo e diz \"RELAXA, A MÃE BANCA\"";
                    return motivo;

                case 116:
                    motivo = "O seu sorrisao de quando eu elogio sua roupa e pergunto de onde é e você diz \"GOSTO? É DA SHEIN\"";
                    return motivo;

                case 117:
                    motivo = "O significado que as músicas tem pra você";
                    return motivo;

                case 118:
                    motivo = "A sua vozinha rouca";
                    return motivo;

                case 119:
                    motivo = "Seus olhos inchados quando chora muito";
                    return motivo;

                case 120:
                    motivo = "Seu beicin quando você té triste :(";
                    return motivo;

                case 121:
                    motivo = "Quando você me pede um beijinho";
                    return motivo;

                case 122:
                    motivo = "A sua clavícula e o encaixe que é quando eu me deito nela";
                    return motivo;

                case 123:
                    motivo = "O jeito que você salvou minha vida";
                    return motivo;

                case 124:
                    motivo = "O jeito que você me trouxe cores que eu nunca tinha visto antes";
                    return motivo;

                case 125:
                    motivo = "A felicidade que você trouxe pra minha vida";
                    return motivo;

                case 126:
                    motivo = "Quando você diz \"não fica calvo não, por favor :(\"";
                    return motivo;

                case 127:
                    motivo = "Quando você começa a fazer uma consulta de coloração nas pessoas";
                    return motivo;

                case 128:
                    motivo = "Você beubada";
                    return motivo;

                case 129:
                    motivo = "Quando a gente se encontra e você vem saltitando";
                    return motivo;

                case 130:
                    motivo = "Quando você me pergunta \"posso arrumar seu cabelo\" e arruma com a maior delicadeza do mundo";
                    return motivo;

                case 131:
                    motivo = "Quando a gente toca junto e eu posso ver sua cara linda de concentração";
                    return motivo;

                case 132:
                    motivo = "Quando a gente tá tocando é eu peço o 55 e você faz algum comentário ou ação engraçada sobre eu chamar esse hino toda hora";
                    return motivo;

                case 134:
                    motivo = "Quando você do nada senta e começa a tocar o órgão e toca só 3 hinos ou menos e volta como se nada tivesse acontecido";
                    return motivo;

                case 135:
                    motivo = "O jeitinho que você dorme";
                    return motivo;

                case 136:
                    motivo = "Quando eu toquei violão pra você dormir";
                    return motivo;

                case 137:
                    motivo = "Você jogando minecraft";
                    return motivo;

                case 138:
                    motivo = "Quando a gente se separa na escada da igreja e você responde meu \"te amo, bom culto\" com um sorrisao";
                    return motivo;

                case 139:
                    motivo = "Quando a gente fofoca junto";
                    return motivo;

                case 140:
                    motivo = "Quando vocÊ se empolga quando digo que tenho uma fofoca";
                    return motivo;

                case 141:
                    motivo = "Quando você vem me fofocar algo";
                    return motivo;

                case 142:
                    motivo = "Você ter se tornado cobrinha....";
                    return motivo;

                case 143:
                    motivo = "Quando você tá tendo aula de música e eu cheiro seu cangote e você da um gritinho";
                    return motivo;

                case 144:
                    motivo = "O cheiro de creme cheiroso no seu cabelo";
                    return motivo;

                case 145:
                    motivo = "Você de cabelo molhado";
                    return motivo;

                case 146:
                    motivo = "Você puxando brincadeira na piscina da chácrinha";
                    return motivo;

                case 147:
                    motivo = "Quando você põem a perna em volta de mim na piscina e a gente fica andando por ela";
                    return motivo;

                case 148:
                    motivo = "Você dizendo que ama vinagrete";
                    return motivo;

                case 149:
                    motivo = "O jeito que você ama animações";
                    return motivo;

                case 150:
                    motivo = "Quando você come algo que gosta e diz\"eu poderia viver só comendo isso\"";
                    return motivo;

                case 151:
                    motivo = "O jeito que você se esforça pra assistir filmes que eu gosto muito";
                    return motivo;

                case 152:
                    motivo = "Quando a gente começa a teorizar sobre algo juntos";
                    return motivo;

                case 153:
                    motivo = "Quando a gente tá triste junto pelo mesmo motivo e um anima o outro";
                    return motivo;

                case 154:
                    motivo = "A sua reação quando eu beijo sua nunca";
                    return motivo;

                case 155:
                    motivo = "Quando você diz que comprou algo na shein e tá empolgada pra chegar";
                    return motivo;

                case 156:
                    motivo = "Quando você se maqueia";
                    return motivo;

                case 157:
                    motivo = "Quando você entra nas minhas metáforas sobre sentinentov";
                    return motivo;

                case 158:
                    motivo = "Seu esforço e vulnerabilidade para tentar melhorar nosso relacionamento";
                    return motivo;

                case 159:
                    motivo = "O jeito que você consegue entender o que eu tô sentindo só de olhar";
                    return motivo;

                case 160:
                    motivo = "Quando a gente ia comer açaí num frio extremo";
                    return motivo;

                case 161:
                    motivo = "Quando a gente senta no Zé da esfirra com alguém e você já começa a fazer uma consulta terapêutica";
                    return motivo;

                case 162:
                    motivo = "Quando a gente vai pro Zé da esfirra e fica conversando e moscando";
                    return motivo;

                case 163:
                    motivo = "Quando a gente se despede e dorme em call";
                    return motivo;

                case 164:
                    motivo = "A tua respiração no celular enquanto você dorme";
                    return motivo;

                case 165:
                    motivo = "A sua paixão por café";
                    return motivo;

                case 166:
                    motivo = "Quando eu faço algo exagerado e você \"meu Deus, eu vou ser viúva\"";
                    return motivo;

                case 167:
                    motivo = "O movimento dos seus dedinhos enquanto toca órgão";
                    return motivo;

                case 168:
                    motivo = "O movimento dos seus dedinhos enquanto toca órgão";
                    return motivo;


                case 169:
                    motivo = "Quando você faz um versinho pensando em mim";
                    return motivo;

                case 170:
                    motivo = "O jeito que você tá se tornando blogueirinha";
                    return motivo;

                case 171:
                    motivo = "Quando você sonha sobre o futuro junto comigo";
                    return motivo;

                case 172:
                    motivo = "O jeito teimosinha e aciosa que você tem";
                    return motivo;

                case 173:
                    motivo = "Quando a gente fala algo juntos e falamos \"dinx\" ao mesmo tempo";
                    return motivo;

                case 174:
                    motivo = "A tua gargalhada sincera quando vê um neném fazendo qualquer coisa";
                    return motivo;

                case 175:
                    motivo = "A curiosidade e a vontade que você tem de aprender sobre as coisas que você gosta";
                    return motivo;

                case 176:
                    motivo = "Quando você diz pros outros que minha intuição é muito boa";
                    return motivo;


                case 177:
                    motivo = "O sentimento de reconexão contigo após uma DR";
                    return motivo;

                case 178:
                    motivo = "Quando dançamos alguma música juntos";
                    return motivo;

                case 179:
                    motivo = "O jeito que você se esforça pra entender e até mesmo tenta gostar das mesmas coisas que gosto";
                    return motivo;

                case 180:
                    motivo = "Quando a gente finge uma briga e alguém da sua família aparece dizendo \"que isso gente, não pode brigar não\"";
                    return motivo;

                case 181:
                    motivo = "A sua cara quando eu digo que você tem bigodinho";
                    return motivo;

                case 182:
                    motivo = "Quando você começa a militar sobre algo que eu ou alguém disse";
                    return motivo;

                case 183:
                    motivo = "Quando você arregala os olhos e diz alguma coisa engraçada com uma voz mais engraçada ainda";
                    return motivo;

                case 184:
                    motivo = "Quando você diz gostar da minha mão e a gente faz a piada de semprr";
                    return motivo;

                case 185:
                    motivo = "O seu pezinho";
                    return motivo;

                case 186:
                    motivo = "A maciez da sua perna e coxa";
                    return motivo;

                case 187:
                    motivo = "Quando você me conta uma história sobre sua vida antes de eu aparecer";
                    return motivo;

                case 188:
                    motivo = "Quando você conta sobre algo de você enquanto a gente já conversava e eu não sabia";
                    return motivo;

                case 189:
                    motivo = "Quando você usa preto e sua pele fica mais corada";
                    return motivo;

                case 190:
                    motivo = "Quando você tá com calor e sua pele fica avermelhada";
                    return motivo;

                case 191:
                    motivo = "O abraço que a gente dá na chácrinha quando você acorda";
                    return motivo;

                case 192:
                    motivo = "Quando a gente deita na rede na chacrinha e fica só moscando";
                    return motivo;

                case 193:
                    motivo = "A textura da sua pele";
                    return motivo;

                case 194:
                    motivo = "Quando você começa a fazer palestra";
                    return motivo;

                case 195:
                    motivo = "Quando você usa figurinhas engraçadas";
                    return motivo;

                case 196:
                    motivo = "Sua cara quando eu começo a fazer piadas sem parar enquanto a gente tá conversando algo sério e eu digo \"desculpa, acho que eu tô tentando me esquivar\" e você me da parabéns";
                    return motivo;

                case 197:
                    motivo = "Quando você se arrepia quando eu te dou um beijinho em algum lugar";
                    return motivo;

                case 198:
                    motivo = "O brilho nos seus olhos quando você tá falando de algo que você gosta muito";
                    return motivo;

                case 199:
                    motivo = "Quando a gente tá assistindo alguma animação que você já viu e quando começa a tocar uma música você canta junto";
                    return motivo;

                case 200:
                    motivo = "Quando você começava a cantar vejo uma porta abrir com a Ana no meio do trem";
                    return motivo;

                case 201:
                    motivo = "Quando você fica comunicativa durante um beijo";
                    return motivo;

                case 202:
                    motivo = "Quando eu digo algo e você aperta os olhos e diz \"suspeito\"";
                    return motivo;

                case 203:
                    motivo = "Quando eu tô triste é você me apresenta quando a gente ora junto";
                    return motivo;

                case 204:
                    motivo = "Sua vozinha de choro";
                    return motivo;

                case 205:
                    motivo = "Sua cara quando você não alcança uma nota e faz uma vozinha engraçada";
                    return motivo;

                case 206:
                    motivo = "Quando a gente dá a mão pra andar";
                    return motivo;

                case 207:
                    motivo = "Quando a gente entra num trem cheio e vc me abraça bem grudadinha em mim";
                    return motivo;

                case 208:
                    motivo = "O seu sorriso de tirar foto";
                    return motivo;

                case 209:
                    motivo = "Quando você vê um número de uma casa e pergunta \"qual hino é o número tal\"";
                    return motivo;

                case 210:
                    motivo = "Quando a gente revive tradições antigas";
                    return motivo;

                case 211:
                    motivo = "Todas as conversas na esquina da sua casa";
                    return motivo;

                case 212:
                    motivo = "Todos os abraços apertados na hora de se despedir";
                    return motivo;

                case 213:
                    motivo = "As suas narinas expressivas";
                    return motivo;

                case 214:
                    motivo = "Teu beicinho lindo";
                    return motivo;

                case 215:
                    motivo = "Teus dentes EXTREMAMENTE retos";
                    return motivo;

                case 216:
                    motivo = "Teu narizinho";
                    return motivo;

                case 217:
                    motivo = "A textura da sua boca quando a gente dá um selinho longo";
                    return motivo;

                case 218:
                    motivo = "O jeito que vc faz biquinho quando vai chorar";
                    return motivo;

                case 219:
                    motivo = "Você sendo dramática";
                    return motivo;

                case 220:
                    motivo = "Quando vc arregala os olhos";
                    return motivo;

                case 221:
                    motivo = "Quando vc imita algumas expressões faciais minha";
                    return motivo;

                case 222:
                    motivo = "Quando vc começa a me explicar sobre um assunto que vc gosta";
                    return motivo;




            }
            return motivo;
        }
    }
}