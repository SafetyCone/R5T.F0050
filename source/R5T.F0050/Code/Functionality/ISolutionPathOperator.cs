using System;

using R5T.T0132;


namespace R5T.F0050
{
	[FunctionalityMarker]
	public partial interface ISolutionPathOperator : IFunctionalityMarker
	{
		/// <summary>
		/// Determines if the solution file path meets the requirements for being a solution file path (i.e. ends with the <see cref="IFileExtensions.SolutionFile"/> solution file extension).
		/// NOTE: Does <i>not</i> check if the file exists, or if the file contents meet the requirements of being a solution file. Merely checks the path.
		/// To check if the file contents meet the requirements of being a solution file, use a solution file operator (for example, F5T.F0024.ISolutionFileOperator.IsSolutionFile()).
		/// </summary>
		public bool IsSolutionFilePath(
			string possibleSolutionFilePath)
		{
			var isSolutionFilePath = Instances.PathOperator.HasFileExtension(
				possibleSolutionFilePath,
				Instances.FileExtensions.SolutionFile);

			return isSolutionFilePath;
		}
	}
}