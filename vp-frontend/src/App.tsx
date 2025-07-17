import { useEffect, useState } from "react";
import "./App.css";
import type { Product } from "./product";

// al jullie collega's gaan dit lelijk vinden. structuur++ graag!

function App() {
  const [name, setName] = useState("JP");
  const [products, setProducts] = useState([] as Product[]);
  const addProduct = () => {
    const newProduct: Product = {
      id: Math.max(...products.map((p) => p.id), 0) + 1,
      description: "New Product",
      price: 10,
    };
    // send to backend

    fetch("http://localhost:3000/products", {
      method: "POST",
      headers: {
        "Content-Type": "application/json",
      },
      body: JSON.stringify(newProduct),
    })
      .then((response) => response.json())
      .then((data) => {
        setProducts([...products, data]);
      })
      .catch((error) => {
        console.error("Error adding product:", error);
      });

    // setProducts([...products, newProduct]);
  };

  // retrieve products from database using fetch
  useEffect(() => {
    fetch("http://localhost:3000/products")
      .then((response) => response.json())
      .then((data) => {
        setProducts(data);
      })
      .catch((error) => {
        console.error("Error fetching products:", error);
      });
  }, []);

  return (
    <>
      Naam: {name}
      <input onInput={(e) => setName((e.target as any).value)} />
      <button onClick={() => setName("Jos")}>Verander naam</button>
      <button onClick={addProduct}>Add product</button>
      <table>
        <thead>
          <tr>
            <th>ID</th>
            <th>Description</th>
            <th>Price</th>
          </tr>
        </thead>
        <tbody>
          {products.map((product) => (
            <tr key={product.id}>
              <td>{product.id}</td>
              <td>{product.description}</td>
              <td>${product.price}</td>
            </tr>
          ))}
        </tbody>
      </table>
    </>
  );
}

export default App;
