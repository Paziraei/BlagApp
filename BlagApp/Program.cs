﻿namespace BlogApp;

public static class Program
{
    static void Main(string[] args)
    {
        Data.DbSetContext context = new();
        context.Database.EnsureCreated();
    }
}
