using System;

using R5T.T0132;


namespace R5T.F0050
{
	[FunctionalityMarker]
	public partial interface ISearchPatternGenerator : IFunctionalityMarker,
		F0000.ISearchPatternGenerator
	{
		public string AllSolutionFiles()
        {
			var searchPattern = this.AllFilesWithExtension(
				Instances.FileExtensions.SolutionFile);

			return searchPattern;
		}
	}
}