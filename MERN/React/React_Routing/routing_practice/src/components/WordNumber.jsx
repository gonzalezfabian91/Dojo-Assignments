import React from 'react';

const WordNumber = ({id}) => {

    return (
        <div>
            {isNaN(id) 
            ? <h1>The word is: {id}</h1> 
            : <h1>The number is: {id}</h1>
            }
        </div>
    )
}

export default WordNumber;