﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaConsole
{
	class Program
	{
		void print(int i)
		{
			Console.WriteLine("Printing Price: {0}", i);
		}
		void print(double f)
		{
			Console.WriteLine("Printing Prices: {0}", f);
		}
		void print(string s)
		{
			Console.WriteLine("Printing Pizza: {0}", s);
		}

		static void Main(string[] args)
		{
			Pizza pizza = new ClassicPizza();
			Display(pizza);

			pizza = new SausagePizza(pizza);
			Display(pizza);

			Polimorphism();

			Overloadding();

			//Console.Read();
		
		}

		private static void Display (Pizza pizza)
		{
			Console.WriteLine("{0} {1:c} {2}", pizza.GetType().Name, pizza.Price, pizza.Ingredients);
		}

		private static void Polimorphism()
		{
			Program p = new Program();

			// Call print to print integer
			p.print(5);

			// Call print to print float
			p.print(500.263);

			// Call print to print string
			p.print("Pizza Frenzy");
			Console.ReadKey();
		}

		private static void Overloadding()
		{
			Box Box1 = new Box();   // Declare Box1 of type Box
			Box Box2 = new Box();   // Declare Box2 of type Box
			Box Box3 = new Box();   // Declare Box3 of type Box
			double volume = 0.0;    // Store the volume of a box here

			// box 1 specification
			Box1.setLength(6.0);
			Box1.setBreadth(7.0);
			Box1.setHeight(5.0);

			// box 2 specification
			Box2.setLength(12.0);
			Box2.setBreadth(13.0);
			Box2.setHeight(10.0);

			// volume of box 1
			volume = Box1.getVolume();
			Console.WriteLine("Volume of Box1 : {0}", volume);

			// volume of box 2
			volume = Box2.getVolume();
			Console.WriteLine("Volume of Box2 : {0}", volume);

			// Add two object as follows:
			Box3 = Box1 + Box2;

			// volume of box 3
			volume = Box3.getVolume();
			Console.WriteLine("Volume of Box3 : {0}", volume);
			Console.ReadKey();
		}
	}

	class Box
	{
		private double length;   // Length of a box
		private double breadth;  // Breadth of a box
		private double height;   // Height of a box

		public double getVolume()
		{
			return length * breadth * height;
		}
		public void setLength(double len)
		{
			length = len;
		}
		public void setBreadth(double bre)
		{
			breadth = bre;
		}
		public void setHeight(double hei)
		{
			height = hei;
		}

		// Overload + operator to add two Box objects.
		public static Box operator +(Box b, Box c)
		{
			Box box = new Box();
			box.length = b.length + c.length;
			box.breadth = b.breadth + c.breadth;
			box.height = b.height + c.height;
			return box;
		}
	}
}
