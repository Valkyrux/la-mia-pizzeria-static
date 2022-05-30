namespace la_mia_pizzeria_static.Models
{
    public class Pizzeria
    {
        public List<Pizza> listaPizze;
        public Pizzeria()
        {
            listaPizze = new List<Pizza>();
        }
        public void addPizza(Pizza pizza)
        {
            this.listaPizze.Add(pizza);
        }
    }
}
