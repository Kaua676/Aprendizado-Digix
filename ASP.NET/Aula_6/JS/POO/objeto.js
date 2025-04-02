let carro = {
    marca: "Fiat",
    modelo: "Uno",
    cor: "Vermelho",
    ano: 2022,
    PaisDeOrigem: {
        pais: "Brasil",
        estado: "São Paulo"
    },
    ligar: () => console.log("Ligando o carro...")
}

console.table(carro.ligar());

carro.marca = "Honda";
console.table(carro);

delete carro.ano;
console.table(carro);