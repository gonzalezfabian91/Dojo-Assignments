class Ninja {
    constructor(name, health = 0, speed = 3, strength = 3){
        this.name = name;
        this.health = health;
        this.speed = speed;
        this.strength = strength;
    }
    SayName(){
        console.log(`Your ninjas name is ${this.name}.`);
    }
    ShowStats(){
        console.log(`Your ninjas name is ${this.name} and his stats are Strength: ${this.strength}, Speed: ${this.speed}, Health: ${this.health}, Wisdom: ${this.wisdom}`)
    }
    DrinkSake(){
        this.health += 10;
        console.log(`Your ninja had some sake and its Health is now at ${this.health}.`)
    }
}
// const ninja1 = new Ninja("Hyabusa", 100);
// ninja1.SayName();
// ninja1.ShowStats();
// ninja1.DrinkSake();

class Sensei extends Ninja {
    constructor(name){
        super(name, 200, 10, 10)
        this.wisdom = 10;
    }
    SpeakWisdom(){
        super.DrinkSake();
        console.log("What one programmer can do in one month, two programmers can do in two months.")
    }
}
const superSensei = new Sensei("Master Splinter");
superSensei.SpeakWisdom();
superSensei.ShowStats();