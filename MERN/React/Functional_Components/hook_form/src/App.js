import React, {useState} from 'react';
import './App.css';
import UserForm from './components/UserForm'
import User from './components/User'

function App() {
	const [user,setUser]=useState({firstname:"",lastname:"",email:"",password:""})
	const [isSubmitted, setIsSubmitted] = useState(false);
	return (
		<div className="App">
			<UserForm user={user} setUser={setUser} setIsSubmitted={setIsSubmitted}/>
			{isSubmitted &&
				<User user={user}/>
			}
		</div>
	);
}

export default App;
