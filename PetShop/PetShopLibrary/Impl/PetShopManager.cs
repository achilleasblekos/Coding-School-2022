using PetShopLibrary.DataObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace PetShopLibrary
{
    public class PetShopManager
    {
        private const string FILE_NAME = "petShop.json";
        private PetShop _petShop;
        
        public PetShopManager()
        {
            Load();
        }

        public PetShopManager(PetShop petShop)
        {
            _petShop = petShop;
        }

        public void Load()
        {
            if (File.Exists(FILE_NAME))
            {
                string text = File.ReadAllText(FILE_NAME, Encoding.UTF8);
                _petShop = JsonSerializer.Deserialize<PetShop>(text);
                return;
            }

            _petShop = new PetShop();
            
        }

        public void Save()
        {
            string json = JsonSerializer.Serialize(_petShop);
            File.WriteAllText(FILE_NAME, json);
        }

        public void Delete(Customer customer) 
        {
            customer.ObjectStatus = DataObjects.Status.Inactive;
        }

        public void Delete(Employee employee)
        {
            employee.ObjectStatus = DataObjects.Status.Inactive;
        }

        public void Delete(Pet pet)
        {
            pet.ObjectStatus = DataObjects.Status.Inactive;
        }


        public void Delete(PetFood petFood)
        {
            petFood.ObjectStatus = DataObjects.Status.Inactive;
        }

        public void DeletePetFoodRange(string brand, int qty)
        {
            if(qty == 0) return;

            List<PetFood> petFoods = GetPetFoods().FindAll(x => x.Brand.Equals(brand) && x.ObjectStatus.Equals(Status.Active)).Take(qty).ToList();
            foreach(PetFood food in petFoods)
            {
                Delete(food);
            }
        }


        public List<Customer> GetCustomers()
        {
            return _petShop.Customers;                
        }

        public List<Transaction> GetTransactions()
        {
            return _petShop.Transactions;
        }

        public List<Pet> GetPets()
        {
            return _petShop.Pets;
        }

        public List<PetFood> GetPetFoods()
        {
            return _petShop.PetFoods;
        }

        public List<Employee> GetEmployees()
        {
            return _petShop.Employees;
        }

        public void Add(Customer customer)
        {
            _petShop.Customers.Add(customer);
        }

        public void Add(Employee employee)
        {
            _petShop.Employees.Add(employee);
        }

        public void Add(Pet pet)
        {
            _petShop.Pets.Add(pet);
        }

        public void Add(Transaction transaction)
        {
            _petShop.Transactions.Add(transaction);
        }

        public void Add(PetFood petFood)
        {
            _petShop.PetFoods.Add(petFood);
        }

        public PetFood? GetFood(AnimalType type, string brand)
        {
            PetFood? food = this.GetPetFoods().Find(x => x.Brand == brand && this.GetFoodType(type) == x.Type && x.ObjectStatus == Status.Active);
            return food;
        }

        public List<string> GetAvailableFoodBrands(AnimalType type)
        {
            var brands = this.GetFoodBrand(type);
            var available = brands.FindAll(x => GetFood(type, x) != null);
            return available;
        }


        public List<string> GetFoodBrand(AnimalType type)
        {
            FoodBrands brand = new FoodBrands();
            if(type == AnimalType.Dog)
            {
                return brand.DogFoodBrands;
            }
            else if(type == AnimalType.Bird)
            {
                return brand.BirdFoodBrands;
            }
            else if(type == AnimalType.Rat)
            {
                return brand.RatFoodBrands;
            }
            else if(type== AnimalType.Fish)
            {
                return brand.FishFoodBrands;
            }
            else if(type == AnimalType.Turtle)
            {
                return brand.TurtleFoodBrands;
            }
            else if(type == AnimalType.Snake)
            {
                return brand.SnakeFoodBrands;
            }
            else if(type == AnimalType.Cat)
            {
                return brand.CatFoodBrands;
            }
            else return null;
        }

        public FoodType GetFoodType(AnimalType type)
        {
            if (type == AnimalType.Dog)
            {
                return FoodType.DogFood;
            }
            else if (type == AnimalType.Bird)
            {
                return FoodType.BirdFood;
            }
            else if (type == AnimalType.Rat)
            {
                return FoodType.RatFood;
            }
            else if (type == AnimalType.Fish)
            {
                return FoodType.FishFood;
            }
            else if (type == AnimalType.Turtle)
            {
                return FoodType.TurtleFood;
            }
            else if (type == AnimalType.Snake)
            {
                return FoodType.SnakeFood;
            }
            else
            {
                return FoodType.CatFood;
            }
            
        }

        public int GetAvailableFoodQty(string brand)
        {
            return GetPetFoods().FindAll(x => x.Brand == brand).Count();
        }

        public decimal GetTotalPrice(Pet pet, int qty)
        {
            return GetFoodPrice(pet) * (qty-1 >= 0 ? qty-1 : 0 ) + pet.Price;
        }
        public decimal GetFoodPrice(Pet pet)
        {
            PetFood? petFood = GetPetFoods().Find(x => x.Brand == pet.FoodType.Brand);
            if (petFood == null) return 0;

            return petFood.Price;
        }

    }
}
