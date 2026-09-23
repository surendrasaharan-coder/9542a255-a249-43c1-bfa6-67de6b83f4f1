using System;
using Xunit;
using App;

namespace Tests
{
    public class SolverTests
    {
        [Theory]
        [MemberData(nameof(TestCaseData.GetCases), MemberType = typeof(TestCaseData))]
        [MemberData(nameof(TestCaseData2.GetCases), MemberType = typeof(TestCaseData2))]
        public void VerifySubsequence(string input, string expected)
        {
            Assert.Equal(expected, Solver.GetLongestIncreasingSubsequence(input));
        }
    }
}
