using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PizzaConsole
{
	public abstract class PizzaDecorator : Pizza
	{
		private Pizza _decoratedPizza;

		public PizzaDecorator(Pizza pizza)
		{
			_decoratedPizza = pizza;
		}

		public virtual decimal Price
		{
			get { return _decoratedPizza.Price; }
		}

		public virtual string Ingredients
		{
			get { return _decoratedPizza.Ingredients; }
		}
	}
}