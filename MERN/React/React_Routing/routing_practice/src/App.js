import React from 'react';
import './App.css';
import {Router} from '@reach/router';
import Welcome from './components/Welcome';
import WordNumber from './components/WordNumber'
import Color from './components/Color';

function App() {
    return (
        <div className="App">
            <Router>
                <Welcome path="/home"/>
                <WordNumber path="/:id"/>
                <Color path="/:id/:backgroundColor/:textColor"/>
            </Router>
        </div>
    );
}

export default App;