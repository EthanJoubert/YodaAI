﻿//using Android.Credentials;
using Azure;
using Azure.AI.OpenAI;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using TheYodaAI_App.Models;
using TheYodaAI_App.Services;
using TheYodaAI_App.Views;

namespace TheYodaAI_App.ViewModels
{
    public partial class  FunFactPageViewModel : BaseViewModel
    {
        private IYodaAssistant _assistant;

		private ChatMessage _answer;

		public ChatMessage Answer
		{
			get { return _answer; }
			set { _answer = value;

                OnPropertyChanged();
            }
		}

        public FunFactPageViewModel(IYodaAssistant assistant)
        {
            _assistant = assistant;
        }

        [RelayCommand]
        public async void GetResponses()
        {
            Answer = await _assistant.GetCompletion();
        }
    }
}