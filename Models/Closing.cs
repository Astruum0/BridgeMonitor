using System;
using System.Text.Json.Serialization;
using System.Globalization;

namespace BridgeMonitor.Models 
{
    public class Closing 
    {
        [JsonPropertyName("boat_name")]
        public string BoatName { get; set; }

        [JsonPropertyName("closing_type")]
        public string ClosingType { get; set; }

        [JsonPropertyName("closing_date")]
        public string ClosingDate { get; set; }

        [JsonPropertyName("reopening_date")]
        public string ReopeningDate { get; set; }

        public string FormattedClosingDateFR { 
            get { return Convert.ToDateTime(ClosingDate).ToString("F", CultureInfo.CreateSpecificCulture("fr-FR")); }}
        
        public string FormattedReopeningDateFR {
            get { return Convert.ToDateTime(ReopeningDate).ToString("F", CultureInfo.CreateSpecificCulture("fr-FR")); }}

        public string FormattedClosingDate { 
            get { return Convert.ToDateTime(ClosingDate).ToString(); }}
        
        public string FormattedReopeningDate {
            get { return Convert.ToDateTime(ReopeningDate).ToString(); }}

        public string ClosingDuration {
            get {
                var diff = Convert.ToDateTime(ReopeningDate) - Convert.ToDateTime(ClosingDate);
                var days = diff.TotalDays <= 1 ? "" : Math.Floor(diff.TotalDays).ToString() + " jours ";
                var hours = diff.TotalHours == 0 ? "" : Math.Floor(diff.TotalHours).ToString() + " heures ";
                var minutes = diff.TotalMinutes%60 == 0 ? "" : (diff.TotalMinutes%60).ToString() + " minutes";

                return days + hours + minutes;
            }
        }

        public string FormattedClosingDateOnlyDays {
            get {
                return Convert.ToDateTime(ClosingDate).ToString("D", CultureInfo.CreateSpecificCulture("fr-FR"));
            }
        }
        public bool TrafficRisk {
            get {
                var closing = Convert.ToDateTime(ClosingDate);
                var reopening = Convert.ToDateTime(ReopeningDate);

                return ((closing.Hour <= 7 && 7 <= reopening.Hour) || (closing.Hour <= 9 && 7 <= reopening.Hour)) || ((closing.Hour <= 17 && 17 <= reopening.Hour) || (closing.Hour <= 19 && 19 <= reopening.Hour));
            }
        }

        public int id { get; set; }

    }

}