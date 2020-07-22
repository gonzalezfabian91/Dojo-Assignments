const {Author} = require('../Models/author.model');

module.exports.authors = (req, res) => {
    Author.find()
        .then(authors => res.json(authors))
        .catch(err => res.status(400).json(err));
};

module.exports.createAuthor = (req, res) => {
    Author.create(req.body)
        .then(author => res.json(author))
        .catch(err => res.status(400).json(err));
};

module.exports.OneAuthor = (req, res) => {
    Author.findOne({ _id:req.params.id })
        .then(author => res.json(author))
        .catch(err => res.status(400).json(err));
};

module.exports.deleteOneAuthor = (req, res) => {
    Author.deleteOne({ _id:req.params.id })
        .then(deletAuthor => res.json(deletAuthor))
        .catch(err => res.status(400).json(err));
};

module.exports.updateAuthor = (req, res) => {
    Author.findOneAndUpdate({ _id:req.params.id }, req.body, {runValidators: true, new:true})
        .then(updatedAuthor => res.json(updatedAuthor))
        .catch(err => res.status(400).json(err));
};