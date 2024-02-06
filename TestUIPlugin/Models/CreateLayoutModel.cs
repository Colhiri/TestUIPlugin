using System.Collections.Generic;

namespace AutoCAD_2022_Plugin1.Models
{
    public class CreateLayoutModel : MainModel
    {
        public static List<string> FL = new List<string> { "1", "2", "3", "4", "5", "6", };



        public static List<string> GetPlotters()
        {
            return new List<string> { "1plot", "2plot", "3plot", "4plot", "5plot", "6plot", };
        }

        public static List<string> GetAllCanonicalScales(string plotter)
        {
            return new List<string> { "1can", "2can", "3can", "4can", "5can", "6can", };
        }

        public static List<string> GetAllAnnotationScales()
        {
            return new List<string> { "1an", "2an", "3an", "4an", "5an", "6an", };
        }
    }
}
