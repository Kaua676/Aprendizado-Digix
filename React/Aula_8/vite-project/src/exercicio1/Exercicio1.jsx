import React, { useState } from "react";

function Contador() {
  const [contador, setContador] = useState(0);

  return (
    <div style={{ textAlign: "center", fontFamily: "Arial" }}>
      <h1>Contador: {contador}</h1>
      <button onClick={() => setContador(contador + 1)}>Incrementar</button>
      <button onClick={() => setContador(0)} style={{ marginLeft: "10px" }}>
        Zerar
      </button>
    </div>
  );
}

export default Contador;
