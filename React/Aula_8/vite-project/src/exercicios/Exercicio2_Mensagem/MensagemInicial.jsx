import { useEffect } from "react";

function MensagemInicial() {
  useEffect(() => {
    console.log("Componente montado!");
  }, []);

  return <p>Bem-vindo ao sistema!</p>;
}

export default MensagemInicial;
