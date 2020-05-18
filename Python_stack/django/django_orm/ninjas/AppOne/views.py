from django.shortcuts import render, redirect
from .models import *

def index(request):
    context = {
        "all_dojos": Dojo.objects.all(),
        "all_ninjas": Ninja.objects.all(),
    }
    return render(request, "index.html", context)

def new_dojo(request):
    new_dojo = Dojo.objects.create(
        name= request.POST['name'],
        city= request.POST['city'],
        state= request.POST['state']
    )
    return redirect("/")

def new_ninja(request):
    # print("ninja function**********")
    # print(request.POST)
    new_ninja = Ninja.objects.create(
        first_name= request.POST['first_name'],
        last_name= request.POST['last_name'],
        ninja_in_dojo_id= request.POST['ninja_in_dojo_id']
    )
    return redirect("/")
# Create your views here.
