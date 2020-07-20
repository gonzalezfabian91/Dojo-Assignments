const {Product} = require('../Models/product.model');

module.exports.products = (req, res) => {
    res.json({
        message: "Sup Bitch"
    });
}

module.exports.createProduct = (req, res) => {
    Product.create(req.body)
        .then(product => res.json(product))
        .catch(err => res.json(err));
}