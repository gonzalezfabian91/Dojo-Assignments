import React, {useState, useEffect} from 'react';
import axios from 'axios';
import {Link} from '@reach/router';

const OneAuthor = ({id}) => {
    const [author, setAuthor] = useState({});
    const [loaded, setLoaded] = useState(false);

    useEffect(() => {
        axios.get(`http://localhost:8000/api/authors/${id}`)
            .then(res => {
                console.log(res.data);
                setAuthor(res.data);
                setLoaded(true);
            })
            .catch(err => {
                console.log(err);
            })
    },[]);

    return(
        <div>
            <h1>Favorite Authors</h1>
            <Link to="/">Home</Link>
            {loaded &&
                <div>
                    <table id="table2" className="table table-dark">
                        <thead>
                            <tr>
                                <th>Author</th>
                                <th>Quote</th>
                            </tr>
                        </thead>
                        <tbody>
                            <tr>
                                <td><h3>{author.name}</h3></td>
                                <td><h3>{author.quote}</h3></td>
                            </tr>
                        </tbody>
                    </table>
                    <Link to={`/update/${id}`} className="btn btn-secondary">Edit</Link>
                </div>
            }
        </div>
    )
}

export default OneAuthor;