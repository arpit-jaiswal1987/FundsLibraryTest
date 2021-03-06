using System;
using InterviewTest.DriverData.Analysers;

namespace InterviewTest.DriverData
{
	public static class AnalyserLookup
	{
		public static IAnalyser GetAnalyser(string type)
		{
			switch (type)
			{
				case "friendly":
					return new FriendlyAnalyser();

				default:
					throw new ArgumentOutOfRangeException(nameof(type), type, "Unrecognised analyser type");
			}
		}
	}
}
