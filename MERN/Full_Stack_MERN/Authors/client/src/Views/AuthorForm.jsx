import React, {useState} from 'react'
import axios from 'axios';
import { navigate, Link } from '@reach/router';


const AuthorForm =  ({addAuthor}) => {
    const [name, setName] = useState('');
    const [quote, setQuote] = useState('');
    const [errors, setErrors] = useState([]);

    const onSubmitHandler = (e) => {
        e.preventDefault();
        axios.post('http://localhost:8000/api/authors/new', {
            name,
            quote
        })
        .then(res => {
            console.log(res);
            addAuthor(res.data);
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
            <p>Add a new Author</p>
            <form onSubmit={onSubmitHandler}>
                {errors.map((err, idx) => <p className="text-danger" key={idx}>{err}</p>)}
                <div>
                    <label className="col-2">Name:</label>
                    <input type="text" id="nameinput" className="col-2 form-control" onChange={(e) => setName(e.target.value)}/>
                </div>
                <div>
                    <label className="col-2">Quote:</label>
                    <input type="text" id="quoteinput" className="col-2 form-control" onChange={(e) => setQuote(e.target.value)}/>
                </div>
                <div>
                    <p></p>
                    <input type="submit" value="Add" className="btn btn-secondary"/>
                    <Link className="btn btn-secondary ml-2" to="/">Cancle</Link>
                </div>
            </form>
        </div>
    )
}

export default AuthorForm;