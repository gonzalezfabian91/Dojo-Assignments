import React, {useState} from 'react';
// import logo from './logo.svg';
import './App.css';
import UserForm from './components/UserForm';
import User from './components/User';

function App() {
    const [user, setUser] = useState({firstName:"", lastName:"", email:"", password:"", confirmPassword:""})
    return (
        <div className="App">
            <UserForm user={user} setUser={setUser}/>
            <User user={user}/>
        </div>
    );
}

export default App;
