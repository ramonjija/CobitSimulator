using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CobitProgram
{
    public class QuestoesRespostas
    {
        public string Questao { get; set; }
        public string[] Alternativas { get; set; }
        public string Resposta { get; set; }

        public QuestoesRespostas()
        {
            this.Alternativas = new string[5];
        }

        public static List<QuestoesRespostas> GeraQuestionario()
        {
            List<QuestoesRespostas> questionario = new List<QuestoesRespostas>();

            QuestoesRespostas questao1A1 = new QuestoesRespostas();
            questao1A1.Questao =
                @"Considere as afirmações abaixo sobre Governança de TI.
I - Há uma preocupação crescente com o aumento dos gastos em TI, o retorno de investimentos nessa área e o alinhamento com as atividades de negócio, aumentando
a importância da governança.
II - São aspectos fundamentais da governança de TI: controle, valor e risco.
III - As disciplinas de ITIL referentes ao gerenciamento de serviços estão divididas em desenvolvimento de sistemas e suporte.
IV - Um plano estratégico de TI deve ser considerado AD HOC quando a sua necessidade ainda não é conhecida pela Direção de TI.
Estão corretas as afirmações:             
                ";
            questao1A1.Alternativas[0] = "I e II, apenas";
            questao1A1.Alternativas[1] = "I e IV, apenas";
            questao1A1.Alternativas[2] = "I, III e IV, apenas";
            questao1A1.Alternativas[3] = "II e III, apenas";
            questao1A1.Alternativas[4] = "I, II, III e IV";

            questao1A1.Resposta = "I e II, apenas";
            questionario.Add(questao1A1);

            QuestoesRespostas questao2A1 = new QuestoesRespostas();
            questao2A1.Questao =
                @"Qual dos seguintes e o interesse mais significativo no Gerenciamento de TI?";

            questao2A1.Alternativas[0] = "Fazer o trabalho da tecnologia corretamente";
            questao2A1.Alternativas[1] = "Manter TI funcionando";
            questao2A1.Alternativas[2] = "Manter as ultimas atualizações de versões";
            questao2A1.Alternativas[3] = "Suporte e Entrega dos serviços aos usuários";
            questao2A1.Alternativas[4] = "N/a";


            questao2A1.Resposta = "Manter TI funcionando";
            questionario.Add(questao2A1);

            QuestoesRespostas questao3A1 = new QuestoesRespostas();

            questao3A1.Questao = @"Qual e o atributo essencial para o sucesso do gerenciamento de
performance?";


            questao3A1.Alternativas[0] = "Alcançar Metas";
            questao3A1.Alternativas[1] = "Bloquear ameaças e metas que não podem ser alcançadas";
            questao3A1.Alternativas[2] = "Ajustar metas que podem ser alcançadas";
            questao3A1.Alternativas[3] = "Definir Métricas e aprovar com os envolvidos";
            questao3A1.Alternativas[4] = "N/a";

            questao3A1.Resposta = "Definir Métricas e aprovar com os envolvidos";

            questionario.Add(questao3A1);


            QuestoesRespostas questao4A1 = new QuestoesRespostas();

            questao4A1.Questao = @"Entre os benefícios advindos da adoção de boas práticas de Governança Corporativa é correto afirmar que: ";

            questao4A1.Alternativas[0] =
            "Ela cria, por si só, valor para a empresa";
            questao4A1.Alternativas[1] =
            @"Proporciona uma administração ainda melhor, em benefício dos acionistas majoritários como prioridade";
            questao4A1.Alternativas[2] =
            @"Proporciona aos proprietários (acionistas ou cotistas) a gestão estratégica de sua empresa, sem a necessidade da efetiva monitoração da direção executiva.";
            questao4A1.Alternativas[3] =
            @"Disponibiliza ferramentas que asseguram ao Conselho de Administração o controle da propriedade sobre a gestão, descartando a necessidade de Auditoria Independente e de Conselho Fiscal";
            questao4A1.Alternativas[4] = @"Os investidores tendem a pagar mais por ações de empresas que adotam melhores práticas de administração e transparência.";

            questao4A1.Resposta = questao4A1.Alternativas[4];

            questionario.Add(questao4A1);

            QuestoesRespostas questao5A1 = new QuestoesRespostas();

            questao5A1.Questao = @" NÃO é recomendado aplicar COBIT para:";

            questao5A1.Alternativas[0] =
"Qualificar a contratação de prestadores de serviços de TI";
            questao5A1.Alternativas[1] =
"Avaliar pontos fortes e fracos dos processos de TI";
            questao5A1.Alternativas[2] =
"Promover benchmarking";
            questao5A1.Alternativas[3] =
"Auditar os riscos operacionais de TI";
            questao5A1.Alternativas[4] =
"Gerenciar configuração de ativos de rede.";

            questao5A1.Resposta = questao5A1.Alternativas[4];
            questionario.Add(questao5A1);

            QuestoesRespostas questao6A1 = new QuestoesRespostas();

            questao6A1.Questao = @"A respeito do guia Cobit 4.1, assinale a opção correta: ";

            questao6A1.Alternativas[0] = @"A efetividade e a eficácia são critérios do Cobit com base nos quais se atesta a qualidade da informação; já a eficiência constitui critério de qualidade das metodologias de gestão de projetos;";
            questao6A1.Alternativas[1] = @"Por meio da governança de tecnologia da informação (TI), controlam-se os investimentos em software, uma vez que os investimentos em hardware são de responsabilidade da gestão de
infraestrutura;";
            questao6A1.Alternativas[2] = @"A governança de TI compete à equipe técnica, que é a responsável por criar mecanismos decontrole, dispensando - se, dessa forma, as intervenções da alta direção da empresa nas questões técnicas da área de TI;";
            questao6A1.Alternativas[3] = @"Define - se governança de TI como uma estrutura de relações e processos mediante a qual se dirige e se controla uma organização com objetivo de adicionar valor ao negócio a partir do gerenciamento balanceado do risco com o retorno do investimento de TI;";
            questao6A1.Alternativas[4] = @"A governança de TI restringe-se ao gerenciamento de recursos, cujo objetivo é otimizar os investimentos, bem como controlar a utilização dos recursos e a mensuração do desempenho da organização.";

            questao6A1.Resposta = questao6A1.Alternativas[3];
            questionario.Add(questao6A1);

            QuestoesRespostas questao7A1 = new QuestoesRespostas();
            questao7A1.Questao = @"A missão do COBIT é:";

            questao7A1.Alternativas[0] = @"Promover o desenvolvimento da padronização e das atividades relacionadas à qualidade com o objetivo de facilitar a troca ou comercialização de produtos e serviços e desenvolver cooperação na esfera intelectual, científica, tecnológica e econômica;";
            questao7A1.Alternativas[1] = @"Promover a segurança da informação, seus objetivos gerais, seu escopo e a importância dessa segurança como um mecanismo que possibilite o compartilhamento de informações;";
            questao7A1.Alternativas[2] = @"Criar um padrão para gerenciar a maioria dos projetos, na maior parte das vezes, em vários tipos de setores de indústria, e descrever os processos, as ferramentas e técnicas de gerenciamento de projetos usados até a obtenção de resultados bem sucedidos;";
            questao7A1.Alternativas[3] = @"Pesquisar, desenvolver, publicar e promover um modelo de governança de TI atualizado e internacionalmente reconhecido para ser adotado por organizações;";
            questao7A1.Alternativas[4] = @"Definir as atividades de TI em um modelo que não é orientado por processos com o objetivo de aumentar a flexibilidade na gestão de TI e garantir a governança adequadas dos negócios.";
            questao7A1.Resposta = questao7A1.Alternativas[3];
            questionario.Add(questao7A1);

            QuestoesRespostas questao8A1 = new QuestoesRespostas();

            questao8A1.Questao = @"Sejam as seguintes ações descritas na documentação COBIT 4.1 associadas às áreas
foco da governança de TI:
 Gerenciar apropriadamente aplicativos, informações, infraestrutura e pessoas;
 Acompanhar a implementação da estratégia, término do projeto, uso do balanced
scorecards;
 Garantir a ligação entre os planos de negócios e de TI, definindo, mantendo e
validando a proposta de valor de TI, alinhando as operações e TI com as operações da
organização.
 Essas ações estão associadas, respectivamente, às seguintes áreas foco:";
            questao8A1.Alternativas[0] = @"Gestão de recursos, Mensuração de desempenho, Alinhamento estratégico;";
            questao8A1.Alternativas[1] = @"Gestão de recursos, Entrega de valor, Gestão de riscos;";
            questao8A1.Alternativas[2] = @"Entrega de valor, Gestão de riscos, Alinhamento estratégico;";
            questao8A1.Alternativas[3] = @"Gestão de riscos, Mensuração de desempenho, Entrega de valor;";
            questao8A1.Alternativas[4] = @"Alinhamento estratégico, Entrega de valor, Gestão de recursos.";

            questao8A1.Resposta = questao8A1.Alternativas[0];
            questionario.Add(questao8A1);

            QuestoesRespostas questao9A1 = new QuestoesRespostas();

            questao9A1.Questao = @"De acordo com o COBIT 4.1, os pilares que sustentam o núcleo da governança de tecnologia da informação (TI) podem ser representados por
cinco áreas. Essas áreas incluem: ";

            questao9A1.Alternativas[0] =
            @"Direção tecnológica e definição do plano estratégico;";

            questao9A1.Alternativas[1] =
            @"Gerenciamento de risco e gerenciamento de recursos;";

            questao9A1.Alternativas[2] =
            @"Agregação de valor e gerenciamento de qualidade;";

            questao9A1.Alternativas[3] =
            @"Alinhamento estratégico e gerenciamento de investimento;";

            questao9A1.Alternativas[4] =
            @"Garantia da conformidade com requisitos externos e medição de desempenho.";

            questao9A1.Resposta = questao9A1.Alternativas[1];
            questionario.Add(questao9A1);

            QuestoesRespostas questao10A1 = new QuestoesRespostas();

            questao10A1.Questao = @"Entre os critérios de informação definidos no COBIT 4.1, a conformidade
está associada à:";
            questao10A1.Alternativas[0] = @"Adequação da informação entregue aos executivos da organização para fins do exercício
de suas responsabilidades;";
            questao10A1.Alternativas[1] = @"Fidedignidade da informação em relação aos valores do negócio e suas expectativas;";
            questao10A1.Alternativas[2] = @"Aderência a leis, regulamentos e contratos, aos quais o processo de negócio está sujeito;";
            questao10A1.Alternativas[3] = @"Relevância, consistência e prazo de utilidade da informação para benefício do negócio;";
            questao10A1.Alternativas[4] = @"Geração de uso dos recursos de maneira mais produtiva e econômica.";

            questao10A1.Resposta = questao10A1.Alternativas[2];
            questionario.Add(questao10A1);

            QuestoesRespostas questao11A1 = new QuestoesRespostas();

            questao11A1.Questao = @"Qual dos seguintes itens é um problema comum encontrado durante a tentativa de alinhar a TI e ao negócio?";

            questao11A1.Alternativas[0] = @"O uso de um consultor de TI externo para o gerenciamento de projetos;";
            questao11A1.Alternativas[1] = @"Lacunas de comunicação entre o negócio e TI;";
            questao11A1.Alternativas[2] = @"Inadequação de práticas de gerenciamento de problemas;";
            questao11A1.Alternativas[3] = @"Apressar-se para desenvolver muito rapidamente";
            questao11A1.Alternativas[4] = @"N/a";

            questao11A1.Resposta = questao11A1.Alternativas[1];
            questionario.Add(questao11A1);

            QuestoesRespostas questao12A1 = new QuestoesRespostas();

            questao12A1.Questao = @"Qual dos seguintes itens é um princípio da Governança de TI?";

            questao12A1.Alternativas[0] = @"Prestação de contas;";
            questao12A1.Alternativas[1] = @"Confiabilidade;";
            questao12A1.Alternativas[2] = @"Disponibilidade;";
            questao12A1.Alternativas[3] = @"Probabilidade.";
            questao12A1.Alternativas[4] = @"N/a";

            questao12A1.Resposta = questao12A1.Alternativas[0];
            questionario.Add(questao12A1);

            QuestoesRespostas questao13A1 = new QuestoesRespostas();
            questao13A1.Questao = @"Qual destes é um objetivo estratégico?";

            questao13A1.Alternativas[0] = @"Cumprir tempo e orçamento;";
            questao13A1.Alternativas[1] = @"Zerar as falhas;";
            questao13A1.Alternativas[2] = @"Desenvolver sistemas personalizados(in house);";
            questao13A1.Alternativas[3] = @"Conceber estratégias para atingir objetivos estabelecidos.";
            questao13A1.Alternativas[4] = @"N/a";

            questao13A1.Resposta = questao13A1.Alternativas[3];
            questionario.Add(questao13A1);

            QuestoesRespostas questao14A1 = new QuestoesRespostas();

            questao14A1.Questao = @"Como o COBIT Framework pode ajudar uma organização a implementar a
Governança de TI?";

            questao14A1.Alternativas[0] = @"Através do conteúdo pronto dos programas de trabalho;";
            questao14A1.Alternativas[1] = @"Fornecendo políticas e normas mandatórias;";
            questao14A1.Alternativas[2] = @"Fornecendo um guia de boas práticas através de uma estrutura lógica;";
            questao14A1.Alternativas[3] = @"Tendo controles que podem ser implementados automaticamente.";
            questao14A1.Alternativas[4] = @"N/a";

            questao14A1.Resposta = questao14A1.Alternativas[2];
            questionario.Add(questao14A1);

            QuestoesRespostas questao15A1 = new QuestoesRespostas();

            questao15A1.Questao = @" Qual ferramenta dentro COBIT ajuda o negócio e TI entender os requisitos da informação?";
            questao15A1.Alternativas[0] = @"Critérios da Informação;";
            questao15A1.Alternativas[1] = @"Modelos de Maturidade;";
            questao15A1.Alternativas[2] = @"Requisitos de Controle;";
            questao15A1.Alternativas[3] = @"Requisitos da Informação.";
            questao15A1.Alternativas[4] = @"N/a";

            questao15A1.Resposta = questao15A1.Alternativas[0];
            questionario.Add(questao15A1);

            QuestoesRespostas questao16A1 = new QuestoesRespostas();

            questao16A1.Questao = @" Qual recurso de TI do COBIT pode ser definido como sistemas automatizados de usuários e procedimentos manuais que processam as
informações?";

            questao16A1.Alternativas[0] = @"Informações;";
            questao16A1.Alternativas[1] = @"Aplicativos;";
            questao16A1.Alternativas[2] = @"Pessoas;";
            questao16A1.Alternativas[3] = @"Infraestrutura.";
            questao16A1.Alternativas[4] = "N/a";

            questao16A1.Resposta = questao16A1.Alternativas[1];
            questionario.Add(questao16A1);

            QuestoesRespostas questao17A1 = new QuestoesRespostas();

            questao17A1.Questao = @" O framework COSO é amplamente aceito em?";

            questao17A1.Alternativas[0] = @"Gerenciamento de TI;";
            questao17A1.Alternativas[1] = @"Gerenciamento de Projetos de TI;";
            questao17A1.Alternativas[2] = @"Serviços;";
            questao17A1.Alternativas[3] = @"Controles Internos.";
            questao17A1.Alternativas[4] = @"N/a";

            questao17A1.Resposta = questao17A1.Alternativas[3];
            questionario.Add(questao17A1);

            QuestoesRespostas questao18A1 = new QuestoesRespostas();
            questao18A1.Questao = @"CobiT pode ser usado em auditorias de TI. Qual é a principal benefício do
COBIT em auditorias?";
            questao18A1.Alternativas[0] = @"Prover assistência e obter garantias sobre o controle de serviços de TI.;";
            questao18A1.Alternativas[1] = @"Fundamentar opiniões sobre controles internos de TI;";
            questao18A1.Alternativas[2] = @"Ajudar a equilibrar risco e controlar investimentos em TI;";
            questao18A1.Alternativas[3] = @"Prestar consultoria sobre controles de TI.";
            questao18A1.Alternativas[4] = @"N/a.";

            questao18A1.Resposta = questao18A1.Alternativas[2];
            questionario.Add(questao18A1);

            QuestoesRespostas questao19A1 = new QuestoesRespostas();

            questao19A1.Questao = @"O cumprimento das normas legais é considerado, no COBIT, como um critério de?";

            questao19A1.Alternativas[0] = @"Integridade;";
            questao19A1.Alternativas[1] = @"Conformidade;";
            questao19A1.Alternativas[2] = @"Confidencialidade";
            questao19A1.Alternativas[3] = @"Viabilidade;";
            questao19A1.Alternativas[4] = @"Eficácia";

            questao19A1.Resposta = questao19A1.Alternativas[1];
            questionario.Add(questao19A1);

            QuestoesRespostas questao20A1 = new QuestoesRespostas();

            questao20A1.Questao = @"Para satisfazer os objetivos de negócio de uma empresa, segundo o CobiT
4.1, a informação deve atender a critérios de controle, que são:";

            questao20A1.Alternativas[0] = @"Excelência, efetividade, entrega ao usuário, segurança, conformidade, disponibilidade e
qualidade;";
            questao20A1.Alternativas[1] = @"Efetividade, eficiência, confidencialidade, integridade, disponibilidade, conformidade e
confiabilidade;";
            questao20A1.Alternativas[2] = @"Eficiência, entrega ao usuário, continuidade, segurança, confidencialidade, conformidade,
disponibilidade e qualidade;";
            questao20A1.Alternativas[3] = @"Eficácia, entrega ao usuário, continuidade, segurança, conformidade, disponibilidade e
qualidade;";
            questao20A1.Alternativas[4] = @"Eficácia, eficiência, excelência, segurança, integridade, confidencialidade e disponibilidade.";

            questao20A1.Resposta = questao20A1.Alternativas[1];
            questionario.Add(questao20A1);

            //Questionario 2

            QuestoesRespostas questao1A2 = new QuestoesRespostas();

            questao1A2.Questao = @"O COBIT define as atividades de TI em um modelo de processos genéricos com quatro domínios.Esses domínios mapeiam as tradicionais áreas de responsabilidade de TI de planejamento,
construção, processamento e monitoramento.Os domínios do COBIT são:";
            questao1A2.Alternativas[0] = @"Planejar e Estimar; Adquirir ou Desenvolver; Implementar e Manter; Avaliar e Monitorar";
            questao1A2.Alternativas[1] = @"Planejar e Monitorar; Analisar e Implementar; Entregar e Manter; Avaliar e Monitorar";
            questao1A2.Alternativas[2] = @"Planejar e Organizar; Estimar e Orçar; Entregar e Suportar; Monitorar e Avaliar";
            questao1A2.Alternativas[3] = @"Planejar e Organizar; Analisar e Desenvolver; Implantar e Suportar; Monitorar e Manter";
            questao1A2.Alternativas[4] = @"Planejar e Organizar; Adquirir e Implementar; Entregar e Suportar; Monitorar e Avaliar";

            questao1A2.Resposta = questao1A2.Alternativas[4];

            questionario.Add(questao1A2);

            QuestoesRespostas questao2A2 = new QuestoesRespostas();

            questao2A2.Questao = @" Qual dos seguintes itens representa uma perspectiva
organizacional de um balanced scorecard?";
            questao2A2.Alternativas[0] = "Painel";
            questao2A2.Alternativas[1] = "Métrica";
            questao2A2.Alternativas[2] = "Bonificação";
            questao2A2.Alternativas[3] = "Cliente";
            questao2A2.Alternativas[4] = "Ameaças";

            questao2A2.Resposta = questao2A2.Alternativas[3];

            questionario.Add(questao2A2);

            QuestoesRespostas questao3A2 = new QuestoesRespostas();

            questao3A2.Questao = @" Analisando o seu ambiente de trabalho em uma empresa, um analista de sistemas verificou que os procedimentos estavam
padronizados, documentados e comunicados através de treinamento.Que nível de maturidade de processos está associado com essa situação no COBIT 4.1 ?";

            questao3A2.Alternativas[0] = "Nível 3 – Definido";
            questao3A2.Alternativas[1] = "Nível 2 – Repetível";
            questao3A2.Alternativas[2] = "Nível 4 – Gerenciado";
            questao3A2.Alternativas[3] = "Nível 1 – Inicial";
            questao3A2.Alternativas[4] = "Nível 5 – Otimizado";

            questao3A2.Resposta = questao3A2.Alternativas[0];

            questionario.Add(questao3A2);

            QuestoesRespostas questao4A2 = new QuestoesRespostas();

            questao4A2.Questao = " Os níveis de maturidade ajudam as organizações a: ";

            questao4A2.Alternativas[0] = "Conhecer metas e objetivos";
            questao4A2.Alternativas[1] = "Avaliar os controles";
            questao4A2.Alternativas[2] = "Determinar a capacidade atual do processo";
            questao4A2.Alternativas[3] = "Definir medidas de desempenho";
            questao4A2.Alternativas[4] = "Avaliar as empresas além da perspectiva financeira";

            questao4A2.Resposta = questao4A2.Alternativas[2];

            questionario.Add(questao4A2);


            QuestoesRespostas questao5A2 = new QuestoesRespostas();

            questao5A2.Questao = @" Determinada empresa reconhece que é necessário definir um plano estratégico de TI; contudo, não existem processos
padronizados para isso, e a abordagem da administração, em geral, não é organizada. O processo COBIT em questão encontra-se no
nível de maturidade: ";

            questao5A2.Alternativas[0] = "Nivel 0";
            questao5A2.Alternativas[1] = "Nivel 1";
            questao5A2.Alternativas[2] = "Nivel 2";
            questao5A2.Alternativas[3] = "Nivel 3";
            questao5A2.Alternativas[4] = "Nivel 4";

            questao5A2.Resposta = questao5A2.Alternativas[1];

            questionario.Add(questao5A2);

            QuestoesRespostas questao6A2 = new QuestoesRespostas();

            questao6A2.Questao = @" Indicadores de Performance são fatores que:";
            questao6A2.Alternativas[0] = "Identificam controles-chave da organização";
            questao6A2.Alternativas[1] = "Identificam processo-chave da organização";
            questao6A2.Alternativas[2] = "Influenciam positivamente o resultado do processo";
            questao6A2.Alternativas[3] = "Concentram-se em práticas de controle";
            questao6A2.Alternativas[4] = "Identificam se o objetivo do processo foi atingido";

            questao6A2.Resposta = questao6A2.Alternativas[2];

            questionario.Add(questao6A2);

            QuestoesRespostas questao7A2 = new QuestoesRespostas();

            questao7A2.Questao = @"Uma empresa que utiliza o COBIT 4.1 como modelo de melhoras práticas para Governança de TI, estabeleceu como meta, até
dezembro de 2015, executar um Plano de Ação com o objetivo de elevar o nível de maturidade de seus processos prioritários de 2 para
3. Isso significa que: ";

            questao7A2.Alternativas[0] = @"Seus processos seguem um padrão de regularidade e deseja-se atingir um nível em que esses
sejam documentados e comunicados.";
            questao7A2.Alternativas[1] = @"Seus processos seguem um padrão de regularidade e deseja-se atingir um nível em que esses
sejam monitorados e medidos.";
            questao7A2.Alternativas[2] = @"Seus processos são monitorados e medidos, e deseja-se atingir um nível em que esses sejam
documentados e comunicados.";
            questao7A2.Alternativas[3] = @"Boas práticas são seguidas e automatizadas, e deseja-se atingir um nível em que seus processos
sejam documentados e medidos.";
            questao7A2.Alternativas[4] = @"Não há gestão em seus processos e deseja - se atingir um nível em que esses sejam monitorados e
  medidos";

            questao7A2.Resposta = questao7A2.Alternativas[0];

            questionario.Add(questao7A2);

            QuestoesRespostas questao8A2 = new QuestoesRespostas();

            questao8A2.Questao = "Qual recurso COBIT fornece benchmarking de capacidade?";
            questao8A2.Alternativas[0] = "COBIT Quickstart";
            questao8A2.Alternativas[1] = "COBIT Security Baseline";
            questao8A2.Alternativas[2] = "IT Governance Implementation Guide";
            questao8A2.Alternativas[3] = "COBIT online";
            questao8A2.Alternativas[4] = "Val IT";

            questao8A2.Resposta = questao8A2.Alternativas[3];

            questionario.Add(questao8A2);

            QuestoesRespostas questao9A2 = new QuestoesRespostas();

            questao9A2.Questao = @"Segundo o COBIT 4.1, um indicador de performance de um serviço de TI mede o:";
            questao9A2.Alternativas[0] = "Índice de sucesso de um objetivo";
            questao9A2.Alternativas[1] = "Nível de maturidade de um processo";
            questao9A2.Alternativas[2] = "Histórico dos requisitos de negócio";
            questao9A2.Alternativas[3] = "Andamento do atingimento de um objetivo";
            questao9A2.Alternativas[4] = "Resultado de um objetivo";

            questao9A2.Resposta = questao9A2.Alternativas[3];

            questionario.Add(questao9A2);

            QuestoesRespostas questao10A2 = new QuestoesRespostas();

            questao10A2.Questao = @"Qual dos seguintes aspectos do COBIT pode ser aferido (benchmarking) no COBIT on-line?";

            questao10A2.Alternativas[0] = "Utilização de Recursos de TI";
            questao10A2.Alternativas[1] = "Utilização de Critérios de Informação";
            questao10A2.Alternativas[2] = "Utilização de Medidas de Resultados e Indicadores de Performance";
            questao10A2.Alternativas[3] = "Utilização de Domínios";
            questao10A2.Alternativas[4] = "Utilização da Matriz RACI";

            questao10A2.Resposta = questao10A2.Alternativas[2];

            questionario.Add(questao10A2);

            QuestoesRespostas questao11A2 = new QuestoesRespostas();

            questao11A2.Questao = @"Quando uma empresa está em fase de elaboração de um plano estratégico de TI, ela precisa entender, inicialmente, qual é a sua
missão, de forma a apoiar adequadamente os objetivos de negócio da empresa. Nesse contexto, missão significa a(o):";
            questao11A2.Alternativas[0] = "Razão de ser, o motivo da existência ou seu propósito.";
            questao11A2.Alternativas[1] = "Elaboração dos indicadores da empresa com base em sua razão de ser.";
            questao11A2.Alternativas[2] = "Posição que a empresa pretende alcançar.";
            questao11A2.Alternativas[3] = "Atingimento da qualidade na execução dos processos com base em onde se pretende chegar.";
            questao11A2.Alternativas[4] = "Cumprimento das metas tangíveis de curto prazo.";

            questao11A2.Resposta = questao11A2.Alternativas[0];

            questionario.Add(questao11A2);

            QuestoesRespostas questao12A2 = new QuestoesRespostas();

            questao12A2.Questao = @"O que faz um indicador-chave de objetivo?";

            questao12A2.Alternativas[0] = "Avalia o resultado de um objetivo de controle";
            questao12A2.Alternativas[1] = "Avalia o resultado de um processo de negócio";
            questao12A2.Alternativas[2] = "Avalia a performance de um processo de TI";
            questao12A2.Alternativas[3] = "Avalia o nível de aderência de uma gestão";
            questao12A2.Alternativas[4] = "Avalia se os objetivos serão possivelmente atingidos";

            questao12A2.Resposta = questao12A2.Alternativas[1];

            questionario.Add(questao12A2);

            QuestoesRespostas questao13A2 = new QuestoesRespostas();

            questao13A2.Questao = @"Um modelo bastante difundido atualmente na formulação de estratégias é o denominado Balanced Scorecard ou Escore
Balanceado, que se baseia no desdobramento da visão de futuro em torno de dimensões equilibradas, podendo essas dimensões ser
alteradas para contemplar as características de organizações privadas, públicas ou do terceiro setor. O Balanced Scorecard inova
por apresentar um(a): ";

            questao13A2.Alternativas[0] = @"Sistema de indicadores de resultados e modelos de remuneração variável, associados.";
            questao13A2.Alternativas[1] = @"Modelo de accountability alinhado à legislação Sarbanes-Oxley.";
            questao13A2.Alternativas[2] = @"Estrutura de objetivos, metas e vetores de desempenho que interagem dentro de uma
lógica de causa e efeito.";
            questao13A2.Alternativas[3] = @"Ferramenta estratégica de coordenação e organização das expectativas dos stakeholders.";
            questao13A2.Alternativas[4] = @"Perspectiva organizada de prestação de contas e responsabilidade socioambiental";

            questao13A2.Resposta = questao13A2.Alternativas[2];

            questionario.Add(questao13A2);

            QuestoesRespostas questao14A2 = new QuestoesRespostas();

            questao14A2.Questao = "Qual o produto COBIT fornece informações atualizadas sobre o COBIT?";
            questao14A2.Alternativas[0] = "COBIT Framework";
            questao14A2.Alternativas[1] = "COBIT Implementation Tools";
            questao14A2.Alternativas[2] = "COBIT Online";
            questao14A2.Alternativas[3] = "COBIT Resources";
            questao14A2.Alternativas[4] = "COBIT Quickstart";

            questao14A2.Resposta = questao14A2.Alternativas[2];

            questionario.Add(questao14A2);

            QuestoesRespostas questao15A2 = new QuestoesRespostas();

            questao15A2.Questao = @"Atualmente, a existência de um sistema de medidas de desempenho confiável, abrangente e estruturado vem-se mostrando um imperativo
ao crescimento e à competitividade empresarial. Responde a essa necessidade, o sistema de indicadores de desempenho, o Balanced
Scorecard. Essa metodologia de avaliação de desempenho: ";
            questao15A2.Alternativas[0] = @"Tem como principal objetivo o estabelecimento de metas de curto prazo.";
            questao15A2.Alternativas[1] = @"Tem como finalidade promover uma comparação objetiva entre uma empresa e seus concorrentes.";
            questao15A2.Alternativas[2] = @"Tem como principal atrativo permitir a atribuição de dimensões matemáticas a valores tangíveis
das empresas, como patrimônio, produtividade e capital intelectual.";
            questao15A2.Alternativas[3] = @"Utiliza um sistema de vetores de desempenho, que consiste em um conjunto de indicadores
financeiros da empresa.";
            questao15A2.Alternativas[4] = @"Avalia o desempenho das organizações a partir de, pelo menos, quatro perspectivas: financeira,
clientes, processos internos e aprendizagem organizacional.";

            questao15A2.Resposta = questao15A2.Alternativas[4];

            questionario.Add(questao15A2);


            QuestoesRespostas questao16A2 = new QuestoesRespostas();

            questao16A2.Questao = @" O processo de TI definido no CobiT como gerenciamento de dados é encontrado em que domínio?";
            questao16A2.Alternativas[0] = "Monitorar e Avaliar.";
            questao16A2.Alternativas[1] = "Adquirir e Implementar.";
            questao16A2.Alternativas[2] = "Planejar e Organizar.";
            questao16A2.Alternativas[3] = "Planejar e Implementar";
            questao16A2.Alternativas[4] = "Entregar e Suportar.";

            questao16A2.Resposta = questao16A2.Alternativas[4];

            questionario.Add(questao16A2);

            QuestoesRespostas questao17A2 = new QuestoesRespostas();

            questao17A2.Questao = @"Qual domínio COBIT concentra-se em prover uma gestão supervisionada no processo de controle?";
            questao17A2.Alternativas[0] = "Adquirir e Implementar.";
            questao17A2.Alternativas[1] = "Planejar e Implementar";
            questao17A2.Alternativas[2] = "Monitorar e Avaliar.";
            questao17A2.Alternativas[3] = "Planejar e Organizar.";
            questao17A2.Alternativas[4] = "Entregar e Suportar.";

            questao17A2.Resposta = questao17A2.Alternativas[2];

            questionario.Add(questao17A2);

            QuestoesRespostas questao18A2 = new QuestoesRespostas();

            questao18A2.Questao = @" O modelo SWOT reforça a relação estratégia-processo e a necessidade da análise interna e externa. Esse modelo é uma das
bases para a definição de qualquer tipo de estratégia. Nesse contexto, um Gestor de TI deve saber que as: ";
            questao18A2.Alternativas[0] = "Ameaças e as fraquezas são consideradas análises do ambiente externo.";
            questao18A2.Alternativas[1] = "Forças e as fraquezas são consideradas análises do ambiente interno.";
            questao18A2.Alternativas[2] = "Oportunidades e as forças são consideradas análises do ambiente externo.";
            questao18A2.Alternativas[3] = "Oportunidades e as ameaças são consideradas análises do ambiente interno.";
            questao18A2.Alternativas[4] = "Oportunidades, as forças, as ameaças e as fraquezas são consideradas análises do ambiente interno.";

            questao18A2.Resposta = questao18A2.Alternativas[1];

            questionario.Add(questao18A2);

            QuestoesRespostas questao19A2 = new QuestoesRespostas();


            questao19A2.Questao = @" No Cobit 4.1, Assegurar a Segurança dos Serviços, Prover a Governança de TI e Gerenciar Mudanças pertencem, respectivamente,
aos domínios:";
            questao19A2.Alternativas[0] = "Entregar e Suportar; Planejar e Organizar; e Adquirir e Implementar.";
            questao19A2.Alternativas[1] = "Adquirir e Implementar; Entregar e Suportar; e Planejar e Organizar.";
            questao19A2.Alternativas[2] = "Planejar e Organizar; Adquirir e Implementar; e Entregar e Suportar.";
            questao19A2.Alternativas[3] = "Entregar e Suportar; Monitorar e Avaliar; e Adquirir e Implementar.";
            questao19A2.Alternativas[4] = "Entregar e Suportar; Planejar e Organizar; e Monitorar e Avaliar.";

            questao19A2.Resposta = questao19A2.Alternativas[3];

            questionario.Add(questao19A2);

            QuestoesRespostas questao20A2 = new QuestoesRespostas();

            questao20A2.Questao = @" Em uma reunião gerencial de TI de uma empresa, um gerente afirma, corretamente, que o objetivo de controle Avaliar e Gerenciar
os Riscos de TI do COBIT pertence ao domínio: ";

            questao20A2.Alternativas[0] = "Gerenciamento de riscos.";
            questao20A2.Alternativas[1] = "Monitorar e avaliar.";
            questao20A2.Alternativas[2] = "Direcionamento estratégico.";
            questao20A2.Alternativas[3] = "Tolerância a riscos.";
            questao20A2.Alternativas[4] = "Planejar e organizar.";

            questao20A2.Resposta = questao20A2.Alternativas[4];

            questionario.Add(questao20A2);


            QuestoesRespostas questao1A3 = new QuestoesRespostas();

            questao1A3.Questao = @" Seja o seguinte objetivo de controle: Manter um dicionário de dados corporativos que incorpore as regras de sintaxe de dados da
organização. A qual processo do domínio Planejar e Organizar do COBIT está associado este objetivo de controle?";
            questao1A3.Alternativas[0] = "Determinar as Diretrizes da Tecnologia.";
            questao1A3.Alternativas[1] = "Definir os Processos, Organização e Relacionamentos de TI.";
            questao1A3.Alternativas[2] = "Definir um Plano Estratégico de TI.";
            questao1A3.Alternativas[3] = "Definir a Arquitetura da Informação.";
            questao1A3.Alternativas[4] = "Gerenciar a Qualidade.";

            questao1A3.Resposta = questao1A3.Alternativas[3];

            questionario.Add(questao1A3);

            QuestoesRespostas questao2A3 = new QuestoesRespostas();

            questao2A3.Questao = @" Qual das seguintes Processos de TI do COBIT aborda a necessidade de um 'programa e projeto de avaliação de risco'?";
            questao2A3.Alternativas[0] = "PO1 Definir um Plano Estratégico de TI.";
            questao2A3.Alternativas[1] = "PO8 Gerenciar a Qualidade.";
            questao2A3.Alternativas[2] = "PO9 Avaliar e Gerenciar os Riscos de TI.";
            questao2A3.Alternativas[3] = "PO10 Gerenciar Projetos.";
            questao2A3.Alternativas[4] = "PO4 Definir os Processos, a Organização e os Relacionamentos de TI";

            questao2A3.Resposta = questao2A3.Alternativas[2];

            questionario.Add(questao2A3);

            QuestoesRespostas questao3A3 = new QuestoesRespostas();

            questao3A3.Questao = @" Na visão da governança corporativa de TI com o modelo COBIT, o domínio de Planejamento e Organização trata das questões estratégicas.
A esse respeito, qual dos processos relacionados abaixo apresenta-se com explicação pertinente?";
            questao3A3.Alternativas[0] = @"Definir um plano estratégico de TI - tem foco na atualização da empresa com as tendências
futuras da tecnologia.";
            questao3A3.Alternativas[1] = @"Gerenciar o investimento de TI - diz respeito a entender quais soluções devem ser vendidas aos
clientes.";
            questao3A3.Alternativas[2] = @"Definir os processos, a organização e os relacionamentos de TI - refere-se ao gerenciamento de
recursos humanos da organização.";
            questao3A3.Alternativas[3] = @"Comunicar as metas e diretrizes gerenciais - passa por um programa de comunicação contínuo
apoiado pela direção para articular missão, metas, políticas e procedimentos.";
            questao3A3.Alternativas[4] = @"Gerenciar a qualidade - mantém padrões que não estejam sujeitos a flutuações nas necessidades
dos clientes.";

            questao3A3.Resposta = questao3A3.Alternativas[3];

            questionario.Add(questao3A3);

            QuestoesRespostas questao4A3 = new QuestoesRespostas();

            questao4A3.Questao = @" Qual é o objetivo de alto nível referente a gestão de todos os projetos de TI?";
            questao4A3.Alternativas[0] = "PO1 Definir um Plano Estratégico de TI.";
            questao4A3.Alternativas[1] = "PO4 Definir os Processos, a Organização e os Relacionamentos de TI.";
            questao4A3.Alternativas[2] = "PO5 Gerenciar o Investimento de TI.";
            questao4A3.Alternativas[3] = "PO10 Gerenciar Projetos.";
            questao4A3.Alternativas[4] = "PO9 Avaliar e Gerenciar os Riscos de TI.";

            questao4A3.Resposta = questao4A3.Alternativas[3];
            questionario.Add(questao4A3);


            QuestoesRespostas questao5A3 = new QuestoesRespostas();

            questao5A3.Questao = @" O processo Gerenciar os Recursos Humanos de TI (PO7) pertence ao domínio CobiT 4.1?";
            questao5A3.Alternativas[0] = "Planejar e Organizar.";
            questao5A3.Alternativas[1] = "Entregar e Suportar.";
            questao5A3.Alternativas[2] = "Adquirir e Implementar.";
            questao5A3.Alternativas[3] = "Implementar e Organizar.";
            questao5A3.Alternativas[4] = "Monitorar e Avaliar.";

            questao5A3.Resposta = questao5A3.Alternativas[0];
            questionario.Add(questao5A3);

            QuestoesRespostas questao6A3 = new QuestoesRespostas();

            questao6A3.Questao = @"Qual dos seguintes processos de TI fornecem resultados dentro do tempo, do orçamento e da qualidade acordados?";
            questao6A3.Alternativas[0] = "PO8 Gerenciar a Qualidade.";
            questao6A3.Alternativas[1] = "PO3 Determinar as Diretrizes de Tecnologia.";
            questao6A3.Alternativas[2] = "PO5 Gerenciar o Investimento de TI.";
            questao6A3.Alternativas[3] = "PO6 Comunicar Metas e Diretrizes Gerenciais.";
            questao6A3.Alternativas[4] = "PO10 Gerenciar Projetos.";

            questao6A3.Resposta = questao6A3.Alternativas[4];

            questionario.Add(questao6A3);

            QuestoesRespostas questao7A3 = new QuestoesRespostas();

            questao7A3.Questao = @" A declaração de controle “avaliar riscos” é prevista no domínio planejamento e organização e visa, entre outros, apoiar decisões
gerenciais, reduzir a complexidade e identificar fatores de decisão importantes.";
            questao7A3.Alternativas[0] = "CERTO";
            questao7A3.Alternativas[1] = "ERRADO";
            questao7A3.Alternativas[2] = "N/a";
            questao7A3.Alternativas[3] = "N/a";
            questao7A3.Alternativas[4] = "N/a";

            questao7A3.Resposta = questao7A3.Alternativas[0];

            questionario.Add(questao7A3);

            QuestoesRespostas questao8A3 = new QuestoesRespostas();

            questao8A3.Questao = @"Para o gerenciamento do processo denominado Definir um Plano Estratégico de TI, estabelecem - se os seguintes objetivos:
a otimização do uso da informação, a garantia de integração total de aplicações nos processos de negócios, a resposta aos requisitos de
negócio em alinhamento com a estratégia corporativa e a criação de agilidade em TI. ";

            questao8A3.Alternativas[0] = "CERTO";
            questao8A3.Alternativas[1] = "ERRADO";
            questao8A3.Alternativas[2] = "N/a";
            questao8A3.Alternativas[3] = "N/a";
            questao8A3.Alternativas[4] = "N/a";

            questao8A3.Resposta = questao8A3.Alternativas[1];

            questionario.Add(questao8A3);


            QuestoesRespostas questao9A3 = new QuestoesRespostas();
            questao9A3.Questao = @" No modelo em apreço, o domínio Planejamento e Organização envolve identificação, desenvolvimento e(ou) aquisição de soluções
para a execução de sistemas de TI específicos, assim como a sua implementação e integração junto a processos de negócio. ";

            questao9A3.Alternativas[0] = "CERTO";
            questao9A3.Alternativas[1] = "ERRADO";
            questao9A3.Alternativas[2] = "N/a";
            questao9A3.Alternativas[3] = "N/a";
            questao9A3.Alternativas[4] = "N/a";

            questao9A3.Resposta = questao9A3.Alternativas[1];

            questionario.Add(questao9A3);

            QuestoesRespostas questao10A3 = new QuestoesRespostas();

            questao10A3.Questao = @" O domínio planejamento e organização encarrega-se de prover a direção tecnológica para entrega das soluções, ao passo que o
domínio aquisição e implementação recebe essas soluções e as tornam disponíveis aos usuários finais. ";


            questao10A3.Alternativas[0] = "CERTO";
            questao10A3.Alternativas[1] = "ERRADO";
            questao10A3.Alternativas[2] = "N/a";
            questao10A3.Alternativas[3] = "N/a";
            questao10A3.Alternativas[4] = "N/a";

            questao10A3.Resposta = questao10A3.Alternativas[0];

            questionario.Add(questao10A3);

            QuestoesRespostas questao11A3 = new QuestoesRespostas();

            questao11A3.Questao = @"Gerenciamento de risco é o processo de identificação, controle e minimização ou eliminação dos riscos de segurança que podem
afetar os sistemas de informação, a custo aceitável. No COBIT, esse gerenciamento está mais relacionado ao domínio planejamento e
organização do que ao domínio de monitoração e avaliação. ";

            questao11A3.Alternativas[0] = "CERTO";
            questao11A3.Alternativas[1] = "ERRADO";
            questao11A3.Alternativas[2] = "N/a";
            questao11A3.Alternativas[3] = "N/a";
            questao11A3.Alternativas[4] = "N/a";

            questao11A3.Resposta = questao11A3.Alternativas[0];

            questionario.Add(questao11A3);

            return questionario;
        }

        public static List<QuestoesRespostas> GeraQuestionarioAV2()
        {
            List<QuestoesRespostas> questionario = new List<QuestoesRespostas>();

            QuestoesRespostas questao1A4 = new QuestoesRespostas();

            questao1A4.Questao =
                @" Qual é o objetivo de alto nível que está relacionado com a produção de documentação e manuais para os usuários?";

            questao1A4.Alternativas[0] = "AI1 Identificar Solução Automatizadas";
            questao1A4.Alternativas[1] = "DS7 Educar e Treinar os Usuários";
            questao1A4.Alternativas[2] = "DS8 Gerenciar a Central de Serviço e os Incidentes";
            questao1A4.Alternativas[3] = "AI4 Habilitar Operação e Uso";
            questao1A4.Alternativas[4] = "AI5 Adquirir Recursos de TI";

            questao1A4.Resposta = questao1A4.Alternativas[3];
            questionario.Add(questao1A4);

            QuestoesRespostas questao2A4 = new QuestoesRespostas();

            questao2A4.Questao =
                @"  Com relação ao COBIT, julgue os próximos itens.
O desenvolvimento e a manutenção dos procedimentos, instalação e certificação de software e gerenciamento de mudanças são processos do domínio aquisição e a implementação. ";

            questao2A4.Alternativas[0] = "CERTO";
            questao2A4.Alternativas[1] = "ERRADO";
            questao2A4.Alternativas[2] = "N/A";
            questao2A4.Alternativas[3] = "N/A";
            questao2A4.Alternativas[4] = "N/A";

            questao2A4.Resposta = questao2A4.Alternativas[0];
            questionario.Add(questao2A4);

            QuestoesRespostas questao3A4 = new QuestoesRespostas();

            questao3A4.Questao =
                @"  Identificar Soluções Automatizadas e Avaliar e Gerenciar os Riscos de TI são objetivos de controle de alto nível pertencentes, respectivamente, aos domínios COBIT";

            questao3A4.Alternativas[0] = "Planejamento e Organização; e Monitoração e Avaliação";
            questao3A4.Alternativas[1] = "Monitoração e Avaliação; e Aquisição e Implementação.";
            questao3A4.Alternativas[2] = "Aquisição e Implementação; e Planejamento e Organização.";
            questao3A4.Alternativas[3] = "Monitoração de Processos; e Entrega e Suporte.";
            questao3A4.Alternativas[4] = "Entrega e Suporte; e Planejamento e Organização.";

            questao3A4.Resposta = questao3A4.Alternativas[2];
            questionario.Add(questao3A4);

            QuestoesRespostas questao4A4 = new QuestoesRespostas();

            questao4A4.Questao =
                @"  No domínio adquirir e implementar (acquire and implement), há o processo adquirir e manter infra-estrutura de tecnologia (acquire and maintain technology infrastructure), que tem como objetivos: desenvolver e executar um plano de garantia de qualidade de software; desenvolver e manter uma estratégia e um plano para a manutenção dos softwares aplicativos";

            questao4A4.Alternativas[0] = "CERTO";
            questao4A4.Alternativas[1] = "ERRADO";
            questao4A4.Alternativas[2] = "N/A";
            questao4A4.Alternativas[3] = "N/A";
            questao4A4.Alternativas[4] = "N/A";

            questao4A4.Resposta = questao4A4.Alternativas[1];
            questionario.Add(questao4A4);

            QuestoesRespostas questao5A4 = new QuestoesRespostas();

            questao5A4.Questao =
                @" O COBIT, em seu domínio aquisição e implementação, descreve o processo garantir a segurança do sistema";

            questao5A4.Alternativas[0] = "CERTO";
            questao5A4.Alternativas[1] = "ERRADO";
            questao5A4.Alternativas[2] = "N/A";
            questao5A4.Alternativas[3] = "N/A";
            questao5A4.Alternativas[4] = "N/A";

            questao5A4.Resposta = questao5A4.Alternativas[1];
            questionario.Add(questao5A4);

            QuestoesRespostas questao6A4 = new QuestoesRespostas();

            questao6A4.Questao =
                @"  Gerência de configuração é descrita, no COBIT, no domínio AI – Adquirir e Implementar";

            questao6A4.Alternativas[0] = "CERTO";
            questao6A4.Alternativas[1] = "ERRADO";
            questao6A4.Alternativas[2] = "N/A";
            questao6A4.Alternativas[3] = "N/A";
            questao6A4.Alternativas[4] = "N/A";

            questao6A4.Resposta = questao6A4.Alternativas[1];
            questionario.Add(questao6A4);

            QuestoesRespostas questao7A4 = new QuestoesRespostas();

            questao7A4.Questao =
                @" Qual dos processos de TI dentro do COBIT deve assegurar a existência de um processo de desenvolvimento que contemple o cumprimento de prazos e otimização de custos";

            questao7A4.Alternativas[0] = "AI2 Adquirir e Manter Software Aplicativo";
            questao7A4.Alternativas[1] = "AI3 Adquirir e Manter Infraestrutura de Tecnologia";
            questao7A4.Alternativas[2] = "AI4 Habilitar Operação e Uso";
            questao7A4.Alternativas[3] = "AI5 Adquirir Recursos de TI";
            questao7A4.Alternativas[4] = "AI7 Instalar e Homologar Soluções e Mudanças";

            questao7A4.Resposta = questao7A4.Alternativas[0];
            questionario.Add(questao7A4);

            QuestoesRespostas questao8A4 = new QuestoesRespostas();

            questao8A4.Questao =
                @" Qual dos processos de TI dentro do COBIT aborda a avaliação crítica do impacto e prioridade das mudanças baseadas nas necessidades do negócio";

            questao8A4.Alternativas[0] = "AI4 Habilitar Operação e Uso";
            questao8A4.Alternativas[1] = "AI5 Adquirir Recursos de TI";
            questao8A4.Alternativas[2] = "AI6 Gerenciar Mudanças";
            questao8A4.Alternativas[3] = "AI3 Adquirir e Manter Infraestrutura de Tecnologia";
            questao8A4.Alternativas[4] = "AI7 Instalar e Homologar Soluções e Mudanças";

            questao8A4.Resposta = questao8A4.Alternativas[2];
            questionario.Add(questao8A4);

            QuestoesRespostas questao1A5 = new QuestoesRespostas();

            questao1A5.Questao =
                @"O COBIT define as atividades de TI num modelo genérico de processos divididos em quatro domínios. 
Esses domínios mapeiam as tradicionais áreas de responsabilidade de TI de planejamento, construção, processamento e monitoramento.
Entre os conjuntos de processos listados abaixo, qual faz parte do domínio Entregar e Suportar ?";

            questao1A5.Alternativas[0] = "Gerenciar a capacidade e o desempenho, educar e treinar os usuários e gerenciar a configuração";
            questao1A5.Alternativas[1] = "Instalar e homologar as soluções e mudanças, gerenciar as mudanças, habilitar a operação e o uso";
            questao1A5.Alternativas[2] = "Instalar e homologar as soluções e mudanças, gerenciar as mudanças, assegurar a continuidade de serviços";
            questao1A5.Alternativas[3] = "Monitorar e avaliar o desempenho, monitorar e avaliar os controles internos, avaliar e gerenciar os riscos de TI";
            questao1A5.Alternativas[4] = "Determinar o direcionamento tecnológico, definir os processos, a organização e os relacionamentos de TI, gerenciar o investimento de TI";

            questao1A5.Resposta = questao1A5.Alternativas[0];
            questionario.Add(questao1A5);

            QuestoesRespostas questao2A5 = new QuestoesRespostas();

            questao2A5.Questao =
                @"Qual processo de TI dentro do COBIT deve assegurar oportunamente definições dos requisitos operacionais e dos níveis de serviço?";

            questao2A5.Alternativas[0] = "AI1 Identificar Soluções Automatizadas.";
            questao2A5.Alternativas[1] = "PO1 Definir um Plano Estratégico de TI.";
            questao2A5.Alternativas[2] = "DS2 Gerenciar Serviços Terceirizados.";
            questao2A5.Alternativas[3] = "AI2 Adquirir e Manter Software Aplicativo.";
            questao2A5.Alternativas[4] = "DS1 Definir e Gerenciar Níveis de Serviços.";

            questao2A5.Resposta = questao2A5.Alternativas[4];
            questionario.Add(questao2A5);

            QuestoesRespostas questao3A5 = new QuestoesRespostas();

            questao3A5.Questao =
                @"É um dos domínios do COBIT. Define as questões operacionais ligadas ao uso da TI para atendimento aos serviços para os clientes, manutenção e garantias ligadas a estes serviços.
Os processos a ele pertencentes tratam da definição dos níveis de serviço, entre outros. Trata-se";

            questao3A5.Alternativas[0] = "da Obtenção de Garantia Independente da Obtenção de Garantia Independente.";
            questao3A5.Alternativas[1] = "do Planejamento e da Organização.";
            questao3A5.Alternativas[2] = "da Monitoração e da Avaliação.";
            questao3A5.Alternativas[3] = "da Entrega e do Suporte.";
            questao3A5.Alternativas[4] = "da Aquisição e da Implementação";

            questao3A5.Resposta = questao3A5.Alternativas[3];
            questionario.Add(questao3A5);

            QuestoesRespostas questao4A5 = new QuestoesRespostas();

            questao4A5.Questao =
                @"Qual dos seguintes processos de TI ajuda a garantir que os prestadores de serviços estão de acordo com os requisitos de negócios ?";

            questao4A5.Alternativas[0] = "PO7 Gerenciar os Recursos Humanos de TI.";
            questao4A5.Alternativas[1] = "DS1 Definir e Gerenciar Níveis de Serviços.";
            questao4A5.Alternativas[2] = "DS2 Gerenciar Serviços Terceirizados.";
            questao4A5.Alternativas[3] = "DS3 Gerenciar o Desempenho e a Capacidade.";
            questao4A5.Alternativas[4] = "AI4 Habilitar Operação e Uso";

            questao4A5.Resposta = questao4A5.Alternativas[2];
            questionario.Add(questao4A5);


            QuestoesRespostas questao5A5 = new QuestoesRespostas();

            questao5A5.Questao =
                @"No COBIT, “Gerenciar os serviços de terceiros” pertence a que domínio?";

            questao5A5.Alternativas[0] = "Auditoria.";
            questao5A5.Alternativas[1] = "Recursos Humanos.";
            questao5A5.Alternativas[2] = "Aquisição e Contratos.";
            questao5A5.Alternativas[3] = "Planejamento e Organização.";
            questao5A5.Alternativas[4] = "Entrega e Suporte";

            questao5A5.Resposta = questao5A5.Alternativas[4];
            questionario.Add(questao5A5);


            QuestoesRespostas questao6A5 = new QuestoesRespostas();

            questao6A5.Questao =
                @"Em DS2 - Gerenciar Serviços Terceirizados, um programa contínuo que identifica e institucionaliza as melhores práticas indica qual nível de maturidade? ";

            questao6A5.Alternativas[0] = "Nível 1: Inicial/ Ad hoc.";
            questao6A5.Alternativas[1] = " Nível 2: Repetível, porém Intuitivo";
            questao6A5.Alternativas[2] = "Nível 3: Processo Definido";
            questao6A5.Alternativas[3] = "Nível 4: Gerenciado e Mensurável.";
            questao6A5.Alternativas[4] = "Nível 5: Otimizado";

            questao6A5.Resposta = questao6A5.Alternativas[4];
            questionario.Add(questao6A5);



            QuestoesRespostas questao7A5 = new QuestoesRespostas();

            questao7A5.Questao =
                @"O Gerente de Operações de uma empresa de TI solicitou os contratos relativos às licenças de uso do sistema gerenciador de banco de dados adotado pela empresa. 
O seu objetivo é verificar se todas as cópias instaladas do SGBD estão cobertas pelos contratos, pois caso contrário, a empresa estará sujeita às penalidades previstas em lei. 
A atividade descrita acima está relacionada a um dos objetivos de controle de um dos processos do domínio Entregar e Suportar (DS) do COBIT. Que processo é esse?";

            questao7A5.Alternativas[0] = "Gerenciar os Dados.";
            questao7A5.Alternativas[1] = "Monitorar e Avaliar os Controles Internos";
            questao7A5.Alternativas[2] = "Gerenciar a Configuração";
            questao7A5.Alternativas[3] = "Assegurar a Conformidade com Requisitos Externos.";
            questao7A5.Alternativas[4] = "Adquirir e Manter Infraestrutura de Tecnologia.";

            questao7A5.Resposta = questao7A5.Alternativas[2];
            questionario.Add(questao7A5);

            QuestoesRespostas questao8A5 = new QuestoesRespostas();

            questao8A5.Questao =
                @"Qual é o objetivo de alto nível que mantém a integridade das informações e protege os ativos de TI dentro de um processo de gestão de segurança?";

            questao8A5.Alternativas[0] = "DS5 Garantir a Segurança dos Sistemas";
            questao8A5.Alternativas[1] = "DS12 Gerenciar o Ambiente Físico.";
            questao8A5.Alternativas[2] = "PO9 Avaliar e Gerenciar os Riscos de TI PO9 Avaliar e Gerenciar os Riscos de TI";
            questao8A5.Alternativas[3] = "AI7 Instalar e Homologar Soluções e Mudanças.";
            questao8A5.Alternativas[4] = "DS4 Assegurar a Continuidade dos Serviços.";

            questao8A5.Resposta = questao8A5.Alternativas[0];
            questionario.Add(questao8A5);

            QuestoesRespostas questao9A5 = new QuestoesRespostas();

            questao9A5.Questao =
                @" Em DS2, medições que suportam a detecção de problemas potenciais com serviços de terceiros, está em com nível?";

            questao9A5.Alternativas[0] = " Nível 1: Inicial/ Ad hoc";
            questao9A5.Alternativas[1] = "Nível 2: Repetível porém Intuitivo";
            questao9A5.Alternativas[2] = "Nível 3: Processo Definido";
            questao9A5.Alternativas[3] = "Nível 4: Gerenciado e Mensurável";
            questao9A5.Alternativas[4] = "Nível 5: Otimizado";

            questao9A5.Resposta = questao9A5.Alternativas[4];
            questionario.Add(questao9A5);


            QuestoesRespostas questao10A5 = new QuestoesRespostas();

            questao10A5.Questao =
                @"Analise os seguintes processos de TI, conforme seus objetivos.
I - Gerenciar as operações - Busca manter a integridade dos dados e assegurar que a infraestrutura de TI possa resistir e se recuperar de erros e falhas, atingindo os níveis de serviço operacionais para o processamento programado de dados,
proteção das saidas de dados criticos, monitoramento e manutenção da infraestrutura.
II - Gerenciar o ambiente físico - Busca proteger os ativos de TI e os dados do negócio e minimizar o risco de interrupção nos negócios, provendo e mantendo um ambiente físico adequado que proteja os recursos de TI contra acesso um ambiente físico adequado que proteja os recursos de TI contra acesso indevido, danos ou roubo.
III - Gerenciar os dados - Busca otimizar o uso da informação e garantir que a informação esteja disponível quando requisitada com alto desempenho, de forma integrada mantendo a sua consistên integrada, mantendo a sua consistência e restringindo o seu acesso aos e restringindo o seu acesso aos administradores das bases de dados.
IV - Garantir a segurança dos sistemas - Busca manter a integridade da infraestrutura de informação e de processamento e minimizar o impacto de vulnerabilidades e incidentes de seguran vulnerabilidades e incidentes de segurança definindo políticas procedimentos e, definindo políticas, procedimentos e padrões de segurança de TI e monitorando, detectando, reportando e solucionando vulnerabilidades de segurança.
Estão de acordo com o COBIT APENAS os que se apresentam em:";

            questao10A5.Alternativas[0] = "I e II ";
            questao10A5.Alternativas[1] = "I e IV";
            questao10A5.Alternativas[2] = "II e III";
            questao10A5.Alternativas[3] = "I, II e IV";
            questao10A5.Alternativas[4] = "II,III e IV";
            questao10A5.Resposta = questao10A5.Alternativas[3];
            questionario.Add(questao10A5);

            QuestoesRespostas questao11A5 = new QuestoesRespostas();

            questao11A5.Questao =
                @"No COBIT, um dos processos do domínio Entrega e Suporte é o de assegurar conformidade com requisitos externos.";

            questao11A5.Alternativas[0] = "CERTO";
            questao11A5.Alternativas[1] = "ERRADO";
            questao11A5.Alternativas[2] = "N/A";
            questao11A5.Alternativas[3] = "N/A";
            questao11A5.Alternativas[4] = "N/A";
            questao11A5.Resposta = questao11A5.Alternativas[1];
            questionario.Add(questao11A5);

            QuestoesRespostas questao12A5 = new QuestoesRespostas();

            questao12A5.Questao =
                @"A contemplação dos aspectos de confidencialidade, integridade e disponibilidade para garantir a segurança da informação cabe ao domínio Entregar e Suportar. domínio Entregar e Suportar.";

            questao12A5.Alternativas[0] = "CERTO";
            questao12A5.Alternativas[1] = "ERRADO";
            questao12A5.Alternativas[2] = "N/A";
            questao12A5.Alternativas[3] = "N/A";
            questao12A5.Alternativas[4] = "N/A";
            questao12A5.Resposta = questao12A5.Alternativas[0];
            questionario.Add(questao12A5);

            QuestoesRespostas questao13A5 = new QuestoesRespostas();

            questao13A5.Questao =
                @"O domínio entrega e suporte abrange a entrega, o desenvolvimento e(ou) as aquisições de soluções de TI, bem como o suporte para executar a estratégia de TI estabelecida no suporte para executar a estratégia de TI estabelecida no SLA.";

            questao13A5.Alternativas[0] = "CERTO";
            questao13A5.Alternativas[1] = "ERRADO";
            questao13A5.Alternativas[2] = "N/A";
            questao13A5.Alternativas[3] = "N/A";
            questao13A5.Alternativas[4] = "N/A";
            questao13A5.Resposta = questao13A5.Alternativas[1];
            questionario.Add(questao13A5);

            QuestoesRespostas questao1A6 = new QuestoesRespostas();

            questao1A6.Questao =
                @"Quais do seguintes processos de TI satisfaz o requesito de negócio em termos de transparência e entendimento de custos, benefícios e etc.";

            questao1A6.Alternativas[0] = "ME1 Monitorar e Avaliar o Desempenho de TI";
            questao1A6.Alternativas[1] = "PO8 Gerenciar a Qualidade";
            questao1A6.Alternativas[2] = "ME3 Assegurar a Conformidade com Requisitos Externos";
            questao1A6.Alternativas[3] = "ME4 Prover Governança de TI";
            questao1A6.Alternativas[4] = "DS6 Identificar e Alocar Custos";
            questao1A6.Resposta = questao1A6.Alternativas[0];
            questionario.Add(questao1A6);

            QuestoesRespostas questao2A6 = new QuestoesRespostas();

            questao2A6.Questao =
                @"Qual processo de COBIT se concentra na gestão dos controles do processo?";

            questao2A6.Alternativas[0] = "Monitorar e Planejar";
            questao2A6.Alternativas[1] = "Monitorar e Avaliar";
            questao2A6.Alternativas[2] = "Monitorar e Organizar";
            questao2A6.Alternativas[3] = "Monitorar e Implementar";
            questao2A6.Alternativas[4] = "Monitorar e Suportar";
            questao2A6.Resposta = questao2A6.Alternativas[1];
            questionario.Add(questao2A6);

            QuestoesRespostas questao3A6 = new QuestoesRespostas();

            questao3A6.Questao =
                @" O COBIT decompõe TI em 4 domínios: Plan and Organise, Acquire and Implement, Deliver and Support e Monitor and Evaluate. 
Com relação ao domínio Monitor and Evaluate, uma pergunta que pode ser feita na autoavaliação da corporação é:";

            questao3A6.Alternativas[0] = "Os objetivos e metas de TI são claros e foram entendidos pela corporação?";
            questao3A6.Alternativas[1] = "As estratégias de TI e do negócio estão alinhadas?";
            questao3A6.Alternativas[2] = "Os sistemas funcionam corretamente após a implementação?";
            questao3A6.Alternativas[3] = "São realizadas auditorias para garantir que as áreas críticas estão operando conforme o esperado ? ";
            questao3A6.Alternativas[4] = "Os serviços de TI estão sendo entregues conforme os acordos do nível de serviço?";
            questao3A6.Resposta = questao3A6.Alternativas[3];
            questionario.Add(questao3A6);

            QuestoesRespostas questao4A6 = new QuestoesRespostas();

            questao4A6.Questao =
                @" Entre os objetivos do processo denominado Monitorar e Avaliar os Controles Internos, incluem-se a monitoração, a comparação e o 
aprimoramento continuado do ambiente e da estrutura de controles de TI, a fim de que sejam atingidos os objetivos organizacionais. ";

            questao4A6.Alternativas[0] = "CERTO";
            questao4A6.Alternativas[1] = "ERRADO";
            questao4A6.Alternativas[2] = "N/A";
            questao4A6.Alternativas[3] = "N/A";
            questao4A6.Alternativas[4] = "N/A";
            questao4A6.Resposta = questao4A6.Alternativas[0];
            questionario.Add(questao4A6);

            QuestoesRespostas questao5A6 = new QuestoesRespostas();

            questao5A6.Questao =
                @" No domínio monitorar e avaliar (monitor and evaluate), tem-se o processo monitorar e avaliar controle interno (monitor and evaluate internal control). 
Um dos objetivos do referido processo é avaliar se os provedores externos de serviços aderem aos requisitos legais e obrigações contratuais. Uma das características do nível de maturidade definido (defined) é o desenvolvimento de políticas e procedimentos para avaliar as atividades de monitoração do controle interno";

            questao5A6.Alternativas[0] = "CERTO";
            questao5A6.Alternativas[1] = "ERRADO";
            questao5A6.Alternativas[2] = "N/A";
            questao5A6.Alternativas[3] = "N/A";
            questao5A6.Alternativas[4] = "N/A";
            questao5A6.Resposta = questao5A6.Alternativas[0];
            questionario.Add(questao5A6);

            QuestoesRespostas questao6A6 = new QuestoesRespostas();

            questao6A6.Questao =
                @"Entre os 34 processos que compõem os quatro domínios do COBIT, aquele responsável por prover auditorias independentes está presente:";

            questao6A6.Alternativas[0] = "Apenas nos domínios de “Planejamento e Organização” e de “Aquisição e Implementação”.";
            questao6A6.Alternativas[1] = "Apenas nos domínios de “Planejamento e Organização” e de “Monitoramento”.";
            questao6A6.Alternativas[2] = "Apenas no domínio de “Entrega e Suporte”.";
            questao6A6.Alternativas[3] = "Apenas no domínio de “Monitoramento”.";
            questao6A6.Alternativas[4] = "Em todos os domínios.";
            questao6A6.Resposta = questao6A6.Alternativas[3];
            questionario.Add(questao6A6);


            QuestoesRespostas questao7A6 = new QuestoesRespostas();

            questao7A6.Questao = @" Analise as seguintes afirrmações relacionadas a conceitos básicos, domínios e terminologias do COBIT (Control Objectives for Information and related Technology).
I. O domínio “Planejamento e Organização” cobre estratégia e tática, e diz
respeito à identificação da maneira como TI e Segurança podem melhor
contribuir para o atendimento dos objetivos do negócio.
II. O domínio “Aquisição e Implementação” cobre a identificação, o
desenvolvimento ou aquisição, a implementação e a integração dos
processos do negócio.
III. O domínio “Entrega e Suporte” cobre a avaliação ao longo do tempo
com relação à sua qualidade e conformidade.
IV. O domínio “Monitoramento” abrange as operações tradicionais sobre
aspectos de segurança, continuidade e treinamento.
Indique a opção que contenha todas as afirmações verdadeiras: ";

            questao7A6.Alternativas[0] = "I e II";
            questao7A6.Alternativas[1] = "II e III";
            questao7A6.Alternativas[2] = "III e IV";
            questao7A6.Alternativas[3] = "I e III";
            questao7A6.Alternativas[4] = "II e IV";
            questao7A6.Resposta = questao7A6.Alternativas[0];
            questionario.Add(questao7A6);

            QuestoesRespostas questao8A6 = new QuestoesRespostas();

            questao8A6.Questao = @" Faz parte do domínio monitoramento e avaliação do COBIT o processo: ";

            questao8A6.Alternativas[0] = "Fornecer governança para a TI.";
            questao8A6.Alternativas[1] = "Garantir a continuidade dos serviços.";
            questao8A6.Alternativas[2] = "Gerenciar mudanças.";
            questao8A6.Alternativas[3] = "Gerenciar problemas.";
            questao8A6.Alternativas[4] = "Avaliar e gerenciar riscos de TI.";
            questao8A6.Resposta = questao8A6.Alternativas[0];
            questionario.Add(questao8A6);
            
            return questionario;
        }
    }
}
