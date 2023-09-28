﻿using Dapper.Contrib.Extensions;

namespace Blog.Models;

[Table("[User]")]
public class User
{
    public User()
        => Roles = new List<Role>();

    public int Id { get; set; }
    public string Name { get; set; } = null!;
    public string Email { get; set; } = null!;
    public string PasswordHash { get; set; } = null!;
    public string Bio { get; set; } = null!;
    public string Image { get; set; } = null!;
    public string Slug { get; set; } = null!;

    [Write(false)]
    public List<Role> Roles { get; set; } = null!;
}
