const express = require('express');
const faker = require('faker');
const app = express();

class User {
    constructor(){
        this.fname = faker.name.firstName();
        this.lname = faker.name.lastName();
        this.job = faker.name.title();
    }
}

class Company {
    constructor(){
        this.cname = faker.company.companyName();
        this.phrase = faker.company.catchPhrase();
        this.bs = faker.company.bs();
    }
}

app.get("/api/user/new", (req, res) => {
    res.json(new User());
});

app.get("/api/companies/new", (req, res) => {
    res.json(new Company());
});

app.get("/api/user/company", (req, res) => {
    res.json([new User(), new Company()]);
});

app.listen(8000, () => {
    console.log("listening");
})