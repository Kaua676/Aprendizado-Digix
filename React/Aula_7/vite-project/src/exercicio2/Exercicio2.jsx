import React from "react";

const MensagemColorida = ({ texto, cor }) => {
  return <p style={{ color: cor, fontSize: "20px" }}>{texto}</p>;
};

const App = () => {
  return (
    <>
      <MensagemColorida texto="Olá, mundo!" cor="blue" />
      <MensagemColorida texto="Mensagem vermelha" cor="red" />
      <MensagemColorida texto="Verde vibrante" cor="green" />
    </>
  );
};

export default App;
