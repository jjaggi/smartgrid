//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SmartEnergyOM
{
    using System;
    using System.Collections.Generic;
    
    public partial class WeatherRegion
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public WeatherRegion()
        {
            this.MarketWeatherEmissionsRegionMappings = new HashSet<MarketWeatherEmissionsRegionMapping>();
            this.WeatherDataPoints = new HashSet<WeatherDataPoint>();
        }
    
        public int WeatherRegionID { get; set; }
        public string FriendlyName { get; set; }
        public System.DateTimeOffset TimeZoneUTCRelative { get; set; }
        public Nullable<double> Latitude { get; set; }
        public Nullable<double> Longitude { get; set; }
        public string WeatherRegionWundergroundSubUrl { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MarketWeatherEmissionsRegionMapping> MarketWeatherEmissionsRegionMappings { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<WeatherDataPoint> WeatherDataPoints { get; set; }
    }
}
