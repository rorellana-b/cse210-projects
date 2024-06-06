public class Video
{
     private string _title;
    private string _author;
    private double _length;

    private List<Comment> _comments = new List<Comment>();

    public Video(){

    }

    public void SetVideoInfo(params object[] args)
    {
        _author = args[0].ToString();
        _title = args[1].ToString();
        _length = int.Parse(args[2].ToString());
    }

    public void DisplayComment()
    {   
        int count = 0;
        foreach (Comment comment in _comments)
        {
            count++;
            Console.WriteLine($"{comment.GetuserName()} - {comment.GetComment()}");
        }
        Console.WriteLine("");
        Console.WriteLine($"Number of Comments: {count}\n");
        
    }

    public void DisplayInfo()
    {
        string info = $"Author of Video: {GetAuthor()}\nTitle: {GetTitle()}\nVideo length: {GetLength()}seg(s)";
        Console.WriteLine(info);
    }

    //GET AND SET
    public string GetTitle(){
        return _title;
    }
    public double GetLength(){
        return _length;
    }
    public string GetAuthor(){
        return _author;
    }

    public void setCommentLength(Comment comment){
        _comments.Add(comment);
    }
    public void SetComment(Comment comment)
    {
        _comments.Add(comment);
    }

    

}