from django.shortcuts import render, redirect
from django.db.models import Avg
from django.contrib import messages
from .models import *

def books(request):
    if "user_id" not in request.session:
        return redirect("/")

    if request.method == "GET":
        context = {
            "user": User.objects.get(id=request.session['user_id']),
            "all_books": BookReview.objects.annotate(avg_rating=Avg("rating"))
        }
        return render(request, "books.html", context)

    if request.method == "POST":

        BookReview.objects.create(
            title = request.POST['title'],
            author = request.POST['author'],
            description = request.POST['description'],
            rating = request.POST['rating'],
            reviewer_id = request.session['user_id']
        )
        return redirect('/books')

def add_review_and_book(request):
    if "user_id" not in request.session:
        return redirect('/')
    if request.method == "GET":

        # b = BookReview.objects.all()

        # context = {
        #     "all_authors": b.author.all()
        # }
        return render(request, "add_book.html")
    return redirect('/add')

def one_book(request):
    return redirect('/<int:book_id>')
# Create your views here.
