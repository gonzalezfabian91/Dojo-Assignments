import React from 'react';

const Color = ({id, backgroundColor, textColor}) => {

    return (
        <div>
            <h1 style={{"background-color":backgroundColor, "color":textColor}}>{id}</h1>
        </div>
    )
}

export default Color;