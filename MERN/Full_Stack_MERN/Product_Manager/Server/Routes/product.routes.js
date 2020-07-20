const ProductController = require('../Controllers/product.controller');

module.exports = app => {
    app.get('/api/products', ProductController.products);
    app.post('/api/products/new', ProductController.createProduct);
}