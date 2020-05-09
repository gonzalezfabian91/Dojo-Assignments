from django.shortcuts import render
from time import gmtime, strftime

def time(request):
    context = {
        "time": strftime("%b %d %Y %H:%M %p", gmtime())
    }
    return render(request, 'index.html', context)


# Create your views here.
