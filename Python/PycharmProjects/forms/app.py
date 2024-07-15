from flask import Flask, render_template

app = Flask(__name__)
app.config['SECRET_KEY'] = 'learning wtf in Python'


@app.route('/')
def home():
  return 'Hello World'


@app.route('/about')
def about():
  return 'The About Page'

@app.route('/blog')
def blog():
  posts = [{'title': 'Technology in 2019', 'author': 'Avi'},
           {'title': 'Expansion of oil in Russia', 'author': 'Rasputin'}                                       '}]
  return render_template('blog.html', author="Bob", )

@app.route('/blog/<string:blog_id>')
def blogpost(blog_id):
  return 'This is blog post number '+ blog_id

@app.route('/signup')
def signup():
  form = SignUpForm()
  return render_template('signup.html', form=form)


if __name__ == '__main__':
  app.run()





