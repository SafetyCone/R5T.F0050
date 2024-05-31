using System;


namespace R5T.F0050
{
    public static class Instances
    {
        public static L0066.IFileExtensionOperator FileExtensionOperator => L0066.FileExtensionOperator.Instance;
        public static Z0072.Z002.IFileExtensions FileExtensions => Z0072.Z002.FileExtensions.Instance;
        public static L0066.IPathOperator PathOperator => L0066.PathOperator.Instance;
        public static ISolutionFileNameOperator SolutionFileNameOperator => F0050.SolutionFileNameOperator.Instance;
    }
}