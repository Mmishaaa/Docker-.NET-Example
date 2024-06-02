﻿namespace Tinder.BLL.Models
{
    public class Message
    {
        public Guid Id { get; set; }
        public string Text { get; set; }
        public DateTime Date { get; set; }
        public Guid ChatId { get; set; }
        public Chat Chat { get; set; }
        public Guid SenderId { get; set; }
        public User User { get; set; }
    }
}
