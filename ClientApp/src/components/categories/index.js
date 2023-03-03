import { faStar, faStarHalfAlt } from "@fortawesome/free-solid-svg-icons";
import { FontAwesomeIcon } from "@fortawesome/react-fontawesome";
import React from "react";
import "./categories.css";

const categories = ({ categories }) => {
  // categories.map((category) => {
  //   console.log(category);
  return (
    <section name="categories">
      <h1 className="heading">
        {" "}
        Products <span>Categories</span>
      </h1>
      <div className="box-container">
        {categories.map((category) => {
          return (
            <div className="swiper-wrapper">
              <div className="box">
                <h3>{category.type}</h3>
                <div className="price">{category.discount}</div>
                <button type="button" className="btn">
                  shop now
                </button>
              </div>
            </div>
          );
        })}
      </div>
    </section>
  );
  //
};

export default categories;
