from django.db import models

class Shows(models.Model):
    title = models.CharField(max_length=55)
    network = models.CharField(max_length=55)
    release_date = models.DateField()
    description = models.CharField(max_length=150)

    created_at = models.DateTimeField(auto_now_add=True)
    updated_at = models.DateTimeField(auto_now=True)


# Create your models here.
