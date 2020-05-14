using Microsoft.Extensions.Configuration;
using Newtonsoft.Json.Linq;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RetentionUnit.Models.Db
{
    public class DbQueries
    {
        private readonly IConfiguration config = new ConfigurationBuilder()
            .AddJsonFile("appsetting.json", true, true)
            .Build();
        private string connectionString;
        public DbQueries()
        {
            connectionString = config.GetConnectionString("cvm");
        }
        public List<ClientInfo> GetClientInfo(string inParams)
        {
            List<ClientInfo> clientInfoList = new List<ClientInfo>();
            JObject inParamsJson = JObject.Parse(inParams);
            OracleConnection connection = new OracleConnection(connectionString);
            //string  sqlstGetClientInfo = "";
            clientInfoList.Add(new ClientInfo
            {
                fullName = "ТЕСТОВ ТЕСТ ТЕСТОВИЧ",
                birthDate = "12.02.1991",
                birthPlace = "МОСКВА",
                clientIbsoId = 12335824,
                clntPhone = "1231234567",
                docSeriesNum = "1234567890",
            });
            return clientInfoList;
        }
    }
}
