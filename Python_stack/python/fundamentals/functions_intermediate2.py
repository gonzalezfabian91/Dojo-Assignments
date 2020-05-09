#1. Update values in Dictionaries and Lists
x = [ [5,2,3], [10,8,9] ] 
students = [
    {'first_name':  'Michael', 'last_name' : 'Jordan'},
    {'first_name' : 'John', 'last_name' : 'Rosales'},
]
sports_directory = {
    'basketball' : ['Kobe', 'Jordan', 'James', 'Curry'],
    'soccer' : ['Messi', 'Ronaldo', 'Rooney']
}
z = [ {'x': 10, 'y': 20} ]

#a. change the value 10 in x to 15. Once your done, x should now be [[5,2,3],[15,8,9]].
x[1][0] = 15
#b. change the last_name of the first student from 'Jordan' to 'Bryant'
students[0]['last_name'] = 'Bryant'
#c. in the sports_directory, change 'Messi' to 'Andres'
sports_directory['soccer'][0] = 'Andres'
#d. change the value 20 in z to 30
z[0]['y'] = 30

#2 Iterate through a list of dictionaries
students = [
        {'first_name':  'Michael', 'last_name' : 'Jordan'},
        {'first_name' : 'John', 'last_name' : 'Rosales'},
        {'first_name' : 'Mark', 'last_name' : 'Guillen'},
        {'first_name' : 'KB', 'last_name' : 'Tonel'}
    ]
def iterateDictionary(students):
    for item in students:
        toPrint = ""
        for key in item:
            toPrint += f"{key} - {item[key]},"

        print(toPrint)

iterateDictionary(students)

# 3. Get Values from a list of dictionaries
# Create a function iterateDictionary2(key_name, some_list) that, given a list of dictionaries and a key name, 
# the function prints the value stored in that key for each dictionary. For example, 
# iterateDictionary2('first_name', students) should output:
# Michael
# John
# Mark
# KB
# And iterateDictionary2('last_name', students) should output:
# Jordan
# Rosales
# Guillen
# Tonel