import Animal from "./animal.js";

export class Cobra extends Animal {
    static venenosa = true;

    constructor(nome, cor, peso, idade) {
        super(nome, cor, peso, idade);
    }

    procriar() {
        console.log("Procriando...");
        console.log("1...");
        console.log("2...");
        console.log("3...");
        console.log("Procriou guri!🚀...");
    }
}