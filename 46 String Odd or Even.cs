//Given a string, return true if its length is even or false if the length is odd.
using NUnit.Framework;

public class Tests
{
	 [Test]
	 [TestCase("apples", Result=true)]
	 [TestCase("banana", Result=true)]
	 [TestCase("cherry", Result=true)]
	 [TestCase("mango", Result=false)]
	 [TestCase("peach", Result=false)]
	 [TestCase("pears", Result=false)]
	
	 public static bool FixedTest(string word)
	 {
		   return Program.oddOrEven(word);
	 }
}
public class Program
{
	 public static bool oddOrEven(string word)
	 {
			
	 }
}
