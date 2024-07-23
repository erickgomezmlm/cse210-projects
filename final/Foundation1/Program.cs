using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> Videos = new List<Video>();
        List<Comments> comments01 = new List<Comments>();
        Comments comment01 = new Comments("dequarius Jones", "this video is lame haha");
        Comments comment02 = new Comments("lebrownie James", "Good video");
        Comments comment03 = new Comments("Starboy", "Cool");

        comments01.Add(comment01);
        comments01.Add(comment02);
        comments01.Add(comment03);

        List<Comments> comments02 = new List<Comments>();
        Comments comment04 = new Comments("DJ", "Super");
        Comments comment05 = new Comments("Coolguy2713", "This video is cool, but I'm cooler");
        Comments comment06 = new Comments("Mario", "Wahoo!");

        comments02.Add(comment04);
        comments02.Add(comment05);
        comments02.Add(comment06);

        List<Comments> comments03 = new List<Comments>();
        Comments comment07 = new Comments("poopyboi", "uh oh stinky");
        Comments comment08 = new Comments("Luigi", "Oooh nooo");
        Comments comment09 = new Comments("cakelover12531", "I like cake guys :)");
        comments03.Add(comment07);
        comments03.Add(comment08);
        comments03.Add(comment09);
 
        Video video01 = new Video("Basketball fail", "epicfailstv", 24, comments01);
        Video video02 = new Video("REATION VIDEO YOU WON'T BELIEVE WHAT HAPPENS NEXT", "Best Reactions", 15, comments02);
        Video video03 = new Video("Cooking egg fried rice", "cooking tuturials", 9, comments03);
        Videos.Add(video01);
        Videos.Add(video02);
        Videos.Add(video03);

        foreach (Video video in Videos)
        {
            video.DisplayVideoInfo();
        }
    }
}
