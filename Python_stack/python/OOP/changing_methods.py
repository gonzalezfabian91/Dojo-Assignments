class User:
    def __init__(self, name):
        self.name = name
        self.account_balance = 0

    def make_deposit(self,amount):
        self.account_balance += amount
        return self

    def __repr__(self):
        return f"Name: {self.name}\nAccount Balance: {self.account_balance}"

fabian = User("Fabian")

fabian.make_deposit(100).make_deposit(200).make_deposit(300).make_deposit(200)
print(fabian)