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

        user = User.objects.filter(email=request.POST['loginemail'].lower())
        if user:
            logged_user = user[0]
            if bcrypt.checkpw(request.POST['loginpassword'].encode(), logged_user.password.encode()):
                request.session['user_id'] = logged_user.id
                return redirect("/wall")
        messages.error(request, "Invalid login credentials", extra_tags="loginemail")
    return redirect("/")

def logged_in(request):
    if 'user_id' not in request.session:
        return redirect('/')
    if 'user_id' in request.session:

        context = {
            "user": User.objects.get(id=request.session['user_id']),
            "all_posts": Post.objects.all().order_by('-created_at'),
            "comments": Comment.objects.all()
            #"orderd_post": Post.objects.all().order_by('-created_at')
        }
        return render(request, "wall.html", context)

def create_post(request):
    if 'user_id' not in request.session:
        return redirect('/')

    user = User.objects.get(id=request.session['user_id'])

    new_post = Post.objects.create(
        content = request.POST['content'],
        poster = user
    )
    return redirect('/wall')

def delete_post(request, post_id):
    delete_post = Post.objects.get(id=post_id)
    delete_post.delete()
    return redirect('/wall')

def create_comment(request):
    errors = Comment.objects.comment_validator(request.POST)

    if len(errors) > 0:
        for key, value in errors.items():
            messages.error(request, value, extra_tags=key)
        return redirect('/wall')

    if 'user_id' not in request.session:
        return redirect('/')

    post_to_comment = Post.objects.get(id=request.POST['post_id'])
    user_who_is_commenting = User.objects.get(id=request.session['user_id'])

    new_comment = Comment.objects.create(
        content = request.POST['content'],
        commentor = user_who_is_commenting,
        post = post_to_comment
    )
    return redirect('/wall')

def delete_comment(request, comment_id):
    delete_comment = Comment.objects.get(id=comment_id)
    delete_comment.delete()
    return redirect('/wall')

def logout(request):
    request.session.flush()
    return redirect('/')
#Create your views here.
