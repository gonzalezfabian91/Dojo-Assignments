from django.db import models

class Dojo(models.Model):
    name = models.CharField(max_length=255)
    city = models.CharField(max_length=255)
    state = models.CharField(max_length=2)
    desc = models.CharField(max_length=255)
    created_at = models.DateTimeField(auto_now_add=True)
    updated_at = models.DateTimeField(auto_now=True)
    # ninja_location = list of Dojos

    def __repr__(self):
        return f"{self.id} - {self.name} {self.city} {self.state}"

class Ninja(models.Model):
    first_name = models.CharField(max_length=255)
    last_name = models.CharField(max_length=255)
    ninja_in_dojo = models.ForeignKey(Dojo, related_name="ninja_location", on_delete=models.CASCADE)
    created_at = models.DateTimeField(auto_now_add=True)
    updated_at = models.DateTimeField(auto_now=True)

    def __repr__(self):
        return f"{self.id} - {self.first_name} {self.last_name}"
# Create your models here.

#dojo.ninja_location