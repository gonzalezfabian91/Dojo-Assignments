import React, {useState, useEffect} from 'react'
import axios from 'axios'
import {navigate, Link} from '@reach/router'

const Update = ({id}) => {
    const [title, setTitle] = useState('');
    const [price, setPrice] = useState('');
    const [description, setDescription] = useState('');

    useEffect(() => {
        axios.get(`http://localhost:8000/api/products/${id}`)
            .then(res => {
                setTitle(res.data.title);
                setPrice(res.data.price);
                setDescription(res.data.description);
            })
            .catch(err => {
                console.log(err)
            })
    },[])

    const updateHandler = (e) => {
        e.preventDefault();
        axios.put(`http://localhost:8000/api/products/${id}`, {
            title,
            price,
            description
        })
        .then(res => {
            console.log(res)
            navigate("/");
        });
    }

    return (
        <div>
            <h1>Edit Product</h1>
            <form onSubmit={updateHandler}>
                <div>
                    <label className="col-2">Title</label>
                    <input type="text" id="titleinput" value={title} className="col-2 form-control" onChange={(e) => setTitle(e.target.value)}/>
                </div>
                <div>
                    <label className="col-2">Price</label>
                    <input type="number" id="priceinput" value={price} className="col-2 form-control" onChange={(e) => setPrice(e.target.value)}/>
                </div>
                <div>
                    <label className="col-2">Description</label>
                    <input type="text" id="descinput" value={description} className="col-2 form-control" onChange={(e) => setDescription(e.target.value)}/>
                </div>
                <div>
                    <p></p>
                    <input type="submit" value="Update" className="btn btn-secondary"/>
                </div>
            </form>
            <Link className="btn btn-secondary mt-2" to={"/"}>Go Back</Link>
        </div>
    )
}

export default Update;