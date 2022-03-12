using System;
using System.IO;

namespace Paint_Keyboard
{
    public enum SolutionType
    {
        None,
        Krita,
        SAI_Paint,
        Affinity_Photo
    }

    public sealed class SolutionUri : Uri
    {

        //@Static
        public static readonly string FilePath = Path.Combine(Directory.GetCurrentDirectory(), "Paint Keyboard Solution.xml");

        public SolutionUri(SolutionType type) : base(SolutionUri.GetUri(type), UriKind.Relative)
        {
        }

        private static string GetUri(SolutionType type)
        {
            switch (type)
            {
                case SolutionType.None: return "/Paint Keyboard;component/XMLs/Solution.xml";
                case SolutionType.Krita: return "/Paint Keyboard;component/XMLs/Solution Krita.xml";
                case SolutionType.SAI_Paint: return "/Paint Keyboard;component/XMLs/Solution SAI Paint.xml";
                case SolutionType.Affinity_Photo: return "/Paint Keyboard;component/XMLs/Solution Affinity Photo.xml";
                default: return SolutionUri.FilePath;
            }
        }

    }
}