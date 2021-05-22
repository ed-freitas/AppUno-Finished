// <autogenerated />
#pragma warning disable 618  // Ignore obsolete members warnings
#pragma warning disable 105  // Ignore duplicate namespaces
#pragma warning disable 1591 // Ignore missing XML comment warnings
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Uno.UI;
using Uno.UI.Xaml;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Documents;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Animation;
using Windows.UI.Xaml.Shapes;
using Windows.UI.Text;
using Uno.Extensions;
using Uno;
using Uno.UI.Helpers.Xaml;
using AppUno.Wasm;

#if __ANDROID__
using _View = Android.Views.View;
#elif __IOS__
using _View = UIKit.UIView;
#elif __MACOS__
using _View = AppKit.NSView;
#elif UNO_REFERENCE_API
using _View = Windows.UI.Xaml.UIElement;
#elif NET461
using _View = Windows.UI.Xaml.UIElement;
#endif

namespace AppUno
{
	[global::System.Diagnostics.CodeAnalysis.SuppressMessage("nventive.Usage", "NV0056", Justification="Generated code")]
	[global::System.Diagnostics.CodeAnalysis.SuppressMessage("nventive.Usage", "NV0058", Justification="Generated code")]
	[global::System.Diagnostics.CodeAnalysis.SuppressMessage("nventive.Usage", "NV1003", Justification="Generated code")]
	[global::System.Diagnostics.CodeAnalysis.SuppressMessage("nventive.Usage", "NV0085", Justification="Generated code")]
	[global::System.Diagnostics.CodeAnalysis.SuppressMessage("nventive.Usage", "NV2001", Justification="Generated code")]
	[global::System.Diagnostics.CodeAnalysis.SuppressMessage("nventive.Usage", "NV2003", Justification="Generated code")]
	[global::System.Diagnostics.CodeAnalysis.SuppressMessage("nventive.Usage", "NV2004", Justification="Generated code")]
	[global::System.Diagnostics.CodeAnalysis.SuppressMessage("nventive.Usage", "NV2005", Justification="Generated code")]
	public partial class MainPage : Windows.UI.Xaml.Controls.Page
	{
		private void InitializeComponent()
		{
			var nameScope = new global::Windows.UI.Xaml.NameScope();
			NameScope.SetNameScope(this, nameScope);
			IsParsing = true
			;
			// Source ..\..\..\..\..\..\..\AppUno.Shared\MainPage.xaml (Line 1:2)
			Content = 
			new global::Windows.UI.Xaml.Controls.Grid
			{
				IsParsing = true
				,
				ColumnDefinitions = 
				{
					new global::Windows.UI.Xaml.Controls.ColumnDefinition
					{
						Width = new Windows.UI.Xaml.GridLength(1f, Windows.UI.Xaml.GridUnitType.Auto)/* Windows.UI.Xaml.GridLength/, Auto, ColumnDefinition/Width */,
						// Source ..\..\..\..\..\..\..\AppUno.Shared\MainPage.xaml (Line 10:8)
					}
					,
					new global::Windows.UI.Xaml.Controls.ColumnDefinition
					{
						// Source ..\..\..\..\..\..\..\AppUno.Shared\MainPage.xaml (Line 11:8)
					}
					,
					new global::Windows.UI.Xaml.Controls.ColumnDefinition
					{
						Width = new Windows.UI.Xaml.GridLength(1f, Windows.UI.Xaml.GridUnitType.Auto)/* Windows.UI.Xaml.GridLength/, Auto, ColumnDefinition/Width */,
						// Source ..\..\..\..\..\..\..\AppUno.Shared\MainPage.xaml (Line 12:8)
					}
					,
				}
				,
				RowDefinitions = 
				{
					new global::Windows.UI.Xaml.Controls.RowDefinition
					{
						Height = new Windows.UI.Xaml.GridLength(1f, Windows.UI.Xaml.GridUnitType.Auto)/* Windows.UI.Xaml.GridLength/, Auto, RowDefinition/Height */,
						// Source ..\..\..\..\..\..\..\AppUno.Shared\MainPage.xaml (Line 15:8)
					}
					,
					new global::Windows.UI.Xaml.Controls.RowDefinition
					{
						// Source ..\..\..\..\..\..\..\AppUno.Shared\MainPage.xaml (Line 16:8)
					}
					,
				}
				,
				// Source ..\..\..\..\..\..\..\AppUno.Shared\MainPage.xaml (Line 8:4)
				Children = 
				{
					new global::Windows.UI.Xaml.Controls.StackPanel
					{
						IsParsing = true
						,
						Background = SolidColorBrushHelper.FromARGB(255, 77, 116, 210)/* Windows.UI.Xaml.Media.Brush/, #4d74d2, StackPanel/Background */,
						Orientation = global::Windows.UI.Xaml.Controls.Orientation.Horizontal/* Windows.UI.Xaml.Controls.Orientation/, Horizontal, StackPanel/Orientation */,
						// Source ..\..\..\..\..\..\..\AppUno.Shared\MainPage.xaml (Line 19:6)
						Children = 
						{
							new global::Windows.UI.Xaml.Controls.TextBlock
							{
								IsParsing = true
								,
								Text = "Doc Tracker"/* string/, Doc Tracker, TextBlock/Text */,
								FontSize = 30d/* double/, 30, TextBlock/FontSize */,
								FontWeight = FontWeights.ExtraBold/* Windows.UI.Text.FontWeight/, ExtraBold, TextBlock/FontWeight */,
								Foreground = SolidColorBrushHelper.White/* Windows.UI.Xaml.Media.Brush/, White, TextBlock/Foreground */,
								VerticalAlignment = global::Windows.UI.Xaml.VerticalAlignment.Bottom/* Windows.UI.Xaml.VerticalAlignment/, Bottom, TextBlock/VerticalAlignment */,
								Margin = new global::Windows.UI.Xaml.Thickness(20)/* Windows.UI.Xaml.Thickness/, 20, TextBlock/Margin */,
								// Source ..\..\..\..\..\..\..\AppUno.Shared\MainPage.xaml (Line 20:8)
							}
							.MainPage_889a76a4c5f2c6eee929514aa1dfc438_XamlApply((MainPage_889a76a4c5f2c6eee929514aa1dfc438XamlApplyExtensions.XamlApplyHandler2)(c3 => 
							{
								global::Uno.UI.FrameworkElementHelper.SetBaseUri(c3, "file:///C:/Projects/AppUno-Finished/AppUno-Finished/AppUno.Shared/MainPage.xaml");
								c3.CreationComplete();
							}
							))
							,
							new global::Windows.UI.Xaml.Controls.Button
							{
								IsParsing = true
								,
								Margin = new global::Windows.UI.Xaml.Thickness(10)/* Windows.UI.Xaml.Thickness/, 10, Button/Margin */,
								// Source ..\..\..\..\..\..\..\AppUno.Shared\MainPage.xaml (Line 21:8)
								Content = 
								new global::Windows.UI.Xaml.Controls.StackPanel
								{
									IsParsing = true
									,
									Orientation = global::Windows.UI.Xaml.Controls.Orientation.Horizontal/* Windows.UI.Xaml.Controls.Orientation/, Horizontal, StackPanel/Orientation */,
									// Source ..\..\..\..\..\..\..\AppUno.Shared\MainPage.xaml (Line 22:10)
									Children = 
									{
										new global::Windows.UI.Xaml.Controls.SymbolIcon
										{
											IsParsing = true
											,
											Symbol = global::Windows.UI.Xaml.Controls.Symbol.Add/* Windows.UI.Xaml.Controls.Symbol/, Add, SymbolIcon/Symbol */,
											// Source ..\..\..\..\..\..\..\AppUno.Shared\MainPage.xaml (Line 23:12)
										}
										.MainPage_889a76a4c5f2c6eee929514aa1dfc438_XamlApply((MainPage_889a76a4c5f2c6eee929514aa1dfc438XamlApplyExtensions.XamlApplyHandler3)(c4 => 
										{
											global::Uno.UI.FrameworkElementHelper.SetBaseUri(c4, "file:///C:/Projects/AppUno-Finished/AppUno-Finished/AppUno.Shared/MainPage.xaml");
											c4.CreationComplete();
										}
										))
										,
										new global::Windows.UI.Xaml.Controls.TextBlock
										{
											IsParsing = true
											,
											Text = "Add"/* string/, Add, TextBlock/Text */,
											Margin = new global::Windows.UI.Xaml.Thickness(5,0,0,0)/* Windows.UI.Xaml.Thickness/, 5 0 0 0, TextBlock/Margin */,
											// Source ..\..\..\..\..\..\..\AppUno.Shared\MainPage.xaml (Line 24:12)
										}
										.MainPage_889a76a4c5f2c6eee929514aa1dfc438_XamlApply((MainPage_889a76a4c5f2c6eee929514aa1dfc438XamlApplyExtensions.XamlApplyHandler2)(c5 => 
										{
											global::Uno.UI.FrameworkElementHelper.SetBaseUri(c5, "file:///C:/Projects/AppUno-Finished/AppUno-Finished/AppUno.Shared/MainPage.xaml");
											c5.CreationComplete();
										}
										))
										,
									}
								}
								.MainPage_889a76a4c5f2c6eee929514aa1dfc438_XamlApply((MainPage_889a76a4c5f2c6eee929514aa1dfc438XamlApplyExtensions.XamlApplyHandler4)(c6 => 
								{
									global::Uno.UI.FrameworkElementHelper.SetBaseUri(c6, "file:///C:/Projects/AppUno-Finished/AppUno-Finished/AppUno.Shared/MainPage.xaml");
									c6.CreationComplete();
								}
								))
								,
							}
							.MainPage_889a76a4c5f2c6eee929514aa1dfc438_XamlApply((MainPage_889a76a4c5f2c6eee929514aa1dfc438XamlApplyExtensions.XamlApplyHandler5)(c7 => 
							{
								__0_Click_ViewModel_AddDoc_Builder = () => 
								{
									var Click_ViewModel_AddDoc_That = (this as global::Uno.UI.DataBinding.IWeakReferenceProvider).WeakReference;
									/* first level targetMethod:AppUno.Model.ViewModel.AddDoc() */ c7.Click += (_sender,_e) => (Click_ViewModel_AddDoc_That.Target as MainPage)?.ViewModel.AddDoc();
								}
								;
								/* _isTopLevelDictionary:False */
								this._component_0 = c7;
								global::Uno.UI.FrameworkElementHelper.SetBaseUri(c7, "file:///C:/Projects/AppUno-Finished/AppUno-Finished/AppUno.Shared/MainPage.xaml");
								c7.CreationComplete();
							}
							))
							,
							new global::Windows.UI.Xaml.Controls.Button
							{
								IsParsing = true
								,
								Margin = new global::Windows.UI.Xaml.Thickness(10)/* Windows.UI.Xaml.Thickness/, 10, Button/Margin */,
								// Source ..\..\..\..\..\..\..\AppUno.Shared\MainPage.xaml (Line 27:8)
								Content = 
								new global::Windows.UI.Xaml.Controls.StackPanel
								{
									IsParsing = true
									,
									Orientation = global::Windows.UI.Xaml.Controls.Orientation.Horizontal/* Windows.UI.Xaml.Controls.Orientation/, Horizontal, StackPanel/Orientation */,
									// Source ..\..\..\..\..\..\..\AppUno.Shared\MainPage.xaml (Line 28:10)
									Children = 
									{
										new global::Windows.UI.Xaml.Controls.SymbolIcon
										{
											IsParsing = true
											,
											Symbol = global::Windows.UI.Xaml.Controls.Symbol.Delete/* Windows.UI.Xaml.Controls.Symbol/, Delete, SymbolIcon/Symbol */,
											// Source ..\..\..\..\..\..\..\AppUno.Shared\MainPage.xaml (Line 29:12)
										}
										.MainPage_889a76a4c5f2c6eee929514aa1dfc438_XamlApply((MainPage_889a76a4c5f2c6eee929514aa1dfc438XamlApplyExtensions.XamlApplyHandler3)(c8 => 
										{
											global::Uno.UI.FrameworkElementHelper.SetBaseUri(c8, "file:///C:/Projects/AppUno-Finished/AppUno-Finished/AppUno.Shared/MainPage.xaml");
											c8.CreationComplete();
										}
										))
										,
										new global::Windows.UI.Xaml.Controls.TextBlock
										{
											IsParsing = true
											,
											Text = "Delete"/* string/, Delete, TextBlock/Text */,
											Margin = new global::Windows.UI.Xaml.Thickness(5,0,0,0)/* Windows.UI.Xaml.Thickness/, 5 0 0 0, TextBlock/Margin */,
											// Source ..\..\..\..\..\..\..\AppUno.Shared\MainPage.xaml (Line 30:12)
										}
										.MainPage_889a76a4c5f2c6eee929514aa1dfc438_XamlApply((MainPage_889a76a4c5f2c6eee929514aa1dfc438XamlApplyExtensions.XamlApplyHandler2)(c9 => 
										{
											global::Uno.UI.FrameworkElementHelper.SetBaseUri(c9, "file:///C:/Projects/AppUno-Finished/AppUno-Finished/AppUno.Shared/MainPage.xaml");
											c9.CreationComplete();
										}
										))
										,
									}
								}
								.MainPage_889a76a4c5f2c6eee929514aa1dfc438_XamlApply((MainPage_889a76a4c5f2c6eee929514aa1dfc438XamlApplyExtensions.XamlApplyHandler4)(c10 => 
								{
									global::Uno.UI.FrameworkElementHelper.SetBaseUri(c10, "file:///C:/Projects/AppUno-Finished/AppUno-Finished/AppUno.Shared/MainPage.xaml");
									c10.CreationComplete();
								}
								))
								,
							}
							.MainPage_889a76a4c5f2c6eee929514aa1dfc438_XamlApply((MainPage_889a76a4c5f2c6eee929514aa1dfc438XamlApplyExtensions.XamlApplyHandler5)(c11 => 
							{
								__1_Click_ViewModel_DeleteDoc_Builder = () => 
								{
									var Click_ViewModel_DeleteDoc_That = (this as global::Uno.UI.DataBinding.IWeakReferenceProvider).WeakReference;
									/* first level targetMethod:AppUno.Model.ViewModel.DeleteDoc() */ c11.Click += (_sender,_e) => (Click_ViewModel_DeleteDoc_That.Target as MainPage)?.ViewModel.DeleteDoc();
								}
								;
								c11.SetBinding(global::Windows.UI.Xaml.Controls.Button.IsEnabledProperty, new Windows.UI.Xaml.Data.Binding{ Mode = global::Windows.UI.Xaml.Data.BindingMode.OneWay/* Windows.UI.Xaml.Data.BindingMode/Windows.UI.Xaml.Data.BindingMode, OneWay, Bind/Mode */,  }.Apply(___b =>  /*defaultBindModeOneTime*/ global::Uno.UI.Xaml.BindingHelper.SetBindingXBindProvider(___b, this, ___ctx => ___ctx is global::AppUno.MainPage ___tctx ? (object)(___tctx.ViewModel.IsDocSelected) : null, null , new [] {"ViewModel.IsDocSelected"})));
																/* _isTopLevelDictionary:False */
								this._component_1 = c11;
								global::Uno.UI.FrameworkElementHelper.SetBaseUri(c11, "file:///C:/Projects/AppUno-Finished/AppUno-Finished/AppUno.Shared/MainPage.xaml");
								c11.CreationComplete();
							}
							))
							,
						}
					}
					.MainPage_889a76a4c5f2c6eee929514aa1dfc438_XamlApply((MainPage_889a76a4c5f2c6eee929514aa1dfc438XamlApplyExtensions.XamlApplyHandler4)(c12 => 
					{
						global::Windows.UI.Xaml.Controls.Grid.SetColumnSpan(c12, 2/* int/, 2, Grid/ColumnSpan */);
						global::Uno.UI.FrameworkElementHelper.SetBaseUri(c12, "file:///C:/Projects/AppUno-Finished/AppUno-Finished/AppUno.Shared/MainPage.xaml");
						c12.CreationComplete();
					}
					))
					,
					new global::Windows.UI.Xaml.Controls.Grid
					{
						IsParsing = true
						,
						Name = "docListGrid",
						Background = SolidColorBrushHelper.FromARGB(255, 229, 235, 248)/* Windows.UI.Xaml.Media.Brush/, #e5ebf8, Grid/Background */,
						RowDefinitions = 
						{
							new global::Windows.UI.Xaml.Controls.RowDefinition
							{
								Height = new Windows.UI.Xaml.GridLength(1f, Windows.UI.Xaml.GridUnitType.Auto)/* Windows.UI.Xaml.GridLength/, Auto, RowDefinition/Height */,
								// Source ..\..\..\..\..\..\..\AppUno.Shared\MainPage.xaml (Line 37:10)
							}
							,
							new global::Windows.UI.Xaml.Controls.RowDefinition
							{
								// Source ..\..\..\..\..\..\..\AppUno.Shared\MainPage.xaml (Line 38:10)
							}
							,
						}
						,
						// Source ..\..\..\..\..\..\..\AppUno.Shared\MainPage.xaml (Line 35:6)
						Children = 
						{
							new global::Windows.UI.Xaml.Controls.ListView
							{
								IsParsing = true
								,
								ItemTemplate = 								new global::Windows.UI.Xaml.DataTemplate(this , __owner => 								new _MainPage_889a76a4c5f2c6eee929514aa1dfc438_AppUnoMainPageSC0().Build(__owner)
								)								,
								// Source ..\..\..\..\..\..\..\AppUno.Shared\MainPage.xaml (Line 41:8)
							}
							.MainPage_889a76a4c5f2c6eee929514aa1dfc438_XamlApply((MainPage_889a76a4c5f2c6eee929514aa1dfc438XamlApplyExtensions.XamlApplyHandler6)(c14 => 
							{
								global::Windows.UI.Xaml.Controls.Grid.SetRow(c14, 1/* int/, 1, Grid/Row */);
								c14.SetBinding(global::Windows.UI.Xaml.Controls.ListView.ItemsSourceProperty, new Windows.UI.Xaml.Data.Binding{ Mode = global::Windows.UI.Xaml.Data.BindingMode.OneWay/* Windows.UI.Xaml.Data.BindingMode/Windows.UI.Xaml.Data.BindingMode, OneWay, Bind/Mode */,  }.Apply(___b =>  /*defaultBindModeOneTime*/ global::Uno.UI.Xaml.BindingHelper.SetBindingXBindProvider(___b, this, ___ctx => ___ctx is global::AppUno.MainPage ___tctx ? (object)(___tctx.ViewModel.Docs) : null, null , new [] {"ViewModel.Docs"})));
																c14.SetBinding(global::Windows.UI.Xaml.Controls.ListView.SelectedItemProperty, new Windows.UI.Xaml.Data.Binding{ Mode = global::Windows.UI.Xaml.Data.BindingMode.TwoWay/* Windows.UI.Xaml.Data.BindingMode/Windows.UI.Xaml.Data.BindingMode, TwoWay, Bind/Mode */,  }.Apply(___b =>  /*defaultBindModeOneTime*/ global::Uno.UI.Xaml.BindingHelper.SetBindingXBindProvider(___b, this, ___ctx => ___ctx is global::AppUno.MainPage ___tctx ? (object)(___tctx.ViewModel.SelectedDoc) : null, (___ctx, __value) => { if(___ctx is global::AppUno.MainPage ___tctx) ___tctx.ViewModel.SelectedDoc = (AppUno.Model.Doc)global::Windows.UI.Xaml.Markup.XamlBindingHelper.ConvertValue(typeof(AppUno.Model.Doc), __value); } , new [] {"ViewModel.SelectedDoc"})));
																/* _isTopLevelDictionary:False */
								this._component_2 = c14;
								global::Uno.UI.FrameworkElementHelper.SetBaseUri(c14, "file:///C:/Projects/AppUno-Finished/AppUno-Finished/AppUno.Shared/MainPage.xaml");
								c14.CreationComplete();
							}
							))
							,
						}
					}
					.MainPage_889a76a4c5f2c6eee929514aa1dfc438_XamlApply((MainPage_889a76a4c5f2c6eee929514aa1dfc438XamlApplyExtensions.XamlApplyHandler7)(c15 => 
					{
						nameScope.RegisterName("docListGrid", c15);
						this.docListGrid = c15;
						global::Windows.UI.Xaml.Controls.Grid.SetRow(c15, 1/* int/, 1, Grid/Row */);
						global::Uno.UI.FrameworkElementHelper.SetBaseUri(c15, "file:///C:/Projects/AppUno-Finished/AppUno-Finished/AppUno.Shared/MainPage.xaml");
						c15.CreationComplete();
					}
					))
					,
					new global::Windows.UI.Xaml.Controls.StackPanel
					{
						IsParsing = true
						,
						// Source ..\..\..\..\..\..\..\AppUno.Shared\MainPage.xaml (Line 53:6)
						Children = 
						{
							new global::Windows.UI.Xaml.Controls.TextBox
							{
								IsParsing = true
								,
								Header = @"Id"/* object/, Id, TextBox/Header */,
								Margin = new global::Windows.UI.Xaml.Thickness(10)/* Windows.UI.Xaml.Thickness/, 10, TextBox/Margin */,
								// Source ..\..\..\..\..\..\..\AppUno.Shared\MainPage.xaml (Line 54:8)
							}
							.MainPage_889a76a4c5f2c6eee929514aa1dfc438_XamlApply((MainPage_889a76a4c5f2c6eee929514aa1dfc438XamlApplyExtensions.XamlApplyHandler8)(c16 => 
							{
								c16.SetBinding(global::Windows.UI.Xaml.Controls.TextBox.TextProperty, new Windows.UI.Xaml.Data.Binding{ Mode = global::Windows.UI.Xaml.Data.BindingMode.TwoWay/* Windows.UI.Xaml.Data.BindingMode/Windows.UI.Xaml.Data.BindingMode, TwoWay, Bind/Mode */, UpdateSourceTrigger = global::Windows.UI.Xaml.Data.UpdateSourceTrigger.PropertyChanged/* Windows.UI.Xaml.Data.UpdateSourceTrigger/Windows.UI.Xaml.Data.UpdateSourceTrigger, PropertyChanged, Bind/UpdateSourceTrigger */,  }.Apply(___b =>  /*defaultBindModeOneTime*/ global::Uno.UI.Xaml.BindingHelper.SetBindingXBindProvider(___b, this, ___ctx => ___ctx is global::AppUno.MainPage ___tctx ? (object)(___tctx.ViewModel.SelectedDoc.Id) : null, (___ctx, __value) => { if(___ctx is global::AppUno.MainPage ___tctx) ___tctx.ViewModel.SelectedDoc.Id = (int)global::Windows.UI.Xaml.Markup.XamlBindingHelper.ConvertValue(typeof(int), __value); } , new [] {"ViewModel.SelectedDoc.Id"})));
																/* _isTopLevelDictionary:False */
								this._component_3 = c16;
								global::Uno.UI.FrameworkElementHelper.SetBaseUri(c16, "file:///C:/Projects/AppUno-Finished/AppUno-Finished/AppUno.Shared/MainPage.xaml");
								c16.CreationComplete();
							}
							))
							,
							new global::Windows.UI.Xaml.Controls.TextBox
							{
								IsParsing = true
								,
								Header = @"Title"/* object/, Title, TextBox/Header */,
								Margin = new global::Windows.UI.Xaml.Thickness(10)/* Windows.UI.Xaml.Thickness/, 10, TextBox/Margin */,
								// Source ..\..\..\..\..\..\..\AppUno.Shared\MainPage.xaml (Line 55:8)
							}
							.MainPage_889a76a4c5f2c6eee929514aa1dfc438_XamlApply((MainPage_889a76a4c5f2c6eee929514aa1dfc438XamlApplyExtensions.XamlApplyHandler8)(c17 => 
							{
								c17.SetBinding(global::Windows.UI.Xaml.Controls.TextBox.TextProperty, new Windows.UI.Xaml.Data.Binding{ Mode = global::Windows.UI.Xaml.Data.BindingMode.TwoWay/* Windows.UI.Xaml.Data.BindingMode/Windows.UI.Xaml.Data.BindingMode, TwoWay, Bind/Mode */, UpdateSourceTrigger = global::Windows.UI.Xaml.Data.UpdateSourceTrigger.PropertyChanged/* Windows.UI.Xaml.Data.UpdateSourceTrigger/Windows.UI.Xaml.Data.UpdateSourceTrigger, PropertyChanged, Bind/UpdateSourceTrigger */,  }.Apply(___b =>  /*defaultBindModeOneTime*/ global::Uno.UI.Xaml.BindingHelper.SetBindingXBindProvider(___b, this, ___ctx => ___ctx is global::AppUno.MainPage ___tctx ? (object)(___tctx.ViewModel.SelectedDoc.Title) : null, (___ctx, __value) => { if(___ctx is global::AppUno.MainPage ___tctx) ___tctx.ViewModel.SelectedDoc.Title = (string)global::Windows.UI.Xaml.Markup.XamlBindingHelper.ConvertValue(typeof(string), __value); } , new [] {"ViewModel.SelectedDoc.Title"})));
																/* _isTopLevelDictionary:False */
								this._component_4 = c17;
								global::Uno.UI.FrameworkElementHelper.SetBaseUri(c17, "file:///C:/Projects/AppUno-Finished/AppUno-Finished/AppUno.Shared/MainPage.xaml");
								c17.CreationComplete();
							}
							))
							,
							new global::Windows.UI.Xaml.Controls.TextBox
							{
								IsParsing = true
								,
								Header = @"Expiration"/* object/, Expiration, TextBox/Header */,
								Margin = new global::Windows.UI.Xaml.Thickness(10)/* Windows.UI.Xaml.Thickness/, 10, TextBox/Margin */,
								// Source ..\..\..\..\..\..\..\AppUno.Shared\MainPage.xaml (Line 56:8)
							}
							.MainPage_889a76a4c5f2c6eee929514aa1dfc438_XamlApply((MainPage_889a76a4c5f2c6eee929514aa1dfc438XamlApplyExtensions.XamlApplyHandler8)(c18 => 
							{
								c18.SetBinding(global::Windows.UI.Xaml.Controls.TextBox.TextProperty, new Windows.UI.Xaml.Data.Binding{ Mode = global::Windows.UI.Xaml.Data.BindingMode.TwoWay/* Windows.UI.Xaml.Data.BindingMode/Windows.UI.Xaml.Data.BindingMode, TwoWay, Bind/Mode */, UpdateSourceTrigger = global::Windows.UI.Xaml.Data.UpdateSourceTrigger.PropertyChanged/* Windows.UI.Xaml.Data.UpdateSourceTrigger/Windows.UI.Xaml.Data.UpdateSourceTrigger, PropertyChanged, Bind/UpdateSourceTrigger */,  }.Apply(___b =>  /*defaultBindModeOneTime*/ global::Uno.UI.Xaml.BindingHelper.SetBindingXBindProvider(___b, this, ___ctx => ___ctx is global::AppUno.MainPage ___tctx ? (object)(___tctx.ViewModel.SelectedDoc.Expiration) : null, (___ctx, __value) => { if(___ctx is global::AppUno.MainPage ___tctx) ___tctx.ViewModel.SelectedDoc.Expiration = (string)global::Windows.UI.Xaml.Markup.XamlBindingHelper.ConvertValue(typeof(string), __value); } , new [] {"ViewModel.SelectedDoc.Expiration"})));
																/* _isTopLevelDictionary:False */
								this._component_5 = c18;
								global::Uno.UI.FrameworkElementHelper.SetBaseUri(c18, "file:///C:/Projects/AppUno-Finished/AppUno-Finished/AppUno.Shared/MainPage.xaml");
								c18.CreationComplete();
							}
							))
							,
						}
					}
					.MainPage_889a76a4c5f2c6eee929514aa1dfc438_XamlApply((MainPage_889a76a4c5f2c6eee929514aa1dfc438XamlApplyExtensions.XamlApplyHandler4)(c19 => 
					{
						global::Windows.UI.Xaml.Controls.Grid.SetRow(c19, 1/* int/, 1, Grid/Row */);
						global::Windows.UI.Xaml.Controls.Grid.SetColumn(c19, 1/* int/, 1, Grid/Column */);
						c19.SetBinding(global::Windows.UI.Xaml.Controls.StackPanel.VisibilityProperty, new Windows.UI.Xaml.Data.Binding{ Mode = global::Windows.UI.Xaml.Data.BindingMode.OneWay/* Windows.UI.Xaml.Data.BindingMode/Windows.UI.Xaml.Data.BindingMode, OneWay, Bind/Mode */,  }.Apply(___b =>  /*defaultBindModeOneTime*/ global::Uno.UI.Xaml.BindingHelper.SetBindingXBindProvider(___b, this, ___ctx => ___ctx is global::AppUno.MainPage ___tctx ? (object)(___tctx.ViewModel.IsDocSelected) : null, null , new [] {"ViewModel.IsDocSelected"})));
												/* _isTopLevelDictionary:False */
						this._component_6 = c19;
						global::Uno.UI.FrameworkElementHelper.SetBaseUri(c19, "file:///C:/Projects/AppUno-Finished/AppUno-Finished/AppUno.Shared/MainPage.xaml");
						c19.CreationComplete();
					}
					))
					,
				}
			}
			.MainPage_889a76a4c5f2c6eee929514aa1dfc438_XamlApply((MainPage_889a76a4c5f2c6eee929514aa1dfc438XamlApplyExtensions.XamlApplyHandler7)(c20 => 
			{
				global::Uno.UI.FrameworkElementHelper.SetBaseUri(c20, "file:///C:/Projects/AppUno-Finished/AppUno-Finished/AppUno.Shared/MainPage.xaml");
				c20.CreationComplete();
			}
			))
			;
			
			this
			.Apply((c21 => 
			{
				// Source C:\Projects\AppUno-Finished\AppUno-Finished\AppUno.Shared\MainPage.xaml (Line 1:2)
				
				// WARNING Property c21.base does not exist on {http://schemas.microsoft.com/winfx/2006/xaml/presentation}Page, the namespace is http://www.w3.org/XML/1998/namespace. This error was considered irrelevant by the XamlFileGenerator
			}
			))
			.Apply((c22 => 
			{
				// Class AppUno.MainPage
				global::Uno.UI.ResourceResolverSingleton.Instance.ApplyResource(c22, global::Windows.UI.Xaml.Controls.Page.BackgroundProperty, "ApplicationPageBackgroundThemeBrush", isThemeResourceExtension: true, context: global::AppUno.Wasm.GlobalStaticResources.__ParseContext_);
				/* _isTopLevelDictionary:False */
				this._component_7 = c22;
				global::Uno.UI.FrameworkElementHelper.SetBaseUri(c22, "file:///C:/Projects/AppUno-Finished/AppUno-Finished/AppUno.Shared/MainPage.xaml");
				c22.CreationComplete();
			}
			))
			;
			OnInitializeCompleted();

			Bindings = new MainPage_Bindings(this);
			Loading += delegate
			{
				Bindings.Update();
				_component_0.UpdateResourceBindings();
				_component_1.UpdateResourceBindings();
				_component_2.UpdateResourceBindings();
				_component_3.UpdateResourceBindings();
				_component_4.UpdateResourceBindings();
				_component_5.UpdateResourceBindings();
				_component_6.UpdateResourceBindings();
				_component_7.UpdateResourceBindings();
			}
			;
		}
		partial void OnInitializeCompleted();
		private global::Windows.UI.Xaml.Data.ElementNameSubject _docListGridSubject = new global::Windows.UI.Xaml.Data.ElementNameSubject();
		private global::Windows.UI.Xaml.Controls.Grid docListGrid
		{
			get
			{
				return (global::Windows.UI.Xaml.Controls.Grid)_docListGridSubject.ElementInstance;
			}
			set
			{
				_docListGridSubject.ElementInstance = value;
			}
		}
		private global::System.Action __0_Click_ViewModel_AddDoc_Builder;
		private global::System.Action __1_Click_ViewModel_DeleteDoc_Builder;
		private class _MainPage_889a76a4c5f2c6eee929514aa1dfc438_AppUnoMainPageSC0
		{
			public _View Build(object __ResourceOwner_0)
			{
				var nameScope = new global::Windows.UI.Xaml.NameScope();
				_View __rootInstance = null;
				__rootInstance = 
				new global::Windows.UI.Xaml.Controls.StackPanel
				{
					IsParsing = true
					,
					Orientation = global::Windows.UI.Xaml.Controls.Orientation.Horizontal/* Windows.UI.Xaml.Controls.Orientation/, Horizontal, StackPanel/Orientation */,
					// Source ..\..\..\..\..\..\..\AppUno.Shared\MainPage.xaml (Line 44:14)
					Children = 
					{
						new global::Windows.UI.Xaml.Controls.TextBlock
						{
							IsParsing = true
							,
							FontWeight = FontWeights.Bold/* Windows.UI.Text.FontWeight/, Bold, TextBlock/FontWeight */,
							// Source ..\..\..\..\..\..\..\AppUno.Shared\MainPage.xaml (Line 45:16)
						}
						.MainPage_889a76a4c5f2c6eee929514aa1dfc438_XamlApply((MainPage_889a76a4c5f2c6eee929514aa1dfc438XamlApplyExtensions.XamlApplyHandler2)(c23 => 
						{
							c23.SetBinding(global::Windows.UI.Xaml.Controls.TextBlock.TextProperty, new Windows.UI.Xaml.Data.Binding{ Mode = global::Windows.UI.Xaml.Data.BindingMode.OneWay/* Windows.UI.Xaml.Data.BindingMode/Windows.UI.Xaml.Data.BindingMode, OneWay, Bind/Mode */,  }.Apply(___b => /*defaultBindModeOneTime*/ global::Uno.UI.Xaml.BindingHelper.SetBindingXBindProvider(___b, null, ___ctx => ___ctx is global::AppUno.Model.Doc ___tctx ? (object)(___tctx.Title) : null, null , new [] {"Title"})));
														/* _isTopLevelDictionary:False */
							this._component_0 = c23;
							global::Uno.UI.FrameworkElementHelper.SetBaseUri(c23, "file:///C:/Projects/AppUno-Finished/AppUno-Finished/AppUno.Shared/MainPage.xaml");
							c23.CreationComplete();
						}
						))
						,
						new global::Windows.UI.Xaml.Controls.TextBlock
						{
							IsParsing = true
							,
							Margin = new global::Windows.UI.Xaml.Thickness(5,0,0,0)/* Windows.UI.Xaml.Thickness/, 5 0 0 0, TextBlock/Margin */,
							// Source ..\..\..\..\..\..\..\AppUno.Shared\MainPage.xaml (Line 46:16)
						}
						.MainPage_889a76a4c5f2c6eee929514aa1dfc438_XamlApply((MainPage_889a76a4c5f2c6eee929514aa1dfc438XamlApplyExtensions.XamlApplyHandler2)(c24 => 
						{
							c24.SetBinding(global::Windows.UI.Xaml.Controls.TextBlock.TextProperty, new Windows.UI.Xaml.Data.Binding{ Mode = global::Windows.UI.Xaml.Data.BindingMode.OneWay/* Windows.UI.Xaml.Data.BindingMode/Windows.UI.Xaml.Data.BindingMode, OneWay, Bind/Mode */,  }.Apply(___b => /*defaultBindModeOneTime*/ global::Uno.UI.Xaml.BindingHelper.SetBindingXBindProvider(___b, null, ___ctx => ___ctx is global::AppUno.Model.Doc ___tctx ? (object)(___tctx.Expiration) : null, null , new [] {"Expiration"})));
														/* _isTopLevelDictionary:False */
							this._component_1 = c24;
							global::Uno.UI.FrameworkElementHelper.SetBaseUri(c24, "file:///C:/Projects/AppUno-Finished/AppUno-Finished/AppUno.Shared/MainPage.xaml");
							c24.CreationComplete();
						}
						))
						,
					}
				}
				.MainPage_889a76a4c5f2c6eee929514aa1dfc438_XamlApply((MainPage_889a76a4c5f2c6eee929514aa1dfc438XamlApplyExtensions.XamlApplyHandler4)(c25 => 
				{
					global::Uno.UI.FrameworkElementHelper.SetBaseUri(c25, "file:///C:/Projects/AppUno-Finished/AppUno-Finished/AppUno.Shared/MainPage.xaml");
					c25.CreationComplete();
				}
				))
				;
				if (__rootInstance is FrameworkElement __fe) 
				{
					__fe.Loading += delegate
					{
						_component_0.UpdateResourceBindings();
						_component_1.UpdateResourceBindings();
					}
					;
				}
				if (__rootInstance is DependencyObject d)
				{
					global::Windows.UI.Xaml.NameScope.SetNameScope(d, nameScope);
					global::Uno.UI.FrameworkElementHelper.AddObjectReference(d, this);
				}
				return __rootInstance;
			}
			private global::Windows.UI.Xaml.Controls.TextBlock _component_0;
			private global::Windows.UI.Xaml.Controls.TextBlock _component_1;
		}
		private global::Windows.UI.Xaml.Controls.Button _component_0;
		private global::Windows.UI.Xaml.Controls.Button _component_1;
		private global::Windows.UI.Xaml.Controls.ListView _component_2;
		private global::Windows.UI.Xaml.Controls.TextBox _component_3;
		private global::Windows.UI.Xaml.Controls.TextBox _component_4;
		private global::Windows.UI.Xaml.Controls.TextBox _component_5;
		private global::Windows.UI.Xaml.Controls.StackPanel _component_6;
		private global::Windows.UI.Xaml.Controls.Page _component_7;
		private interface IMainPage_Bindings
		{
			void Initialize();
			void Update();
			void StopTracking();
		}
		#pragma warning disable 0169 //  Suppress unused field warning in case Bindings is not used.
		private IMainPage_Bindings Bindings;
		#pragma warning restore 0169
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		private class MainPage_Bindings : IMainPage_Bindings
		{
			#if UNO_HAS_UIELEMENT_IMPLICIT_PINNING
			private global::System.WeakReference _ownerReference;
			private MainPage Owner { get => (MainPage)_ownerReference?.Target; set => _ownerReference = new global::System.WeakReference(value); }
			#else
			private MainPage Owner { get; set; }
			#endif
			public MainPage_Bindings(MainPage owner)
			{
				Owner = owner;
			}
			void IMainPage_Bindings.Initialize()
			{
			}
			void IMainPage_Bindings.Update()
			{
				var owner = Owner;
				owner._component_0.ApplyXBind();
				owner.__0_Click_ViewModel_AddDoc_Builder?.Invoke();
				owner.__0_Click_ViewModel_AddDoc_Builder = null;
				owner.__1_Click_ViewModel_DeleteDoc_Builder?.Invoke();
				owner.__1_Click_ViewModel_DeleteDoc_Builder = null;
				owner._component_1.ApplyXBind();
				owner.__0_Click_ViewModel_AddDoc_Builder?.Invoke();
				owner.__0_Click_ViewModel_AddDoc_Builder = null;
				owner.__1_Click_ViewModel_DeleteDoc_Builder?.Invoke();
				owner.__1_Click_ViewModel_DeleteDoc_Builder = null;
				owner._component_2.ApplyXBind();
				owner.__0_Click_ViewModel_AddDoc_Builder?.Invoke();
				owner.__0_Click_ViewModel_AddDoc_Builder = null;
				owner.__1_Click_ViewModel_DeleteDoc_Builder?.Invoke();
				owner.__1_Click_ViewModel_DeleteDoc_Builder = null;
				owner._component_3.ApplyXBind();
				owner.__0_Click_ViewModel_AddDoc_Builder?.Invoke();
				owner.__0_Click_ViewModel_AddDoc_Builder = null;
				owner.__1_Click_ViewModel_DeleteDoc_Builder?.Invoke();
				owner.__1_Click_ViewModel_DeleteDoc_Builder = null;
				owner._component_4.ApplyXBind();
				owner.__0_Click_ViewModel_AddDoc_Builder?.Invoke();
				owner.__0_Click_ViewModel_AddDoc_Builder = null;
				owner.__1_Click_ViewModel_DeleteDoc_Builder?.Invoke();
				owner.__1_Click_ViewModel_DeleteDoc_Builder = null;
				owner._component_5.ApplyXBind();
				owner.__0_Click_ViewModel_AddDoc_Builder?.Invoke();
				owner.__0_Click_ViewModel_AddDoc_Builder = null;
				owner.__1_Click_ViewModel_DeleteDoc_Builder?.Invoke();
				owner.__1_Click_ViewModel_DeleteDoc_Builder = null;
				owner._component_6.ApplyXBind();
				owner.__0_Click_ViewModel_AddDoc_Builder?.Invoke();
				owner.__0_Click_ViewModel_AddDoc_Builder = null;
				owner.__1_Click_ViewModel_DeleteDoc_Builder?.Invoke();
				owner.__1_Click_ViewModel_DeleteDoc_Builder = null;
				owner.__0_Click_ViewModel_AddDoc_Builder?.Invoke();
				owner.__0_Click_ViewModel_AddDoc_Builder = null;
				owner.__1_Click_ViewModel_DeleteDoc_Builder?.Invoke();
				owner.__1_Click_ViewModel_DeleteDoc_Builder = null;
			}
			void IMainPage_Bindings.StopTracking()
			{
			}
		}
	}
}
namespace AppUno.Wasm
{
	static class MainPage_889a76a4c5f2c6eee929514aa1dfc438XamlApplyExtensions
	{
		public delegate void XamlApplyHandler0(global::Windows.UI.Xaml.Controls.ColumnDefinition instance);
		[System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
		public static global::Windows.UI.Xaml.Controls.ColumnDefinition MainPage_889a76a4c5f2c6eee929514aa1dfc438_XamlApply(this global::Windows.UI.Xaml.Controls.ColumnDefinition instance, XamlApplyHandler0 handler)
		{
			handler(instance);
			return instance;
		}
		public delegate void XamlApplyHandler1(global::Windows.UI.Xaml.Controls.RowDefinition instance);
		[System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
		public static global::Windows.UI.Xaml.Controls.RowDefinition MainPage_889a76a4c5f2c6eee929514aa1dfc438_XamlApply(this global::Windows.UI.Xaml.Controls.RowDefinition instance, XamlApplyHandler1 handler)
		{
			handler(instance);
			return instance;
		}
		public delegate void XamlApplyHandler2(global::Windows.UI.Xaml.Controls.TextBlock instance);
		[System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
		public static global::Windows.UI.Xaml.Controls.TextBlock MainPage_889a76a4c5f2c6eee929514aa1dfc438_XamlApply(this global::Windows.UI.Xaml.Controls.TextBlock instance, XamlApplyHandler2 handler)
		{
			handler(instance);
			return instance;
		}
		public delegate void XamlApplyHandler3(global::Windows.UI.Xaml.Controls.SymbolIcon instance);
		[System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
		public static global::Windows.UI.Xaml.Controls.SymbolIcon MainPage_889a76a4c5f2c6eee929514aa1dfc438_XamlApply(this global::Windows.UI.Xaml.Controls.SymbolIcon instance, XamlApplyHandler3 handler)
		{
			handler(instance);
			return instance;
		}
		public delegate void XamlApplyHandler4(global::Windows.UI.Xaml.Controls.StackPanel instance);
		[System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
		public static global::Windows.UI.Xaml.Controls.StackPanel MainPage_889a76a4c5f2c6eee929514aa1dfc438_XamlApply(this global::Windows.UI.Xaml.Controls.StackPanel instance, XamlApplyHandler4 handler)
		{
			handler(instance);
			return instance;
		}
		public delegate void XamlApplyHandler5(global::Windows.UI.Xaml.Controls.Button instance);
		[System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
		public static global::Windows.UI.Xaml.Controls.Button MainPage_889a76a4c5f2c6eee929514aa1dfc438_XamlApply(this global::Windows.UI.Xaml.Controls.Button instance, XamlApplyHandler5 handler)
		{
			handler(instance);
			return instance;
		}
		public delegate void XamlApplyHandler6(global::Windows.UI.Xaml.Controls.ListView instance);
		[System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
		public static global::Windows.UI.Xaml.Controls.ListView MainPage_889a76a4c5f2c6eee929514aa1dfc438_XamlApply(this global::Windows.UI.Xaml.Controls.ListView instance, XamlApplyHandler6 handler)
		{
			handler(instance);
			return instance;
		}
		public delegate void XamlApplyHandler7(global::Windows.UI.Xaml.Controls.Grid instance);
		[System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
		public static global::Windows.UI.Xaml.Controls.Grid MainPage_889a76a4c5f2c6eee929514aa1dfc438_XamlApply(this global::Windows.UI.Xaml.Controls.Grid instance, XamlApplyHandler7 handler)
		{
			handler(instance);
			return instance;
		}
		public delegate void XamlApplyHandler8(global::Windows.UI.Xaml.Controls.TextBox instance);
		[System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
		public static global::Windows.UI.Xaml.Controls.TextBox MainPage_889a76a4c5f2c6eee929514aa1dfc438_XamlApply(this global::Windows.UI.Xaml.Controls.TextBox instance, XamlApplyHandler8 handler)
		{
			handler(instance);
			return instance;
		}
	}
}
