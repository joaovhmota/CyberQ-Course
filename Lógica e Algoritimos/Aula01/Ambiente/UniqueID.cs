using System;

namespace Ambiente
{
	public class UniqueID
	{
		public UniqueID() { }

		public string GenerateUniqueID()
		{
			return ( (DateTime.Now.Ticks % 100000).ToString() + new Random().NextInt64().ToString() );
		}
	}
}
