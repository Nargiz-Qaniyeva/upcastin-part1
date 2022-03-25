using System;
using System.Collections.Generic;
using System.Text;

namespace upcasting.Models
{
    internal class Currency_Enum
    {
        public static upcasting.Currency Usd { get; internal set; }
        public static upcasting.Currency Try { get; internal set; }
        public static upcasting.Currency Euro { get; internal set; }

        enum Currency
        {
            Usd,
            Euro,
            Try
        }
    }
}
