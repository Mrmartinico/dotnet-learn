//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MyRepository
{
    using System;
    using System.Collections.Generic;
    
    public partial class ScadaAlarms
    {
        public int DeviceIdentifier { get; set; }
        public string DeviceType { get; set; }
        public string Localization { get; set; }
        public string FrenchAlarmDescription { get; set; }
        public string EnglishAlarmDescription { get; set; }
        public string SpanishAlarmDescription { get; set; }
        public string AlarmStatus { get; set; }
        public string AlarmSeverity { get; set; }
        public System.DateTime AlarmStartDate { get; set; }
        public Nullable<System.DateTime> AlarmEndDate { get; set; }
    }
}
