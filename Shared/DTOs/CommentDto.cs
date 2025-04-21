
// Shared/DTOs/CommentDto.cs
namespace Shared.DTOs;

public class CommentDto
{
    public Guid PostId { get; set; }
    public string Author { get; set; } = "";
    public string Text { get; set; } = "";
}