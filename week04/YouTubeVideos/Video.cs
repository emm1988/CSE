using System;
using System.Collections.Generic;

public class Video
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public int Seconds { get; set; }

        private List<Comment> comments = new List<Comment>();

        public Video(string title, string author, int length)
        {
            Title = title;
            Author = author;
            Seconds = length;
        }

        public void AddComment(Comment comment)
        {
            comments.Add(comment);
        }

        public int GetNumberOfComments()
        {
            return comments.Count;
        }

        public List<Comment> GetComments()
        {
            return comments;
        }
    }