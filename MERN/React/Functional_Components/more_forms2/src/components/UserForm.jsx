import React from 'react';

const UserForm = props => {
    const {user, setUser} = props;

    const onChangeHandler = (e) => {
        e.preventDefault();
        setUser({
            ...user,
            [e.target.name]: e.target.value
        })
    }

    const nameValid = (fname) => {
        if (fname.length < 2 && fname.length > 0){
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
    const passwordValid = (password) => {
        if (password.length < 8 && password.length > 0){
            return false
        }
        return true
    }
    // const confirmValid = (con) => {
    //     if (con.input !== con.password){
    //         return false
    //     }
    //     return true
    // }

    return (
        <form>
            <div>
                <label>First Name:</label>
                <input type="text" name="firstName" onChange={(e) => onChangeHandler(e)}/>
                {
                    !nameValid(user.firstName) && <p style={{color:'red'}}>First Name must be 2 Characters</p>
                }
            </div>
            <div>
                <label>Last Name:</label>
                <input type="text" name="lastName" onChange={(e) => onChangeHandler(e)}/>
                {
                    !nameValid(user.lastName) && <p style={{color:'red'}}>Last Name must be 2 Characters</p>
                }
            </div>
            <div>
                <label>Email:</label>
                <input type="text" name="email" onChange={(e) => onChangeHandler(e)}/>
                {
                    !emailValid(user.email) && <p style={{color:'red'}}>Email is not Valid</p>
                }
            </div>
            <div>
                <label>Password:</label>
                <input type="text" name="password" onChange={(e) => onChangeHandler(e)}/>
                {
                    !passwordValid(user.password) && <p style={{color:'red'}}>Password must be atleast 8 Characters</p>
                }
            </div>
            <div>
                <label>Confirm Password:</label>
                <input type="text" name="confirmPassword" onChange={(e) => onChangeHandler(e)}/>
                {/* {
                    !confirmValid(user.confirmPassword) && <p style={{color:'red'}}>Password do not match</p>
                } */}
            </div>
            <div>
                <input type="submit" value="Create User"/>
            </div>
        </form>
    )
}

export default UserForm;