from django.urls import path
from . import views


urlpatterns = [
path('',views.reglog),
path ('adduser',views.adduser),
path('login',views.login),
path('success/<int:userid>',views.success),
path('logout',views.logout)
]

