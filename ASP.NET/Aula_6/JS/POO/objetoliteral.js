function Jogador(nome, idade) {
    this.nome = nome;
    this.idade = idade;
    this.fazerJogar = () => console.log("Jogando...");
    console.log(this.nome + "Chutou a bola");
}

function Time(nome, qtd) {
    this.nome = nome;
    this.qtd = qtd;
    this.jogadores = [];
    this.adicionarJogador = (jogador) => this.jogadores.push(jogador);
}

let jogador1 = new Jogador("Ronaldo", 35);
let jogador2 = new Jogador("Messi", 35);

let time1 = new Time("Brasil", 5);
let time2 = new Time("Argentina", 5);
time1.adicionarJogador(jogador1);
time1.adicionarJogador(jogador2);

function a(time1, time2) {
    if (time1.qtd > time2.qtd) {
        console.log(time1.nome + " é o melhor time");
    } else {
        console.log(time2.nome + " é o melhor time");
    }
}

compararTime = (time1, time2) => time1.qtd > time2.qtd ? console.log(time1.nome + " é o melhor time") : console.log(time2.nome + " é o melhor time");

compararTime(time1, time2);
