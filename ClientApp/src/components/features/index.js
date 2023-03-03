import React from "react";
import "./features.css";

const Features = ({ features }) => {
  return (
    <section className="features">
      <h1 className="heading">
        Our <span>Features</span>
      </h1>
      <div className="box-container">
        {features.map((feature) => {
          return (
            <div className="box">
              <h3>{feature.name}</h3>
              <div>{feature.description}</div>
              <button type="button" className="btn">
                Read More
              </button>
            </div>
          );
        })}
      </div>
    </section>
  );
};

export default Features;
