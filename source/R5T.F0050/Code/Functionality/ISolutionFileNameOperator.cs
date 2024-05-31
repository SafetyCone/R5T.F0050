using System;

using R5T.T0132;


namespace R5T.F0050
{
	[FunctionalityMarker]
	public partial interface ISolutionFileNameOperator : IFunctionalityMarker
	{
		public string Get_SolutionFileNameStem_FromSolutionName(string solutionName)
		{
			var solutionFileNameStem = solutionName;
			return solutionFileNameStem;
		}

		public string Get_SolutionFileName_FromSolutionName(string solutionName)
		{
			var solutionFileNameStem = this.Get_SolutionFileNameStem_FromSolutionName(solutionName);
			var solutionFileExtension = Instances.FileExtensions.Solution_File;

			var output = Instances.FileExtensionOperator.Get_FileName(solutionFileNameStem, solutionFileExtension);
			return output;
		}
	}
}