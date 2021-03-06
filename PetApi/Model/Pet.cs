﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Threading.Tasks;

namespace PetApi.Model
{
    public enum Animal
    {
        Dog,
        Cat
    }

    public class Pet : IEquatable<Pet> 
    {
        public Pet(string name, Animal animal, string color, double price)
        {
            Name = name;
            Type = animal;
            Color = color;
            Price = price;
        }

        public Pet()
        { 
        }

        public string Name { get; set; }
        public Animal Type { get; set; }
        public string Color { get; set; }
        public double Price { get; set; }

        public bool Equals(Pet pet)
        {
            if (pet == null || this == null)
            {
                return false;
            }

            if (pet.GetType() != this.GetType())
            {
                return false;
            }

            return Name == pet.Name && Type == pet.Type && Color == pet.Color && Price == pet.Price;
        }
    }
}
