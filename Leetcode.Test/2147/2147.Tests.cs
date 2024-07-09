//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
using NUnit.Framework;

namespace Leetcode.Test
{
	[TestFixture]
	public class _2147_Tests
	{

		[Test]
        [TestCase("SSPPSP", 0)]
        [TestCase("SSPPSPS", 3)]
		[TestCase("PPSPSP", 1)]
		[TestCase("S", 0)]
		[TestCase("SPPSSSSPPS", 1)]
        [TestCase("SPPPPPPSSSS", 0)]
        [TestCase("PPPPPPPSPPPSPPPPSPPPSPPPPPSPPPSPPSPPSPPPPPSPSPPPPPSPPSPPPPPSPPSPPSPPPSPPPPSPPPPSPPPPPSPSPPPPSPSPPPSPPPPSPPPPPSPSPPSPPPPSPPSPPSPPSPPPSPPSPSPPSSSS", 18335643)]
        [TestCase("PPPPPSPPSPPSPPPSPPPPSPPPPSPPPPSPPSPPPSPSPPPSPSPPPSPSPPPSPSPPPPSPPPPSPPPSPPSPPPPSPSPPPPSPSPPPPSPSPPPSPPSPPPPSPSPSS", 919999993)]
        public void Test1(string nums, int expected)
		{
			var actual = new _2147().NumberOfWays(nums);
			Assert.AreEqual(expected, actual);

		}
	}
}
