class Card {
    constructor(name, cost){
        this.name = name;
        this.cost = cost;
    }
}

class Unit extends Card{
    constructor(name, cost, power, res){
        super(name, cost);
        this.power = power;
        this.res = res;
    }

    attack(target){
        if (target instanceof Unit){
            target.res -= this.power;
            console.log(`${target.name} res ${target.res}`);
        }
        else{
            throw new Error("Target must be a Unit");
        }
    }

    play(effect){
        let mag = effect.magnitude;
        if(effect.stat == "resilience"){
            this.res += mag;
        }
        if(effect.stat == "power"){
            this.power += mag;
        }
    }
}

class Effect extends Card{
    constructor(name, cost, text, stat, magnitude){
        super(name, cost);
        this.text = text;
        this.stat = stat;
        this.magnitude = magnitude;
    }
}

const RedBelt = new Unit("Red Belt Ninja", 3, 3, 4);
const BlackBelt = new Unit("Black Belt Ninja", 4, 5, 4);
const HardAlgo = new Effect("Hard Algorithm", 2, "increase targets resilience bt 3", "resilience", 3);
const UPR = new Effect("Unhandled Promise Rejection", 1, "reduce targets resilience by 2", "resilience", -2);
const PairPro = new Effect("Pair Programming", 3, "increase targets power by 2", "power", 2);

RedBelt.play(HardAlgo);
console.log(`RedBelt's res ${RedBelt.res}`);
RedBelt.play(UPR);
console.log(`RedBelt's res ${RedBelt.res}`);
RedBelt.play(PairPro);
console.log(`RedBelt's power ${RedBelt.power}`);
console.log(`BlackBelt's res ${BlackBelt.res}`);
RedBelt.attack(BlackBelt);


