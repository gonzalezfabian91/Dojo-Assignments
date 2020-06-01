from django.db import models
from UserApp.models import *

class BookReview(models.Model):
    title = models.CharField(max_length=50)
    author = models.CharField(max_length=50)
    description = models.TextField()
    rating = models.IntegerField()
    reviewed_by = models.ManyToManyField(User, related_name="reviewed_book")
    reviewer = models.ForeignKey(User, related_name="reviews_left", on_delete=models.CASCADE)

    created_at = models.DateTimeField(auto_now_add=True)
    updated_at = models.DateTimeField(auto_now=True)
# Create your models here.
