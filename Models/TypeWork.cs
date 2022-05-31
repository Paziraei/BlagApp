﻿namespace Models.Base
{
    public class TypeWork :BaseEntity
    {
        public TypeWork()
        {
        }
        public string Name { get; set; }
        public User User { get; set; }
        public int UserId { get; set; }
        public Post Post { get; set; }
        public int PostId { get; set; }
    }
}