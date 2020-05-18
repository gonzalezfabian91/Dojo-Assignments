from django.urls import path
from . import views

urlpatterns = [
    path('', views.list_shows),
    path('new', views.new_show),
    path('<int:show_id>', views.one_show),
    path('<int:show_id>/edit', views.edit_show),
    path('<int:show_id>/delete', views.delete_show
    )
]