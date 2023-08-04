using System;
namespace CSharp_intermediate
{
	public class Text : Shape
	{
		public int FontSize { get; set; }
		public string FontName { get; set; }

		public void AddHyperlink (string url)
		{
			Console.WriteLine("We added a link to " + url);
		}
	}
}

