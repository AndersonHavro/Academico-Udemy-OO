﻿using secao9StringBuilder01.Entites;
using System;

namespace secao9StringBuilder01
{
    class Program
    {
        static void Main(string[] args)
        {
            Comment c1 = new Comment("Have a nice trip");
            Comment c2 = new Comment("Wow that's awesome!");

            Post p1 = new Post(DateTime.Parse("21/06/2018 13:05:44"), "Traveling to New Zealand",
            Comment cc2 = new Comment("May the Force be with you");

            Post p2 = new Post(DateTime.Parse("28/07/2018 23:14:19"), "Good night guys",

            p2.AddComment(cc1);
            p2.AddComment(cc2);




        }
    }
}