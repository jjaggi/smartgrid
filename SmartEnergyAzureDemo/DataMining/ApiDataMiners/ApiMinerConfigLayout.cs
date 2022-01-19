﻿
// --------------------------------------------------------------------------------------------------------------------
// This code is published under the The MIT License (MIT). See LICENSE.TXT for details. 
// Copyright(c) Microsoft and Contributors
// --------------------------------------------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiDataMiners
{

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
    public partial class ApiMinerConfigLayout
    {

        private ApiMinerConfigLayoutRegion[] regionsField;

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("Region", IsNullable = false)]
        public ApiMinerConfigLayoutRegion[] Regions
        {
            get
            {
                return this.regionsField;
            }
            set
            {
                this.regionsField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class ApiMinerConfigLayoutRegion
    {

        private ApiMinerConfigLayoutRegionEmissionsMiningRegion emissionsMiningRegionField;

        private ApiMinerConfigLayoutRegionWundergroundWeatherMiningRegion wundergroundWeatherMiningRegionField;

        private ApiMinerConfigLayoutRegionDarkSkyWeatherMiningRegion darkSkyWeatherMiningRegionField;

        private string friendlyNameField;

        /// <remarks/>
        public ApiMinerConfigLayoutRegionEmissionsMiningRegion EmissionsMiningRegion
        {
            get
            {
                return this.emissionsMiningRegionField;
            }
            set
            {
                this.emissionsMiningRegionField = value;
            }
        }

        /// <remarks/>
        public ApiMinerConfigLayoutRegionWundergroundWeatherMiningRegion WundergroundWeatherMiningRegion
        {
            get
            {
                return this.wundergroundWeatherMiningRegionField;
            }
            set
            {
                this.wundergroundWeatherMiningRegionField = value;
            }
        }

        /// <remarks/>
        public ApiMinerConfigLayoutRegionDarkSkyWeatherMiningRegion DarkSkyWeatherMiningRegion
        {
            get
            {
                return this.darkSkyWeatherMiningRegionField;
            }
            set
            {
                this.darkSkyWeatherMiningRegionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string friendlyName
        {
            get
            {
                return this.friendlyNameField;
            }
            set
            {
                this.friendlyNameField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class ApiMinerConfigLayoutRegionEmissionsMiningRegion
    {

        private string emissionsWattTimeAbbreviationField;

        private double latitudeField;

        private double longitudeField;

        private string miningMethodField;

        private string timeZoneField;

        private string apiUrlField;

        private string apiKeyField;

        private string wattTimeApiV2UrlField;

        private string wattTimeUsernameField;

        private string wattTimePasswordField;

        private string wattTimeEmailField;

        private string wattTimeOrganizationField;

        private string friendlyNameField;

        private string selfThrottlingMethodField;

        private int maxNumberOfCallsPerMinuteField;

        private string relativeMeritDataSource;

        /// <remarks/>
        public string EmissionsWattTimeAbbreviation
        {
            get
            {
                return this.emissionsWattTimeAbbreviationField;
            }
            set
            {
                this.emissionsWattTimeAbbreviationField = value;
            }
        }

        /// <remarks/>
        public double Latitude
        {
            get
            {
                return this.latitudeField;
            }
            set
            {
                this.latitudeField = value;
            }
        }

        /// <remarks/>
        public double Longitude
        {
            get
            {
                return this.longitudeField;
            }
            set
            {
                this.longitudeField = value;
            }
        }

        /// <remarks/>
        public string MiningMethod
        {
            get
            {
                return this.miningMethodField;
            }
            set
            {
                this.miningMethodField = value;
            }
        }

        /// <remarks/>
        public string TimeZone
        {
            get
            {
                return this.timeZoneField;
            }
            set
            {
                this.timeZoneField = value;
            }
        }

        /// <remarks/>
        public string SelfThrottlingMethod
        {
            get
            {
                return this.selfThrottlingMethodField;
            }
            set
            {
                this.selfThrottlingMethodField = value;
            }
        }

        /// <remarks/>
        public int MaxNumberOfCallsPerMinute
        {
            get
            {
                return this.maxNumberOfCallsPerMinuteField;
            }
            set
            {
                this.maxNumberOfCallsPerMinuteField = value;
            }
        }

        /// <remarks/>
        public string ApiUrl
        {
            get
            {
                return this.apiUrlField;
            }
            set
            {
                this.apiUrlField = value;
            }
        }

        /// <remarks/>
        public string ApiKey
        {
            get
            {
                return this.apiKeyField;
            }
            set
            {
                this.apiKeyField = value;
            }
        }

        /// <remarks/>
        public string WattTimeApiV2Url
        {
            get
            {
                return this.wattTimeApiV2UrlField;
            }
            set
            {
                this.wattTimeApiV2UrlField = value;
            }
        }

        /// <remarks/>
        public string WattTimeUsername
        {
            get
            {
                return this.wattTimeUsernameField;
            }
            set
            {
                this.wattTimeUsernameField = value;
            }
        }

        /// <remarks/>
        public string WattTimePassword
        {
            get
            {
                return this.wattTimePasswordField;
            }
            set
            {
                this.wattTimePasswordField = value;
            }
        }

        /// <remarks/>
        public string WattTimeEmail
        {
            get
            {
                return this.wattTimeEmailField;
            }
            set
            {
                this.wattTimeEmailField = value;
            }
        }

        /// <remarks/>
        public string WattTimeOrganization
        {
            get
            {
                return this.wattTimeOrganizationField;
            }
            set
            {
                this.wattTimeOrganizationField = value;
            }
        }

        /// <remarks/>
        public string RelativeMeritDataSource
        {
            get
            {
                return this.relativeMeritDataSource;
            }
            set
            {
                this.relativeMeritDataSource = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string friendlyName
        {
            get
            {
                return this.friendlyNameField;
            }
            set
            {
                this.friendlyNameField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class ApiMinerConfigLayoutRegionWundergroundWeatherMiningRegion
    {

        private string weatherRegionWundergroundSubUrlField;

        private double latitudeField;

        private double longitudeField;

        private string miningMethodField;

        private string timeZoneField;

        private string apiUrlField;

        private string apiKeyField;

        private string selfThrottlingMethodField;

        private int maxNumberOfCallsPerMinuteField;

        private string friendlyNameField;

        /// <remarks/>
        public string weatherRegionWundergroundSubUrl
        {
            get
            {
                return this.weatherRegionWundergroundSubUrlField;
            }
            set
            {
                this.weatherRegionWundergroundSubUrlField = value;
            }
        }

        /// <remarks/>
        public double Latitude
        {
            get
            {
                return this.latitudeField;
            }
            set
            {
                this.latitudeField = value;
            }
        }

        /// <remarks/>
        public double Longitude
        {
            get
            {
                return this.longitudeField;
            }
            set
            {
                this.longitudeField = value;
            }
        }

        /// <remarks/>
        public string MiningMethod
        {
            get
            {
                return this.miningMethodField;
            }
            set
            {
                this.miningMethodField = value;
            }
        }

        /// <remarks/>
        public string TimeZone
        {
            get
            {
                return this.timeZoneField;
            }
            set
            {
                this.timeZoneField = value;
            }
        }

        /// <remarks/>
        public string ApiUrl
        {
            get
            {
                return this.apiUrlField;
            }
            set
            {
                this.apiUrlField = value;
            }
        }

        /// <remarks/>
        public string ApiKey
        {
            get
            {
                return this.apiKeyField;
            }
            set
            {
                this.apiKeyField = value;
            }
        }

        /// <remarks/>
        public string SelfThrottlingMethod
        {
            get
            {
                return this.selfThrottlingMethodField;
            }
            set
            {
                this.selfThrottlingMethodField = value;
            }
        }

        /// <remarks/>
        public int MaxNumberOfCallsPerMinute
        {
            get
            {
                return this.maxNumberOfCallsPerMinuteField;
            }
            set
            {
                this.maxNumberOfCallsPerMinuteField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string friendlyName
        {
            get
            {
                return this.friendlyNameField;
            }
            set
            {
                this.friendlyNameField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class ApiMinerConfigLayoutRegionDarkSkyWeatherMiningRegion
    {

        private double latitudeField;

        private double longitudeField;

        private string timeZoneField;

        private string apiUrlField;

        private string apiKeyField;

        private string selfThrottlingMethodField;

        private int maxNumberOfCallsPerMinuteField;

        private int maxNumberOfCallsPerDayField;

        private string friendlyNameField;

        /// <remarks/>
        public double Latitude
        {
            get
            {
                return this.latitudeField;
            }
            set
            {
                this.latitudeField = value;
            }
        }

        /// <remarks/>
        public double Longitude
        {
            get
            {
                return this.longitudeField;
            }
            set
            {
                this.longitudeField = value;
            }
        }

        /// <remarks/>
        public string TimeZone
        {
            get
            {
                return this.timeZoneField;
            }
            set
            {
                this.timeZoneField = value;
            }
        }

        /// <remarks/>
        public string ApiUrl
        {
            get
            {
                return this.apiUrlField;
            }
            set
            {
                this.apiUrlField = value;
            }
        }

        /// <remarks/>
        public string ApiKey
        {
            get
            {
                return this.apiKeyField;
            }
            set
            {
                this.apiKeyField = value;
            }
        }

        /// <remarks/>
        public string SelfThrottlingMethod
        {
            get
            {
                return this.selfThrottlingMethodField;
            }
            set
            {
                this.selfThrottlingMethodField = value;
            }
        }

        /// <remarks/>
        public int MaxNumberOfCallsPerMinute
        {
            get
            {
                return this.maxNumberOfCallsPerMinuteField;
            }
            set
            {
                this.maxNumberOfCallsPerMinuteField = value;
            }
        }

        /// <remarks/>
        public int MaxNumberOfCallsPerDay
        {
            get
            {
                return this.maxNumberOfCallsPerDayField;
            }
            set
            {
                this.maxNumberOfCallsPerDayField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string friendlyName
        {
            get
            {
                return this.friendlyNameField;
            }
            set
            {
                this.friendlyNameField = value;
            }
        }
    }
}