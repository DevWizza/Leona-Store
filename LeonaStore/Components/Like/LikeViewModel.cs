using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Input;
using Xamarin.Forms;

namespace Like.ViewModels
{
	public class LikeViewModel : BindableBase
	{
		public bool IsLiked { get; set; }

		public ICommand UserLikedArticleCommand { get; set; }

		public LikeViewModel()
		{
			UserLikedArticleCommand = new Command(OnUserLikedArticle);
		}

		void OnUserLikedArticle()
		{
			IsLiked = !IsLiked;
		}
	}
}
