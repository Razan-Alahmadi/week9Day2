﻿// Controllers/PostsController.cs
using Microsoft.AspNetCore.Mvc;
using Shared.DTOs;

namespace PostService.Controllers;

[ApiController]
[Route("posts")]
public class PostsController : ControllerBase
{
    private static readonly List<PostDto> Posts = new();

    [HttpPost]
    public IActionResult CreatePost(PostDto post)
    {
        post.Id = Guid.NewGuid();
        Posts.Add(post);
        return Ok(post);
    }

    [HttpGet]
    public IActionResult GetAllPosts() => Ok(Posts);
}
