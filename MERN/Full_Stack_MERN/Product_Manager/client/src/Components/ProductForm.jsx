import React, {useState} from 'react'
import axios from 'axios';

const ProductForm = props => {
    const [title, setTitle] = useState('');
    const [price, setPrice] = useState('');
    const [description, setDescription] = useState('');

    const onSubmitHandler = (e) => {
        e.preventDefault();
        axios.post('http://localhost:8000/api/products/new', {
            title,
            price,
            description
        })
        .then(res => console.log(res))
        .catch(err => console.log(err))
    }

    return(
        <div>
            <h1>Product Manager</h1>
            <form onSubmit={onSubmitHandler}>
                <div>
                    <label className="col-2">Title</label>
                    <input type="text" id="titleinput" className="col-2 form-control" onChange={(e) => setTitle(e.target.value)}/>
                </div>
                <div>
                    <label className="col-2">Price</label>
                    <input type="number" id="priceinput" className="col-2 form-control" onChange={(e) => setPrice(e.target.value)}/>
                </div>
                <div>
                    <label className="col-2">Description</label>
                    <input type="text" id="descinput" className="col-2 form-control" onChange={(e) => setDescription(e.target.value)}/>
                </div>
                <div>
                    <p></p>
                    <input type="submit" value="Create" className="btn btn-secondary"/>
                </div>
            </form>
        </div>
    )
}

export default ProductForm;