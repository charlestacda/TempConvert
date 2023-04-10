class Converter
{
    public double convertTemp(double num1)
    {
        double cel, frh;
        cel = num1;
        frh = (cel * 9.0) / 5.0 + 32;
        return frh;

    }


}