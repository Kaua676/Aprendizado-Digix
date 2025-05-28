import { useState, useEffect, useRef } from "react";

// Exercícios
import Contador from "./exercicios/Exercicio1_Contador/Contador.jsx";
import MensagemInicial from "./exercicios/Exercicio2_Mensagem/MensagemInicial.jsx";
import InputAutoFocus from "./exercicios/Exercicio3_Input/InputAutoFocus.jsx";
import Produtos from "./exercicios/Exercicio4_Produtos/Produtos.jsx";
import Welcome from "./exercicios/Exercicio5_Theme/Welcome.jsx";
import ThemeButton from "./exercicios/Exercicio5_Theme/ThemeButton.jsx";

function App() {
  const [exercicio, setExercicio] = useState("");
  const [dados, setDados] = useState(null);
  const [loading, setLoading] = useState(false);

  // Tema
  const [theme, setTheme] = useState("light");
  const [name, setName] = useState("");
  const inputRef = useRef();

  useEffect(() => {
    document.body.style.background = theme === "light" ? "#fff" : "#222";
    document.body.style.color = theme === "light" ? "#000" : "#fff";
  }, [theme]);

  useEffect(() => {
    if (exercicio === "tema" && inputRef.current) {
      inputRef.current.focus();
    }
  }, [exercicio]);

  async function handleProdutoClick(nomeProduto) {
    setLoading(true);
    const response = await fetch(
      `https://ranekapi.origamid.dev/json/api/produto/${nomeProduto}`
    );
    const json = await response.json();
    setDados(json);
    setLoading(false);
  }

  function renderExercicio() {
    switch (exercicio) {
      case "contador":
        return <Contador />;
      case "mensagem":
        return <MensagemInicial />;
      case "input":
        return <InputAutoFocus />;
      case "produtos":
        return (
          <>
            <button onClick={() => handleProdutoClick("Notebook")}>
              Notebook
            </button>
            <button onClick={() => handleProdutoClick("Smartphone")}>
              Smartphone
            </button>
            <button onClick={() => handleProdutoClick("Tablet")}>Tablet</button>
            {loading && <p>Carregando...</p>}
            {!loading && dados && <Produtos dados={dados} />}
          </>
        );
      case "tema":
        return (
          <>
            <input
              ref={inputRef}
              type="text"
              placeholder="Digite seu nome"
              value={name}
              onChange={(e) => setName(e.target.value)}
            />
            <Welcome userName={name} />
            <ThemeButton theme={theme} setTheme={setTheme} />
          </>
        );
      default:
        return <p>Escolha um exercício acima.</p>;
    }
  }

  return (
    <div style={{ padding: "2rem" }}>
      <h1>Exercícios React</h1>
      <nav style={{ marginBottom: "1rem" }}>
        <button onClick={() => setExercicio("contador")}>Contador</button>
        <button onClick={() => setExercicio("mensagem")}>Mensagem</button>
        <button onClick={() => setExercicio("input")}>AutoFocus</button>
        <button onClick={() => setExercicio("produtos")}>Produtos</button>
        <button onClick={() => setExercicio("tema")}>Tema</button>
      </nav>
      <hr />
      <section style={{ marginTop: "1rem" }}>{renderExercicio()}</section>
    </div>
  );
}

export default App;
