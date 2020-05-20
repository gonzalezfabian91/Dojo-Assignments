from django.shortcuts import render, redirect
from django.contrib import messages
import bcrypt
from .models import *

def login_reg(request):
    return render(request, "login_reg.html")

def add_user(request):
    errors = User.objects.user_validator(request.POST)

    if len(errors) > 0:
        for key, value in errors.items():
            messages.error(request, value, extra_tags=key)
        return redirect("/")

    password = request.POST['password']
    pw_hash = bcrypt.hashpw(password.encode(), bcrypt.gensalt()).decode()
    print(pw_hash)
    confpw = request.POST['confpw']
    confpw_hash = bcrypt.hashpw(password.encode(), bcrypt.gensalt()).decode()
    print(confpw_hash)

    new_user = User.objects.create(
        first_name = request.POST['first_name'],
        last_name = request.POST['last_name'],
        email = request.POST['email'],
        password = pw_hash,
        confpw = confpw_hash
    )
    return redirect("/wall")

def login(request):
    if request.method == 'POST':

        user = User.objects.filter(email=request.POST['email'].lower())
        if user:
            logged_user = user[0]
            if bcrypt.checkpw(request.POST['password'].encode(), logged_user.password.encode()):
                request.session['userid'] = logged_user.id
                return redirect("/wall")
        messages.error(request, "Invalid login credentials", extra_tags="login")
    return redirect("/")

def logged_in(request):
    if 'userid' in request.session:

        context = {
            "user": User.objects.get(id=request.session['userid'])
        }
        return render(request, "wall.html", context)

def logout(request):
    request.session.flush()
    return redirect('/')
# Create your views here.
