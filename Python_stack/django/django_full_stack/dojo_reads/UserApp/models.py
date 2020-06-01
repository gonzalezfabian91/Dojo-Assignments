from django.db import models
import re

class UserManager(models.Manager):
    def registration_val(sef, postData):
        EMAIL_REGEX = re.compile(r'^([a-zA-Z0-9_\-\.]+)@([a-zA-Z0-9_\-\.]+)\.([a-zA-Z]{2,5})$')
        PASS_REGEX = re.compile(r"^(?=.*[A-Za-z])(?=.*\d)(?=.*[@$!%*#?&])[A-Za-z\d@$;!%*#?&]{8,16}$")

        errors = {}

        #validation for first name
        if len(postData['first_name']) == 0:
            errors['first_name'] = "First Name field cannot be left blank."
        elif len(postData['first_name']) < 2:
            errors['first_name'] = "First Name must be atleast 2 characters in length."
        elif len(postData['first_name']) > 20:
            errors['first_name'] = "First Name cannot be longer than 20 characters."

        #validation for last name
        if len(postData['last_name']) == 0:
            errors['last_name'] = "Last Name field cannor be left blank."
        elif len(postData['last_name']) < 2:
            errors['last_name'] = "Last Name must be atleast 2 characters in length."
        elif len(postData['last_name']) > 20:
            errors['last_name'] = "Last Name cannot be longer than 20 characters."

        #validation for email
        user = User.objects.filter(email=postData['email'])
        if len(postData['email']) == 0:
            errors['email'] = "Email cannot be left blank."
        elif len(postData['email']) < 6:
            errors['email'] = "Invalid email address."
        elif not EMAIL_REGEX.match(postData['email']):
            errors['email'] = "Invalid email address."
        elif user:
            errors["email"] = "Please use another email address."

        #validation for password
        if len(postData['password']) == 0:
            errors['password'] = "Password cannot be left blank."
        elif len(postData['password']) < 8:
            errors['password'] = "Password must be atlest 8 characters in length."
        elif not PASS_REGEX.match(postData['password']):
            errors['password'] = "Password must contain minimum of 1 uppercase, 1 lowercase, 1 number, and 1 special character."
        elif postData['password'] != postData['confpw']:
            errors['password'] = "Passwords do not match."

        return errors

class User(models.Model):
    first_name = models.CharField(max_length=50)
    last_name = models.CharField(max_length=50)
    email = models.CharField(max_length=50)
    password = models.CharField(max_length=50)
    confpw = models.CharField(max_length=50)

    created_at = models.DateTimeField(auto_now_add=True)
    updated_at = models.DateTimeField(auto_now=True)

    objects = UserManager()
# Create your models here.
