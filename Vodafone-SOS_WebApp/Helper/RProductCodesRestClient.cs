﻿using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Net;
using Vodafone_SOS_WebApp.ViewModels;

namespace Vodafone_SOS_WebApp.Helper
{
    public class RProductCodesRestClient:IRProductCodesRestClient
    {
        private readonly RestClient _client;
        private readonly String _url = ConfigurationManager.AppSettings["webapibaseurl"];

        public RProductCodesRestClient()
        {
            _client = new RestClient { BaseUrl = new System.Uri(_url) };
        }

       
        public IEnumerable<RProductCodeViewModel> GetDropDownDataByCompanyId(int CompanyId)
        {
            var request = new RestRequest("api/RProductCodes/GetRProductCodesDropdownData?CompanyId={CompanyId}", Method.GET) { RequestFormat = DataFormat.Json };
            request.AddParameter("CompanyId", CompanyId, ParameterType.UrlSegment);
            var response = _client.Execute<List<RProductCodeViewModel>>(request);

            if (response.Data == null)
                throw new Exception(response.ErrorMessage);

            return response.Data;
        }

        public IEnumerable<RProductCodeViewModel> GetByCompanyId(int CompanyId)
        {
            var request = new RestRequest("api/RProductCodes/GetRProductCodesByCompanyId?CompanyId={CompanyId}", Method.GET) { RequestFormat = DataFormat.Json };
            request.AddParameter("CompanyId", CompanyId, ParameterType.UrlSegment);
            var response = _client.Execute<List<RProductCodeViewModel>>(request);

            if (response.Data == null)
                throw new Exception(response.ErrorMessage);

            return response.Data;
        }
        public RProductCodeViewModel GetById(int id)
        {
            var request = new RestRequest("api/RProductCodes/GetRProductCode/{id}", Method.GET) { RequestFormat = DataFormat.Json };

            request.AddParameter("id", id, ParameterType.UrlSegment);
            var response = _client.Execute<RProductCodeViewModel>(request);

            if (response.Data == null)
                throw new Exception(response.ErrorMessage);

            return response.Data;
        }

        public void Add(RProductCodeViewModel serverData)
        {
            var request = new RestRequest("api/RProductCodes/PostRProductCode", Method.POST) { RequestFormat = DataFormat.Json };
            request.AddBody(serverData);

            var response = _client.Execute<RProductCodeViewModel>(request);

            if (response.StatusCode == HttpStatusCode.InternalServerError)
            {
                var ex = new Exception(String.Format("{0},{1}", response.ErrorMessage, response.StatusCode));
                ex.Data.Add("ErrorCode", response.StatusCode);
                string source = response.Content;
                dynamic data = JsonConvert.DeserializeObject(source);
                string xx = data.Message;
                ex.Data.Add("ErrorMessage", xx);
                throw ex;
            }
            if (response.StatusCode == HttpStatusCode.BadRequest)
            {
                var ex = new Exception(String.Format("{0},{1}", response.ErrorMessage, response.StatusCode));
                ex.Data.Add("ErrorCode", response.StatusCode);
                string source = response.Content;
                dynamic data = JsonConvert.DeserializeObject(source);
                string xx = data.Message;
                ex.Data.Add("ErrorMessage", xx);
                throw ex;
            }
        }

        public void Update(RProductCodeViewModel serverData)
        {
            var request = new RestRequest("api/RProductCodes/PutRProductCode/{id}", Method.PUT) { RequestFormat = DataFormat.Json };
            request.AddParameter("id", serverData.Id, ParameterType.UrlSegment);
            request.AddBody(serverData);

            var response = _client.Execute<RProductCodeViewModel>(request);

            if (response.StatusCode == HttpStatusCode.NotFound)
            {
                var ex = new Exception(String.Format("{0},{1}", response.ErrorMessage, response.StatusCode));
                ex.Data.Add("ErrorCode", response.StatusCode);
                string source = response.Content;
                dynamic data = JsonConvert.DeserializeObject(source);
                string xx = data.Message;
                ex.Data.Add("ErrorMessage", xx);
                throw ex;
            }



            if (response.StatusCode == HttpStatusCode.InternalServerError)
            {
                var ex = new Exception(String.Format("{0},{1}", response.ErrorMessage, response.StatusCode));
                ex.Data.Add("ErrorCode", response.StatusCode);
                string source = response.Content;
                dynamic data = JsonConvert.DeserializeObject(source);
                string xx = data.Message;
                ex.Data.Add("ErrorMessage", xx);
                throw ex;
            }
            if (response.StatusCode == HttpStatusCode.BadRequest)
            {
                var ex = new Exception(String.Format("{0},{1}", response.ErrorMessage, response.StatusCode));
                ex.Data.Add("ErrorCode", response.StatusCode);
                string source = response.Content;
                dynamic data = JsonConvert.DeserializeObject(source);
                string xx = data.Message;
                ex.Data.Add("ErrorMessage", xx);
                throw ex;
            }

        }

        public void Delete(int id)
        {
            var request = new RestRequest("api/RProductCodes/DeleteRProductCode/{id}", Method.DELETE);
            request.AddParameter("id", id, ParameterType.UrlSegment);

            var response = _client.Execute<RProductCodeViewModel>(request);

            if (response.StatusCode != HttpStatusCode.OK)
            {

                var ex = new Exception(String.Format("{0},{1}", response.ErrorMessage, response.StatusCode));
                ex.Data.Add("ErrorCode", response.StatusCode);
                string source = response.Content;
                dynamic data = JsonConvert.DeserializeObject(source);
                string xx = data.Message;
                ex.Data.Add("ErrorMessage", xx);
                throw ex;
            }
        }
    }

    interface IRProductCodesRestClient
    {
        RProductCodeViewModel GetById(int id);
        IEnumerable<RProductCodeViewModel> GetDropDownDataByCompanyId(int CompanyId);
        IEnumerable<RProductCodeViewModel> GetByCompanyId(int CompanyId);
        void Add(RProductCodeViewModel RProductCodeViewModel);
        void Update(RProductCodeViewModel RProductCodeViewModel);
        void Delete(int id);
    }
}