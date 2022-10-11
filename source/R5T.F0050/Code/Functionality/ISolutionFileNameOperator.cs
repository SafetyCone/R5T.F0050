using System;

using R5T.T0132;


namespace R5T.F0050
{
	[FunctionalityMarker]
	public partial interface ISolutionFileNameOperator : IFunctionalityMarker
	{
		public string GetSolutionFileNameStem_FromSolutionName(string solutionName)
		{
			var solutionFileNameStem = solutionName;
			return solutionFileNameStem;
		}

		public string GetSolutionFileName_FromSolutionName(string solutionName)
		{
			var solutionFileNameStem = this.GetSolutionFileNameStem_FromSolutionName(solutionName);
			var solutionFileExtension = Instances.FileExtensions.SolutionFile;

			var output = Instances.FileExtensionOperator.GetFileName(solutionFileNameStem, solutionFileExtension);
			return output;
		}
	}
}