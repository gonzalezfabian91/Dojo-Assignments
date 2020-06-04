from django.db import models
from django.shortcuts import render, redirect
import bcrypt, re
from datetime import date
from datetime import datetime,timedelta
from django.utils import timezone





class usermanager(models.Manager):
    def validator(self,postdata):
        today = date.today()
        errors = {}
        if len(postdata['firstname'])==0:
            errors['firstname']='This field cannot not be blank!'
        elif len(postdata['firstname'])<2:
            errors['firstname']='This field must be at least 2 characters!'
        elif len(postdata['firstname'])>30:
            errors['firstname']='This field must be less then 30 characters!'

        if len(postdata['lastname'])==0:
            errors['lastname']='This field cannot not be blank!'
        elif len(postdata['lastname'])<2:
            errors['lastname']='This field must be at least 2 characters!'
        elif len(postdata['lastname'])>30:
            errors['lastname']='This field must be less then 30 characters!'

        try:
            bdate = datetime.strptime((postdata['birthday']), '%Y-%m-%d')
            if (today.year - bdate.year - ((today.month, today.day) < (bdate.month, bdate.day)))<21:
                errors['birthday'] = "You must be 21 to access!"
        except:
            errors['birthday'] = 'Invaild entry'

        EMAIL_REGEX = re.compile(r'^[a-zA-Z0-9.+_-]+@[a-zA-Z0-9._-]+\.[a-zA-Z]+$')
        if not EMAIL_REGEX.match(postdata['email']):    
            errors['email'] = "Invalid email address!"
        elif len(user.objects.filter(email=postdata["email"]))>0:
            errors['email']='Email already regestered'
        elif len(postdata['email'])>30:
            errors['email']='This field must be less then 50 characters!'

        PW_REGEX = re.compile(r"^(?=.*[a-z])(?=.*[A-Z])(?=.*[0-9])(?=.*[!@#\$%\^&\*])(?=.{7,20})");
        if len(postdata['password'])==0:
            errors['password']='Password must not be left blank!'
        elif len(postdata['password'])>30:
            errors['password']='This field must be less then 20 characters!'
        elif not PW_REGEX.match(postdata['password']):
            errors['password']='Password must conatin at least 1 lowercase letter, 1 uppercase letter, 1 number, 1 of these characters[!@#$%^&*]and be 7-20 characters long!'
        elif not ((postdata['password'])==(postdata['confirmpassword'])):
            errors['password']='Passwords entered do no match!'
            
        
        return errors
    

    

class user(models.Model):
    firstname=models.CharField(max_length=30)
    lastname=models.CharField(max_length=30)
    birthday=models.DateField()
    email=models.CharField(max_length=50)
    password=models.CharField(max_length=100)
    objects=usermanager()

    created_at = models.DateTimeField(auto_now_add = True)
    updated_at = models.DateTimeField(auto_now = True)





# Create your models here.
