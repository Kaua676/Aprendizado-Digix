import { writeFile } from 'fs';

const produto = {
    nome: "Notebook",
    preco: 4999.99,
    desconto: 0.15
}

writeFile("produto.json", JSON.stringify(produto), err => {
    console.log(err || "Arquivo salvo!");
});
