import React from 'react';

const User = props => {
    const {firstname,lastname,email,password}= props.user;
    return (
        <div>
            <p>First Name: {firstname}</p>
            <p>Last Name: {lastname}</p>
            <p>Email: {email}</p>
            <p>Password: {password}</p>
        </div>
    );
};

export default User;
