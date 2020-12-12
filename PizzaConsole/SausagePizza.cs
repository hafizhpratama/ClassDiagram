using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PizzaConsole
{
	public class SausagePizza : PizzaDecorator
	{
		public SausagePizza(Pizza pizza) : base(pizza)
		{

		}

		public override string Ingredients => base.Ingredients + ", sweet sausage";

		public override decimal Price => base.Price + 3.75m;
	}
}