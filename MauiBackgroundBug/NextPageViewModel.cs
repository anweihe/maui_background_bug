using System;
using System.ComponentModel;
using CommunityToolkit.Maui;
using CommunityToolkit.Mvvm;

namespace MauiBackgroundBug
{
	public class NextPageViewModel : INotifyPropertyChanged
	{
		public NextPageViewModel()
		{
		}

        public event PropertyChangedEventHandler PropertyChanged;
    }
}

