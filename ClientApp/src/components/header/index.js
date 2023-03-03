import { faBars, faShoppingBasket } from "@fortawesome/free-solid-svg-icons";
import { FontAwesomeIcon } from "@fortawesome/react-fontawesome";
import React from "react";

const Header = () => {
  return (
    <header className="header">
      <a href="/" className="logo">
        <i>
          <FontAwesomeIcon icon={faShoppingBasket} />
        </i>
      </a>
      <div className="icons">
        <button id="menu-btn">
          <FontAwesomeIcon className="fa-icon" icon={faBars} />
        </button>
        <button id="search-btn">
          <FontAwesomeIcon className="fa-icon" icon={faBars} />
        </button>
        <button id="cart-btn">
          <FontAwesomeIcon className="fa-icon" icon={faBars} />
        </button>
        <button id="user-btn">
          <FontAwesomeIcon className="fa-icon" icon={faBars} />
        </button>
      </div>
    </header>
  );
};

export default Header;
