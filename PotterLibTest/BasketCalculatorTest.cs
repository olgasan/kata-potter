//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18063
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using PotterLib;
using NUnit.Framework;
using System.Collections.Generic;

namespace PotterLibTest
{
	[TestFixture]
	public class BasketCalculatorTest
	{
		BasketCalculator basketCalculator;
		List<int> books;

		[SetUp]
		public void SetUp()
		{
			books = new List<int>();
		 	basketCalculator = new BasketCalculator();
		}

		[Test]
		public void returnPriceForAnyBook()
		{		
			books.Add(1);
			float price = basketCalculator.CalculatePrice(books);
		
			Assert.AreEqual(8, price);
		}

		[Test]
		public void returnPriceForTwoPromotionBooks()
		{		
			books.Add(1);
			books.Add(2);
			float price = basketCalculator.CalculatePrice(books);
			
			Assert.AreEqual(15.2f, price);
		}

		
		[Test]
		public void returnPriceForThreePromotionBooks()
		{	
			books.Add(1);
			books.Add(2);
			books.Add(3);

			float price = basketCalculator.CalculatePrice(books);
			
			Assert.AreEqual(21.6f, price);
		}

		[Test]
		public void returnPriceForFourPromotionBooks()
		{		
			books.Add(1);
			books.Add(2);
			books.Add(3);
			books.Add(4);

			float price = basketCalculator.CalculatePrice(books);
			
			Assert.AreEqual(24f, price);
		}

		[Test]
		public void returnPriceForThreePromotionBooksandOneFullPrice()
		{		
			books.Add(1);
			books.Add(2);
			books.Add(3);
			books.Add(3);

			float price = basketCalculator.CalculatePrice(books);
			
			Assert.AreEqual(29.6f, price);
		}

		[Test]
		[Ignore]
		public void returnPriceForTwoPairPromotions()
		{		
			books.Add(1);
			books.Add(1);
			books.Add(2);
			books.Add(2);
			
			float price = basketCalculator.CalculatePrice(books);
			
			Assert.AreEqual(30.4f, price);
		}

		[Test]
		public void returnTwoPromotionBook()
		{		
			books.Add(1);
			books.Add(2);
						
			int promoBooks = basketCalculator.CalculateNumberOfBooksWithDiscount( books );
			
			Assert.AreEqual(2, promoBooks);
		}

		[Test]
		public void returnTwoPromotionBookWithThreeBasket()
		{		
			books.Add(1);
			books.Add(2);
			books.Add(2);
			
			int promoBooks = basketCalculator.CalculateNumberOfBooksWithDiscount( books );
			
			Assert.AreEqual(2, promoBooks);
		}

		[Test]
		public void returnThreePromotionBookWithThreeBasket()
		{		
			books.Add(1);
			books.Add(2);
			books.Add(3);
			
			int promoBooks = basketCalculator.CalculateNumberOfBooksWithDiscount( books );
			
			Assert.AreEqual(3, promoBooks);
		}
	}
}

