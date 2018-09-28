using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonDemo
{
    public class Rootobject
    {
        public string rcode { get; set; }
        public string desc { get; set; }
        public Data data { get; set; }

    }

    public class Rootobject2
    {
        public string rcode { get; set; }
        public string desc { get; set; }
        public Data data { get; set; }

    }

    public class Data
    {
        public string queryKey { get; set; }
        public string toStationCode { get; set; }
        public int pageSize { get; set; }
        public int totalCount { get; set; }
        public Train[] trains { get; set; }
        public string fromStation { get; set; }
        public int FromInterval { get; set; }
        public string toStation { get; set; }
        public int totalSize { get; set; }
        public int pageIndex { get; set; }
        public string trainDate { get; set; }
        public To[] tos { get; set; }
        public string fromStationCode { get; set; }
        public From[] froms { get; set; }
        public string canNotBookEndTime { get; set; }
        public int ToInterval { get; set; }
    }

    public class Train
    {
        public int toPassType { get; set; }
        public string note { get; set; }
        public int serialNumber { get; set; }
        public Tickets tickets { get; set; }
        public string saleDateTime { get; set; }
        public string trainClass { get; set; }
        public string toStationCode { get; set; }
        public string trainNo { get; set; }
        public string saleFlag { get; set; }
        public string fromStation { get; set; }
        public int pullInByIdCard { get; set; }
        public int bookState { get; set; }
        public int miles { get; set; }
        public string toStation { get; set; }
        public string runTimeSpan { get; set; }
        public string fromTime { get; set; }
        public string fromStationCode { get; set; }
        public int fromPassType { get; set; }
        public string toTime { get; set; }
    }

    public class Tickets
    {
        public Noseat noseat { get; set; }
        public Hardsleepermid hardsleepermid { get; set; }
        public Hardseat hardseat { get; set; }
        public Softsleeperdown softsleeperdown { get; set; }
        public Businessseat businessseat { get; set; }
        public Secondseat secondseat { get; set; }
        public Firstseat firstseat { get; set; }
        public Specialseat specialseat { get; set; }
        public Dsleeperdown dsleeperdown { get; set; }
        public Advancedsoftsleeper advancedsoftsleeper { get; set; }
        public Softseat softseat { get; set; }
    }

    public class Noseat
    {
        public decimal? downPrice { get; set; }
        public decimal? price { get; set; }
        public int seatState { get; set; }
        public string seatName { get; set; }
        public decimal? upPrice { get; set; }
        public string seats { get; set; }
        public decimal? midPrice { get; set; }
    }

    public class Hardsleepermid
    {
        public decimal? downPrice { get; set; }
        public decimal? price { get; set; }
        public int seatState { get; set; }
        public string seatName { get; set; }
        public decimal? upPrice { get; set; }
        public string seats { get; set; }
        public decimal? midPrice { get; set; }
    }

    public class Hardseat
    {
        public decimal? downPrice { get; set; }
        public decimal? price { get; set; }
        public int seatState { get; set; }
        public string seatName { get; set; }
        public decimal? upPrice { get; set; }
        public string seats { get; set; }
        public decimal? midPrice { get; set; }
    }

    public class Softsleeperdown
    {
        public decimal? downPrice { get; set; }
        public decimal? price { get; set; }
        public int seatState { get; set; }
        public string seatName { get; set; }
        public decimal? upPrice { get; set; }
        public string seats { get; set; }
        public decimal? midPrice { get; set; }
    }

    public class Businessseat
    {
        public decimal? downPrice { get; set; }
        public decimal? price { get; set; }
        public int seatState { get; set; }
        public string seatName { get; set; }
        public decimal? upPrice { get; set; }
        public string seats { get; set; }
        public decimal? midPrice { get; set; }
    }

    public class Secondseat
    {
        public decimal? downPrice { get; set; }
        public decimal? price { get; set; }
        public int seatState { get; set; }
        public string seatName { get; set; }
        public decimal? upPrice { get; set; }
        public string seats { get; set; }
        public decimal? midPrice { get; set; }
    }

    public class Firstseat
    {
        public decimal? downPrice { get; set; }
        public decimal? price { get; set; }
        public int seatState { get; set; }
        public string seatName { get; set; }
        public decimal? upPrice { get; set; }
        public string seats { get; set; }
        public decimal? midPrice { get; set; }
    }

    public class Specialseat
    {
        public decimal? downPrice { get; set; }
        public decimal? price { get; set; }
        public int seatState { get; set; }
        public string seatName { get; set; }
        public decimal? upPrice { get; set; }
        public string seats { get; set; }
        public decimal? midPrice { get; set; }
    }

    public class Dsleeperdown
    {
        public decimal? downPrice { get; set; }
        public decimal? price { get; set; }
        public int seatState { get; set; }
        public string seatName { get; set; }
        public decimal? upPrice { get; set; }
        public string seats { get; set; }
        public decimal? midPrice { get; set; }
    }

    public class Advancedsoftsleeper
    {
        public decimal? downPrice { get; set; }
        public decimal? price { get; set; }
        public int seatState { get; set; }
        public string seatName { get; set; }
        public decimal? upPrice { get; set; }
        public string seats { get; set; }
        public decimal? midPrice { get; set; }
    }

    public class Softseat
    {
        public decimal? downPrice { get; set; }
        public decimal? price { get; set; }
        public int seatState { get; set; }
        public string seatName { get; set; }
        public decimal? upPrice { get; set; }
        public string seats { get; set; }
        public decimal? midPrice { get; set; }
    }

    public class To
    {
        public string station { get; set; }
        public string location { get; set; }
    }

    public class From
    {
        public string station { get; set; }
        public string location { get; set; }
    }

    
}
