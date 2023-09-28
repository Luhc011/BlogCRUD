﻿namespace Blog.Models;
using Dapper.Contrib.Extensions;

[Table("Category")]
public class Category
{
    public int Id { get; set; }
    public string Name { get; set; } = null!;
    public string Slug { get; set; } = null!;
}
