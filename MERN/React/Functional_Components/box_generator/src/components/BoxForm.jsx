import React, {useState} from 'react';

const BoxForm = ({boxes, setBoxes}) => {
    const [color , setColor] = useState("");

    const colorHandler = (e) => {
        setColor(e.target.value);
    }

    const formHandler = (e) => {
        e.preventDefault();
        setBoxes([
            ...boxes,
            {
                color: color,
                height: "100px",
                width: "100px",
                style: {
                    display: "inline-block",
                    border: "1px solid black",
                    background: color,
                    height: "100px",
                    width: "100px",
                    margin: "10px"
                },
            },
        ]);
    };

    return (
        <div>
            <form onSubmit={formHandler}>
                <div>
                    <input type="text" id="colorinput" className="form-control col-2" name="color" placeholder="Color" onChange={colorHandler}/>
                </div>
                <div>
                    <input type="submit" className="btn btn-secondary" value="Add Box"/>
                </div>
            </form>
        </div>
    )
}

export default BoxForm;