using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.WindowsAzure.Mobile.Service;

namespace siolRecieverService.DataObjects
{
    public class MsgCliRelational : EntityData
    {        
        public virtual Announcement Announcement { get; set; }
        public virtual Receiver Receiver { get; set; }
    }
}