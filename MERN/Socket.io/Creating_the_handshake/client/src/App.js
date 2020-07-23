import React, {useState, useEffect} from 'react';
import io from 'socket.io-client'
import './App.css';

function App() {

    const [socket] = useState(() => io(':8000'));

    useEffect(() => {

        console.log("is running?");
        socket.on("send_to_other_client", data => {
            console.log(data)
        });

        socket.emit("message_from_client", {"messsage":"This is comming from the client"});


        return () => socket.disconnect(true);
    },[]);

  return (
    <div className="App">
      <h1>Hello World!!!</h1>
    </div>
  );
}

export default App;
