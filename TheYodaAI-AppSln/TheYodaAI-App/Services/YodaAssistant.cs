using Azure;
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

        // Does Code from OpenAi portal go here??? 
          public async Task<ChatMessage> GetCompletion()
           {

               try
               {
                   var client = new OpenAIClient(new Uri(_settings.AzureOpenAiEndPoint), new AzureKeyCredential(_settings.AzureOpenAiKey));
                   string deploymentName = "gpt35turbo16";
                   string fact = "Give a fun fact";

                   var chatCompletionsOptions = new ChatCompletionsOptions()
                   {
                       Messages =
                       {
                           new ChatMessage(ChatRole.System,YodaBehaviorDescription),
                           new ChatMessage(ChatRole.User,fact)
                       }
                   };

                   Response<ChatCompletions> response = await client.GetChatCompletionsAsync(deploymentName,  chatCompletionsOptions);
                   ChatMessage responseMessage = response.Value.Choices[0].Message;

                   return responseMessage;

               }
               catch (Exception ex)
               {

               }

               return null;
           }

        // Does Code from OpenAi portal go here??? 
        /*   public async Task<ChatResponseMessage> GetCompletion()
           {

               try
               {



                   var client = new OpenAIClient(new Uri(_settings.AzureOpenAiEndPoint), new AzureKeyCredential(_settings.AzureOpenAiKey));
                   string deploymentName = "gpt35turbo16";
                   string fact = "Give a fun fact";

                   var chatCompletionsOptions = new ChatCompletionsOptions()
                   {
                       Messages =
                   {
                       new ChatRequestSystemMessage(YodaBehaviorDescription),
                       new ChatRequestUserMessage(fact)
                   },
                       DeploymentName = deploymentName
                   };

                   Response<ChatCompletions> response = await client.GetChatCompletionsAsync(chatCompletionsOptions);
                   ChatResponseMessage responseMessage = response.Value.Choices[0].Message;

                   return responseMessage;

               }
               catch (Exception ex)
               {

               }

               return null;
           }*/
    }
}
