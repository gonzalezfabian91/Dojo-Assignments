from django.shortcuts import render, HttpResponse, redirect
import random

def index(request):
    if 'gold' not in request.session:
        request.session['gold'] = 0
    return render(request, "index.html")
def process_money(request):
    activities = []
    if request.POST['gold'] == 'farm':
        request.session['earnedGold'] = random.randint(10,20)
        request.session['gold'] += request.session['earnedGold']
        activities.append("Earned {} gold from the farm!")
    if request.POST['gold'] == 'cave':
        request.session['earnedGold'] = random.randint(5,10)
        request.session['gold'] += request.session['earnedGold']
    if request.POST['gold'] == 'house':
        request.session['earnedGold'] = random.randint(2,5)
        request.session['gold'] += request.session['earnedGold']
    if request.POST['gold'] == 'casino':
        request.session['earnedGold'] = random.randint(-50,50)
        request.session['gold'] += request.session['earnedGold']
    

    
    
    return redirect("/")
# Create your views here.
