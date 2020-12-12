using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PizzaConsole
{
	public interface Pizza
	{
		/// <summary>
		/// list of toppings
		/// </summary>
		decimal Price { get; }
		/// <summary>
		/// cost of a price
		/// </summary>
		string Ingredients { get; }
	}
}