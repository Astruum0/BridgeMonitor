using System;
using System.Text.Json.Serialization;

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

        public string TimeUntilClosing {
            get {
                var diff = Convert.ToDateTime(ClosingDate) - DateTime.Now;
                return $"{Math.Floor(diff.TotalDays).ToString()} jours, {Math.Floor(diff.TotalHours%24).ToString()} heures, {Math.Floor(diff.TotalMinutes%60).ToString()} minutes et {Math.Floor(diff.TotalSeconds%60).ToString()} secondes";
            }
        }

        public bool TrafficRisk {
            get {
                var closing = Convert.ToDateTime(ClosingDate);
                var reopening = Convert.ToDateTime(ReopeningDate);

                return (closing.Hour <= 9 && 7 >= reopening.Hour) || (closing.Hour <= 19 && 17 >= reopening.Hour);
            }
        }

    }

}