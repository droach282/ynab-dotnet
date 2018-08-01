using System;
using System.Collections.Generic;
using System.Net;
using Newtonsoft.Json;
using RestSharp;
using YNAB.Models;

namespace YNAB
{
    public class YNABClient
    {
        private const string _urlRoot = "https://api.youneedabudget.com/v1/";

        private readonly RestClient _client;

        public YNABClient()
        {
            _client = new RestSharp.RestClient(_urlRoot);
        }

        // Configure the client with a personal access token.  See https://api.youneedabudget.com/#personal-access-tokens.
        public void SetPersonalToken(string token)
        {
            _client.AddDefaultHeader("Authorization", $"Bearer {token}");
        }

        public User GetCurrentUser()
        {
            return RunGet<UserResponse>("user")?.User;
        }

        public List<BudgetSummary> GetBudgets()
        {
            return RunGet<BudgetSummaryResponse>("budgets")?.Budgets;
        }

        private T RunGet<T>(string uri) where T : class, IResponse
        {
            var request = new RestRequest(uri, Method.GET);
            var response = _client.Execute(request);
            var content = JsonConvert.DeserializeObject<DataResponse<T>>(response.Content);

            if (content.Error != null)
            {
                throw new Exception(content.Error.Detail);
            }

            return content.Data as T;
        }
    }
}