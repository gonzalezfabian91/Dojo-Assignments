from django.urls import path
from.import views

urlpatterns = [
    path('', views.index),
    path('addtocount', views.addcount),
    path('resetattempt', views.reset)
]