﻿namespace Catalog.Api.Models;

public class Product
{
    public Guid Id { get; set; }
    public string Name { get; set; } = default!;
    public List<string> Category { get; set; } = new List<string>();
    public string Description { get; set; } = default!;
    public string ImagemFile { get; set; } = default!;
    public decimal Price { get; set; }
}
