using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheYodaAI_App.Configuration
{
    internal class ConstantSettings : ISettings
    {
        public string AzureOpenAiEndPoint { get => "<Your Azure Open AI Endpoint>"; }
        public string AzureOpenAiKey { get => "<Your Azure Open AI AP Key>"; }
    }
}
