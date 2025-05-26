import React from "react";
import PerfilUsuario from "./PerfilUsuario";

const PaginaUser = () => {
  return (
    <main>
      <PerfilUsuario
        imagem="https://upload.wikimedia.org/wikipedia/pt/b/b4/Corinthians_simbolo.png"
        nome="Vai Curintia"
        bio="Lorem ipsum dolor sit, amet consectetur adipisicing elit. Facere voluptatum nemo illum? Nam mollitia libero quisquam nisi quaerat at eveniet, alias temporibus est illo, ipsam accusantium ut repellat maxime enim!"
      />
    </main>
  );
};

export default PaginaUser;