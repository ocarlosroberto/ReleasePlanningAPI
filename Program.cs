var builder = WebApplication.CreateBuilder(args);

builder.Services.AddCors();

var app = builder.Build();

app.UseCors(p =>
{
    p.AllowAnyOrigin();
    p.WithMethods("GET");
    p.AllowAnyHeader();
});

app.MapGet("/", () => "Hello World!");

var capacity = new Capacity()
{
    dias_release = 61.5,
    perc_suporte = 10,
    horas_internas = 7.2,
    horas_externas = 8,
    time = new List<Pessoa>() {
       new Pessoa() { nome = "Elton", cargo = "Team Member", horas = 443, tipo = "interno" },
       new Pessoa() { nome = "Gustavo", cargo = "Team Member", horas = 443, tipo = "interno" },
       new Pessoa() { nome = "Italo", cargo = "Team Member", horas = 371, tipo = "interno" },
       new Pessoa() { nome = "James", cargo = "Team Member", horas = 385, tipo = "interno" },
       new Pessoa() { nome = "Midia", cargo = "Team Member", horas = 443, tipo = "interno" },
       new Pessoa() { nome = "Alessandra", cargo = "Team Lead", horas = 443, tipo = "interno" },
       new Pessoa() { nome = "Carlos", cargo = "Tech Lead", horas = 443, tipo = "interno" },
       new Pessoa() { nome = "Paulo", cargo = "Fabrica - UX", horas = 246, tipo = "externo" },
       new Pessoa() { nome = "Andrey", cargo = "Fabrica - TM", horas = 492, tipo = "externo" },
       new Pessoa() { nome = "Antonio", cargo = "Fabrica - TL", horas = 164, tipo = "externo" },
    }
};

var envolvimentos = new List<Envolvimento>() {
     new Envolvimento() { demanda = "Cedentes", iniciativa = "IN-2020-9017016", entrega = "EN-2021-0071861", feature = "FTR-2021-9076508", racional = "Continuação R4", descricao = "ações de modernização da ferramenta cockpit que utilização o B4 passarem a utilizar o EP9", tipo_envolvimento = "Refinamento", horas = 100 },
     new Envolvimento() { demanda = "Cedentes", iniciativa = "IN-2020-9017016", entrega = "EN-2021-0071897", feature = "FTR-2021-9076508", racional = "Continuação R4", descricao = "Fluxo de Inclusão - Varejo + Atacado", tipo_envolvimento = "Refinamento", horas = 100 },
     new Envolvimento() { demanda = "Cedentes", iniciativa = "IN-2020-9017016", entrega = "EN-2021-0071966", feature = "FTR-2021-9076547", racional = "Continuação R4", descricao = "IBBA - fluxo de alteração", tipo_envolvimento = "Execução + Teste", horas = 200 },
     new Envolvimento() { demanda = "Cedentes", iniciativa = "IN-2020-9017016", entrega = "EN-2021-0072202", feature = "FTR-2021-9076587", racional = "Continuação R4", descricao = "Ajustes no BFF e gateway para contemplar o fluxo de inclusão do Cedentes", tipo_envolvimento = "Execução + Teste", horas = 80 },
     new Envolvimento() { demanda = "Cedentes", iniciativa = "IN-2020-9017016", entrega = "EN-2021-0072386", feature = "FTR-2021-9076668", racional = "Continuação R4", descricao = "gestão de acesso aos modulos do cockpit", tipo_envolvimento = "Execução + Teste", horas = 200 },
     new Envolvimento() { demanda = "Cedentes", iniciativa = "IN-2020-9017016", entrega = "EN-2021-0072432", feature = "FTR-2021-9076686", racional = "Continuação R4", descricao = "contemplando desenvolvimento, testes, homologação e testes e2e", tipo_envolvimento = "Execução + Teste", horas = 100 },
     new Envolvimento() { demanda = "Cedentes", iniciativa = "IN-2020-9017016", entrega = "EN-2021-0072485", feature = "FTR-2021-9076698", racional = "Continuação R4", descricao = "Ajustes no BFF e gateway para contemplar os campos definidos posteriormente", tipo_envolvimento = "Execução + Teste", horas = 80 },
     new Envolvimento() { demanda = "SISPAG", iniciativa = "IN-2020-9017108", entrega = "EN-2021-0076771 ", feature = "FTR-2021-9070938", racional = "Continuação R4", descricao = "Modernização - Contratação SISPAG – Consulta ,  Alteração e Inclusão", tipo_envolvimento = "Execução + Teste", horas = 500 },
     new Envolvimento() { demanda = "Sinergia Rede", iniciativa = "IN-2021-9001451", entrega = "EN-2021-0069397", feature = "", racional = "Demanda emergencial", descricao = "EPI-2021-9013704 - Habilitar CPF na Contratação Cash Inception para habilitar na contratação cash os produtos aplic aut e IEI alinhamento efetuado com a Alessandra Guedes", tipo_envolvimento = "Refinamento", horas = 60 },
     new Envolvimento() { demanda = "Sinergia Rede", iniciativa = "IN-2021-9005460", entrega = "EN-2021-0078449", feature = "", racional = "Demanda emergencial", descricao = "Abertura de solicitações em lote na visão grupo. Cadastrar ou equiparar na visão grupo em único acesso para todos os produtos.", tipo_envolvimento = "Refinamento", horas = 40 },
     new Envolvimento() { demanda = "Sinergia Rede", iniciativa = "IN-2021-9005460", entrega = "EN-2021-0078572", feature = "FTR-2021-9078288", racional = "Demanda emergencial", descricao = "Ao solicitar uma demanda e finalizá-la dar a opção do solicitante reaproveitar os dados principais para solicitação de mais produtos - Front", tipo_envolvimento = "Execução + Teste", horas = 300 },
     new Envolvimento() { demanda = "Sinergia Rede", iniciativa = "IN-2021-9005460", entrega = "EN-2021-0078564", feature = "FTR-2021-9072020", racional = "Demanda emergencial", descricao = "Sinergia Rede - Atualização em todos os produtos o módulo unico de produtos", tipo_envolvimento = "Execução + Teste", horas = 150 },
     new Envolvimento() { demanda = "Sinergia Rede", iniciativa = "IN-2021-9005460", entrega = "EN-2021-0078555", feature = "FTR-2021-9078281", racional = "Demanda emergencial", descricao = "Campos integrados ao Sistema - Ao efetuar a solicitações, digitar AG e Cta e os demais dados como por ex CNPJ já carregar integrados ao sistema - carregar a funcional de quem está pedindo e quando o officer cash solicitar não ter mais a obrigatoriedade de solicitar a funcional do AC.", tipo_envolvimento = "Execução + Teste", horas = 100 },
     new Envolvimento() { demanda = "TIM", iniciativa = "IN-2020-9017016", entrega = "EN-2021-0071926", feature = "FTR-2021-9076508", racional = "Planejada R1", descricao = "Interface do TIM na central de de implantação Cash", tipo_envolvimento = "Refinamento", horas = 100 },
     new Envolvimento() { demanda = "BaaS", iniciativa = "IN-2021-9009528", entrega = "EN-2021-0075095", feature = "FTR-2021-9077392", racional = "Planejada R1", descricao = "Parametrização da AWS pensando no portal de atendimento que está sendo construído para a ,iniciativa do BaaS / IaaS", tipo_envolvimento = "Execução + Teste", horas = 500 },
     new Envolvimento() { demanda = "BaaS", iniciativa = "IN-2021-9009528", entrega = "EN-2021-0075118", feature = "FTR-2021-9077406", racional = "Planejada R1", descricao = "Construção da tela de consulta de cadastro da plataforma de atendimento para o BaaS / IaaS", tipo_envolvimento = "Execução + Teste", horas = 400 },
     new Envolvimento() { demanda = "BaaS", iniciativa = "IN-2021-9009528", entrega = "EN-2021-0075153", feature = "FTR-2021-9077413", racional = "Planejada R1", descricao = "Construção da timeline com PIX e TED/TEF para a plataforma de atendimento IaaS", tipo_envolvimento = "Execução + Teste", horas = 500 },
     new Envolvimento() { demanda = "PIX Conta Certa", iniciativa = "IN-2021-9005977", entrega = "EN-2021-0074514", feature = "FTR-2021-9077249", racional = "Planejada R1", descricao = "Mostrar o que o cliente tem de negociação para o comercial. Customer disponibilizar um serviço com as informações de negociação do cliente.", tipo_envolvimento = "Refinamento", horas = 40 },
     new Envolvimento() { demanda = "PIX Recebidos", iniciativa = "IN-2019-9009298", entrega = "EN-2021-0077421", feature = "", racional = "Planejada R1", descricao = "Melhorias Consultas PIX recebidos (qrcode e transferências) nos canais Internos (PRC / Painel de serviço / Cockpit)", tipo_envolvimento = "Refinamento", horas = 40 },
     new Envolvimento() { demanda = "Bacen 74", iniciativa = "", entrega = "", feature = "", racional = "Planejada R1", descricao = "Feature dedicada para abertura de chamados e utilização da ferramenta BP4 para o portal de atendimento do BaaS / IaaS", tipo_envolvimento = "Acompanhamento", horas = 80 },
     new Envolvimento() { demanda = "BaaS", iniciativa = "IN-2021-9009528", entrega = "EN-2021-0075187", feature = "FTR-2021-9077426", racional = "Planejada R1", descricao = "Feature dedicada para abertura de chamados e utilização da ferramenta BP4 para o portal de atendimento do BaaS / IaaS", tipo_envolvimento = "Execução + Teste", horas = 400 },
     new Envolvimento() { demanda = "BaaS", iniciativa = "IN-2021-9009528", entrega = "EN-2021-0075234", feature = "FTR-2021-9077434", racional = "Planejada R1", descricao = "Gestão de acessos para a plataforma do BaaS / IaaS", tipo_envolvimento = "Execução + Teste", horas = 300 },
     new Envolvimento() { demanda = "Prova de Vida", iniciativa = "IN-2021-9004219", entrega = "EN-2021-0067536", feature = "FTR-2021-9075120", racional = "Planejada R1", descricao = "No cockpit deverá ter um botão de consulta de prova de vida e um de consulta de vinculação/desvinculação para atender ao pedido do beneficiário", tipo_envolvimento = "Execução + Teste", horas = 250 },
     new Envolvimento() { demanda = "Prova de Vida", iniciativa = "IN-2021-9004219", entrega = "EN-2021-0067553", feature = "FTR-2021-9075135", racional = "Planejada R1", descricao = "Implementação das infraestrutura da AWS para os ambientes do microfrontend, bff e gateway .", tipo_envolvimento = "Execução + Teste", horas = 150 },
};

app.MapGet("/capacity", () => { return capacity; });
app.MapGet("/envolvimentos", () => { return envolvimentos; });
app.Run();

