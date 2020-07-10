import React from 'react';

const User = props => {
    const {firstName, lastName, email, password} = props.user;
    return (
        <div>
            <p>First Name: {firstName}</p>
            <p>Last Name: {lastName}</p>
            <p>Email: {email}</p>
            <p>Password: {password}</p>
        </div>
    );
};

export default User;