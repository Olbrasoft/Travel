using System.ComponentModel.DataAnnotations;

namespace Olbrasoft.Data.Geography
{
    public struct Point 
    {
        [Range(typeof(double), "-90", "90")] public double Latitude;

        [Range(typeof(double), "-180", "180")] public double Longitude;
    }
}