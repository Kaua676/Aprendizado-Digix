import React from "react";
import "./PerfilUsuario.css";

const PerfilUsuario = ({ imagem, nome, bio }) => {
  return (
    <section className="perfil-container">
      <img
        src={imagem}
        alt={`Foto de ${nome}`}
        style={{
          border: "2px solid #ccc",
          borderRadius: "50%",
          width: "200px",
          height: "200px",
          objectFit: "cover",
        }}
      />
      <h2 className="titulo-nome">{nome}</h2>
      <p className="bio">{bio}</p>
      <button
        onClick={() => alert(`Você começou a seguir ${nome}`)}
        style={{
          backgroundColor: "#4CAF50",
          color: "white",
          padding: "10px 20px",
          border: "none",
          borderRadius: "5px",
          cursor: "pointer",
          marginTop: "10px",
        }}
      >
        Seguir
      </button>
    </section>
  );
};

export default PerfilUsuario;
