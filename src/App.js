import React from 'react';
import './App.css';
import { BrowserRouter } from 'react-router-dom';
import Header from './components/Header';
import Nav from './components/Nav';

function App() {
  return (
    <>
<BrowserRouter>
      <Nav />
      <Header />
</BrowserRouter>
  
    </>
  );
}

export default App;
