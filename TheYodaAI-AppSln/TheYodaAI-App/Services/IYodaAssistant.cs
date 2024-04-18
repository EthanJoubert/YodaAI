﻿using Azure.AI.OpenAI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheYodaAI_App.Models;

namespace TheYodaAI_App.Services
{
    public interface IYodaAssistant
    {
        Task<ChatMessage> GetCompletion();
    }
}
