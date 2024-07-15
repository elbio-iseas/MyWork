from flask import Flask

app = Flask(__name__)

@app.route("/")
def home():
    return '<h1>Home page</h1>'

@app.route("/about")
def about():
    return '<h1>About us page</h1>'

@app.route("/contact")
def contact():
    return '<h1>Contact page</h1>'

if __name__ == '__main__':
    app.run(debug=True, port=5000)
