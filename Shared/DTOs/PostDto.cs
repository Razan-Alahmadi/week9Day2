// Shared/DTOs/PostDto.cs
namespace Shared.DTOs;

public class PostDto
{
    public Guid Id { get; set; }
    public string Title { get; set; } = "";
    public string Content { get; set; } = "";
}

