﻿namespace Kino.Database
{
	public class Genre
	{
		public int ID { get; set; }

		public string Name { get; set; }

		public override string ToString()
		{
			return Name;
		}
	}
}