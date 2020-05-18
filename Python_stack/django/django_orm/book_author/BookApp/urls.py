from django.urls import path
from.import views

urlpatterns = [
    path('', views.index),
    path('new_book', views.new_book),
    path('add_book', views.add_book),
    path('new_author', views.new_author),
    path('add_author', views.add_author),
    path('authors', views.authors),
    path('books/<int:books_id>', views.one_book),
    path('authors/<int:author_id>', views.one_author)
]