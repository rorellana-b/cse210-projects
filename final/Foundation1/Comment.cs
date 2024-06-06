public class Comment
{
   
    private string _nameofUser;
    private string _comment;

    public Comment(string name,string comment){
        _comment = comment;
        _nameofUser = name;
    }

    public string GetuserName(){
        return _nameofUser;
    
    }

    public string GetComment(){
        return _comment;
    }

    

}