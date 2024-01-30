using System;


namespace R5T.F0050
{
    public static class Instances
    {
        public static L0066.IFileExtensionOperator FileExtensionOperator => L0066.FileExtensionOperator.Instance;
        public static IFileExtensions FileExtensions => F0050.FileExtensions.Instance;
        public static L0066.IPathOperator PathOperator => L0066.PathOperator.Instance;
        public static ISolutionFileNameOperator SolutionFileNameOperator => F0050.SolutionFileNameOperator.Instance;
    }
}