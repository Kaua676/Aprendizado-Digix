function Produtos({ dados }) {
  return (
    <div>
      <h2>{dados.nome}</h2>
      <p>{dados.preco}</p>
      <img src={dados.fotos[0].src} alt={dados.nome} width="200" />
    </div>
  );
}

export default Produtos;
