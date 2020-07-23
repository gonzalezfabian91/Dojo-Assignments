import React, {useState, useEffect} from 'react';
import io from 'socket.io-client'
import './App.css';

function App() {

    const [socket] = useState(() => io(':8000'));
    const [number, setNumber] = useState(0);

    useEffect(() => {

        // console.log("is running?");
        socket.on("update_number", data => {
            console.log("Update Number has Fired");
            setNumber(number + data.number);
        });

        // socket.emit("message_from_client", {"messsage":"This is comming from the client"});


        return () => socket.disconnect(true);
    },[]);

    const clickHandler = (e) => {
        socket.on("update_number", data => {
            console.log(data);
            setNumber(number + data.number);
        });
        socket.emit("message_from_client", {"message": "hey this is client", "number": number + 1});
        setNumber(number + 1);
    }

  return (
    <div className="App">
        <h1>Hello World!!!</h1>
        <p>Clicked: {number}</p>
        <button onClick={clickHandler}>Click</button>
    </div>
  );
}

export default App;
