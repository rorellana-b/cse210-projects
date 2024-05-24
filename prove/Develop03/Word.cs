class Word
{
    public string _text { get; }
    public bool _isHidden {get; private set; }

    public Word(string text){
        _text = text;
        _isHidden = false;
    }

    public void Hidden(){
        _isHidden = true;
    }
    public void show(){
        _isHidden = false;
    }
    public bool isHidden(){
        return true;
    }
    public string   GetDisplayText(){
        return _isHidden ? new string('_', _text.Length) : _text;;
    }
}