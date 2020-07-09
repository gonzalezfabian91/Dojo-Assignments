import React, {Component} from 'react';

class PersonCard extends Component{
    constructor(props){
        super(props);
        this.state = {
            ageCount: props.age
        }
    }
    clickHandler = event => {
        console.log(event);
        this.setState({ageCount: this.state.ageCount + 1});
    }
    render(){
        return(
            <>
                <h1>{this.props.lastName}, {this.props.firstName}</h1>
                <p>Age: {this.state.ageCount}</p>
                <p>Hair Color: {this.props.hairColor}</p>
                <button onClick = {this.clickHandler}>Birthday Button for {this.props.firstName} {this.props.lastName}</button>
            </>
        )
    }
}

export default PersonCard;