import React, {useState} from 'react';
import './App.css';
import ToDo from './components/ToDo';
import AddToDo from './components/AddToDo';

function App() {
    const [todo, setTodo] = useState([]);
    return (
        <div className="App">
            <AddToDo todo={todo} setTodo={setTodo}/>
            {todo.map((task, i) => (
                <ToDo task={task} todo={todo} setToDo={setTodo} index={i}/>
            ))}
        </div>
    );
}

export default App;
