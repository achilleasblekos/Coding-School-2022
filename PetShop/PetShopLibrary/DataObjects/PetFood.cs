using PetShopLibrary;
using System;

public enum FoodType
{
    CatFood,
    DogFood,
    FishFood,
    ReptilianFood,
    BirdFood,
    RatFood,
    TurtleFood,
    SnakeFood
}

public interface IFood
{
    FoodType Type { get; set; }
}

public class PetFood : Product, IFood
{
    public FoodType Type { get; set; }

    public string Brand { get; set; }

    public PetFood()
    {
        Brand = "";
    }

}


