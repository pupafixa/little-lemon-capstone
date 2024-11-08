import React, { useState } from "react";
import logo from '../Assets/images/logo.png';

const Nav = () => {
  const [menuOpen, setMenuOpen] = useState(false); // Default state is `false`

  const toggleMenu = () => {
    setMenuOpen(!menuOpen); // Toggle menuOpen state
  };

  return (
    <nav className="navbar">
      <a href="/" className="logo">
        <img className="logo" src={logo} alt="Logo" />
      </a>

      {/* Mobile Navbar */}
      <div className="menu-icon" onClick={toggleMenu}>
        <div className="bar"></div>
        <div className="bar"></div>
        <div className="bar"></div>
      </div>

      <ul className={`nav-links ${menuOpen ? "open" : ""}`}>
        <li><a href="/">Home</a></li>
        <li><a href="/">About</a></li>
        <li><a href="/">Services</a></li>
        <li><a href="/">Menu</a></li>
        <li><a href="/">Reservations</a></li>
        <li><a href="/booking">Order Online</a></li>
        <li><a href="/">Login</a></li>
      </ul>
    </nav>
  );
};

export default Nav;





