const express = require('express');
const app = express();

require('./Server/config/mongoose.config');

app.use(express.json(), express.urlencoded({ extended: true }));

const AllJokeRoutes = require('./Server/routes/jokes.routes');
AllJokeRoutes(app);

app.listen(8000, () => {
    console.log('listening');
})

const mongoose = require('mongoose');