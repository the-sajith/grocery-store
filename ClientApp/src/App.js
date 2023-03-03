import "./App.css";
import Products from "./components/products";
import Categories from "./components/categories";
import Features from "./components/features";
import Header from "./components/header";
import Footer from "./components/footer";
import Banner from "./components/banner";
import { useEffect, useState } from "react";

function App() {
  const [products, setProducts] = useState([]);
  const [categories, setCategories] = useState([]);
  const [features, setFeatures] = useState([]);

  useEffect(() => {
    const getProducts = async () => {
      const productsFromServer = await fetchProducts();
      setProducts(productsFromServer);
    };

    const getCategories = async () => {
      const categoriesFromServer = await fetch(
        `${process.env.REACT_APP_API_URL}/categories`
      );
      const categoryData = await categoriesFromServer.json();
      setCategories(categoryData);
    };

    const getFeatures = async () => {
      const featuresFromServer = await fetch(
        `${process.env.REACT_APP_API_URL}/features`
      );

      const featureData = await featuresFromServer.json();

      setFeatures(featureData);
    };

    getProducts();
    getCategories();
    getFeatures();
  }, []);

  const fetchProducts = async () => {
    const res = await fetch(`${process.env.REACT_APP_API_URL}/products`);
    const data = await res.json();

    return data;
  };

  return (
    <div className="App">
      <Header />
      <Banner />
      <Features features={features} />
      <Products products={products} />
      <Categories categories={categories} />
      <Footer />
    </div>
  );
}

export default App;
