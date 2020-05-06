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


fabian = BankAccount(0.04, 0)
yadira = BankAccount(0.05, 0)

fabian.deposit(100).deposit(200).deposit(50).withdraw(300).yield_interest().display_account_info()

yadira.deposit(500).deposit(500).withdraw(200).withdraw(200).withdraw(150).withdraw(100).yield_interest().display_account_info()