import React, {useState} from 'react';
import './App.css';
import UserForm from './components/UserForm'
import User from './components/User'

function App() {
    const [user, setUser]=useState({firsName:"",lastName:"",email:"",password:""})
    return (
        <div className="App">
            <UserForm user={user} setUser={setUser} />
            <User user={user}/>
        </div>
    );
}

export default App;
