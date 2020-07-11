import React, { useState } from 'react';

const UserForm = (props) => {
    const { user, setUser, setIsSubmitted } = props;

    // const [firstname, setFirstName] = useState("");
    // const [lastname, setLastName] = useState("");
    // const [email, setEmail] = useState("");
    // const [password, setPassword] = useState("");
    // const [confirmpassword, setConfirmPassword] = useState("");
    // const [firstNameError, setFirstNameError] = useState("");

    const onChangeHandler = (e) => {
        e.preventDefault();
        // const newUser = { firstname, lastname, email, password, confirmpassword };
        setUser({
            ...user,
            [e.target.name]: e.target.value
        });
        // console.log("Welcome", newUser);
    };

    const isValid = (name) => {
        if (name.length < 2 && name.length > 0){
            return false
        }
        return true
    }

    const emailValid = (email) => {
        if (email.length < 5 && email.length > 0){
            return false
        }
        return true
    }

    const showUser = (e) => {
        e.preventDefault();
        setIsSubmitted(true);

    }

    return (
        <form onSubmit={showUser}>
            <div>
                <label>First Name:</label>
                <input type="text" name="firstname" onChange={(e) => onChangeHandler(e)} />
                {
                    !isValid(user.firstname) && <p style={{color: 'red'}}>First Name must be 2 Characters</p>
                }
            </div>
            <div>
                <label>Last Name:</label>
                <input type="text" name="lastname" onChange={(e) => onChangeHandler(e)} />
            </div>
            <div>
                <label>Email:</label>
                <input type="email" name="email" onChange={(e) => onChangeHandler(e)} />
                {
                    !emailValid(user.email) && <p style={{color: 'red'}}>Email must be at least 5 Characters</p>
                }
            </div>
            <div>
                <label>Password:</label>
                <input type="password" name="password" onChange={(e) => onChangeHandler(e)} />
            </div>
            <div>
                <label>Confirm Password:</label>
                <input type="password" />
            </div>
            <div>
                <input type="submit" value="Create User" />
            </div>
        </form>
    );
};

export default UserForm;