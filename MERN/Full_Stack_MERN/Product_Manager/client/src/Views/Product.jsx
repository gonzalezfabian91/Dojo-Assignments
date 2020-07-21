import React, {useState, useEffect} from 'react'
import ProductForm from '../Components/ProductForm'
import ProductList from '../Components/ProductList'
import axios from 'axios';

const Product = props => {
    const [products, setProducts] = useState([]);

    useEffect(() => {
        getAllProductsAPI();
    },[])

    const getAllProductsAPI = () => {
        axios.get('http://localhost:8000/api/products')
            .then(res => {
                console.log(res.data);
                setProducts(res.data);
            })
            .catch(err => {
                console.log(err.responce)
            })
    }
    const deleteProduct = (id) => {
        setProducts(products.filter(product => product._id !== id))
    };
    const addProduct = (product) => {
        setProducts([...products, product])
    };

    return(
        <div>
            <ProductForm addProduct={addProduct} getAllProductsAPI={getAllProductsAPI}/>
            <hr/>
            <ProductList products={products} deleteProduct={deleteProduct}/>
        </div>
    )
}

export default Product;