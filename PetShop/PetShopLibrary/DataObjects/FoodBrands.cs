using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShopLibrary.DataObjects
{
    public class FoodBrands
    {
        public List<string> DogFoodBrands = new List<string> { "Taste of the Wild", "Instinct RawBoost Mixers", "Zignature Lamb", "The Farmer's Dog", "Pedigrie" };
        public List<string> CatFoodBrands = new List<string> { "Royal Canin", "Taste of the Wild", "Hill's Science Diet", "Wellness", "Friskies" };
        public List<string> SnakeFoodBrands = new List<string> { "Predator Foods", "UGRodents", "Fluker's Repta", "Fluker's Gourmet" };
        public List<string> BirdFoodBrands = new List<string> { "Lafeber Sunny Orchard", "Kaytee Forti-Diet", "Lafeber Tropical Fruit", "ZuPreem FruitBlend" };
        public List<string> RatFoodBrands = new List<string> { "Oxbow Essentials", "Kaytee Supreme", "Oxbow Garden", "Mazuri Rat Food" };
        public List<string> FishFoodBrands = new List<string> { "Zoo Med Spirulina", "Omega One", "Fluval Bug Bites", "Hikari Bio-Pure" };
        public List<string> TurtleFoodBrands = new List<string> { "Tetra ReptoMin", "Zoo Med Natural", "Zilla Reptile", "Fluker's Buffet Blend" };
    }
}
