using System;

using R5T.T0132;


namespace R5T.F0050
{
	[FunctionalityMarker]
	public partial interface ISolutionPathsOperator : IFunctionalityMarker
	{
		public string GetSolutionFilePath(
			string solutionDirectoryPath,
			string solutionName)
		{
			var solutionFileName = Instances.SolutionFileNameOperator.GetSolutionFileName_FromSolutionName(solutionName);

			var solutionFilePath = Instances.PathOperator.GetFilePath(
				solutionDirectoryPath,
				solutionFileName);

			return solutionFilePath;
		}

		public string GetSolutionDirectoryPath_FromRepositorySourceDirectoryPath(string repositorySourceDirectoryPath)
		{
			// The solution directory path is just the repository source directory path.
			var solutionDirectoryPath = repositorySourceDirectoryPath;
			return solutionDirectoryPath;
		}

		public string GetSolutionDirectoryPath_FromSolutionFilePath(string solutionFilePath)
		{
			var solutionDirectoryPath = Instances.PathOperator.GetParentDirectoryPath_ForFile(solutionFilePath);
			return solutionDirectoryPath;
		}
	}
}