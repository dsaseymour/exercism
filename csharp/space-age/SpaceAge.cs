using System;

public class SpaceAge
{

  private int _seconds;
  private double _earthtime;

    public SpaceAge(int seconds)
    {
      _seconds=seconds;
      _earthtime=0.00;
    }

    public double OnEarth()
    {
      if( _earthtime == 0.00){
        _earthtime = _seconds/((double)31557600);
      }
      return _earthtime;
    }

    public double OnMercury()
    {
      return 0.2408467*OnEarth() ;
    }

    public double OnVenus()
    {
      return 0.61519726/OnEarth() ;
    }

    public double OnMars()
    {
      return 1.8808158/OnEarth() ;
    }

    public double OnJupiter()
    {
      return 11.862615/OnEarth() ;
    }

    public double OnSaturn()
    {
      return 29.447498/OnEarth() ;
    }

    public double OnUranus()
    {
      return 84.016846/OnEarth() ;
    }

    public double OnNeptune()
    {
      return 164.79132/OnEarth();
    }
}
