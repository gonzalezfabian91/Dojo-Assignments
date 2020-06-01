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

class CommentManager(models.Manager):
    def comment_validator(self, postData):
        errors = {}

        if len(postData['content']) == 0:
            errors['content'] = "Cannot leave comment box empty."

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

class Post(models.Model):
    content = models.CharField(max_length=500)
    poster = models.ForeignKey(User, related_name='posts', on_delete=models.CASCADE)

    created_at = models.DateTimeField(auto_now_add=True)
    updated_at = models.DateTimeField(auto_now=True)

class Comment(models.Model):
    content = models.CharField(max_length=500)
    commentor = models.ForeignKey(User, related_name='comments', on_delete=models.CASCADE)
    post = models.ForeignKey(Post, related_name='comments', on_delete=models.CASCADE)

    created_at = models.DateTimeField(auto_now_add=True)
    updated_at = models.DateTimeField(auto_now=True)

    objects = CommentManager()

# Create your models here.
