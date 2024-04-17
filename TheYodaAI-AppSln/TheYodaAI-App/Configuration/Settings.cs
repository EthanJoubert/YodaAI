using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheYodaAI_App.Configuration
{
    public class ConstantSettings : ISettings
    {
        public string AzureOpenAiEndPoint { get => "https://loadsheddinglpopenai.openai.azure.com/"; }
        public string AzureOpenAiKey { get => "6a6655adb5f54164afa3de59fd4dae65"; }
    }
}
