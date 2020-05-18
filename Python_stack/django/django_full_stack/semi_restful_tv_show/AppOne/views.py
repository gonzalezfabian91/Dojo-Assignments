from django.shortcuts import render, redirect
from .models import *

def list_shows(request):
    context = {
        "all_shows": Shows.objects.all()
    }
    return render(request, "list_shows.html", context)

def new_show(request):
    if request.method =="GET":
        return render(request, "new_show.html")
    elif request.method == "POST":
        new_show = Shows.objects.create(
            title= request.POST['title'],
            network= request.POST['network'],
            release_date= request.POST['release_date'],
            description= request.POST['description']
        )
        return redirect(f"/shows/{new_show.id}")
    else:
        return redirect('/shows')

def one_show(request, show_id):
    context = {
        "one_show": Shows.objects.get(id=show_id)
    }
    return render(request, "one_show.html", context)

def edit_show(request, show_id):
    if request.method == "GET":
        context = {
            "show_to_edit": Shows.objects.get(id=show_id)
        }
        return render(request, "edit_show.html", context)
    elif request.method == "POST":
        to_edit = Shows.objects.get(id=show_id)
        to_edit.title = request.POST['title']
        to_edit.network = request.POST['network']
        to_edit.release_date = request.POST['release_date']
        to_edit.description = request.POST['description']
        to_edit.save()
        return redirect(f"/shows/{show_id}")
    else:
        return redirect(f"/shows/{show_id}")

def delete_show(request, show_id):
    to_delete = Shows.objects.get(id=show_id)
    to_delete.delete()
    return redirect("/shows")