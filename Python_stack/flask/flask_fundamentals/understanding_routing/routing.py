from flask import Flask
app = Flask(__name__)

@app.route('/')
def hello_world():
    return "Hello World!"

@app.route('/dojo')
def dojo():
    return "Dojo!"

@app.route('/say/<name>')
def name(name):
    return "Hi " + name + "!"

@app.route('/repeat/<int:id>/<name>')
def num(id, name):
    return f"{name} " * id

if __name__ =="__main__":
    app.run(debug=True)