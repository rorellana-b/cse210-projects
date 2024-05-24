using System;

class Program
{
    static void Main(string[] args)
    {
        //  adding scriptures to the Library
        ScriptureLibrary library = new ScriptureLibrary();

        library.AddScripture(new Reference("1 Nephi", 3, 7), "And it came to pass that I, Nephi, said unto my father: I awill go and do the things which the Lord hath commanded, for I know that the Lord giveth no bcommandments unto the children of men, save he shall cprepare a way for them that they may accomplish the thing which he commandeth them.");
        library.AddScripture(new Reference("Proverbs", 3, 5, 6), "Trust in the LORD with all thine heart; and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct");
        library.AddScripture(new Reference("Psalm", 23, 1), "The Lord is my shepherd, I shall not want.");
        library.AddScripture(new Reference("Alma", 12, 14), "For our awords will condemn us, yea, all our works will condemn us; we shall not be found spotless; and our thoughts will also condemn us; and in this awful state we shall not dare to look up to our God; and we would fain be glad if we could command the rocks and the bmountains to fall upon us to chide us from his presence.");
        library.AddScripture(new Reference("Matthew", 11, 28), "Come to me, all you who are weary and burdened, and I will give you rest.");
        library.AddScripture(new Reference("Philippians", 4, 13), "I can do all things through Christ who strengthens me.");

        while (true)
        {
            // Selecting ramdom scripture
            Console.Clear();
            Scripture scripture = library.SelectRandomScripture(); 

            if (scripture != null)
            {
                bool memorized = false;

                while (!scripture.isCompletelyHidden())
                {
                    Console.Clear();
                    Console.WriteLine(scripture.GetDisplayText());
                    Console.WriteLine();
                    Console.WriteLine("Press Enter to hide a word or type 'quit' to exit: ");
                    string input = Console.ReadLine();

                    if (input.ToLower() == "quit")
                        return;

                    scripture.HideRandomWords();

                    if (scripture.isCompletelyHidden())
                    {
                        memorized = true;
                        break;
                    }
                }

                if (memorized)
                {
                    Console.Clear();
                    Console.WriteLine("You've memorized the entire scripture!");
                    Console.WriteLine("Press Enter to continue...");
                    Console.ReadLine();
                }
            }
            else
            {
                Console.WriteLine("The scripture library is empty. Add scriptures or load them from files.");
                Console.WriteLine("Press Enter to exit.");
                Console.ReadLine();
                return;
            }
        }
        
    }
    public class ScriptureLibrary
{
    private List<Scripture> scriptures = new List<Scripture>();

    public void AddScripture(Reference reference, string text)
    {
        scriptures.Add(new Scripture(reference, text));
    }

    public Scripture SelectRandomScripture()
    {
        if (scriptures.Count == 0)
        {
            Console.WriteLine("The scripture library is empty.");
            return null;
        }

        Random random = new Random();
        int index = random.Next(scriptures.Count);
        return scriptures[index];
    }
}
}