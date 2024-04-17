using Azure.AI.OpenAI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheYodaAI_App.Configuration;
using TheYodaAI_App.Models;

namespace TheYodaAI_App.Services
{
    public class YodaAssistant : IYodaAssistant
    {
        private ISettings _settings;
        private const string YodaBehaviorDescription = "I am an AI assistant that can help you with your loadshedding questions.";

        public YodaAssistant(ISettings settings)
        {
            _settings = settings;
        }

        private IList<ChatRequestMessage> BuildChatContext(IList<YodaMessage> chatInboundHistory, YodaMessage userMessage)
        {
            var chatContext = new List<ChatRequestMessage>();

            chatContext.Add(new ChatRequestSystemMessage(YodaBehaviorDescription));

            foreach (var chatMessage in chatInboundHistory)
                chatContext.Add(new ChatRequestAssistantMessage(chatMessage.MessageBody));

            chatContext.Add(new ChatRequestUserMessage(userMessage.MessageBody));

            return chatContext;

        }

        public ChatResponseMessage GetCompletion(IList<YodaMessage> chatInboundHistory, YodaMessage userMessage)
        {
            throw new NotImplementedException();
        }
    }
}
