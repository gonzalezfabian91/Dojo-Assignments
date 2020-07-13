import React from 'react';

const BoxDisplay = ({boxes}) => {
    return (
        <div>
            {boxes.map((val, i) => (
                <div key={i} style={val.style}></div>
            ))}
        </div>
    );
};

export default BoxDisplay;