from django.urls import path
from . import views

urlpatterns = [
    path('', views.books),
    path('/add', views.add_review_and_book),
    path('/<int:book_id>', views.one_book),
]