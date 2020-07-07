class Ninja {
    constructor(name, health = 0){
        this.name = name;
        this.health = health;
        this.speed = 3;
        this.strength = 3;
    }
    SayName(){
        console.log(`Your ninjas name is ${this.name}.`);
    }
    ShowStats(){
        console.log(`Your ninhas name is ${this.name} and his stats are Strength: ${this.strength}, Speed: ${this.speed}, Health: ${this.health}.`)
    }
    DrinkSake(){
        this.health += 10;
        console.log(`Your ninja had some sake and its Health is now at ${this.health}.`)
    }
}
const ninja1 = new Ninja("Hyabusa", 100);
ninja1.SayName();
ninja1.ShowStats();
ninja1.DrinkSake();
