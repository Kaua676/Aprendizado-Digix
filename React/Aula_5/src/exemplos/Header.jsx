import React from "react";

const Header = () => {
  return (
    <>
      <header className="header">
        <img className="img-logo" src="" alt="" />
        <nav className="nav-bar">
          <ul>
            <li>
              <a href="">Sobre</a>
              <a href="">Home</a>
              <a href="">Contato</a>
              <a className="login-btn" href="">
                Login
              </a>
            </li>
          </ul>
        </nav>
      </header>
    </>
  );
};

export default Header;
