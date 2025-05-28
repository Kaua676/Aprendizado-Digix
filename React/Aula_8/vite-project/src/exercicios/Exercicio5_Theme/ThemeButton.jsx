function ThemeButton({ theme, setTheme }) {
  const toggleTheme = () => {
    setTheme((prev) => (prev === "light" ? "dark" : "light"));
  };

  return (
    <button style={{ marginTop: "1rem" }} onClick={toggleTheme}>
      Mudar para tema {theme === "light" ? "escuro" : "claro"}
    </button>
  );
}

export default ThemeButton;
