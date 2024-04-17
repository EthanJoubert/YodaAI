using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheYodaAI_App.Models;
using TheYodaAI_App.Services;
using TheYodaAI_App.Views;

namespace TheYodaAI_App.ViewModels
{
    public class FunFactPageViewModel : BaseViewModel
    {
        private IYodaAssistant _assistant;

        private ObservableCollection<YodaMessage> _chatHistory;

        public ObservableCollection<YodaMessage> ChatHistory
        {
            get { return _chatHistory; }
            set
            {
                _chatHistory = value;

                OnPropertyChanged();
            }
        }

        private string _currentQuestion;
        public string CurrentQuestion
        {
            get { return _currentQuestion; }
            set
            {
                _currentQuestion = value;

                OnPropertyChanged();
            }
        }
    }
}