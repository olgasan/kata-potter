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
using System.Collections.Generic;


namespace PotterLib
{
	public class BasketCalculator
	{
		public BasketCalculator ()
		{
		}

		public float CalculatePrice( List<int> books )
		{
			int numPromoBooks = CalculateNumberOfBooksWithDiscount( books );
			int numFullPriceBooks = books.Count - numPromoBooks;

			if ( numPromoBooks == 2 )
				return 15.2f + ( numFullPriceBooks * 8 );
			else if ( numPromoBooks == 3 ) 
				return 21.6f + ( numFullPriceBooks * 8 );
			else if ( numPromoBooks == 4 ) 
				return 24f + ( numFullPriceBooks * 8 );
			else
				return 8;
		}

		public int CalculateNumberOfBooksWithDiscount( List<int> books )
		{
			int numPromoBooks = books.Count;
			for ( int booksIndex = 0; booksIndex < ( books.Count - 1 ); booksIndex++ )
			{
				if ( books[booksIndex] == books[booksIndex+1] )
				    numPromoBooks--;
			}
			return numPromoBooks; 
		}
	};

	public class PromotionPacks
	{
		List<List<int>> promotionPacks;

		public PromotionPacks()
		{
			promotionPacks = new List<List<int>> ();
		}

		public void AddBook( int book )
		{

			if ( promotionPacks.Count == 0 )
			{
				AddNewPack( book );
			}
			else
			{
				for( int i = 0; i < promotionPacks.Count; i++ )
				{
					for ( int j = 0; j < promotionPacks[i].Count; j++ )
					{
						if ( book == promotionPacks[i][j] )
						{
							AddNewPack( book );
						}
					}
				}
			}
		}

		public void AddNewPack( int book )
		{
			List<int> new_pack = new List<int> ();
			new_pack.Add( book );
			promotionPacks.Add( new_pack );
		}

		public int GetNumberOfGroups ()
		{
			return promotionPacks.Count;
		}
	}
}

