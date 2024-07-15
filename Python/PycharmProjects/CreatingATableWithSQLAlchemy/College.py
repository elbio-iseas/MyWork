# how to create a table with SQLAlchemy
from sqlalchemy import MetaData, create_engine, Table, Column, Integer, String
meta = MetaData()
engine = create_engine('sqlite:///college.db', echo=True)

students = Table(
  'students', meta,
  Column('id', Integer, primary_key=True),
  Column('firstname', String),
  Column('lastname', String),
  )
meta.create_all(engine)
