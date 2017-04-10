using System;
using System.Collections;
using System.Collections.Generic;
using System.Windows.Input;
using Xamarin.Forms;

namespace LeonaStore.Components.Gesturator
{
	public partial class GesturatorView : StackLayout
	{
		public static BindableProperty ItemTemplateProperty =
				BindableProperty.Create("ItemTemplate",
					  typeof(View),
					  typeof(GesturatorView),
					  null);

		public static BindableProperty PositionProperty =
				BindableProperty.Create("PositionCommand", typeof(int),
					  typeof(GesturatorView), 0);

		public static BindableProperty ItemsSourceProperty =
					BindableProperty.Create("ItemsSource",
								  typeof(IList),
	                              typeof(GesturatorView), null, 
			                                propertyChanged: HandleItemSourcePropertyChanged);

		public static BindableProperty ReachedLastPageCommandProperty =
				BindableProperty.Create("ReachedLastPageCommand",
					  typeof(ICommand),
					  typeof(GesturatorView), null);

		public static BindableProperty ViewTapCommandProperty =
				BindableProperty.Create("ViewTapCommand",
					  typeof(ICommand),
					  typeof(GesturatorView), null);

		public View ItemTemplate
		{

			get { return (View)GetValue(ItemTemplateProperty); }
			set { SetValue(ItemTemplateProperty, value); }
		}

		public IList ItemsSource
		{
			get { return (IList)GetValue(ItemsSourceProperty); }
			set { SetValue(ItemsSourceProperty, value); }
		}

		public ICommand ReachedLastPageCommand
		{
			get { return (ICommand)GetValue(ReachedLastPageCommandProperty); }
			set { SetValue(ReachedLastPageCommandProperty, value); }
		}

		public ICommand ViewTapCommand
		{
			get { return (ICommand)GetValue(ViewTapCommandProperty); }
			set { SetValue(ViewTapCommandProperty, value); }
		}

		public int Position
		{
			get { return (int)GetValue(PositionProperty); }
			set { SetValue(PositionProperty, value); }
		}

		static void HandleItemSourcePropertyChanged(BindableObject bindable, object oldValue, object newValue)
		{
			var instance = (GesturatorView)bindable;

			instance.PopulateControl((IList) newValue);
		}

		void PopulateControl(IList newValue)
		{
			foreach (var child in newValue)
			{
				var view = ItemTemplate;

				view.BindingContext = child;

				Children.Add(view);
			}
		}

		protected override void LayoutChildren(double x, double y, double width, double height)
		{
			base.LayoutChildren(x, y, width, height);

			foreach (var child in Children)
			{
				child.WidthRequest = width;
				child.HeightRequest = height;
			}
		}
	}
}
