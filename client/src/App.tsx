import React from "react";
import logo from "./logo.svg";
import "./App.css";
import { BrowserRouter, Route, Routes } from "react-router-dom";
import { Home } from "./routes/Home";
import { Planet } from "./routes/Planet";

function App() {
  return (
    <div className="App">
      <header className="App-header">
        <BrowserRouter>
          <Routes>
            <Route path="/" element={<Home />} />
            <Route path="/planet/:name" element={<Planet />} />
          </Routes>
        </BrowserRouter>
      </header>
    </div>
  );
}

export default App;
