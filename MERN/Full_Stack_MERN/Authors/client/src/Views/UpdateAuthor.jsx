import React, {useState, useEffect} from 'react';
import axios from 'axios';
import { navigate, Link } from '@reach/router';

const UpdateAuthor = ({id, updateAuthor}) => {
    const [name, setName] = useState('');
    const [quote, setQuote] = useState('');
    const [errors, setErrors] = useState([]);

    useEffect(() => {
        axios.get(`http://localhost:8000/api/authors/${id}`)
            .then(res => {
                setName(res.data.name);
                setQuote(res.data.quote);
            })
            .catch(err => {
                console.log(err.response)
            })
    },[])

    const updateHandler = (e) => {
        e.preventDefault();
        axios.put(`http://localhost:8000/api/authors/${id}`, {
            name,
            quote
        })
        .then(res => {
            console.log(res);
            updateAuthor(id, {name: name, quote: quote});
            navigate('/');
        })
        .catch(err => {
            console.log(err.response);
            console.log(err.response.data.errors);
            
            const errArr = [];
            for (const key of Object.keys(err.response.data.errors)){
                errArr.push(err.response.data.errors[key].properties.message)
            }
            setErrors(errArr);
        })
    }

    return (
        <div>
            <h1>Favorite Authors</h1>
            <Link to="/">Home</Link>
            <p>Update Author</p>
            <form onSubmit={updateHandler}>
                {errors.map((err, idx) => <p className="text-danger" key={idx}>{err}</p>)}
                <div>
                    <label className="col-2">Name:</label>
                    <input type="text" id="nameinput" value={name} className="col-2 form-control" onChange={(e) => setName(e.target.value)}/>
                </div>
                <div>
                    <label className="col-2">Quote:</label>
                    <input type="text" id="quoteinput" value={quote} className="col-2 form-control" onChange={(e) => setQuote(e.target.value)}/>
                </div>
                <div>
                    <p></p>
                    <input type="submit" value="Update" className="btn btn-secondary"/>
                    <Link className="btn btn-secondary ml-2" to="/">Cancel</Link>
                </div>
            </form>
        </div>
    )
}

export default UpdateAuthor;