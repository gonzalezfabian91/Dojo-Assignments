class User:
    def __init__(self, name,):
        self.name = name
        self.account_balance = 0

    def make_deposit(self, amount):
        self.account_balance += amount
        return self

    def make_withdrawl(self, amount):
        self.account_balance -= amount
        return self

    def transfer_money(self, receiver, amount):
        self.account_balance -= amount
        receiver.account_balance += amount
        print(f"{self.name} transfered money to {receiver.name} of the ammount of {amount}")
        return self

    def __repr__(self):
        return f"Name: {self.name}\nAccount Balance: {self.account_balance}"



fabian = User("Fabian")
elena = User("Elena")
clarisa = User("Clarisa")

print(fabian)
print(elena)
print(clarisa)

fabian.make_deposit(200).make_deposit(300).make_deposit(100)
fabian.make_withdrawl(200)
print(fabian)

elena.make_deposit(500).make_deposit(500)
elena.make_withdrawl(200).make_withdrawl(100)
print(elena)


clarisa.make_deposit(1000)
clarisa.make_withdrawl(200).make_withdrawl(200).make_withdrawl(200)#
print(clarisa)


fabian.transfer_money(clarisa, 200)
print(fabian)
print(clarisa)


