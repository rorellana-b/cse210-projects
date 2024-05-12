public class Fractions
{
    private int _top;
    private int _bottom;

    Fractions fractions = new Fractions();

    public Fractions(){
        _bottom = 1;
        _top= 1;
    }
    public Fractions(int bottom){
        _bottom = bottom;
        _top = 1;
    }
    public Fractions(int bottom, int top){
        _bottom = bottom;
        _top = top;
    }

    public string GetFractionString(){
        string text = $"{_top}/{_bottom}";
        return text;
    }

    public double GetDecimalValue(){
        return (double) _top / (double) _bottom;
    }
}