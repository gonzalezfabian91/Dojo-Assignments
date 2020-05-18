from django.db import models

class Book(models.Model):
    name = models.CharField(max_length=50)
    desc = models.CharField(max_length=200)
    #authors = authors list
    created_at = models.DateTimeField(auto_now_add=True)
    updated_at = models.DateTimeField(auto_now=True)

    def __repr__(self):
        return f"{self.id} - {self.name}"

class Author(models.Model):
    first_name = models.CharField(max_length=50)
    last_name = models.CharField(max_length=50)
    notes = models.CharField(max_length=50)
    books = models.ManyToManyField(Book, related_name="authors")

    created_at = models.DateTimeField(auto_now_add=True)
    updated_at = models.DateTimeField(auto_now=True)

    def __repr__(self):
        return f"{self.id} - {self.first_name} {self.last_name}"

# Create your models here.
