using System;

class Program
{
    static void Main(string[] args)
    {

        List<Video> videos = new List<Video>();

        Video video1 = new Video("How to cook Vanilla Cake", "Cooker Master", 650);
        video1.AddComment(new Comment("Diego", "I love this recipe!"));
        video1.AddComment(new Comment("Robert", "Loved the explanation on baking techniques."));
        video1.AddComment(new Comment("Sofia", "Very easy to follow."));
        videos.Add(video1);

        Video video2 = new Video("Video Vlog in Roma", "Markliper", 700);
        video2.AddComment(new Comment("Joshua", "This was amazing!"));
        video2.AddComment(new Comment("Phillip", "Great landscape shots."));
        video2.AddComment(new Comment("Ruth", "My next trip."));
        videos.Add(video2);

        Video video3 = new Video("Minecraft Tips and Tricks", "GamerGuy", 770);
        video3.AddComment(new Comment("David", "LOOOOOOL I love this video!"));
        video3.AddComment(new Comment("Maria", "Thanks for the helpful tips!"));
        video3.AddComment(new Comment("Oscar", "Great suggestions."));
        video3.AddComment(new Comment("Andrew", "I followed you since 2015."));
        videos.Add(video3);

        Video video4 = new Video("Lofi-Music 10 hours", "Beatboy", 36000);
        video4.AddComment(new Comment("Olivia", "Perfect for studying."));
        video4.AddComment(new Comment("Rodrick", "So chill."));
        video4.AddComment(new Comment("Steve", "I really needed this video."));
        videos.Add(video4);
        
        foreach (Video video in videos)
        {
            Console.WriteLine($"Title: {video.Title}");
            Console.WriteLine($"Author: {video.Author}");
            Console.WriteLine($"Length: {video.Seconds} seconds");
            Console.WriteLine($"Number of Comments: {video.GetNumberOfComments()}");
            Console.WriteLine("Comments:");

            foreach (Comment comment in video.GetComments())
            {
                Console.WriteLine($" - {comment.CommenterName}: {comment.Text}");
            }

            Console.WriteLine("  ");
        }

    }
}

