from django.db import models
import bcrypt, re

class UserManager(models.Manager):
    def user_validator(self, postData):
        errors = {}

        if len(postData['first_name']) < 2:
            errors['first_name'] = "Your First Name entry must be at least 2 Characters."
        if len(postData['last_name']) < 2:
            errors['last_name'] = "Your Last Name entry must be at least 2 Characters."
        EMAIL_REGEX = re.compile(r'^[a-zA-Z0-9.+_-]+@[a-zA-Z0-9._-]+\.[a-zA-Z]+$')
        if not EMAIL_REGEX.match(postData['email']):
            errors['email'] = "Invalid email address."
        elif len(User.objects.filter(email=postData['email'])) > 0:
            errors['email'] = "This email is already being used."
        if len(postData['password']) < 8:
            errors['password'] = "Your Password must be at least 8 Characters."
        if postData['password'] != postData['confpw']:
            errors['confpw'] = "Passwords do not match."
        return errors

class User(models.Model):
    first_name = models.CharField(max_length=55)
    last_name = models.CharField(max_length=55)
    email = models.CharField(max_length=55)
    password = models.CharField(max_length=55)
    confpw = models.CharField(max_length=55)

    created_at = models.DateTimeField(auto_now_add=True)
    updated_at = models.DateTimeField(auto_now=True)

    objects = UserManager()


# Create your models here.
