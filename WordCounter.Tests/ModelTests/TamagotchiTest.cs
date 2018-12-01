using Microsoft.VisualStudio.TestTools.UnitTesting;
using WordCounterSpace.Models;
using System.Collections.Generic;


namespace WordCounterSpace.Tests
{
  [TestClass]
  public class TamagotchiTest
  {
    [TestMethod]
    public void Feed_Amount_ChangeProperties()
    {
      Tamagotchi tamagotchi = new Tamagotchi("Picachou");
      tamagotchi.Feed(10);
      Assert.AreEqual(80, tamagotchi.GetCurrentHunger());
      Assert.AreEqual(40, tamagotchi.GetCurrentEnergy());
      Assert.AreEqual(40, tamagotchi.GetCurrentAttention());
    }
    [TestMethod]
    public void Rest_Amount_ChangeProperties()
    {
      Tamagotchi tamagotchi = new Tamagotchi("Picachou");
      tamagotchi.Rest(10);
      Assert.AreEqual(40, tamagotchi.GetCurrentHunger());
      Assert.AreEqual(80, tamagotchi.GetCurrentEnergy());
      Assert.AreEqual(40, tamagotchi.GetCurrentAttention());
    }
    [TestMethod]
    public void Play_Amount_ChangeProperties()
    {
      Tamagotchi tamagotchi = new Tamagotchi("Picachou");
      tamagotchi.Play(10);
      Assert.AreEqual(40, tamagotchi.GetCurrentHunger());
      Assert.AreEqual(40, tamagotchi.GetCurrentEnergy());
      Assert.AreEqual(80, tamagotchi.GetCurrentAttention());
    }
    [TestMethod]
    public void PassingTime_Nothing_ChangeProperties()
    {
      Tamagotchi tamagotchi = new Tamagotchi("Picachou");
      tamagotchi.PassingTime();
      Assert.AreEqual(49, tamagotchi.GetCurrentHunger());
      Assert.AreEqual(49, tamagotchi.GetCurrentEnergy());
      Assert.AreEqual(49, tamagotchi.GetCurrentAttention());
    }
    [TestMethod]
    public void ChangeImage_Nothing_ChangeURL()
    {
      Tamagotchi tamagotchi = new Tamagotchi("Picachou");
      tamagotchi.ChangeImage();
      Assert.AreEqual("~/Img/happyPikachu.png", tamagotchi.GetImageURL());
    }
  }
}
