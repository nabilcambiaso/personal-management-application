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

namespace GESTIONPERSONNEL
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="GESTIONPERSONNEL")]
	public partial class DataClasses1DataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertPROFESSION(PROFESSION instance);
    partial void UpdatePROFESSION(PROFESSION instance);
    partial void DeletePROFESSION(PROFESSION instance);
    partial void InsertTRAVAIL(TRAVAIL instance);
    partial void UpdateTRAVAIL(TRAVAIL instance);
    partial void DeleteTRAVAIL(TRAVAIL instance);
    partial void InsertCONGE(CONGE instance);
    partial void UpdateCONGE(CONGE instance);
    partial void DeleteCONGE(CONGE instance);
    partial void InsertADMIN(ADMIN instance);
    partial void UpdateADMIN(ADMIN instance);
    partial void DeleteADMIN(ADMIN instance);
    partial void InsertPERSONNEL(PERSONNEL instance);
    partial void UpdatePERSONNEL(PERSONNEL instance);
    partial void DeletePERSONNEL(PERSONNEL instance);
    partial void InsertUSER(USER instance);
    partial void UpdateUSER(USER instance);
    partial void DeleteUSER(USER instance);
    #endregion
		
		public DataClasses1DataContext() : 
				base(global::GESTIONPERSONNEL.Properties.Settings.Default.GESTIONPERSONNELConnectionString1, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<PROFESSION> PROFESSIONs
		{
			get
			{
				return this.GetTable<PROFESSION>();
			}
		}
		
		public System.Data.Linq.Table<TRAVAIL> TRAVAILs
		{
			get
			{
				return this.GetTable<TRAVAIL>();
			}
		}
		
		public System.Data.Linq.Table<CONGE> CONGEs
		{
			get
			{
				return this.GetTable<CONGE>();
			}
		}
		
		public System.Data.Linq.Table<ADMIN> ADMINs
		{
			get
			{
				return this.GetTable<ADMIN>();
			}
		}
		
		public System.Data.Linq.Table<PERSONNEL> PERSONNELs
		{
			get
			{
				return this.GetTable<PERSONNEL>();
			}
		}
		
		public System.Data.Linq.Table<USER> USERs
		{
			get
			{
				return this.GetTable<USER>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.PROFESSION")]
	public partial class PROFESSION : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _CODE_PROFESSION;
		
		private string _INTITULE;
		
		private System.Nullable<float> _SALAIRE;
		
		private System.Nullable<float> _PRIME;
		
		private EntitySet<TRAVAIL> _TRAVAILs;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnCODE_PROFESSIONChanging(int value);
    partial void OnCODE_PROFESSIONChanged();
    partial void OnINTITULEChanging(string value);
    partial void OnINTITULEChanged();
    partial void OnSALAIREChanging(System.Nullable<float> value);
    partial void OnSALAIREChanged();
    partial void OnPRIMEChanging(System.Nullable<float> value);
    partial void OnPRIMEChanged();
    #endregion
		
		public PROFESSION()
		{
			this._TRAVAILs = new EntitySet<TRAVAIL>(new Action<TRAVAIL>(this.attach_TRAVAILs), new Action<TRAVAIL>(this.detach_TRAVAILs));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CODE_PROFESSION", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int CODE_PROFESSION
		{
			get
			{
				return this._CODE_PROFESSION;
			}
			set
			{
				if ((this._CODE_PROFESSION != value))
				{
					this.OnCODE_PROFESSIONChanging(value);
					this.SendPropertyChanging();
					this._CODE_PROFESSION = value;
					this.SendPropertyChanged("CODE_PROFESSION");
					this.OnCODE_PROFESSIONChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_INTITULE", DbType="VarChar(50)")]
		public string INTITULE
		{
			get
			{
				return this._INTITULE;
			}
			set
			{
				if ((this._INTITULE != value))
				{
					this.OnINTITULEChanging(value);
					this.SendPropertyChanging();
					this._INTITULE = value;
					this.SendPropertyChanged("INTITULE");
					this.OnINTITULEChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SALAIRE", DbType="Real")]
		public System.Nullable<float> SALAIRE
		{
			get
			{
				return this._SALAIRE;
			}
			set
			{
				if ((this._SALAIRE != value))
				{
					this.OnSALAIREChanging(value);
					this.SendPropertyChanging();
					this._SALAIRE = value;
					this.SendPropertyChanged("SALAIRE");
					this.OnSALAIREChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PRIME", DbType="Real")]
		public System.Nullable<float> PRIME
		{
			get
			{
				return this._PRIME;
			}
			set
			{
				if ((this._PRIME != value))
				{
					this.OnPRIMEChanging(value);
					this.SendPropertyChanging();
					this._PRIME = value;
					this.SendPropertyChanged("PRIME");
					this.OnPRIMEChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="PROFESSION_TRAVAIL", Storage="_TRAVAILs", ThisKey="CODE_PROFESSION", OtherKey="CODE_PROFESSION")]
		public EntitySet<TRAVAIL> TRAVAILs
		{
			get
			{
				return this._TRAVAILs;
			}
			set
			{
				this._TRAVAILs.Assign(value);
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
		
		private void attach_TRAVAILs(TRAVAIL entity)
		{
			this.SendPropertyChanging();
			entity.PROFESSION = this;
		}
		
		private void detach_TRAVAILs(TRAVAIL entity)
		{
			this.SendPropertyChanging();
			entity.PROFESSION = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.TRAVAIL")]
	public partial class TRAVAIL : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _CIN;
		
		private int _CODE_PROFESSION;
		
		private System.Nullable<System.DateTime> _DATE_TRAVAIL;
		
		private System.Nullable<int> _DUREE;
		
		private EntityRef<PROFESSION> _PROFESSION;
		
		private EntityRef<PERSONNEL> _PERSONNEL;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnCINChanging(string value);
    partial void OnCINChanged();
    partial void OnCODE_PROFESSIONChanging(int value);
    partial void OnCODE_PROFESSIONChanged();
    partial void OnDATE_TRAVAILChanging(System.Nullable<System.DateTime> value);
    partial void OnDATE_TRAVAILChanged();
    partial void OnDUREEChanging(System.Nullable<int> value);
    partial void OnDUREEChanged();
    #endregion
		
		public TRAVAIL()
		{
			this._PROFESSION = default(EntityRef<PROFESSION>);
			this._PERSONNEL = default(EntityRef<PERSONNEL>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CIN", DbType="VarChar(10) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string CIN
		{
			get
			{
				return this._CIN;
			}
			set
			{
				if ((this._CIN != value))
				{
					if (this._PERSONNEL.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnCINChanging(value);
					this.SendPropertyChanging();
					this._CIN = value;
					this.SendPropertyChanged("CIN");
					this.OnCINChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CODE_PROFESSION", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int CODE_PROFESSION
		{
			get
			{
				return this._CODE_PROFESSION;
			}
			set
			{
				if ((this._CODE_PROFESSION != value))
				{
					if (this._PROFESSION.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnCODE_PROFESSIONChanging(value);
					this.SendPropertyChanging();
					this._CODE_PROFESSION = value;
					this.SendPropertyChanged("CODE_PROFESSION");
					this.OnCODE_PROFESSIONChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DATE_TRAVAIL", DbType="Date")]
		public System.Nullable<System.DateTime> DATE_TRAVAIL
		{
			get
			{
				return this._DATE_TRAVAIL;
			}
			set
			{
				if ((this._DATE_TRAVAIL != value))
				{
					this.OnDATE_TRAVAILChanging(value);
					this.SendPropertyChanging();
					this._DATE_TRAVAIL = value;
					this.SendPropertyChanged("DATE_TRAVAIL");
					this.OnDATE_TRAVAILChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DUREE", DbType="Int")]
		public System.Nullable<int> DUREE
		{
			get
			{
				return this._DUREE;
			}
			set
			{
				if ((this._DUREE != value))
				{
					this.OnDUREEChanging(value);
					this.SendPropertyChanging();
					this._DUREE = value;
					this.SendPropertyChanged("DUREE");
					this.OnDUREEChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="PROFESSION_TRAVAIL", Storage="_PROFESSION", ThisKey="CODE_PROFESSION", OtherKey="CODE_PROFESSION", IsForeignKey=true)]
		public PROFESSION PROFESSION
		{
			get
			{
				return this._PROFESSION.Entity;
			}
			set
			{
				PROFESSION previousValue = this._PROFESSION.Entity;
				if (((previousValue != value) 
							|| (this._PROFESSION.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._PROFESSION.Entity = null;
						previousValue.TRAVAILs.Remove(this);
					}
					this._PROFESSION.Entity = value;
					if ((value != null))
					{
						value.TRAVAILs.Add(this);
						this._CODE_PROFESSION = value.CODE_PROFESSION;
					}
					else
					{
						this._CODE_PROFESSION = default(int);
					}
					this.SendPropertyChanged("PROFESSION");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="PERSONNEL_TRAVAIL", Storage="_PERSONNEL", ThisKey="CIN", OtherKey="CIN", IsForeignKey=true)]
		public PERSONNEL PERSONNEL
		{
			get
			{
				return this._PERSONNEL.Entity;
			}
			set
			{
				PERSONNEL previousValue = this._PERSONNEL.Entity;
				if (((previousValue != value) 
							|| (this._PERSONNEL.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._PERSONNEL.Entity = null;
						previousValue.TRAVAILs.Remove(this);
					}
					this._PERSONNEL.Entity = value;
					if ((value != null))
					{
						value.TRAVAILs.Add(this);
						this._CIN = value.CIN;
					}
					else
					{
						this._CIN = default(string);
					}
					this.SendPropertyChanged("PERSONNEL");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.CONGE")]
	public partial class CONGE : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _CIN;
		
		private System.DateTime _DATE_CONGE;
		
		private System.Nullable<int> _DUREE;
		
		private string _ETAT;
		
		private EntityRef<PERSONNEL> _PERSONNEL;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnCINChanging(string value);
    partial void OnCINChanged();
    partial void OnDATE_CONGEChanging(System.DateTime value);
    partial void OnDATE_CONGEChanged();
    partial void OnDUREEChanging(System.Nullable<int> value);
    partial void OnDUREEChanged();
    partial void OnETATChanging(string value);
    partial void OnETATChanged();
    #endregion
		
		public CONGE()
		{
			this._PERSONNEL = default(EntityRef<PERSONNEL>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CIN", DbType="VarChar(10) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string CIN
		{
			get
			{
				return this._CIN;
			}
			set
			{
				if ((this._CIN != value))
				{
					if (this._PERSONNEL.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnCINChanging(value);
					this.SendPropertyChanging();
					this._CIN = value;
					this.SendPropertyChanged("CIN");
					this.OnCINChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DATE_CONGE", DbType="Date NOT NULL", IsPrimaryKey=true)]
		public System.DateTime DATE_CONGE
		{
			get
			{
				return this._DATE_CONGE;
			}
			set
			{
				if ((this._DATE_CONGE != value))
				{
					this.OnDATE_CONGEChanging(value);
					this.SendPropertyChanging();
					this._DATE_CONGE = value;
					this.SendPropertyChanged("DATE_CONGE");
					this.OnDATE_CONGEChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DUREE", DbType="Int")]
		public System.Nullable<int> DUREE
		{
			get
			{
				return this._DUREE;
			}
			set
			{
				if ((this._DUREE != value))
				{
					this.OnDUREEChanging(value);
					this.SendPropertyChanging();
					this._DUREE = value;
					this.SendPropertyChanged("DUREE");
					this.OnDUREEChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ETAT", DbType="VarChar(30) NOT NULL", CanBeNull=false)]
		public string ETAT
		{
			get
			{
				return this._ETAT;
			}
			set
			{
				if ((this._ETAT != value))
				{
					this.OnETATChanging(value);
					this.SendPropertyChanging();
					this._ETAT = value;
					this.SendPropertyChanged("ETAT");
					this.OnETATChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="PERSONNEL_CONGE", Storage="_PERSONNEL", ThisKey="CIN", OtherKey="CIN", IsForeignKey=true)]
		public PERSONNEL PERSONNEL
		{
			get
			{
				return this._PERSONNEL.Entity;
			}
			set
			{
				PERSONNEL previousValue = this._PERSONNEL.Entity;
				if (((previousValue != value) 
							|| (this._PERSONNEL.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._PERSONNEL.Entity = null;
						previousValue.CONGEs.Remove(this);
					}
					this._PERSONNEL.Entity = value;
					if ((value != null))
					{
						value.CONGEs.Add(this);
						this._CIN = value.CIN;
					}
					else
					{
						this._CIN = default(string);
					}
					this.SendPropertyChanged("PERSONNEL");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.ADMIN")]
	public partial class ADMIN : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _USERNAME;
		
		private string _PASSWORD;
		
		private int _CODE;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnUSERNAMEChanging(string value);
    partial void OnUSERNAMEChanged();
    partial void OnPASSWORDChanging(string value);
    partial void OnPASSWORDChanged();
    partial void OnCODEChanging(int value);
    partial void OnCODEChanged();
    #endregion
		
		public ADMIN()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_USERNAME", DbType="VarChar(100)")]
		public string USERNAME
		{
			get
			{
				return this._USERNAME;
			}
			set
			{
				if ((this._USERNAME != value))
				{
					this.OnUSERNAMEChanging(value);
					this.SendPropertyChanging();
					this._USERNAME = value;
					this.SendPropertyChanged("USERNAME");
					this.OnUSERNAMEChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PASSWORD", DbType="VarChar(50)")]
		public string PASSWORD
		{
			get
			{
				return this._PASSWORD;
			}
			set
			{
				if ((this._PASSWORD != value))
				{
					this.OnPASSWORDChanging(value);
					this.SendPropertyChanging();
					this._PASSWORD = value;
					this.SendPropertyChanged("PASSWORD");
					this.OnPASSWORDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CODE", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int CODE
		{
			get
			{
				return this._CODE;
			}
			set
			{
				if ((this._CODE != value))
				{
					this.OnCODEChanging(value);
					this.SendPropertyChanging();
					this._CODE = value;
					this.SendPropertyChanged("CODE");
					this.OnCODEChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.PERSONNEL")]
	public partial class PERSONNEL : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _CIN;
		
		private string _NOM;
		
		private string _PRENOM;
		
		private string _ADRESSE;
		
		private System.Nullable<int> _NUMTEL;
		
		private string _image;
		
		private EntitySet<TRAVAIL> _TRAVAILs;
		
		private EntitySet<CONGE> _CONGEs;
		
		private EntityRef<USER> _USER;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnCINChanging(string value);
    partial void OnCINChanged();
    partial void OnNOMChanging(string value);
    partial void OnNOMChanged();
    partial void OnPRENOMChanging(string value);
    partial void OnPRENOMChanged();
    partial void OnADRESSEChanging(string value);
    partial void OnADRESSEChanged();
    partial void OnNUMTELChanging(System.Nullable<int> value);
    partial void OnNUMTELChanged();
    partial void OnimageChanging(string value);
    partial void OnimageChanged();
    #endregion
		
		public PERSONNEL()
		{
			this._TRAVAILs = new EntitySet<TRAVAIL>(new Action<TRAVAIL>(this.attach_TRAVAILs), new Action<TRAVAIL>(this.detach_TRAVAILs));
			this._CONGEs = new EntitySet<CONGE>(new Action<CONGE>(this.attach_CONGEs), new Action<CONGE>(this.detach_CONGEs));
			this._USER = default(EntityRef<USER>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CIN", DbType="VarChar(10) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string CIN
		{
			get
			{
				return this._CIN;
			}
			set
			{
				if ((this._CIN != value))
				{
					this.OnCINChanging(value);
					this.SendPropertyChanging();
					this._CIN = value;
					this.SendPropertyChanged("CIN");
					this.OnCINChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NOM", DbType="VarChar(20)")]
		public string NOM
		{
			get
			{
				return this._NOM;
			}
			set
			{
				if ((this._NOM != value))
				{
					this.OnNOMChanging(value);
					this.SendPropertyChanging();
					this._NOM = value;
					this.SendPropertyChanged("NOM");
					this.OnNOMChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PRENOM", DbType="VarChar(20)")]
		public string PRENOM
		{
			get
			{
				return this._PRENOM;
			}
			set
			{
				if ((this._PRENOM != value))
				{
					this.OnPRENOMChanging(value);
					this.SendPropertyChanging();
					this._PRENOM = value;
					this.SendPropertyChanged("PRENOM");
					this.OnPRENOMChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ADRESSE", DbType="VarChar(200)")]
		public string ADRESSE
		{
			get
			{
				return this._ADRESSE;
			}
			set
			{
				if ((this._ADRESSE != value))
				{
					this.OnADRESSEChanging(value);
					this.SendPropertyChanging();
					this._ADRESSE = value;
					this.SendPropertyChanged("ADRESSE");
					this.OnADRESSEChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NUMTEL", DbType="Int")]
		public System.Nullable<int> NUMTEL
		{
			get
			{
				return this._NUMTEL;
			}
			set
			{
				if ((this._NUMTEL != value))
				{
					this.OnNUMTELChanging(value);
					this.SendPropertyChanging();
					this._NUMTEL = value;
					this.SendPropertyChanged("NUMTEL");
					this.OnNUMTELChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_image", DbType="NVarChar(30)")]
		public string image
		{
			get
			{
				return this._image;
			}
			set
			{
				if ((this._image != value))
				{
					this.OnimageChanging(value);
					this.SendPropertyChanging();
					this._image = value;
					this.SendPropertyChanged("image");
					this.OnimageChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="PERSONNEL_TRAVAIL", Storage="_TRAVAILs", ThisKey="CIN", OtherKey="CIN")]
		public EntitySet<TRAVAIL> TRAVAILs
		{
			get
			{
				return this._TRAVAILs;
			}
			set
			{
				this._TRAVAILs.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="PERSONNEL_CONGE", Storage="_CONGEs", ThisKey="CIN", OtherKey="CIN")]
		public EntitySet<CONGE> CONGEs
		{
			get
			{
				return this._CONGEs;
			}
			set
			{
				this._CONGEs.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="PERSONNEL_USER", Storage="_USER", ThisKey="CIN", OtherKey="CIN", IsUnique=true, IsForeignKey=false)]
		public USER USER
		{
			get
			{
				return this._USER.Entity;
			}
			set
			{
				USER previousValue = this._USER.Entity;
				if (((previousValue != value) 
							|| (this._USER.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._USER.Entity = null;
						previousValue.PERSONNEL = null;
					}
					this._USER.Entity = value;
					if ((value != null))
					{
						value.PERSONNEL = this;
					}
					this.SendPropertyChanged("USER");
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
		
		private void attach_TRAVAILs(TRAVAIL entity)
		{
			this.SendPropertyChanging();
			entity.PERSONNEL = this;
		}
		
		private void detach_TRAVAILs(TRAVAIL entity)
		{
			this.SendPropertyChanging();
			entity.PERSONNEL = null;
		}
		
		private void attach_CONGEs(CONGE entity)
		{
			this.SendPropertyChanging();
			entity.PERSONNEL = this;
		}
		
		private void detach_CONGEs(CONGE entity)
		{
			this.SendPropertyChanging();
			entity.PERSONNEL = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.USERS")]
	public partial class USER : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _CIN;
		
		private string _USERNAME;
		
		private string _PASSWORD;
		
		private EntityRef<PERSONNEL> _PERSONNEL;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnCINChanging(string value);
    partial void OnCINChanged();
    partial void OnUSERNAMEChanging(string value);
    partial void OnUSERNAMEChanged();
    partial void OnPASSWORDChanging(string value);
    partial void OnPASSWORDChanged();
    #endregion
		
		public USER()
		{
			this._PERSONNEL = default(EntityRef<PERSONNEL>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CIN", DbType="VarChar(10) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string CIN
		{
			get
			{
				return this._CIN;
			}
			set
			{
				if ((this._CIN != value))
				{
					if (this._PERSONNEL.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnCINChanging(value);
					this.SendPropertyChanging();
					this._CIN = value;
					this.SendPropertyChanged("CIN");
					this.OnCINChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_USERNAME", DbType="VarChar(50)")]
		public string USERNAME
		{
			get
			{
				return this._USERNAME;
			}
			set
			{
				if ((this._USERNAME != value))
				{
					this.OnUSERNAMEChanging(value);
					this.SendPropertyChanging();
					this._USERNAME = value;
					this.SendPropertyChanged("USERNAME");
					this.OnUSERNAMEChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PASSWORD", DbType="VarChar(30)")]
		public string PASSWORD
		{
			get
			{
				return this._PASSWORD;
			}
			set
			{
				if ((this._PASSWORD != value))
				{
					this.OnPASSWORDChanging(value);
					this.SendPropertyChanging();
					this._PASSWORD = value;
					this.SendPropertyChanged("PASSWORD");
					this.OnPASSWORDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="PERSONNEL_USER", Storage="_PERSONNEL", ThisKey="CIN", OtherKey="CIN", IsForeignKey=true)]
		public PERSONNEL PERSONNEL
		{
			get
			{
				return this._PERSONNEL.Entity;
			}
			set
			{
				PERSONNEL previousValue = this._PERSONNEL.Entity;
				if (((previousValue != value) 
							|| (this._PERSONNEL.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._PERSONNEL.Entity = null;
						previousValue.USER = null;
					}
					this._PERSONNEL.Entity = value;
					if ((value != null))
					{
						value.USER = this;
						this._CIN = value.CIN;
					}
					else
					{
						this._CIN = default(string);
					}
					this.SendPropertyChanged("PERSONNEL");
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
