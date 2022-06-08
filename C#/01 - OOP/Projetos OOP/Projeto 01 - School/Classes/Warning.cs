using System;

namespace ProjetoSchool
{
	internal class Warning
	{
		public string Title { get; }
		public string Message { get; }
		public DateTime CreatedAt { get; }

		public Warning(string Title, string Message)
		{
			this.Title = Title;
			this.Message = Message;
			this.CreatedAt = new DateTime();
		}
	}
}
