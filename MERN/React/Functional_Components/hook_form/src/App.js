import React, {useState} from 'react';
import './App.css';
import UserForm from './components/UserForm'
import User from './components/User'

function App() {
	const [user,setUser]=useState({firstname:"",lastname:"",email:"",password:""})
	return (
		<div className="App">
			<UserForm setUser={setUser}/>
			<User user={user}/>
		</div>
	);
}

export default App;
