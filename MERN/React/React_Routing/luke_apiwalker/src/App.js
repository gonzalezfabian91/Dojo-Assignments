import React from 'react';
import './App.css';
import {Router} from '@reach/router';
import Display from './components/Display';
import Search from './components/Search';

function App() {
    return (
        <div className="App">
            <Search/>
            <Router>
                <Display path="/:options/:id"/>
            </Router>
        </div>
    );
}

export default App;
