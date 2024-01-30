using System;

using R5T.T0131;


namespace R5T.F0050
{
	[ValuesMarker]
	public partial interface IFileExtensions : IValuesMarker
	{
		/// <summary>
		/// <para><value>sln</value></para>
		/// </summary>
		public string SolutionFile => "sln";
	}
}