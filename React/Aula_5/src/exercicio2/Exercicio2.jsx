import React from "react";

// Uso de parametros destruturado
const Soma1 = ({ numero1, numero2 }) => {
  const resultado = numero1 + numero2;
  return <p>A soma é: {resultado}</p>;
};

// Ou

// Uso de props
const Soma2 = (props) => {
  const resultado = props.numero1 + props.numero2;
  return <p>A soma é: {resultado}</p>;
};

const App = () => {
  return (
    <div>
      <h2>Primeira forma</h2>
      <Soma1 numero1={5} numero2={3} />
      <Soma1 numero1={10} numero2={20} />
      <Soma1 numero1={7} numero2={2} />

      <h2>Segunda forma</h2>
      <Soma2 numero1={40} numero2={3} />
      <Soma2 numero1={30} numero2={20} />
      <Soma2 numero1={81} numero2={2} />
    </div>
  );
};

export default App;
