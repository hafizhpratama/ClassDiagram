using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PizzaConsole
{
	public sealed class ClassicPizza : Pizza
	{
		public decimal Price
		{
			get { return 20; }
		}

		public string Ingredients
		{
			get { return "Basic ingredients"; }
		}
	}
}