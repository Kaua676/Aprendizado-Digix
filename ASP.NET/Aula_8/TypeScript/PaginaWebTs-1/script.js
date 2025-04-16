function saudarTratado() {
    const saudacaoElement = document.getElementById('nome');
    if (saudacaoElement && saudacaoElement instanceof HTMLInputElement) {
        const nome = saudacaoElement.value.trim();
        if (nome === "") {
            alert("Por favor, digite seu nome.");
        } else {
            alert(`Ola ${nome}`);
        }
    } else {
        console.alert("Elemento com id 'nome' não encontrado.");
    }
}
