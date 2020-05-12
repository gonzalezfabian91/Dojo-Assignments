from django.shortcuts import render, redirect

def index(request):
    if 'counter' not in request.session:
        request.session['counter'] = 0

    from django.utils.crypto import get_random_string
    unique_id = get_random_string(length=14)
    context = {
        "random_word": unique_id
    }

    return render(request, "index.html", context)

def addcount(request):
    if 'counter' not in request.session:
        request.session['counter'] = 0
    request.session['counter'] += 1

    #request.session.flush()
    
    return redirect('/')

def reset(request):
    request.session.flush()

    return redirect('/')
# Create your views here.