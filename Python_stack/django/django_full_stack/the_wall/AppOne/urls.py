from django.urls import path
from. import views

urlpatterns = [
    path('', views.login_reg),
    path('add_user', views.add_user),
    path('login', views.login),
    path('wall', views.logged_in),
    path('logout', views.logout),
    path('create_post', views.create_post),
    path('create_comment', views.create_comment),
    path('<int:post_id>/delete_post', views.delete_post),
    path('<int:comment_id>/delete_comment', views.delete_comment)
]