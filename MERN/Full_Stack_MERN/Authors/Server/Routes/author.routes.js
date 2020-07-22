const AuthorController = require('../Controllers/author.controller');

module.exports = app => {
    app.get('/api/authors', AuthorController.authors);
    app.post('/api/authors/new', AuthorController.createAuthor);
    app.get('/api/authors/:id', AuthorController.OneAuthor);
    app.delete('/api/authors/:id', AuthorController.deleteOneAuthor);
    app.put('/api/authors/:id', AuthorController.updateAuthor);
}