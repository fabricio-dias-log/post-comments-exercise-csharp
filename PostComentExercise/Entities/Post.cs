﻿using System.Text;

namespace PostComentExercise.Entities;

public class Post
{
    public DateTime Moment { get; set; }
    public string Title { get; set; }
    public string Content { get; set; }
    public int Likes { get; set; }
    public List<Comment> Comments { get; set; } = new List<Comment>();

    public Post()
    {
        
    }

    public Post(DateTime moment, string title, string content, int likes)
    {
        Moment = moment;
        Title = title;
        Content = content;
        Likes = likes;
    }

    public void AddComment(Comment comment)
    {
        Comments.Add(comment);
    }

    public void RemoveComment(Comment comment)
    {
        Comments.Remove(comment);
    }

    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.AppendLine("!!!-----------------Post-----------------!!!");
        sb.AppendLine($"{Title}");
        sb.AppendLine("--------------------------------------------");
        sb.AppendLine($"{Likes} Likes - {Moment.ToString("dd/MM/yyyy HH:mm:ss")}");
        sb.AppendLine("-------------------Content------------------");
        sb.AppendLine($"{Content}");
        sb.AppendLine("------------------Comments------------------");
        sb.AppendLine("Comments:");
        sb.AppendLine("--------------------------------------------");
        
        foreach (Comment comment in Comments)
        {
            sb.AppendLine(comment.Text);
            sb.AppendLine("--------------------------------------------");
        }
        
        return sb.ToString();
    }
}