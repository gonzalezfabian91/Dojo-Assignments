import React from 'react';

const ToDo = ({task, todo, setToDo, index}) => {

    const onClickDelete = () => {
        setToDo(() => todo.filter((task) => todo.indexOf(task) !== index));
    };

    const onCheckBox = () => {
        todo[index].isCompleted = !todo[index].isCompleted;
        setToDo([...todo]);
    };

    return (
        <div>
            <table id="info" className="table table-dark col-6">
                <thead>
                    <tr>
                        <th scope="col" className="col-8">Task</th>
                        <th scope="col" className="col-2">Completed</th>
                        <th scope="col" className="col-2">Delete</th>
                    </tr>
                </thead>
                <tbody>
                    <tr>
                        <td>
                            <h3
                                style={
                                    task.isCompleted
                                    ? {textDecoration: "line-through"}
                                    : {textDecoration: "none"}
                                }
                            >{task.name}</h3>
                        </td>
                        <td><input type="checkbox" name="checkbox" onChange={onCheckBox}/></td>
                        <td><button onClick={onClickDelete} className="btn btn-danger">Delete</button></td>
                    </tr>
                </tbody>
            </table>
        </div>
    )
}

export default ToDo;