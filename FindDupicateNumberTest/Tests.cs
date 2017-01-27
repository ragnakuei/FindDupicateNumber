using System;
using System.IO;
using System.Linq;
using NUnit.Framework;
using FluentAssertions;
using MyExtend;

namespace FindDupicateNumberTest
{
	// 給定 小於 32 的不定長度正整數數量，取出重複的數字

	[TestFixture]
	public class Tests
	{
		[Test]
		public void FindDupicateNumber_OneDupicateTwoNumber_Should_be_16()
		{
			int[] numbers = { 16, 16, 1 };
			int[] expected = { 16 };

			var actual = numbers.FindDuplicateNumber();

			actual.ShouldBeEquivalentTo(expected);
		}

		[Test]
		public void FindDupicateNumber_TwoDupicateTwoNumber_Should_be_1_16()
		{
			int[] numbers = { 1, 1, 31, 31, 16 };
			int[] expected = { 1, 31 };

			var actual = numbers.FindDuplicateNumber();

			actual.ShouldBeEquivalentTo(expected);
		}

		[Test]
		public void FindDupicateNumber_ThreeDupicateThreeNumber_Should_be_1_3()
		{
			int[] numbers = { 1, 1, 1, 3, 3, 3, 16, 2 };
			int[] expected = { 1, 3 };

			var actual = numbers.FindDuplicateNumber();

			actual.ShouldBeEquivalentTo(expected);
		}
	}
}
