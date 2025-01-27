﻿using PostComentExercise.Entities;

namespace PostComentExercise;

class Program
{
    static void Main(string[] args)
    {
        Comment comment1 = new Comment("Have a nice trip!");
        Comment comment2 = new Comment("Wow that's awesome!");
        
        Post post1 = new Post(
            DateTime.Parse("30/08/2024 13:10:55"), 
            "Traveling to new Zeland", 
            "I'm going to visit this wonderful country",
            12
            );
        
        post1.AddComment(comment1);
        post1.AddComment(comment2);
        
        Comment comment3 = new Comment("Good night!");
        Comment comment4 = new Comment("May the Force be with you!");
        
        Post post2 = new Post(
            DateTime.Parse("27/07/2024 23:15:15"), 
            "Good night guys", 
            "See you tomorrow",
            5
            );
        
        post2.AddComment(comment3);
        post2.AddComment(comment4);

        Console.WriteLine(post1);
        Console.WriteLine(post2);
        
    }
}