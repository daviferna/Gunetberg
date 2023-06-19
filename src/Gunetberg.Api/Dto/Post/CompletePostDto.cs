﻿namespace Gunetberg.Api.Dto.Post
{
    public class CompletePostDto
    {
        public Guid Id { get; set; }

        public string Language { get; set; }

        public string Title { get; set; }

        public string ImageUrl { get; set; }

        public string Content { get; set; }

        public Guid CreatedBy { get; set; }

        public DateTime CreatedAt { get; set; }
    }
}
