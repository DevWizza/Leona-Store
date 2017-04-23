using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace LandingPageTemplate
{
	public partial class LandingPageGetStartedButton : Button
	{
public static BindableProperty CurrentPageProperty =
	BindableProperty.Create("CurrentPage",
						typeof(int),
						typeof(LandingPageGetStartedButton),
						0,
			                propertyChanged: async (bindable,old,@new) => await OnCurrentPageChanged(bindable,old,@new));

		public int CurrentPage
{
	get { return (int)GetValue(CurrentPageProperty); }
	set { SetValue(CurrentPageProperty, value); }
		}

public static BindableProperty ItemsSourceProperty =
	BindableProperty.Create("ItemsSource",
				typeof(IList),
				typeof(LandingPageGetStartedButton),
				null);

public IList ItemsSource
{
	get { return (IList)GetValue(ItemsSourceProperty); }
	set { SetValue(ItemsSourceProperty, value); }
		}

static async Task OnCurrentPageChanged(BindableObject bindable, object oldValue, object newValue)
{
			var instance = (LandingPageGetStartedButton)bindable;

			await instance.ShowUpIf((int)newValue + 1);
		}

		async Task ShowUpIf(int position)
		{
			if (position == ItemsSource.Count)
			{
				IsEnabled = true;

				await Show();
			}
			else
			{
				await Hide();

				IsEnabled = false;
			}
		}

		public LandingPageGetStartedButton()
		{
			InitializeComponent();
		}
			
		async Task Show()
		{
			await this.FadeTo(1, 500, Easing.SinIn);
		}

		async Task Hide()
		{ 
			await this.FadeTo(0, 500, Easing.SinIn);
		}
	}
}
