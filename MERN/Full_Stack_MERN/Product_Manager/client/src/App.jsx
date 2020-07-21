import React from 'react';
import './App.css';
import Product from './Views/Product';
import { Router } from '@reach/router';
import Detail from './Views/Detail';

function App() {
    return (
        <div className="App">
            <Router>
                <Product path="/"/>
                <Detail path="products/:id"/>
            </Router>
        </div>
    );
}

export default App;
