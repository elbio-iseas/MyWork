from flask import Flask, url_for, render_template, redirect
from sqlalchemy import ForeignKey
from sqlalchemy.orm import relationship
from sqlalchemy.ext.declarative import declarative_base
from flask_sqlalchemy import SQLAlchemy

Base = declarative_base()
app = Flask(__name__)
app.config['SQLALCHEMY_DATABASE_URI'] = 'sqlite:///mybooks.sqlite3'
app.config['SECRET_KEY'] = "random string"
app.config['SQLALCHEMY_TRACK_MODIFICATIONS'] = False

db = SQLAlchemy(app)


class Authors(db.Model):
  __tablename__ = 'authors'
  id = db.Column(db.Integer, primary_key=True)
  first_name = db.Column(db.String(40))
  last_name = db.Column(db.String(60))
  email = db.Column(db.String(80))
  books = relationship('Books')

  def __init__(self, first_name, last_name, email):
    self.first_name = first_name
    self.last_name = last_name
    self.email = email


class Publishers(db.Model):
  __tablename__ = 'publishers'
  id = db.Column(db.Integer, primary_key=True)
  name = db.Column(db.String(80))
  website = db.Column(db.String(100))
  books = relationship('Books')

  def __init__(self, name, website):
    self.name = name
    self.website = website


class Topics(db.Model):
  __tablename__ = 'topics'
  id = db.Column(db.Integer, primary_key=True)
  name = db.Column(db.String(100))
  books = relationship('Books')

  def __init__(self, name):
    self.name = name


class Subtopics(db.Model):
  __tablename__ = 'subtopics'
  id = db.Column(db.Integer, primary_key=True)
  name = db.Column(db.String(100))
  books = relationship('Books')

  def __init__(self, name):
    self.name = name


class Books(db.Model):
  __tablename__ = 'books'
  id = db.Column(db.Integer, primary_key=True)
  title = db.Column(db.String(100))
  topic = db.Column(db.Integer, ForeignKey('topics.id'))
  subtopic = db.Column(db.Integer, ForeignKey('subtopics.id'))
  isbn = db.Column(db.String(23))
  publisher = db.Column(db.Integer, ForeignKey('publishers.id'))
  author = db.Column(db.Integer, ForeignKey('authors.id'))
  price = db.Column(db.Numeric)

  def __init__(self, title, topic, subtopic, isbn, publisher, author):
    self.title = title
    self.topic = topic
    self.subtopic = subtopic
    self.isbn = isbn
    self.publisher = publisher
    self.author = author


@app.route('/')
def index():
  return render_template('index.html')


# @app.route('/')
# def display_books():
#  return render_template('display_books.html', books=Books.query.all())


if __name__ == '__main__':
  # db.drop_all()
  # db.create_all()
  # db.session.commit()
  app.run(debug=True)
