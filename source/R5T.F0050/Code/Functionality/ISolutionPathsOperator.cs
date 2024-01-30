using System;

using R5T.T0132;


namespace R5T.F0050
{
	[FunctionalityMarker]
	public partial interface ISolutionPathsOperator : IFunctionalityMarker
	{
		public string Get_SolutionFilePath(
			string solutionDirectoryPath,
			string solutionName)
		{
			var solutionFileName = Instances.SolutionFileNameOperator.Get_SolutionFileName_FromSolutionName(solutionName);

			var solutionFilePath = Instances.PathOperator.Get_FilePath(
				solutionDirectoryPath,
				solutionFileName);

			return solutionFilePath;
		}

		public string Get_SolutionDirectoryPath_FromRepositorySourceDirectoryPath(string repositorySourceDirectoryPath)
		{
			// The solution directory path is just the repository source directory path.
			var solutionDirectoryPath = repositorySourceDirectoryPath;
			return solutionDirectoryPath;
		}

		public string Get_SolutionDirectoryPath_FromSolutionFilePath(string solutionFilePath)
		{
			var solutionDirectoryPath = Instances.PathOperator.Get_ParentDirectoryPath_ForFile(solutionFilePath);
			return solutionDirectoryPath;
		}
	}
}