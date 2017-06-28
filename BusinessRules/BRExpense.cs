using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.Collections.Generic;
using speechflow.Models;

namespace speechflow.BusinessRules
{
    public static class BRExpense
    {
        public static async Task<List<Expense>> getExpenses()
        {
			using (var client = new HttpClient())
			{
                const string path = "tables/expense";
				client.BaseAddress = new Uri("https://speechflow.azurewebsites.net/");
				client.DefaultRequestHeaders.Accept.Clear();
				client.Timeout = new TimeSpan(0, 0, 10);
				client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
                client.DefaultRequestHeaders.Add("zumo-api-version", "2.0.0");

                HttpResponseMessage response = await client.GetAsync(path);

                if (response.IsSuccessStatusCode)
                {
                    try
                    {
						List<Expense> expenses = await response.Content.ReadAsAsync<List<Expense>>();
						return expenses;
					}
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }

                return new List<Expense>();
			}

		}
    }
}
