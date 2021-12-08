using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Stocks.Services
{
    public static class Credentials
    {
        public static string token = "eyJ0eXAiOiJKV1QiLCJhbGciOiJIUzI1NiJ9.eyJpc3MiOiJodHRwOlwvXC9sb2NhbGhvc3RcL3NlcmdleVwvYXBpXC9hdXRoXC9sb2dpbiIsImlhdCI6MTYzNzg0MjEyNCwiZXhwIjoxNjQwNDM0MTI0LCJuYmYiOjE2Mzc4NDIxMjQsImp0aSI6Ik1rTUJiNHhzNnJhNmRibngiLCJzdWIiOjEsInBydiI6Ijg3ZTBhZjFlZjlmZDE1ODEyZmRlYzk3MTUzYTE0ZTBiMDQ3NTQ2YWEifQ.hhsAFToW9atnrijTyj4ggFnIuABHl0McFTcXnf9y6nA";
        public static string baseUrl = "https://imaginaryworkstation.com/hitbull/api/";
        public static string forexUrl = baseUrl + "forex-data?";
        public static string cryptoUrl = baseUrl + "crypto-data?";
        public static string stockGetUrl = baseUrl+"stock-data?";
        public static string liveStockUrl = "https://eodhistoricaldata.com/api/eod/{0}.US?api_token=" + token + "&fmt=json";
    }
}

