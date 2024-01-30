using System;

using R5T.T0131;


namespace R5T.F0050
{
	[ValuesMarker]
	public partial interface IDirectoryNames : IValuesMarker
	{
        /// <summary>
        /// <para><value>source</value></para>
        /// </summary>
        public string Source => "source";
    }
}