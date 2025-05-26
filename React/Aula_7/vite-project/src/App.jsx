// App.jsx
import BotaoEstilizado from "./exercicio1/Exercicio1.jsx";
import MensagemColorida from "./exercicio2/Exercicio2.jsx";
import SecaoSobre from "./exercicio3/Exercicio3.jsx";
import Form from "./exemplos/Form/Form.jsx";
import Header from "./exemplos/Desafio/Header.jsx";
import Home from "./exemplos/Desafio/Home.jsx";
import Produtos from "./exemplos/Desafio/Produtos.jsx";
import PaginaUser from "./Desafio/PaginaUser.jsx";

function App() {
  const { pathname } = window.location;
  let Pagina;

  if (pathname === "/produtos") {
    Pagina = Produtos;
  } else {
    Pagina = Home;
  }

  return (
    <>
      <BotaoEstilizado />
      <MensagemColorida />
      <SecaoSobre />
      <Form />
      <Header />
      <Pagina />
      <PaginaUser />
    </>
  );
}

export default App;
