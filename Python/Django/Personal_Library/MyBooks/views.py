from django.http import HttpResponse
from django.shortcuts import render
from django.template import loader
from .models import Authors, Books, Publishers, SubTopics, Topics


def index(request):
  mybooks = Books.objects.all().values()
  template = loader.get_template('index.html') 
  return HttpResponse(template.render())
  
  
def add(request):
  template = loader.get_template('add.html')
  return HttpResponse(template.render())


def delete(request):
  template = loader.get_template('delete.html')
  return HttpResponse(template.render())


def edit(request):  
  template = loader.get_template('edit.html')
  return HttpResponse(template.render())
  

def find(request):  
  template = loader.get_template('find.html')
  return HttpResponse(template.render())

  
def list(request):
  mybooks = Books.objects.all().values()
  template = loader.get_template('list.html')
  context = { 'mybooks': mybooks, }
  return HttpResponse(template.render(context, request))
