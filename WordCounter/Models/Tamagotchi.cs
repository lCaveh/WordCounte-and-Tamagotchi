using System.Collections.Generic;

namespace WordCounterSpace.Models
{
  public class Tamagotchi
  {
    private string _name;
    public string _imageURL="~/Img/happyPikachu.png";
    private int _maxHunger = 100;
    private int _maxEnergy= 100;
    private int _maxAttention= 100;
    private int _currentHunger = 50;
    private int _currentEnergy= 50;
    private int _currentAttention= 50;
    public static Tamagotchi currentTamagotchi = null;
    public Tamagotchi(string name)
    {
      _name = name;
      currentTamagotchi = this;
    }
    public void Feed (int amount)
    {
      _currentHunger+= amount*3;
      if (_currentHunger>_maxHunger)
      {
        _currentHunger=_maxHunger;
      }
      _currentEnergy-= amount;
      _currentAttention-= amount;
    }
    public void Rest (int amount)
    {
      _currentEnergy+= amount*3;
      if (_currentEnergy>_maxEnergy)
      {
        _currentEnergy=_maxEnergy;
      }
      _currentHunger-= amount;
      _currentAttention-= amount;
    }
    public void Play (int amount)
    {
      _currentAttention+= amount*3;
      if (_currentAttention>_maxAttention)
      {
        _currentAttention=_maxAttention;
      }
      _currentEnergy-= amount;
      _currentHunger-= amount;

    }
    public void PassingTime ()
    {
      _currentAttention--;
      _currentEnergy--;
      _currentHunger--;
    }
    public void ChangeImage()
    {
      if ((_currentAttention<30 && _currentEnergy<30) || (_currentAttention<30 && _currentHunger<30) || (_currentEnergy<30 && _currentHunger<30))
      {
        _imageURL = "~/Img/pikachuFrustated.jpeg";
      } else if (_currentAttention<30)
      {
        _imageURL = "~/Img/pikachuSad.jpeg";
      } else if (_currentEnergy<30)
      {
        _imageURL = "~/Img/pikachutierd.jpeg";
      } else if (_currentHunger<30)
      {
        _imageURL = "~/Img/pikachuAngry.jpg";
      } else
      {
        _imageURL="~/Img/happyPikachu.png";
      }
    }
    public string GetImageURL()
    {
      return _imageURL;
    }
    public int GetCurrentAttention()
    {
      return _currentAttention;
    }
    public int GetCurrentEnergy()
    {
      return _currentEnergy;
    }
    public int GetCurrentHunger()
    {
      return _currentHunger;
    }
    public string GetName()
    {
      return _name;
    }

    public bool EndGame ()
    {
      return (_currentHunger <=0 || _currentEnergy <=0 || _currentAttention <=0);
    }
  }
}
