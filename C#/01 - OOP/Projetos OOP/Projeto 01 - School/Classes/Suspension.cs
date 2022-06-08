using System;

namespace ProjetoSchool.Classes
{
	internal class Suspension
	{
		public string Title { get; }
		public string Message { get; }
		public DateTime CreatedAt { get; }
		public int Duration { get; }

		public Suspension(string Title, string Message, int Duration)
		{
			this.Title = Title;
			this.Message = Message;
			this.Duration = Duration;
			this.CreatedAt = new DateTime();
		}
	}
}
