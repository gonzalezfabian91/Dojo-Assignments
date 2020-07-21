const {Product} = require('../Models/product.model');

// module.exports.products = (req, res) => {
//     res.json({
//         message: "Sup"
//     });
// }

module.exports.createProduct = (req, res) => {
    Product.create(req.body)
        .then(product => res.json(product))
        .catch(err => res.status(400).json(err));
};

module.exports.getAllProducts = (req, res) => {
    Product.find()
        .then(products => res.json(products))
        .catch(err => res.status(400).json(err));
};

module.exports.getOneProduct = (req, res) => {
    Product.findOne({ _id:req.params.id })
        .then(product => res.json(product))
        .catch(err => res.status(400).json(err));
};

module.exports.deleteOneProduct = (req, res) => {
    Product.deleteOne({ _id:req.params.id })
        .then(deleteConfirm => res.json(deleteConfirm))
        .catch(err => res.status(400).json(err));
};

module.exports.updateProduct = (req, res) => {
    Product.findOneAndUpdate({ _id:req.params.id }, req.body, {new:true})
        .then(updatedProduct => res.json(updatedProduct))
        .catch(err => res.status(400).json(err));
};