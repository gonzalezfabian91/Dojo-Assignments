import React, {useState, useEffect} from 'react'
import axios from 'axios'

const Detail = ({id}) => {
    const [product, setProduct] = useState({});
    const [loaded, setLoaded] = useState(false);

    useEffect(() => {
        axios.get(`http://localhost:8000/api/products/${id}`)
            .then(response => {
                console.log(response.data);
                setProduct(response.data);
                setLoaded(true);
            })
            .catch(err => {
                console.log(err);
            })
    },[]);

    return(
        <div>
            {loaded && <div>
                <p>Title: {product.title}</p>
                <p>Price: {product.price}</p>
                <p>Description: {product.description}</p>
            </div>}
        </div>
    )
}

export default Detail;