import React, { useState } from 'react';

const UserForm = props => {
    const {setUser} = props;
    const [firstName, setFirstName] = useState("");
    const [firstNameError, setFirstNameError] = useState("");
    const [lastName , setLastName] = useState("");
    const [lastNameError, setLastNameError] = useState("");
    const [email, setEmail] = useState("");
    const [emailError, setEmailError] = useState("");
    const [password, setPassword] = useState("");
    const [passwordError, setPasswordError] = useState("");
    const [Errors, setErrors] = useState("stop");

    const createUser = (e) => {
        if(Errors === ""){
            e.preventDefault();
            const newUser = {firstName, lastName, email, password};
            setUser(newUser);
            console.log("Welcome", newUser);
        }
        else{
            setErrors("Cannot process request");
            console.log("not going to happen");
        }
    };

    const handlefirstName = (e) => {
        setFirstName(e.target.value);
        if(e.target.value.length < 1){
            setFirstNameError("First Name is required");
            setErrors("Cannot proccess request");
        }else if(e.target.value.length < 2){
            setFirstNameError("First Name must be at least 2 Characters");
            setErrors("Cannot proccess request");
        }else{
            setFirstNameError("");
            setErrors("");
        }
    }

    const handlelastName = (e) => {
        setLastName(e.target.value);
        if(e.target.value.length < 1){
            setLastNameError("Last Name is required");
            setErrors("Cannot proccess request");
        }else if(e.target.value.length < 2){
            setLastNameError("Last Name must be at least 2 Characters");
            setErrors("Cannot proccess request");
        }else{
            setLastNameError("");
            setErrors("");
        }
    }
    
    const handleemail = (e) => {
        setEmail(e.target.value);
        if(e.target.value.length < 1){
            setEmailError("Email is required");
            setErrors("Cannot proccess request");
        }else if(e.target.value.length < 5){
            setEmailError("Email must be at least 5 Characters");
            setErrors("Cannot proccess request");
        }else{
            setEmailError("");
            setErrors("");
        }
    }

    const handlepassword = (e) => {
        setPassword(e.target.value);
        if(e.target.value.length < 1){
            setPasswordError("Password is required");
            setErrors("Cannot proccess request");
        }else if(e.target.value.length < 8){
            setPasswordError("Passowrd must be atleast 8 Characters");
            setErrors("Cannot proccess request");
        }else{
            setPasswordError("");
            setErrors("");
        }
    }

    return (
        <form onSubmit={createUser}>
            <div>
                <label>First Name:</label>
                <input className="fname" type="text" onChange={handlefirstName}/>
                {
                    firstNameError ?
                    <p style = {{color: 'red'}}>{firstNameError}</p>:
                    ''
                }
            </div>
            <div>
                <label>Last Name:</label>
                <input className="lname" type="text" onChange={handlelastName}/>
                {
                    lastNameError ?
                    <p style={{color: 'red'}}>{lastNameError}</p>:
                    ''
                }
            </div>
            <div>
                <label>Email:</label>
                <input className="email" type="text" onChange={handleemail}/>
                {
                    emailError ?
                    <p style={{color: 'red'}}>{emailError}</p>:
                    ''
                }
            </div>
            <div>
                <label>Password:</label>
                <input className="pass" type="password" onChange={handlepassword}/>
                {
                    passwordError ?
                    <p style={{color: 'red'}}>{passwordError}</p>:
                    ''
                }
            </div>
            <div>
                <input type="submit" value="Create User"/>
            </div>
        </form>
    )
}

export default UserForm;