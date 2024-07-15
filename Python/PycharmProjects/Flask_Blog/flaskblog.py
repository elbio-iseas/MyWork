from flask import Flask, render_template, url_for
app = Flask(__name__)
app.config


posts
 = [
    {
        'author': 'Corey Schafer',
        'title': 'Blog Post 1',
        'content': 'First Post 1',
        'date_posted': 'April 20, 2018'
    },
    {
        'author': 'Jane Doe',
        'title': 'Blog Post 2',
        'content': 'Second post content',
        'date_posted': 'April 21, 2018'
    }
 ]
















@app.route("/")
@app.route("/home")
def home():
    return "<h1>Home Page</h1>"


@app.route("/about")
def about():
    return "<h1>About Page</h1>"


@app.route("/register")
def register():
    return "<h1>Registration Page</h1>"


if __name__ == '__main__':
    app.run(debug=True)

