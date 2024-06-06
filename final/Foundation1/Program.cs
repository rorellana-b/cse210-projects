using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    
    static void Main(string[] args)
    {
        
        List<Video> videos = new List<Video>();

        void DisplayVideo()
        {
            
            int count = 0;
            foreach (Video video in videos)
            {
                count++;
                Console.WriteLine("");
                Console.WriteLine($"Video0{count} - Information");
                video.DisplayInfo();
                Console.WriteLine("\nComments:");
                video.DisplayComment();
                

            }
        }

        
        Video video1 = new();
        Video video2 = new();
        Video video3 = new();
    
        Comment comment = new Comment("Joseph","Blessed!");
        // Video1
        video1.SetVideoInfo("Carl. B Cook", "Just Keep going, with faith", 1010);
        video1.SetComment(comment);
        comment = new("Mary", "Love it ❤️");
        video1.SetComment(comment);
        comment = new("Sofia", "Elder never disappoints");
        video1.SetComment(comment);
        comment = new("Edgar", "Beatiful speech.");
        video1.SetComment(comment);
        videos.Add(video1);

        // Video2
        video2.SetVideoInfo("Gerrit W. Gong", "The ministration", 3020);
        comment = new("Nephi", "Thaks! I know that your words are true!");
        video2.SetComment(comment);
        comment = new("Karina", "What a wonderfull! ");
        video2.SetComment(comment);
        comment = new("Manuel", "That's amazing");
        video2.SetComment(comment);
        videos.Add(video2);

        // Video3
        video3.SetVideoInfo("Allen D. Haynie", "A living prophet for the last days", 2030);
        comment = new("Ronal", "I will follow your counsel");
        video3.SetComment(comment);
        comment = new("Balmore", "That's really importante to me!");
        video3.SetComment(comment);
        comment = new("Orellana", "Ready to follow the prophet!");
        video3.SetComment(comment);
        videos.Add(video3);
        DisplayVideo();
    }

    public void DisplayVideo(){
        
    }
}