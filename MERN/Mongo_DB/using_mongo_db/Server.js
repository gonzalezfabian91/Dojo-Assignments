const express = require('express');
const app = express();
const mongoose = require('mongoose');
const cors = require('cors');

app.use(cors());

mongoose.connect('mongodb://localhost/my_first_db', {
    useNewUrlParser: true,
    useUnifiedTopology: true,
    useFindAndModify: false
})

const StudentSchema = new mongoose.Schema({
    name: String,
    home_state: String,
    lucky_number: Number,
    birthyear: Number, 
}, {timestamps: true})

const Student = mongoose.model("Student", StudentSchema);



app.post('/api/student', (req, res) => {
    Student.create(req.body)
        .then(data => res.json(data))
        .catch(err => res.json(err))
})

app.get('/api/student', (req, res) => {
    Student.find()
        .then(data => res.json(data))
        .catch(err => res.json(err))
})

app.listen(8000, () => {
    console.log("listening");
})