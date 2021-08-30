using API_C_Sharp.Models;
using System.Collections.Generic;
using System.Linq;

namespace API_C_Sharp.Services
{
    public static class PizzaService
    {
        static List<Pizza> Pizzas {get;}
        static int nextId = 3; 

        static PizzaService() {
            Pizzas = new List<Pizza> {
                new Pizza { Id = 1, name = "Classic Italian", IsGlutenFree = false },
                new Pizza { Id = 2, name = "Veggie", IsGlutenFree = true }
            };
        } // Salida de pizza Service 

        public static List<Pizza> getAll() => Pizzas;

        public static Pizza Get(int id) => Pizzas.FirstOrDefault(p => p.Id == id);

        // Método CREATE
        public static void Add(Pizza pizza) {
            pizza.Id = nextId++;
            Pizzas.Add(pizza);
        }

        // Método DELETE
        public static void Delete(int id) {
            var pizza = Get(id);

            if (pizza is null) return;

            Pizzas.Remove(pizza);
        }

        // Método UPDATE
        public static void Update(Pizza pizza) {
            var index = Pizzas.FindIndex(p => p.Id == pizza.Id);
            if (index == -1) return;

            Pizzas[index] = pizza;
        }

    }

}
