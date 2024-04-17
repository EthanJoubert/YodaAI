using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheYodaAI_App.Enums;

namespace TheYodaAI_App.Models
{
    public class YodaMessage
    {
        public YodaMessageTypeEnums MessageType { get; set; }
        public string? MessageBody { get; set; }
    }
}
