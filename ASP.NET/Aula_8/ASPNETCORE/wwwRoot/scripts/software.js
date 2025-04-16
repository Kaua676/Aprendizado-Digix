// Ajuste para a URL da sua API
// Se estiver em outra porta ou caminho, mude aqui.
const urlSoftware = "http://localhost:5000/Software";

// Vincular o evento de submit do form
document.getElementById("softwareForm").addEventListener("submit", salvarSoftware);

// Ao abrir a página, carrega tudo
carregarSoftwares();

function carregarSoftwares() {
    fetch(urlSoftware)
        .then(response => response.json())
        .then(softwares => {
            const tbody = document.querySelector("#tabelaSoftwares tbody");
            if (!tbody) return;
            tbody.innerHTML = "";

            softwares.forEach(s => {
                tbody.innerHTML += `
          <tr>
            <td>${s.softwareId}</td>
            <td>${s.produto}</td>
            <td>${s.hardDisk}</td>
            <td>${s.memoriaRam}</td>
            <td>${s.maquinaId}</td>
            <td>
              <button onclick="editarSoftware(${s.softwareId})">Editar</button>
              <button onclick="excluirSoftware(${s.softwareId})">Excluir</button>
            </td>
          </tr>
        `;
            });
        })
        .catch(error => console.error("Erro ao carregar softwares:", error));
}

function salvarSoftware(event) {
    event.preventDefault();

    const softwareId = document.getElementById("softwareId").value;
    const produto = document.getElementById("produto").value;
    const hardDisk = parseInt(document.getElementById("hardDisk").value);
    const memoriaRam = parseInt(document.getElementById("memoriaRam").value);
    const maquinaId = parseInt(document.getElementById("maquinaId").value);

    // Monta objeto conforme seu Model
    const software = {
        softwareId: softwareId ? parseInt(softwareId) : 0,
        produto,
        hardDisk,
        memoriaRam,
        maquinaId
    };

    // Decide se é CREATE (POST) ou UPDATE (PUT)
    const metodo = softwareId ? "PUT" : "POST";
    const url = softwareId ? `${urlSoftware}/${softwareId}` : urlSoftware;

    fetch(url, {
        method: metodo,
        headers: { "Content-Type": "application/json" },
        body: JSON.stringify(software)
    })
        .then(response => {
            if (!response.ok) throw new Error("Erro ao salvar software");
            return response.json();
        })
        .then(() => {
            document.getElementById("softwareForm").reset();
            carregarSoftwares();
        })
        .catch(error => console.error(error));
}

function editarSoftware(id) {
    // Precisamos do endpoint GET /Software/{id} para puxar um software específico
    fetch(`${urlSoftware}/${id}`)
        .then(response => {
            if (!response.ok) throw new Error("Erro ao buscar software");
            return response.json();
        })
        .then(s => {
            // Preenche o formulário
            document.getElementById("softwareId").value = s.softwareId;
            document.getElementById("produto").value = s.produto;
            document.getElementById("hardDisk").value = s.hardDisk;
            document.getElementById("memoriaRam").value = s.memoriaRam;
            document.getElementById("maquinaId").value = s.maquinaId;
        })
        .catch(error => console.error(error));
}

function excluirSoftware(id) {
    if (!confirm("Tem certeza que deseja excluir este software?")) return;

    fetch(`${urlSoftware}/${id}`, { method: "DELETE" })
        .then(response => {
            if (!response.ok) throw new Error("Erro ao excluir software");
            carregarSoftwares();
        })
        .catch(error => console.error(error));
}
