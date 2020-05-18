from django.shortcuts import render, redirect
from .models import *

def index(request):
    
    return render(request, "index.html")

def logged_in(request):

    return render(request, "logged_in.html")


# Create your views here.
