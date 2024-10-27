﻿using Domain.Dtos;
using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class Product
{
    public int Id { get; private set; }
    public string Name { get; private set; } = null!;
    public decimal Price { get; private set; }

    private Product(string name, decimal price)
    {
        Name = name;
        Price = price;
    }

    public static Product Create(string name, decimal price)
    {
        return new Product(name, price);
    }

    public void Update(string name, decimal price)
    {
        Name = name;
        Price = price;
    }
}

