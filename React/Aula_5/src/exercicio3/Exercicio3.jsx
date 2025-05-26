import React from "react";

const JSXExemplo = () => {
  return (
    <>
      <h1>Olá React!</h1>
      <p className="paragrafo">
        Lorem ipsum dolor sit amet consectetur adipisicing elit. Animi, pariatur
        recusandae fuga culpa odit cum obcaecati, maxime amet, explicabo eveniet
        eligendi mollitia veritatis officiis dolorem enim ad corporis harum
        ratione!
      </p>
      {/* Isso é um comentário */}
    </>
  );
};

const App = () => {
  return <JSXExemplo />;
};

export default App;
