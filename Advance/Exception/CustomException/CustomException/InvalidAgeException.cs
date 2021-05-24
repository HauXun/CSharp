using System;

namespace CustomException
{
	class InvalidAgeException : Exception
	{
		public InvalidAgeException(string message) : base (message) { }
		public InvalidAgeException(string message, Exception innerException) :
			base(message, innerException)
		{

		}
	}
}
