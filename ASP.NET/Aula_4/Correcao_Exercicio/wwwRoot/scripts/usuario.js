const url = "http://localhost:5000/Usuario";

document.getElementById("usuarioForm").addEventListener("submit", SalvarUsuario);
CarregarUsuarios();

function CarregarUsuarios() {
    fetch(url)
        .then(response => response.json())
        .then(data => {
            const tbody = document.querySelector("#tabelaUsuarios tbody");
            if (!tbody) return;

            tbody.innerHTML = "";
            data.forEach(usuario => {
                tbody.innerHTML += `
                    <tr>
                        <td>${usuario.id}</td>
                        <td>${usuario.nome}</td>
                        <td>${usuario.ramal}</td>
                        <td>${usuario.especialidade}</td>
                        <td>
                            <button class="edit" onclick="EditarUsuario(${usuario.id})">Editar</button>
                            <button class="delete" onclick="ExcluirUsuario(${usuario.id})">Deletar</button>
                        </td>
                    </tr>
                `;
            });
        })
        .catch(error => console.error("Erro ao carregar usuários:", error));
}

function SalvarUsuario(event) {
    event.preventDefault();

    const id = document.getElementById("id").value;
    const nome = document.getElementById("nome").value;
    const senha = document.getElementById("senha").value;
    const ramal = document.getElementById("ramal").value;
    const especialidade = document.getElementById("especialidade").value;

    const usuario = { nome, senha, ramal, especialidade };

    const metodo = id ? "PUT" : "POST";
    const urlFinal = id ? `${url}/${id}` : url;

    fetch(urlFinal, {
        method: metodo,
        headers: { "Content-Type": "application/json" },
        body: JSON.stringify(usuario)
    })
        .then(response => response.json())
        .then(() => {
            document.getElementById("usuarioForm").reset();
            CarregarUsuarios();
        })
        .catch(error => console.error("Erro ao salvar usuário:", error));
}

function EditarUsuario(id) {
    fetch(`${url}/${id}`)
        .then(response => response.json())
        .then(usuario => {
            document.getElementById("id").value = usuario.id;
            document.getElementById("nome").value = usuario.nome;
            document.getElementById("senha").value = usuario.senha;         // se quiser preencher
            document.getElementById("ramal").value = usuario.ramal;
            document.getElementById("especialidade").value = usuario.especialidade;
        })
        .catch(error => console.error("Erro ao carregar usuário:", error));
}

function ExcluirUsuario(id) {
    if (!confirm("Tem certeza que deseja excluir este usuário?")) return;

    fetch(`${url}/${id}`, { method: "DELETE" })
        .then(() => CarregarUsuarios())
        .catch(error => console.error("Erro ao excluir usuário:", error));
}