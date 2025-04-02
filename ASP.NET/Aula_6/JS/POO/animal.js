export default class Animal {
    constructor(nome, raca, peso, idade) {
        this.nome = nome;
        this.raca = raca;
        this.peso = peso;
        this.idade = idade;
    }

    getNome() {
        return this.nome;
    }

    getRaca() {
        return this.raca;
    }

    getPeso() {
        return this.peso;
    }

    getIdade() {
        return this.idade;
    }

    setNome(nome) {
        this.nome = nome;
    }

    setRaca(raca) {
        this.raca = raca;
    }

    setPeso(peso) {
        this.peso = peso;
    }

    setIdade(idade) {
        this.idade = idade;
    }

    fazerSom() {
        console.log("Som");
    }

    comer() {
        console.log("Comendo...");
    }

    procriar() {
        console.log("Procriando...");
        console.log("1...");
        console.log("2...");
        console.log("3...");
        console.log("Procriou guri!🚀...");
    }

}