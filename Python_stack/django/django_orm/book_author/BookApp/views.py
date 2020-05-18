from django.shortcuts import render, redirect
from .models import *

def index(request):
    context = {
        "list_of_books": Book.objects.all()
    }
    return render(request, 'index.html', context)

def new_book(request):
    new_book = Book.objects.create(
        name= request.POST['name'],
        desc= request.POST['desc']
    )
    return redirect("/")

def one_book(request, books_id):
    context = {
        "one_book": Book.objects.get(id=books_id),
        "all_authors": Author.objects.all()
    }
    return render(request, 'onebook.html', context)

def add_author(request):
    add_author = books.authors.add(
        author= request.POST['author']
    )
    return redirect("/books/<int:books_id>")


def authors(request):
    context = {
        "list_of_authors": Author.objects.all()
    }
    return render(request, 'authors.html', context)

def one_author(request, author_id):
    context = {
        "one_author": Author.objects.get(id=author_id),
        "all_books": Book.objects.all() 
    }
    return render(request, 'oneauthor.html', context)

def new_author(request):
    new_author = Author.objects.create(
        first_name= request.POST['first_name'],
        last_name= request.POST['last_name'],
        notes= request.POST['notes']
    )
    return redirect("/authors")

def add_book(request):
    add_book = one_author.books.add(
        books= request.POST['books']
    )
    return redirect("/authors/<int:author_id>")

# Create your views here.
