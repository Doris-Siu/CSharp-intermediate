using System;
namespace CSharp_intermediate
{
	public class HttpCookie
	{
		// Dictionary generic data type - a semantic collection which implement an indexer
		private readonly Dictionary<string, string> _dictionary;
		public DateTime Expiry { get; set; }


		public HttpCookie()
		{
			_dictionary = new Dictionary<string, string>();
		}


		// implement an indexer for the dictionary field
		public string this[string key]
		{
			get { return _dictionary[key]; }
			set { _dictionary[key] = value; }

		}
	}
}

