from django.shortcuts import render, redirect
from .models import *

def index(request):
    print("index function********")
    context = {
        "list_of_users": Users.objects.all()
    }
    return render(request, 'index.html', context)

def new_user(request):
    print("user function*********")
    print(request.POST)
    new_user = Users.objects.create(
        first_name= request.POST['first_name'],
        last_name= request.POST['last_name'],
        email_address= request.POST['email_address'],
        age= request.POST['age']
    )
    return redirect("/")
# Create your views here.
