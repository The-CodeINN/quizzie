﻿using System;
using System.Collections.Generic;
using Quizzie.Models;

namespace Quizzie.DTOs;

public class AdminQuizDetailDto
{
    public Guid Id { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public string Instructions { get; set; }
    public int Duration { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;
    public UserDto User { get; set; }
    public Guid UserId { get; set; }
    public QuizCategoryDto Category { get; set; }
    public Guid CategoryId { get; set; }
    public ICollection<Question> Questions { get; set; }
    public bool IsActive { get; set; }
}
