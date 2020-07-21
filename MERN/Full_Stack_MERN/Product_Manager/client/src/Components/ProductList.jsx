import React from 'react'
// import axios from 'axios'
import {Link} from '@reach/router'

const ProductList = ({products}) => {
    return(
        <div>
            {
                products.map((prod, idx) => {
                    return(
                        <div key={idx}>
                            <Link to={`/products/${prod._id}`}>{prod.title}</Link>
                        </div>
                    )
                })
            }
        </div>
    )
}

export default ProductList;