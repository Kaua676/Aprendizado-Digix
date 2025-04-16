// URL base da sua API para Maquinas
const urlMaquina = "http://localhost:5000/Maquina";
// Se estiver rodando em outra porta, ajuste ex: "http://localhost:5001/Maquina"

document.getElementById("maquinaForm").addEventListener("submit", salvarMaquina);

// Carrega a lista ao abrir a página
carregarMaquinas();

function carregarMaquinas() {
  fetch(urlMaquina)
    .then(response => response.json())
    .then(maquinas => {
      const tbody = document.querySelector("#tabelaMaquinas tbody");
      if (!tbody) return;

      tbody.innerHTML = ""; // Limpa o conteúdo

      maquinas.forEach(m => {
        tbody.innerHTML += `
          <tr>
            <td>${m.maquinaId}</td>
            <td>${m.tipo}</td>
            <td>${m.velocidade}</td>
            <td>${m.hardDisk}</td>
            <td>${m.placaRede}</td>
            <td>${m.memoriaRam}</td>
            <td>${m.id_Usuario}</td>
            <td>
              <button onclick="editarMaquina(${m.maquinaId})">Editar</button>
              <button onclick="excluirMaquina(${m.maquinaId})">Excluir</button>
            </td>
          </tr>
        `;
      });
    })
    .catch(error => console.error("Erro ao carregar máquinas:", error));
}

function salvarMaquina(event) {
  event.preventDefault();

  // Pegar os valores dos campos
  const maquinaId = document.getElementById("maquinaId").value;
  const tipo = document.getElementById("tipo").value;
  const velocidade = parseInt(document.getElementById("velocidade").value);
  const hardDisk = parseInt(document.getElementById("hardDisk").value);
  const placaRede = parseInt(document.getElementById("placaRede").value);
  const memoriaRam = parseInt(document.getElementById("memoriaRam").value);
  const id_Usuario = parseInt(document.getElementById("idUsuario").value);

  // Montar objeto com as propriedades que o C# espera
  // (cuidado com maiúsculas e minúsculas)
  const maquina = {
    maquinaId: maquinaId ? parseInt(maquinaId) : 0, // você pode ignorar se a API não exige
    tipo,
    velocidade,
    hardDisk,
    placaRede,
    memoriaRam,
    id_UsuarioF
  };

  // Decide se é POST ou PUT
  const metodo = maquinaId ? "PUT" : "POST";
  const url = maquinaId ? `${urlMaquina}/${maquinaId}` : urlMaquina;

  fetch(url, {
    method: metodo,
    headers: { "Content-Type": "application/json" },
    body: JSON.stringify(maquina)
  })
    .then(response => {
      if (!response.ok) throw new Error("Falha ao salvar máquina");
      return response.json();
    })
    .then(() => {
      // Limpa o form e recarrega a tabela
      document.getElementById("maquinaForm").reset();
      carregarMaquinas();
    })
    .catch(error => console.error(error));
}

function editarMaquina(id) {
  // Buscar a máquina pelo ID
  fetch(`${urlMaquina}/${id}`)
    .then(response => {
      if (!response.ok) throw new Error("Não foi possível obter a máquina");
      return response.json();
    })
    .then(maquina => {
      // Preenche o formulário
      document.getElementById("maquinaId").value = maquina.maquinaId;
      document.getElementById("tipo").value = maquina.tipo;
      document.getElementById("velocidade").value = maquina.velocidade;
      document.getElementById("hardDisk").value = maquina.hardDisk;
      document.getElementById("placaRede").value = maquina.placaRede;
      document.getElementById("memoriaRam").value = maquina.memoriaRam;
      document.getElementById("idUsuario").value = maquina.id_Usuario;
    })
    .catch(error => console.error("Erro ao buscar máquina:", error));
}

function excluirMaquina(id) {
  if (!confirm("Tem certeza que deseja excluir esta máquina?")) return;

  fetch(`${urlMaquina}/${id}`, { method: "DELETE" })
    .then(response => {
      if (!response.ok) throw new Error("Falha ao excluir máquina");
      carregarMaquinas();
    })
    .catch(error => console.error(error));
}
