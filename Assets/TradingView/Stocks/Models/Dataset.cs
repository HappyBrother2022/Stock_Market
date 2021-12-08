using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Stocks.Models
{
    [System.Serializable]
    public class Dataset
    {
        public int id;
        public DateTime date;
        public double open;
        public double high;
        public double low;
        public double close;
        public double adjusted_close;
        public double volume;
        public string type;
        public string currency;
        public int user_id;

        public int Id { get => id; set => id = value; }
        public DateTime Date { get => date; set => date = value; }
        public double Open { get => open; set => open = value; }
        public double High { get => high; set => high = value; }
        public double Low { get => low; set => low = value; }
        public double Close { get => close; set => close = value; }
        public double Adjusted_close { get => adjusted_close; set => adjusted_close = value; }
        public double Volume { get => volume; set => volume = value; }
        public string Type { get => type; set => type = value; }
        public string Currency { get => currency; set => currency = value; }
        public int User_id { get => user_id; set => user_id = value; }
    }
}

