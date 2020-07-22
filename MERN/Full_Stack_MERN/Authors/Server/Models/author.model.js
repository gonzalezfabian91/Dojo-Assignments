const mongoose = require('mongoose');

const AuthorSchema = new mongoose.Schema({
    name: {
        type: String,
        required: [true, "Name is Required"],
        minlength: [3, "Name Must be at least 3 characters"]
    },
    quote: {
        type: String,
        required: [true, "Quote is Required"],
        minlength: [3, "Quote must be at least 3 characters"]
    }
},{timestamps:true})

module.exports.Author = mongoose.model('Author', AuthorSchema);