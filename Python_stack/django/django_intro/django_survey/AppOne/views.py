from django.shortcuts import render, HttpResponse

def index(request):
    return render(request, "index.html")

def form_submission(request):
    student_from_form = request.POST['student']
    location_from_form = request.POST['location']
    language_from_form = request.POST['language']
    comment_from_form = request.POST['comment']
    
    print(request.POST['student'])
    context = {
        "from_form": student_from_form,
        "location": location_from_form,
        "stack": language_from_form,
        "comment": comment_from_form
    }
    return render(request, 'submission.html', context)

# Create your views here.
