class Scripture
{
    public Reference _reference { get; }
    private List<Word> _words;

    private int currentWordIndex = 0;

    public Scripture(Reference reference, string text){

        _reference = reference;
        _words = new List<Word>();

        string[] wordArray = text.Split(' ');
        foreach (var word in wordArray)
        {
            _words.Add(new Word(word));
            
        }
    }

    public void HideRandomWords(){
        if (currentWordIndex < _words.Count)
        {
            List<int> hiddenIndexes = _words
                .Select((word, index) => new { Word = word, Index = index })
                .Where(item => !item.Word._isHidden)
                .Select(item => item.Index)
                .ToList();

            if (hiddenIndexes.Count > 0)
            {
                Random random = new Random();
                int randomIndex = random.Next(0, hiddenIndexes.Count);
                _words[hiddenIndexes[randomIndex]].Hidden();
                currentWordIndex++;
            }
        }

    }

    public string GetDisplayText(){
        List<string>    visibleWords = _words.ConvertAll(word => word.GetDisplayText());
        string renderWords = string.Join(" ", visibleWords);
        return $"{_reference.GetDisplayText()}:{renderWords}";

    }
    public bool isCompletelyHidden(){
        return currentWordIndex >= _words.Count;
    }
}