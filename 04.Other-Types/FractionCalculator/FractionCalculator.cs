using System;
public struct Fraction
{
    public int numerator;
    private int denomerator;
    public double result;

    public Fraction(int num, int denum)
    {
        this.numerator = num;
        this.denomerator = denum;
        this.result = Convert.ToDouble(num / denum);
    }
    
    public static Fraction operator +(Fraction c1, Fraction c2)
    {
        int num1 = c1.numerator;
        int num2 = c2.numerator;
        int denum1 = c1.Denomerator;
        int denum2 = c2.Denomerator;

        int num = (num1 * denum2);
        num += num2 * denum1;
        int denum = denum1 * denum2;

        return new Fraction(num,denum);
    }
    public static Fraction operator -(Fraction c1, Fraction c2)
    {
        int num1 = c1.numerator;
        int num2 = c2.numerator;
        int denum1 = c1.Denomerator;
        int denum2 = c2.Denomerator;

        int num = (num1 * denum2);
        num -= num2 * denum1;
        int denum = denum1 * denum2;

        return new Fraction(num, denum);
    }
    public int Denomerator
    {
        get { return denomerator; }

        set
        {                      
            denomerator = value;
            if (denomerator == 0)
            {
                throw new ArgumentException("Denomerator cannot be zero.");
            }
        }             
    }
    public override string ToString() 
    {
     string numerator = this.numerator.ToString();
     string denumenator = this.Denomerator.ToString();
     string r = this.result.ToString("F27");
     return numerator + "\n" + denumenator + "\n" + r;
    }
}

class FractionCalculator
{
    static void Main()
    {
        Fraction f = new Fraction(22 , 7);
        Fraction f2 = new Fraction(40, 4);
        Fraction r = f + f2;
        Console.WriteLine(f);
        Console.WriteLine(r.Denomerator);
        Console.WriteLine(r);
    }
}

