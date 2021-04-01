using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Threading.Tasks;
using System.Net.Http;
using Microsoft.AspNetCore.Http;
using System.Linq;


namespace BridgeMonitor.Models
{
    public class ClosingList
    {
        public List<Closing> ListOfClosing { get; set; }

        public Closing NextClosing { get; set; }

        public List<Closing> ListOfFutureClosing = new List<Closing>();

        public List<Closing> ListOfDoneClosing = new List<Closing>();
        public static readonly HttpClient client = new HttpClient();
        public static async Task<List<Closing>> ApiCall() {
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Add("User-Agent", ".NET Foundation Repository Reporter");

            var streamTask = client.GetStreamAsync("https://api.alexandredubois.com/pont-chaban/api.php");
            var closings = await JsonSerializer.DeserializeAsync<List<Closing>>(await streamTask);
            return closings;
        }

        public async Task fetchData() {
            ListOfClosing = await ClosingList.ApiCall();
            ListOfClosing = ListOfClosing.OrderBy(closing=>Convert.ToDateTime(closing.ClosingDate)).ToList();
            var today = DateTime.Now;

            var NextClosingAssigned = false;
            foreach (var closing in ListOfClosing)
            {
                var closing_date = Convert.ToDateTime(closing.ClosingDate);
                if (!NextClosingAssigned && DateTime.Compare(today, closing_date) <= 0)
                {
                    NextClosing = closing;
                    NextClosingAssigned = true;
                }
                if (NextClosingAssigned)
                {
                    ListOfFutureClosing.Add(closing);
                }
                else
                {
                    ListOfDoneClosing.Add(closing);
                }
            }

        }

    }
}