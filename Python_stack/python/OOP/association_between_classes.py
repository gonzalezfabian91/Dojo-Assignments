class User:
    def __init__(self, name):
        self.name = name
        self.account = BankAccount(int_rate = 0.04, balance = 0)

    def make_deposit(self, amount):
        self.account.deposit(200)
        return self

    def make_withdrawl(self, amount):
        self.account.withdraw(100)
        return self

    def transfer_money(self, receiver, amount):
        self.account -= amount
        receiver.account += amount
        print(f"{self.name} transfered money to {receiver.name} of the ammount of {amount}")
        return self

    def __repr__(self):
        return f"Name: {self.name}\nAccount Balance: {self.account}"

class BankAccount:
    def __init__(self, int_rate, balance):
        self.int_rate = int_rate
        self.balance = balance

    def deposit(self, amount):
        self.balance += amount
        return self

    def withdraw(self, amount):
        if self.balance < amount: 
            print(f"Insufficient funds: Chargin a $5 fee")
            self.balance -= 5
            return self
        self.balance -= amount
        return self

    def display_account_info(self):
        print(f"Balance: {self.balance}")

    def yield_interest(self):
        if self.balance > 0:
            self.balance += self.balance * self.int_rate
        return self

fabian = User("Fabian")
elena = User("Elena")
clarisa = User("Clarisa")