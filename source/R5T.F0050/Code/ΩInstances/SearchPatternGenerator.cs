using System;


namespace R5T.F0050
{
	public class SearchPatternGenerator : ISearchPatternGenerator
	{
		#region Infrastructure

	    public static ISearchPatternGenerator Instance { get; } = new SearchPatternGenerator();

	    private SearchPatternGenerator()
	    {
        }

	    #endregion
	}
}