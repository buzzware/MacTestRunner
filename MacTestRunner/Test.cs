using NUnit.Framework;
using System;
using System.Diagnostics;

namespace FreeXam.Mac.IntelTests {
	[TestFixture]
	public class Test {
		[Test]
		public void TestCase() {
			Debug.WriteLine("TestCase");
		}

		[TestCase(1, 1, 2)]
		[TestCase(-1, -1, -2)]
		[TestCase(100, 5, 105)]
		public void CanAddNumbers(int x, int y, int expected) {
			Assert.That(x + y, Is.EqualTo(expected));
		}

	}
}
