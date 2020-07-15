import React, {useState} from 'react';
import axios from 'axios';

const Pokemon = props => {
    const [pokemon, setPokemon] = useState([]);
    // const [responseData, setResponseData] = useState(null);

    const getPokemon = () => {
        axios.get('https://pokeapi.co/api/v2/pokemon?limit=807')
            .then(response => {setPokemon(response.data.results);
            });
    };

    return (
        <div>
            <button onClick={getPokemon}>Fetch Pokemon</button>
            {pokemon.length > 0 && pokemon.map((pokemon, index) => {
                return (
                    <div>
                        <p key={index}>{pokemon.name}</p>
                    </div>
                )
            })}
        </div>
    )
}

export default Pokemon;