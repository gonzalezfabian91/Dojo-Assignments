import React, {useState} from 'react';

const Pokemon = (props) => {
    const [pokemon, setPokemon] = useState([]);

    const getPokemon = () => {
        fetch('https://pokeapi.co/api/v2/pokemon?limit=807')
            .then(response => response.json())
            .then(responce => setPokemon(responce.results))
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