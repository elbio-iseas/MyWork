from flask import Flask, render_template, redirect, request
from forms import SignUpForm

app = Flask(__name__)
app.config['SECRET_KEY'] = 'thecodex'


@app.route('/')
def home():
  return 'Hello World with Codex!'


@app.route('/about')
def about():
  return 'The About page'


@app.route('/blog')
def blog():
  posts = [{'title': 'Technology in 2019'}, {'author': 'Elbio'},
           {'title': 'Expansion of oil in Russia'}, {'author': 'Bob'}]
  return render_template('blog.html', author="Elbio", sunny=True, posts=posts)


@app.route('/blog/<string:blog_id>')
def blogpost(blog_id):
  return 'This is blog post number ' + str(blog_id)


@app.route('/signup', methods=['GET', 'POST'])
def signup():
  form = SignUpForm()
  if form.is_submitted():
     result = request.form
     return render_template('user.html', result=result)
  return render_template('signup.html', form=form)


if __name__ == '__main__':
  app.debug = True
  app.run()
