﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GeolabOldCcar.Models
{
	using System.Data.Linq;
	using System.Data.Linq.Mapping;
	using System.Data;
	using System.Collections.Generic;
	using System.Reflection;
	using System.Linq;
	using System.Linq.Expressions;
	using System.ComponentModel;
	using System;
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="GeolabDatabaseForOldCar")]
	public partial class DataConnectDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertEmail(Email instance);
    partial void UpdateEmail(Email instance);
    partial void DeleteEmail(Email instance);
    partial void InsertIcon(Icon instance);
    partial void UpdateIcon(Icon instance);
    partial void DeleteIcon(Icon instance);
    partial void InsertSlider(Slider instance);
    partial void UpdateSlider(Slider instance);
    partial void DeleteSlider(Slider instance);
    #endregion
		
		public DataConnectDataContext() : 
				base(global::System.Configuration.ConfigurationManager.ConnectionStrings["GeolabDatabaseForOldCarConnectionString"].ConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public DataConnectDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataConnectDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataConnectDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataConnectDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Email> Emails
		{
			get
			{
				return this.GetTable<Email>();
			}
		}
		
		public System.Data.Linq.Table<Icon> Icons
		{
			get
			{
				return this.GetTable<Icon>();
			}
		}
		
		public System.Data.Linq.Table<Slider> Sliders
		{
			get
			{
				return this.GetTable<Slider>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Email")]
	public partial class Email : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private string _EmailFrom;
		
		private string _EmailTo;
		
		private string _EmailText;
		
		private string _gender;
		
		private string _EmailSubject;
		
		private System.Nullable<bool> _images;
		
		private System.Nullable<bool> _promotions;
		
		private System.Nullable<bool> _updates;
		
		private System.Nullable<bool> _JobOffer;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnEmailFromChanging(string value);
    partial void OnEmailFromChanged();
    partial void OnEmailToChanging(string value);
    partial void OnEmailToChanged();
    partial void OnEmailTextChanging(string value);
    partial void OnEmailTextChanged();
    partial void OngenderChanging(string value);
    partial void OngenderChanged();
    partial void OnEmailSubjectChanging(string value);
    partial void OnEmailSubjectChanged();
    partial void OnimagesChanging(System.Nullable<bool> value);
    partial void OnimagesChanged();
    partial void OnpromotionsChanging(System.Nullable<bool> value);
    partial void OnpromotionsChanged();
    partial void OnupdatesChanging(System.Nullable<bool> value);
    partial void OnupdatesChanged();
    partial void OnJobOfferChanging(System.Nullable<bool> value);
    partial void OnJobOfferChanged();
    #endregion
		
		public Email()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this.OnIdChanging(value);
					this.SendPropertyChanging();
					this._Id = value;
					this.SendPropertyChanged("Id");
					this.OnIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_EmailFrom", DbType="NVarChar(50)")]
		public string EmailFrom
		{
			get
			{
				return this._EmailFrom;
			}
			set
			{
				if ((this._EmailFrom != value))
				{
					this.OnEmailFromChanging(value);
					this.SendPropertyChanging();
					this._EmailFrom = value;
					this.SendPropertyChanged("EmailFrom");
					this.OnEmailFromChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_EmailTo", DbType="NVarChar(50)")]
		public string EmailTo
		{
			get
			{
				return this._EmailTo;
			}
			set
			{
				if ((this._EmailTo != value))
				{
					this.OnEmailToChanging(value);
					this.SendPropertyChanging();
					this._EmailTo = value;
					this.SendPropertyChanged("EmailTo");
					this.OnEmailToChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_EmailText", DbType="NVarChar(MAX)")]
		public string EmailText
		{
			get
			{
				return this._EmailText;
			}
			set
			{
				if ((this._EmailText != value))
				{
					this.OnEmailTextChanging(value);
					this.SendPropertyChanging();
					this._EmailText = value;
					this.SendPropertyChanged("EmailText");
					this.OnEmailTextChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_gender", DbType="NVarChar(5)")]
		public string gender
		{
			get
			{
				return this._gender;
			}
			set
			{
				if ((this._gender != value))
				{
					this.OngenderChanging(value);
					this.SendPropertyChanging();
					this._gender = value;
					this.SendPropertyChanged("gender");
					this.OngenderChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_EmailSubject", DbType="NVarChar(50)")]
		public string EmailSubject
		{
			get
			{
				return this._EmailSubject;
			}
			set
			{
				if ((this._EmailSubject != value))
				{
					this.OnEmailSubjectChanging(value);
					this.SendPropertyChanging();
					this._EmailSubject = value;
					this.SendPropertyChanged("EmailSubject");
					this.OnEmailSubjectChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_images", DbType="Bit")]
		public System.Nullable<bool> images
		{
			get
			{
				return this._images;
			}
			set
			{
				if ((this._images != value))
				{
					this.OnimagesChanging(value);
					this.SendPropertyChanging();
					this._images = value;
					this.SendPropertyChanged("images");
					this.OnimagesChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_promotions", DbType="Bit")]
		public System.Nullable<bool> promotions
		{
			get
			{
				return this._promotions;
			}
			set
			{
				if ((this._promotions != value))
				{
					this.OnpromotionsChanging(value);
					this.SendPropertyChanging();
					this._promotions = value;
					this.SendPropertyChanged("promotions");
					this.OnpromotionsChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_updates", DbType="Bit")]
		public System.Nullable<bool> updates
		{
			get
			{
				return this._updates;
			}
			set
			{
				if ((this._updates != value))
				{
					this.OnupdatesChanging(value);
					this.SendPropertyChanging();
					this._updates = value;
					this.SendPropertyChanged("updates");
					this.OnupdatesChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_JobOffer", DbType="Bit")]
		public System.Nullable<bool> JobOffer
		{
			get
			{
				return this._JobOffer;
			}
			set
			{
				if ((this._JobOffer != value))
				{
					this.OnJobOfferChanging(value);
					this.SendPropertyChanging();
					this._JobOffer = value;
					this.SendPropertyChanged("JobOffer");
					this.OnJobOfferChanged();
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Icon")]
	public partial class Icon : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private string _OptionName;
		
		private string _OptionIcon;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnOptionNameChanging(string value);
    partial void OnOptionNameChanged();
    partial void OnOptionIconChanging(string value);
    partial void OnOptionIconChanged();
    #endregion
		
		public Icon()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this.OnIdChanging(value);
					this.SendPropertyChanging();
					this._Id = value;
					this.SendPropertyChanged("Id");
					this.OnIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_OptionName", DbType="NVarChar(50)")]
		public string OptionName
		{
			get
			{
				return this._OptionName;
			}
			set
			{
				if ((this._OptionName != value))
				{
					this.OnOptionNameChanging(value);
					this.SendPropertyChanging();
					this._OptionName = value;
					this.SendPropertyChanged("OptionName");
					this.OnOptionNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_OptionIcon", DbType="NVarChar(50)")]
		public string OptionIcon
		{
			get
			{
				return this._OptionIcon;
			}
			set
			{
				if ((this._OptionIcon != value))
				{
					this.OnOptionIconChanging(value);
					this.SendPropertyChanging();
					this._OptionIcon = value;
					this.SendPropertyChanged("OptionIcon");
					this.OnOptionIconChanged();
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Slider")]
	public partial class Slider : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private string _SliderName;
		
		private string _SliderUrl;
		
		private string _SliderImageExt;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnSliderNameChanging(string value);
    partial void OnSliderNameChanged();
    partial void OnSliderUrlChanging(string value);
    partial void OnSliderUrlChanged();
    partial void OnSliderImageExtChanging(string value);
    partial void OnSliderImageExtChanged();
    #endregion
		
		public Slider()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this.OnIdChanging(value);
					this.SendPropertyChanging();
					this._Id = value;
					this.SendPropertyChanged("Id");
					this.OnIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SliderName", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string SliderName
		{
			get
			{
				return this._SliderName;
			}
			set
			{
				if ((this._SliderName != value))
				{
					this.OnSliderNameChanging(value);
					this.SendPropertyChanging();
					this._SliderName = value;
					this.SendPropertyChanged("SliderName");
					this.OnSliderNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SliderUrl", DbType="NVarChar(50)")]
		public string SliderUrl
		{
			get
			{
				return this._SliderUrl;
			}
			set
			{
				if ((this._SliderUrl != value))
				{
					this.OnSliderUrlChanging(value);
					this.SendPropertyChanging();
					this._SliderUrl = value;
					this.SendPropertyChanged("SliderUrl");
					this.OnSliderUrlChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SliderImageExt", DbType="NVarChar(5)")]
		public string SliderImageExt
		{
			get
			{
				return this._SliderImageExt;
			}
			set
			{
				if ((this._SliderImageExt != value))
				{
					this.OnSliderImageExtChanging(value);
					this.SendPropertyChanging();
					this._SliderImageExt = value;
					this.SendPropertyChanged("SliderImageExt");
					this.OnSliderImageExtChanged();
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
}
#pragma warning restore 1591