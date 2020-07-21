import React from 'react';
import './App.css';
import Product from './Views/Product';
import { Router } from '@reach/router';
import Detail from './Views/Detail';
import Update from './Views/Update'

function App() {
    return (
        <div className="App">
            <Router>
                <Product path="/"/>
                <Detail path="products/:id"/>
                <Update path="update/:id"/>
            </Router>
        </div>
    );
}

export default App;
