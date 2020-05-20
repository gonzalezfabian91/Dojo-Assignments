from django.urls import path
from. import views

urlpatterns = [
    path('', views.login_reg),
    path('add_user', views.add_user),
    path('login', views.login),
    path('wall', views.logged_in),
    path('logout', views.logout)
]