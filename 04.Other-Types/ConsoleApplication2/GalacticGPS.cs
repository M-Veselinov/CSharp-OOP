using System;

public enum Planet { Mercury, Venus, Earth, Mars, Jupiter, Saturn, Uranus, Neptun };

struct Location
{
    private double latitude;
    private Planet planet;

    public Planet Planet
    {
        get { return planet; }
        set { planet = value; }
    }
    public double Latitude
    {
        get { return latitude; }
        set { latitude = value; }
    }
    public Location(double latitu, double longtitu, Planet p)
    {
        this.latitude = latitu;
        this.longtitude = longtitu;
        this.planet = p;
    }
    private double longtitude;
    public double Longtitude
    {
        get { return longtitude; }
        set { longtitude = value; }
    }
    public override string ToString() 
    {
     string l = this.latitude.ToString();
     string longt = this.longtitude.ToString();
     string p = this.planet.ToString();
     return l + "," + longt + "-" + p;
     }
}



    class GalacticGPS
    {
        static void Main()
        {

            Planet planet = Planet.Earth;
            Location home = new Location(18.037986, 28.870097, planet);
            Console.WriteLine(home);
        }
    }

