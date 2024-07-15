from datetime import datetime
from flask import Flask
from flask_sqlalchemy import SQLAlchemy

app = Flask(__name__)

app.config['SQLALCHEMY_TRACK_MODIFICATIONS'] = False
app.config['SQLALCHEMY_DATABASE_URI'] = 'sqlite:///db.sqlite3'

db = SQLAlchemy(app)


class User(db.Model):
  id = db.Column(db.Integer, primary_key=True)
  name = db.Column(db.String(50))
  location = db.Column(db.String(50))
  date_created = db.Column(db.DateTime, default=datetime.now)


@app.route('/<name>/<location>')
def index(name, location):
  user = User(name=name, location=location)
  db.session.add(user)
  db.session.commit()

  return '<h1>New User added!</h1>'
