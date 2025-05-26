import React from "react";
import "./Exercicio1.css";

const BotaoEstilizado = () => {
  return (
    <button className="botao-legal" onClick={() => alert("Botão Clicado!")}>
      Clique Aqui
    </button>
  );
};

const App = () => {
  return <BotaoEstilizado />;
};

export default App;
