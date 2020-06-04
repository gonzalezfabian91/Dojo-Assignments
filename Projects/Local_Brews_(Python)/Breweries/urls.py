from django.urls import path
from . import views

urlpatterns = [
    path('<int:userid>',views.dashboard),
    path('brewery/<int:breweryid>',views.brewerypage),
    path('create_review',views.create_review),
    path('api/reviews/<int:breweryid>', views.getBreweryReviews) # should return json response to caller
]