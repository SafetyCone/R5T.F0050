using System;


namespace R5T.F0050
{
	public class SolutionPathOperator : ISolutionPathOperator
	{
		#region Infrastructure

	    public static ISolutionPathOperator Instance { get; } = new SolutionPathOperator();

	    private SolutionPathOperator()
	    {
        }

	    #endregion
	}
}