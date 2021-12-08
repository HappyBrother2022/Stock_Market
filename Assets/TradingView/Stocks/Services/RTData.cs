using Stocks.Models;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Net;
using UnityEngine;

namespace Stocks.Services
{
    public class RTData
    {
        public Dataset GetRealTimeData(string url, string toCur)
        {
            string dataurl = string.Format(url, toCur);

            HttpWebRequest client = (HttpWebRequest)WebRequest.Create(dataurl);
            Dataset dataset = null;
            HttpWebResponse response = (HttpWebResponse)client.GetResponse();


            if (response.StatusCode == HttpStatusCode.OK)
            {
                StreamReader reader = new StreamReader(response.GetResponseStream());
                string jsonstr = reader.ReadToEnd();
                dataset = (Dataset)JsonUtility.FromJson<Dataset>(jsonstr);
                Debug.Log(jsonstr);
            }

            return dataset;
        }

        public StockBarData GetRealTiimeStockBarData(string url, string toCur,int period)
        {
            Dataset dataset = GetRealTimeData(url, toCur);
            
            StockBarData stockBarData = new StockBarData();

            stockBarData.Open = (int)dataset.Open;
            stockBarData.Close = (int)dataset.Close;
            stockBarData.High = (int)dataset.High;
            stockBarData.Low = (int)dataset.Low;
            stockBarData.Red = stockBarData.Open > stockBarData.Close;
            stockBarData.Period = period;
            return stockBarData;
        }

        public List<Dataset> GetRealTimeDataList(string url, string toCur, string fromDate = null, string toDate = null)
        {
            if (fromDate != null)
            {
                url += "&from=" + fromDate;
            }
            if (toDate != null)
            {
                url += "&to=" + toDate;
            }
            string dataurl = url;
            Debug.Log(dataurl);
            HttpWebRequest client =(HttpWebRequest)WebRequest.Create(dataurl);
            client.Headers["Authorization"] = "Bearer "+Credentials.token;
            
            HttpWebResponse response = (HttpWebResponse)client.GetResponse();
            List<Dataset> dataset = new List<Dataset>();
            if (response.StatusCode == HttpStatusCode.OK)
            {
                StreamReader reader = new StreamReader(response.GetResponseStream());
                string jsonstr = reader.ReadToEnd();
                Debug.Log(jsonstr);
                int start = jsonstr.IndexOf("[");
                int end = jsonstr.IndexOf("]");
                if (start >= 0)
                    jsonstr = jsonstr.Substring(start,end-start+1);
                Debug.Log(jsonstr);
                start = jsonstr.IndexOf("{");
                end = jsonstr.IndexOf("}");
                if (start >= 0)
                    jsonstr = jsonstr.Substring(start, end - start + 1);
                else
                    jsonstr = "{}";
                //jsonstr = jsonstr.Replace('"',' ');
                Debug.Log(jsonstr);
                dataset.Add(JsonUtility.FromJson<Dataset>(jsonstr));
            }
            return dataset;
        }

    }
}

