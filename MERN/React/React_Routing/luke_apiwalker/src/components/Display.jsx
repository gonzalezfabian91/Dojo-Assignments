import React, {useState, useEffect} from 'react';
import axios from 'axios';

const Display = ({options, id}) => {
    const [display, setDisplay] = useState([]);
    const url = "https://swapi.dev/api/";

    useEffect(() => {
        axios.get(`${url}${options}/${id}/`)
            .then((response) => {setDisplay(response.data);
                console.log(response);
            });
    }, [id, options]);

    return (
        <div>
            {options === "people" ? (
                <div>
                    <h1>{display.name}</h1>
                    <h3>Homeworld: <p style={{"color":"red"}}>{display.homeworld}</p></h3>
                    <h3>Height: <p style={{"color":"red"}}>{display.height}</p></h3>
                    <h3>Mass: <p style={{"color":"red"}}>{display.mass}</p></h3>
                    <h3>Hair Color: <p style={{"color":"red"}}>{display.hair_color}</p></h3>
                    <h3>Eye Color: <p style={{"color":"red"}}>{display.eye_color}</p></h3>
                    <h3>Skin Color: <p style={{"color":"red"}}>{display.skin_color}</p></h3>
                </div>
            ) : (
                <div>
                    <h1>{display.name}</h1>
                    <h3>Climate: <p style={{"color":"red"}}>{display.climate}</p></h3>
                    <h3>Terrain: <p style={{"color":"red"}}>{display.terrain}</p></h3>
                    <h3>Surface Water: <p style={{"color":"red"}}>{display.surface_water}</p></h3>
                    <h3>Population: <p style={{"color":"red"}}>{display.population}</p></h3>
                </div>
            ) 
            }
        </div>
    )
}

export default Display;