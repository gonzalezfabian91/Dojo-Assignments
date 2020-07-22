const express = require('express');
const app = express();
const cors = require('cors');

require('./Server/Config/author.config');

app.use(cors());
app.use(express.json())
app.use(express.urlencoded({ extended: true }))

require('./Server/Routes/author.routes')(app);

app.listen(8000, () => {
    console.log('Listening on port 8000')
});