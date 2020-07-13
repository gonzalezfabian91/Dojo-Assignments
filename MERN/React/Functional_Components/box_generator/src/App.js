import React, {useState} from 'react';
// import logo from './logo.svg';
import './App.css';
import BoxForm from './components/BoxForm';
import BoxDisplay from './components/BoxDisplay';


function App() {
    const [boxes, setBoxes] = useState([
        {
            color: "",
            height: "",
            width: "",
            style:{
                display: "",
                border: "",
                background: "",
                height: "",
                width: "",
                margin: ""
            }
        }
    ])
    return (
        <div className="App">
            <h1>Add Some Colored Boxes</h1>
            <BoxForm boxes={boxes} setBoxes={setBoxes}/>
            <hr className="col-8"/>
            <BoxDisplay boxes={boxes}/>
        </div>
    );
}

export default App;
