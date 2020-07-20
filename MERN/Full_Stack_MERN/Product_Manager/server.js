const express = require('express')
const app = express();
const cors = require('cors')

require('./Server/Config/product.config');

app.use(cors());
app.use(express.json());
app.use(express.urlencoded({ extended: true }));

require('./Server/Routes/product.routes')(app);

app.listen(8000, () => {
    console.log('listening on port 8000')
});