from django.db import models
from Login.models import *


class ReviewManager(models.Manager):
    def validator(self,postData):
        errors = {}
        if len(postData['content'])<10:
            errors['content']='This field must be at least 10 characters!'
        return errors





class Reviews(models.Model):
    content = models.CharField(max_length=500)
    reviewer = models.ForeignKey(user, related_name='review', on_delete=models.CASCADE)
    brewery_id = models.IntegerField()
    rating = models.IntegerField()
    objects=ReviewManager()

    created_at = models.DateTimeField(auto_now_add=True)
    updated_at = models.DateTimeField(auto_now=True)

# Create your models here.
