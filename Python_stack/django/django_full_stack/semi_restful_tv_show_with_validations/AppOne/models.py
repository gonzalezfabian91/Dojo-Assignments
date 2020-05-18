from django.db import models


class ShowsManager(models.Manager):
    def show_validator(self, postData):
        errors = {}

        if len(postData['title']) < 2:
            errors['title'] = "Your title entry must be at least 2 Characters."
        if len(postData['network']) < 2:
            errors['network'] = "Your network entry must be at least 3 Characters."
        if len(postData['description']) < 10:
            errors['description'] = "Your description entry must be at least 10 Characters."
        return errors

class Shows(models.Model):
    title = models.CharField(max_length=55)
    network = models.CharField(max_length=55)
    release_date = models.DateField()
    description = models.CharField(max_length=150)

    created_at = models.DateTimeField(auto_now_add=True)
    updated_at = models.DateTimeField(auto_now=True)

    objects = ShowsManager()


# Create your models here.
