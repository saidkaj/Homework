using System;
namespace Homework_6.Models
{
	public class Student
	{
		private static int objectCount = 0;
		public int Id { get; private set; }

		public Student()
		{
			objectCount++;
			Id = objectCount;	
		}
	}
}


