import React, {useState, useEffect} from 'react';
import './App.css';
import Authors from './Views/Authors';
import {Router} from '@reach/router'
import AuthorForm from './Views/AuthorForm';
import axios from 'axios';
import OneAuthor from './Views/OneAuthor';
import UpdateAuthor from './Views/UpdateAuthor';

function App() {
    const [authors, setAuthors] = useState([]);

    useEffect(() => {
        getAllAuthorsAPI();
    },[])

    const getAllAuthorsAPI = () => {
        axios.get('http://localhost:8000/api/authors')
            .then(res => {
                console.log(res.data);
                setAuthors(res.data);
            })
            .catch(err => {
                console.log(err.responce)
            })
    }

    const deleteAuthor = (id) => {
        setAuthors(authors.filter(author => author._id !== id))
    };

    const addAuthor = (author) => {
        setAuthors([...authors, author])
    };

    const updateAuthor = (id, author) => {
        let idx = 0;
        for(let i = 0; i < authors.length; i++){
            if(authors[i]._id === id){
                idx = i;
            }
        }
        const authorsCopy = [...authors];
        authorsCopy[idx] = author
        setAuthors(authorsCopy);
    };

    return (
        <div className="App">
            <Router>
                <Authors path="/" authors={authors} deleteAuthor={deleteAuthor}/>
                <AuthorForm path="/new" addAuthor={addAuthor} getAllAuthorsAPI={getAllAuthorsAPI}/>
                <OneAuthor path="/authors/:id"/>
                <UpdateAuthor path="/update/:id" updateAuthor={updateAuthor}/>
            </Router>
        </div>
    );
}

export default App;
