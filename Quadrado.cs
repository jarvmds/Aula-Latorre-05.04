public class Quadrado
{
    private double lado;

    /*public double Lado { 
        get {return lado; } 
        set {
            if (value <=0.0) {
                throw new ArgumentOutOfRangeException
            }
            lado = value;
        }
    } */

    public double Lado {get; set;}
    public double Area {get => Lado * Lado; }
    public double Perimetro {get => 4 * Lado; }

    public Quadrado(double lado) => Lado = lado;

}