const pokemon = Object.freeze([
        { "id": 1,   "name": "Bulbasaur",  "types": ["poison", "grass"] },
        { "id": 5,   "name": "Charmeleon", "types": ["fire"] },
        { "id": 9,   "name": "Blastoise",  "types": ["water"] },
        { "id": 12,  "name": "Butterfree", "types": ["bug", "flying"] },
        { "id": 16,  "name": "Pidgey",     "types": ["normal", "flying"] },
        { "id": 23,  "name": "Ekans",      "types": ["poison"] },
        { "id": 24,  "name": "Arbok",      "types": ["poison"] },
        { "id": 25,  "name": "Pikachu",    "types": ["electric"] },
        { "id": 37,  "name": "Vulpix",     "types": ["fire"] },
        { "id": 52,  "name": "Meowth",     "types": ["normal"] },
        { "id": 63,  "name": "Abra",       "types": ["psychic"] },
        { "id": 67,  "name": "Machamp",    "types": ["fighting"] },
        { "id": 72,  "name": "Tentacool",  "types": ["water", "poison"] },
        { "id": 74,  "name": "Geodude",    "types": ["rock", "ground"] },
        { "id": 87,  "name": "Dewgong",    "types": ["water", "ice"] },
        { "id": 98,  "name": "Krabby",     "types": ["water"] },
        { "id": 115, "name": "Kangaskhan", "types": ["normal"] },
        { "id": 122, "name": "Mr. Mime",   "types": ["psychic"] },
        { "id": 133, "name": "Eevee",      "types": ["normal"] },
        { "id": 144, "name": "Articuno",   "types": ["ice", "flying"] },
        { "id": 145, "name": "Zapdos",     "types": ["electric", "flying"] },
        { "id": 146, "name": "Moltres",    "types": ["fire", "flying"] },
        { "id": 148, "name": "Dragonair",  "types": ["dragon"] }
    ]);

    //an array of pokemon objects where the id is evenly divisible by 3

    // const DivisibleBy3 = pokemon.filter(object => object.id % 3 === 0);
    // console.log(DivisibleBy3);

    //an array of pokemon objects that are "fire" type

    // const fire = pokemon.filter(object => object.types.includes("fire"));
    // console.log(fire);

    //an array of pokemon objects that have more than one type

    // const multiple = pokemon.filter(object => object.types.length > 1);
    // console.log(multiple);

    //an array with just the names of the pokemon

    // const names = pokemon.map(object => object.name);
    // console.log(names);

    //an array with just the names of the pokemon with an id greater than 99

    // const greater = pokemon.filter(object => object.id > 99).map(object => object.name);
    // console.log(greater);

    //an array with just the names of the pokemon whos type is poison

    // const poison = pokemon.filter(object => object.types.includes("poison")).map(object => object.name);
    // console.log(poison);

    //an array containing just the first type of all the pokemon whose second type is "flying"

    // const flying = pokemon.filter(object => object.types[1] === "flying").map(object => ({"name": object.name, "Type": object.types[0]}));
    // console.log(flying);

    //a count of the number of pokemon that are "normal" type

    // const normal = pokemon.filter(object => object.types.includes("normal")).length;
    // console.log(normal);
