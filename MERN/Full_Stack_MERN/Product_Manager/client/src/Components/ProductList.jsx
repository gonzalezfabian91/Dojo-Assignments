import React from 'react'
import axios from 'axios'
import {Link, navigate} from '@reach/router'

const ProductList = ({products, deleteProduct}) => {

    const deleteHandler = (id) => {
        axios.delete(`http://localhost:8000/api/products/${id}`)
            .then(res => {
                console.log(res);
                deleteProduct(id);
                navigate("/");
            })
            .catch(err => {
                console.log(err);
            })
    }

    return(
        <div>
            {
                products.map((prod, idx) => {
                    return(
                        <div className="mt-2" key={idx}>
                            <Link to={`/products/${prod._id}`}>{prod.title}</Link>
                            <button className="btn btn-secondary ml-2" onClick={ (e) => { deleteHandler(prod._id) }}>Delete</button>
                        </div>
                    )
                })
            }
        </div>
    )
}

export default ProductList;