using XnaFan.ImageComparison;

namespace TestingFramework.Extensions
{
    class ImageUtils
    {
        public static bool CompareImages(string firstImagePath, string secondImahePath)
        {
            return ImageTool.GetPercentageDifference(firstImagePath, secondImahePath) == 0f;
        }
    }
}
