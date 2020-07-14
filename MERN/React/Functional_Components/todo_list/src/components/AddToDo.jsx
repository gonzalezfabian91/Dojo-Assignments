import React from 'react';

const AddToDo = ({todo, setTodo}) => {
    let task = {
        name: "",
        isCompleted: false
    };

    const onChange = (e) => {
        task.name = e.target.value;
    }

    const onSubmit = (e) => {
        e.preventDefault();
        setTodo([...todo, task]);
        console.log(todo, task)
        e.target.value = "";
        task = "";
        console.log(todo)
    };

    return (
        <div>
            <h3>Add to your To Do list!</h3>
            <form onSubmit={onSubmit}>
                <div>
                    <label>To Do:</label>
                    <input type="text" onChange={onChange} className="form-control col-2" name="task" id="task"/>
                </div>
                <div>
                    <input type="submit" className="btn btn-secondary" value="Add"/>
                </div>
            </form>
            <hr className="col-6"/>
        </div>

    )
}

export default AddToDo;