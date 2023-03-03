import React from "react";
import { FontAwesomeIcon } from "@fortawesome/react-fontawesome";
import { faStar, faStarHalfAlt } from "@fortawesome/free-solid-svg-icons";
import "./products.css";

const Products = ({ products }) => {
  return (
    <section className="products">
      <h1 className="heading">
        Our <span>Products</span>
      </h1>
      <div className="box-container">
        {products.map((product) => {
          return (
            <div className="swiper-wrapper">
              <div className="box">
                <h3>{product.name}</h3>
                <div className="price">{product.price}</div>
                <div className="stars">
                  <FontAwesomeIcon icon={faStar} />
                  <FontAwesomeIcon icon={faStar} />
                  <FontAwesomeIcon icon={faStar} />
                  <FontAwesomeIcon icon={faStarHalfAlt} />
                </div>
                <button className="btn">Add to Cart</button>
              </div>
            </div>
          );
        })}
      </div>
    </section>
  );
};

export default Products;
