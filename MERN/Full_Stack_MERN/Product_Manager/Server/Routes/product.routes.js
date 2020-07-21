const ProductController = require('../Controllers/product.controller');

module.exports = app => {
    // app.get('/api', ProductController.products);
    app.post('/api/products/new', ProductController.createProduct);
    app.get('/api/products', ProductController.getAllProducts);
    app.get('/api/products/:id', ProductController.getOneProduct);
    app.delete('/api/products/:id', ProductController.deleteOneProduct);
    app.put('/api/products/:id', ProductController.updateProduct);
}