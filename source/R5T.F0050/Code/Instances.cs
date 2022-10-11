using System;

using R5T.F0000;


namespace R5T.F0050
{
    public static class Instances
    {
        public static IFileExtensionOperator FileExtensionOperator { get; } = F0000.FileExtensionOperator.Instance;
        public static IFileExtensions FileExtensions { get; } = F0050.FileExtensions.Instance;
        public static F0002.IPathOperator PathOperator { get; } = F0002.PathOperator.Instance;
        public static ISolutionFileNameOperator SolutionFileNameOperator { get; } = F0050.SolutionFileNameOperator.Instance;
    }
}