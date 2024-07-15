from django.db import models

# Create your models here.

class Authors(models.Model):
  first_name = models.CharField(max_length= 40),
  last_name = models.CharField(max_length=60),
  email = models.EmailField(max_length=100)  
  
  class Meta:
    db_table = 'authors'
    
class Publishers(models.Model):
  name = models.CharField(max_length=80),
  website = models.CharField(max_length=100)
    
  class Meta:
    db_table = 'publishers'
    
class Topics(models.Model):
  name = models.CharField(max_length=100)

  class Meta:
    db_table = 'topics'

class SubTopics(models.Model):
  name = models.CharField(max_length=100)

  class Meta:
    db_table = 'subtopics'

class Books(models.Model):
  title = models.CharField(max_length=100),
  topic = models.ForeignKey(Topics, on_delete = models.CASCADE)
  subtopic = models.ForeignKey(SubTopics, on_delete = models.CASCADE)
  isbn = models.CharField(max_length=23)
  publisher = models.ForeignKey(Publishers, on_delete = models.CASCADE)
  author = models.ForeignKey(Authors, on_delete = models.CASCADE)
  price = models.IntegerField
  
  class Meta:
    db_table = 'books'
    
    
  
  
    
    
    
    