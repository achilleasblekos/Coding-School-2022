namespace University_new
{

    public class Person
    {

        public Guid ID { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }


        public Person()
        {

        }


        private string _name;
        public string GetName()
        {
            return _name;
        }

        public void SetName(string name)
        {
            _name = name;
        }


    }





}