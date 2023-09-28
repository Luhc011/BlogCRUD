using Dapper.Contrib.Extensions;

namespace Blog.Models;

[Table("[Tag]")]
public class Tag
{
    public int Id { get; set; }
    public string Name { get; set; } = null!;
    public string Slug { get; set; } = null!;
}
