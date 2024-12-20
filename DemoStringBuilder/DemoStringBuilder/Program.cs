using System;
using DemoStringBuilder;

namespace DemoStringBuilder {
    class Program {
        static void Main(string[] args) {
            Comment c1 = new Comment("Have a nice trip!");
            Comment c2 = new Comment("Wow thats awesome!");
            Post p1 = new Post(
                DateTime.Parse("20/12/2024 07:37:33"),
                "Traveling to New Zeland",
                "I'm going to visit this wonderfull country!",
                12
                );

            p1.AddComment(c1);
            p1.AddComment(c2);

            Comment c3 = new Comment("Good night!");
            Comment c4 = new Comment("May the Force be with you!");
            Post p2 = new Post (
                DateTime.Parse("28/07/2018 23:14:19"),
                "Good night guys!",
                "See You tomorrow!",
                5
                );
            
            p2.AddComment(c3);
            p2.AddComment(c4); 
        }
    }
}