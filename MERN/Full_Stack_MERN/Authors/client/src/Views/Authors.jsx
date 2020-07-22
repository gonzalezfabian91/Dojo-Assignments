import React from 'react';
import axios from 'axios';
import {Link, navigate} from '@reach/router';

const Authors = ({authors, deleteAuthor}) => {

    const deleteHandler = (id) => {
        axios.delete(`http://localhost:8000/api/authors/${id}`)
            .then(res => {
                console.log(res);
                deleteAuthor(id);
                navigate('/');
            })
            .catch(err => {
                console.log(err);
            })
    }

    return (
        <div>
            <h1>Favorite Authors</h1>
            <Link to={"/new"}>Add an author</Link>
            <p>We have quotes by:</p>
                <table id="table" className="table table-dark col-6">
                    <thead>
                        <tr>
                            <th>Author</th>
                            <th>Actions Available</th>
                        </tr>
                    </thead>
                    {
                        authors.map((author, idx) => {
                            return(
                                <tbody key={idx}>
                                    <tr>
                                        <td><Link to={`/authors/${author._id}`}>{author.name}</Link></td>
                                        <td>
                                            <Link to={`/update/${author._id}`} className="btn btn-secondary">Edit</Link>
                                            <button className="btn btn-secondary ml-2" onClick={(e) => { deleteHandler( author._id )}}>Delete</button>
                                        </td>
                                    </tr>
                                </tbody>
                            )
                        })
                    } 
                </table>
        </div>
    )
}

export default Authors;