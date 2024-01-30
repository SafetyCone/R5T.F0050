using System;

using R5T.T0132;


namespace R5T.F0050
{
	[FunctionalityMarker]
	public partial interface ISearchPatternGenerator : IFunctionalityMarker,
		L0066.ISearchPatternGenerator
	{
		public string For_SolutionFiles()
        {
			var searchPattern = this.Files_WithExtension(
				Instances.FileExtensions.SolutionFile);

			return searchPattern;
		}
	}
}