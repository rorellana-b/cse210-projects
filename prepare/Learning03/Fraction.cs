public class Fraction
{
    private int _top;
    private int _bottom;

    public Fraction(){
        _bottom = 1;
        _top= 1;
    }
    public Fraction(int top){
        _top = top;
        _bottom = 1;
    }
    public Fraction(int top, int bottom){
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