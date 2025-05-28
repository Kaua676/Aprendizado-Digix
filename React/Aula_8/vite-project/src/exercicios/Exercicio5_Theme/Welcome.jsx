function Welcome({ userName }) {
  return (
    <h2>
      {userName ? `Olá, ${userName}! 👋` : "Digite seu nome para continuar."}
    </h2>
  );
}

export default Welcome;
