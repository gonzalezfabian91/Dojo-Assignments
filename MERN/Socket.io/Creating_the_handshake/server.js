const express = require('express');
const app = express();
const sockets = require('socket.io')

const server = app.listen(8000, () => {
    console.log('The server is all fired up on port 8000')
});

const io = sockets(server);

io.on("connection", socket => {
    // console.log('Nice to meet you. (Shake Hand)');

    socket.on("message_from_client", data => {
        console.log(data);
        socket.emit("send_to_other_client", {"message":"this is comming from the server"});
    });
});