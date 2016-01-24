using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.ComponentModel.DataAnnotations;

namespace mediunion_2.Models
{
    public class ScheduleEntry
    {
        [Key]
        public int EntryId { get; set; }
        public DateTime DateAndTime { get; set; }
        public string AgentName { get; set; }
        public string FacilityName { get; set; }
        public string CustomerName { get; set; }
        public string CallNotes { get; set; }   // Call Notes
        public string GeneralFee { get; set; } // 費用。
        public string TransportationFee { get; set; }   // 交通費。

        // 備註及單據說明： 常用代號：  P - 停車費 O - 油資  E - ETC費用
        public string Remarks { get; set; }
    }
}