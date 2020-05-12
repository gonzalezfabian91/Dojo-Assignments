from django.shortcuts import render, HttpResponse, redirect
import random

def index(request):
    if 'gold' not in request.session or 'activities' not in request.session:
        request.session['gold'] = 0
        request.session['activities'] = []

    activities = request.session['activities']
    context = {
        "earned": activities
    }
    
    return render(request, "index.html", context)

def process_money(request):
    if request.POST['gold'] == 'farm':
        request.session['earnedGold'] = random.randint(10,20)
        request.session['gold'] += request.session['earnedGold']
        request.session['activities'].append(f"You have earned {request.session['earnedGold']} gold from the farm!!")
    if request.POST['gold'] == 'cave':
        request.session['earnedGold'] = random.randint(5,10)
        request.session['gold'] += request.session['earnedGold']
        request.session['activities'].append(f"You have earned {request.session['earnedGold']} gold from the cave!!")
    if request.POST['gold'] == 'house':
        request.session['earnedGold'] = random.randint(2,5)
        request.session['gold'] += request.session['earnedGold']
        request.session['activities'].append(f"You have earned {request.session['earnedGold']} gold from the house!!")
    if request.POST['gold'] == 'casino':
        request.session['earnedGold'] = random.randint(-50,50)
        request.session['gold'] += request.session['earnedGold']
        request.session['activities'].append(f"You have earned {request.session['earnedGold']} gold from the casino!!")
    #print(request.session['activities'])
    
    
    
    return redirect("/")
# Create your views here.