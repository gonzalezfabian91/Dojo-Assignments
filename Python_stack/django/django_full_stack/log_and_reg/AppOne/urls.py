from django.urls import path
from. import views

urlpatterns = [
    path('', views.index),
    path('add_user', views.add_user),
    path('login', views.login),
    path('success', views.logged_in),
    path('logout', views.logout)
]