from django.shortcuts import render, redirect, HttpResponse
from .models import *
from django.contrib import messages
import bcrypt

def reglog(request):
    return render(request,'reglog.html')

def adduser(request):
    if request.method=='POST':
        errors=user.objects.validator(request.POST)
        if len(errors)>0:
            for key, value in errors.items():
                messages.error(request, value,extra_tags=key)
            return redirect('/')
        password = request.POST['password']
        pw_hash = bcrypt.hashpw(password.encode(), bcrypt.gensalt()).decode() 
        print(pw_hash)
        user1=user.objects.create(
        firstname=request.POST['firstname'],
        lastname=request.POST['lastname'],
        birthday=request.POST['birthday'],
        email=request.POST['email'].lower(),
        password=pw_hash
        )
    return redirect('/')

def login(request):
    if request.method=='POST':
        User = user.objects.filter(email=request.POST['loginemail'].lower())
        if User: 
            logged_user = User[0] 
        
            if bcrypt.checkpw(request.POST['loginpassword'].encode(), logged_user.password.encode()):
                request.session['userid'] = logged_user.id
                return redirect(f'/success/{logged_user.id}')
        messages.error(request, "Invalid login credentials",extra_tags="login")
    return redirect("/")

def success(request,userid):
    return redirect(f'/dashboard/{userid}')

def logout(request):
        request.session.flush()
        return redirect('/')

