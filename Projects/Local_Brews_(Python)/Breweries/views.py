from django.shortcuts import render, redirect, HttpResponse
from .models import *
from django.contrib import messages
from django.http import JsonResponse

def dashboard(request,userid):
    context={
        'user_info':user.objects.get(id=userid),
        'all_Reviews': Reviews.objects.all().order_by("-id")

    }
    
    if 'userid'not in request.session:
        return redirect('/')
    elif request.session['userid']==userid:
        return render(request,'dashboard.html',context)
    return redirect('/')
# Create your views here.


def brewerypage(request,breweryid):
    if 'userid'not in request.session:
        return redirect('/')
    context={
        'breweryid':breweryid
    }
    return render (request,'one_brewery.html',context)

def create_review(request):
    print (request.POST)
    errors = Reviews.objects.validator(request.POST)
    if len(errors) > 0:
        for tags, value in errors.items():
            messages.error(request, value, extra_tags=tags)
        return JsonResponse({"status": "error"})
    userid=request.session['userid']
    user1=user.objects.get(id=userid)
    new_review = Reviews.objects.create(
        content = request.POST['content'],
        rating = request.POST['review'],
        brewery_id= request.POST['brewery_id'],
        reviewer= user1
    )
    return JsonResponse({"status": "success", "review_id": new_review.id})

def getBreweryReviews(request,breweryid):
    brewery_review = Reviews.objects.filter(brewery_id=breweryid).values() # or simply .values() to get all fields
# important: convert the QuerySet to a list object
    return JsonResponse(list(brewery_review), safe=False)


# def one_review()
