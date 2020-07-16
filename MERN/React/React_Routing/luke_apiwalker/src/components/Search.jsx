import React, {useState} from 'react';
import {navigate} from '@reach/router';

const Search = props => {
    const [options, setOption] = useState("people");
    const [id, setId] = useState("4");

    const onSubmit = (e) => {
        e.preventDefault();
        navigate(`/${options}/${id}/`);
    };

    return (
        <div id="display">
            <form onSubmit={onSubmit}>
                <select name="option" onChange={(e) => setOption(e.target.value)}>
                    <option value="people">People</option>
                    <option value="planets">Planets</option>
                </select>
                <label htmlFor="id">ID</label>
                <input type="number" id="id" name="id" min="1" onChange={(e) => setId(e.target.value)}/>
                <button type="submit">Search</button>
            </form>
        </div>
    )
}

export default Search;