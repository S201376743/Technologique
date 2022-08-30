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

namespace Technologique_SVC
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="TechnologiqueDB1")]
	public partial class TechnologiqueLinq1DataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertCart(Cart instance);
    partial void UpdateCart(Cart instance);
    partial void DeleteCart(Cart instance);
    partial void InsertAddress(Address instance);
    partial void UpdateAddress(Address instance);
    partial void DeleteAddress(Address instance);
    partial void InsertUser(User instance);
    partial void UpdateUser(User instance);
    partial void DeleteUser(User instance);
    partial void InsertProduct(Product instance);
    partial void UpdateProduct(Product instance);
    partial void DeleteProduct(Product instance);
    #endregion
		
		public TechnologiqueLinq1DataContext() : 
				base(global::System.Configuration.ConfigurationManager.ConnectionStrings["TechnologiqueDB1ConnectionString"].ConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public TechnologiqueLinq1DataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public TechnologiqueLinq1DataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public TechnologiqueLinq1DataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public TechnologiqueLinq1DataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Cart> Carts
		{
			get
			{
				return this.GetTable<Cart>();
			}
		}
		
		public System.Data.Linq.Table<Address> Addresses
		{
			get
			{
				return this.GetTable<Address>();
			}
		}
		
		public System.Data.Linq.Table<User> Users
		{
			get
			{
				return this.GetTable<User>();
			}
		}
		
		public System.Data.Linq.Table<Product> Products
		{
			get
			{
				return this.GetTable<Product>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Cart")]
	public partial class Cart : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Cart_Id;
		
		private int _Product_Id;
		
		private string _Paid;
		
		private int _User_Id;
		
		private EntityRef<User> _User;
		
		private EntityRef<Product> _Product;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnCart_IdChanging(int value);
    partial void OnCart_IdChanged();
    partial void OnProduct_IdChanging(int value);
    partial void OnProduct_IdChanged();
    partial void OnPaidChanging(string value);
    partial void OnPaidChanged();
    partial void OnUser_IdChanging(int value);
    partial void OnUser_IdChanged();
    #endregion
		
		public Cart()
		{
			this._User = default(EntityRef<User>);
			this._Product = default(EntityRef<Product>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Cart_Id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int Cart_Id
		{
			get
			{
				return this._Cart_Id;
			}
			set
			{
				if ((this._Cart_Id != value))
				{
					this.OnCart_IdChanging(value);
					this.SendPropertyChanging();
					this._Cart_Id = value;
					this.SendPropertyChanged("Cart_Id");
					this.OnCart_IdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Product_Id", DbType="Int NOT NULL")]
		public int Product_Id
		{
			get
			{
				return this._Product_Id;
			}
			set
			{
				if ((this._Product_Id != value))
				{
					if (this._Product.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnProduct_IdChanging(value);
					this.SendPropertyChanging();
					this._Product_Id = value;
					this.SendPropertyChanged("Product_Id");
					this.OnProduct_IdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Paid", DbType="VarChar(10) NOT NULL", CanBeNull=false)]
		public string Paid
		{
			get
			{
				return this._Paid;
			}
			set
			{
				if ((this._Paid != value))
				{
					this.OnPaidChanging(value);
					this.SendPropertyChanging();
					this._Paid = value;
					this.SendPropertyChanged("Paid");
					this.OnPaidChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_User_Id", DbType="Int NOT NULL")]
		public int User_Id
		{
			get
			{
				return this._User_Id;
			}
			set
			{
				if ((this._User_Id != value))
				{
					if (this._User.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnUser_IdChanging(value);
					this.SendPropertyChanging();
					this._User_Id = value;
					this.SendPropertyChanged("User_Id");
					this.OnUser_IdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="User_Cart", Storage="_User", ThisKey="User_Id", OtherKey="User_Id", IsForeignKey=true)]
		public User User
		{
			get
			{
				return this._User.Entity;
			}
			set
			{
				User previousValue = this._User.Entity;
				if (((previousValue != value) 
							|| (this._User.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._User.Entity = null;
						previousValue.Carts.Remove(this);
					}
					this._User.Entity = value;
					if ((value != null))
					{
						value.Carts.Add(this);
						this._User_Id = value.User_Id;
					}
					else
					{
						this._User_Id = default(int);
					}
					this.SendPropertyChanged("User");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Product_Cart", Storage="_Product", ThisKey="Product_Id", OtherKey="Product_Id", IsForeignKey=true)]
		public Product Product
		{
			get
			{
				return this._Product.Entity;
			}
			set
			{
				Product previousValue = this._Product.Entity;
				if (((previousValue != value) 
							|| (this._Product.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Product.Entity = null;
						previousValue.Carts.Remove(this);
					}
					this._Product.Entity = value;
					if ((value != null))
					{
						value.Carts.Add(this);
						this._Product_Id = value.Product_Id;
					}
					else
					{
						this._Product_Id = default(int);
					}
					this.SendPropertyChanged("Product");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Address")]
	public partial class Address : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Address_Id;
		
		private string _Street_Address;
		
		private string _ComplexBuilding;
		
		private string _TownCity;
		
		private string _Province;
		
		private int _PostalCode;
		
		private int _User_id;
		
		private EntityRef<User> _User;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnAddress_IdChanging(int value);
    partial void OnAddress_IdChanged();
    partial void OnStreet_AddressChanging(string value);
    partial void OnStreet_AddressChanged();
    partial void OnComplexBuildingChanging(string value);
    partial void OnComplexBuildingChanged();
    partial void OnTownCityChanging(string value);
    partial void OnTownCityChanged();
    partial void OnProvinceChanging(string value);
    partial void OnProvinceChanged();
    partial void OnPostalCodeChanging(int value);
    partial void OnPostalCodeChanged();
    partial void OnUser_idChanging(int value);
    partial void OnUser_idChanged();
    #endregion
		
		public Address()
		{
			this._User = default(EntityRef<User>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Address_Id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int Address_Id
		{
			get
			{
				return this._Address_Id;
			}
			set
			{
				if ((this._Address_Id != value))
				{
					this.OnAddress_IdChanging(value);
					this.SendPropertyChanging();
					this._Address_Id = value;
					this.SendPropertyChanged("Address_Id");
					this.OnAddress_IdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Street_Address", DbType="VarChar(100) NOT NULL", CanBeNull=false)]
		public string Street_Address
		{
			get
			{
				return this._Street_Address;
			}
			set
			{
				if ((this._Street_Address != value))
				{
					this.OnStreet_AddressChanging(value);
					this.SendPropertyChanging();
					this._Street_Address = value;
					this.SendPropertyChanged("Street_Address");
					this.OnStreet_AddressChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ComplexBuilding", DbType="VarChar(100)")]
		public string ComplexBuilding
		{
			get
			{
				return this._ComplexBuilding;
			}
			set
			{
				if ((this._ComplexBuilding != value))
				{
					this.OnComplexBuildingChanging(value);
					this.SendPropertyChanging();
					this._ComplexBuilding = value;
					this.SendPropertyChanged("ComplexBuilding");
					this.OnComplexBuildingChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TownCity", DbType="VarChar(30) NOT NULL", CanBeNull=false)]
		public string TownCity
		{
			get
			{
				return this._TownCity;
			}
			set
			{
				if ((this._TownCity != value))
				{
					this.OnTownCityChanging(value);
					this.SendPropertyChanging();
					this._TownCity = value;
					this.SendPropertyChanged("TownCity");
					this.OnTownCityChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Province", DbType="VarChar(30) NOT NULL", CanBeNull=false)]
		public string Province
		{
			get
			{
				return this._Province;
			}
			set
			{
				if ((this._Province != value))
				{
					this.OnProvinceChanging(value);
					this.SendPropertyChanging();
					this._Province = value;
					this.SendPropertyChanged("Province");
					this.OnProvinceChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PostalCode", DbType="Int NOT NULL")]
		public int PostalCode
		{
			get
			{
				return this._PostalCode;
			}
			set
			{
				if ((this._PostalCode != value))
				{
					this.OnPostalCodeChanging(value);
					this.SendPropertyChanging();
					this._PostalCode = value;
					this.SendPropertyChanged("PostalCode");
					this.OnPostalCodeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_User_id", DbType="Int NOT NULL")]
		public int User_id
		{
			get
			{
				return this._User_id;
			}
			set
			{
				if ((this._User_id != value))
				{
					if (this._User.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnUser_idChanging(value);
					this.SendPropertyChanging();
					this._User_id = value;
					this.SendPropertyChanged("User_id");
					this.OnUser_idChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="User_Address", Storage="_User", ThisKey="User_id", OtherKey="User_Id", IsForeignKey=true)]
		public User User
		{
			get
			{
				return this._User.Entity;
			}
			set
			{
				User previousValue = this._User.Entity;
				if (((previousValue != value) 
							|| (this._User.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._User.Entity = null;
						previousValue.Addresses.Remove(this);
					}
					this._User.Entity = value;
					if ((value != null))
					{
						value.Addresses.Add(this);
						this._User_id = value.User_Id;
					}
					else
					{
						this._User_id = default(int);
					}
					this.SendPropertyChanged("User");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.[User]")]
	public partial class User : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _User_Id;
		
		private string _U_Name;
		
		private string _U_Password;
		
		private string _U_Email;
		
		private string _U_Surname;
		
		private EntitySet<Cart> _Carts;
		
		private EntitySet<Address> _Addresses;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnUser_IdChanging(int value);
    partial void OnUser_IdChanged();
    partial void OnU_NameChanging(string value);
    partial void OnU_NameChanged();
    partial void OnU_PasswordChanging(string value);
    partial void OnU_PasswordChanged();
    partial void OnU_EmailChanging(string value);
    partial void OnU_EmailChanged();
    partial void OnU_SurnameChanging(string value);
    partial void OnU_SurnameChanged();
    #endregion
		
		public User()
		{
			this._Carts = new EntitySet<Cart>(new Action<Cart>(this.attach_Carts), new Action<Cart>(this.detach_Carts));
			this._Addresses = new EntitySet<Address>(new Action<Address>(this.attach_Addresses), new Action<Address>(this.detach_Addresses));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_User_Id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int User_Id
		{
			get
			{
				return this._User_Id;
			}
			set
			{
				if ((this._User_Id != value))
				{
					this.OnUser_IdChanging(value);
					this.SendPropertyChanging();
					this._User_Id = value;
					this.SendPropertyChanged("User_Id");
					this.OnUser_IdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_U_Name", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string U_Name
		{
			get
			{
				return this._U_Name;
			}
			set
			{
				if ((this._U_Name != value))
				{
					this.OnU_NameChanging(value);
					this.SendPropertyChanging();
					this._U_Name = value;
					this.SendPropertyChanged("U_Name");
					this.OnU_NameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_U_Password", DbType="VarChar(MAX) NOT NULL", CanBeNull=false)]
		public string U_Password
		{
			get
			{
				return this._U_Password;
			}
			set
			{
				if ((this._U_Password != value))
				{
					this.OnU_PasswordChanging(value);
					this.SendPropertyChanging();
					this._U_Password = value;
					this.SendPropertyChanged("U_Password");
					this.OnU_PasswordChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_U_Email", DbType="VarChar(MAX) NOT NULL", CanBeNull=false)]
		public string U_Email
		{
			get
			{
				return this._U_Email;
			}
			set
			{
				if ((this._U_Email != value))
				{
					this.OnU_EmailChanging(value);
					this.SendPropertyChanging();
					this._U_Email = value;
					this.SendPropertyChanged("U_Email");
					this.OnU_EmailChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_U_Surname", DbType="VarChar(60) NOT NULL", CanBeNull=false)]
		public string U_Surname
		{
			get
			{
				return this._U_Surname;
			}
			set
			{
				if ((this._U_Surname != value))
				{
					this.OnU_SurnameChanging(value);
					this.SendPropertyChanging();
					this._U_Surname = value;
					this.SendPropertyChanged("U_Surname");
					this.OnU_SurnameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="User_Cart", Storage="_Carts", ThisKey="User_Id", OtherKey="User_Id")]
		public EntitySet<Cart> Carts
		{
			get
			{
				return this._Carts;
			}
			set
			{
				this._Carts.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="User_Address", Storage="_Addresses", ThisKey="User_Id", OtherKey="User_id")]
		public EntitySet<Address> Addresses
		{
			get
			{
				return this._Addresses;
			}
			set
			{
				this._Addresses.Assign(value);
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
		
		private void attach_Carts(Cart entity)
		{
			this.SendPropertyChanging();
			entity.User = this;
		}
		
		private void detach_Carts(Cart entity)
		{
			this.SendPropertyChanging();
			entity.User = null;
		}
		
		private void attach_Addresses(Address entity)
		{
			this.SendPropertyChanging();
			entity.User = this;
		}
		
		private void detach_Addresses(Address entity)
		{
			this.SendPropertyChanging();
			entity.User = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Product")]
	public partial class Product : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Product_Id;
		
		private string _Prod_Name;
		
		private string _Prod_Description;
		
		private System.Nullable<int> _Prod_Stock;
		
		private System.Nullable<double> _Prod_Price;
		
		private string _Prod_Image;
		
		private EntitySet<Cart> _Carts;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnProduct_IdChanging(int value);
    partial void OnProduct_IdChanged();
    partial void OnProd_NameChanging(string value);
    partial void OnProd_NameChanged();
    partial void OnProd_DescriptionChanging(string value);
    partial void OnProd_DescriptionChanged();
    partial void OnProd_StockChanging(System.Nullable<int> value);
    partial void OnProd_StockChanged();
    partial void OnProd_PriceChanging(System.Nullable<double> value);
    partial void OnProd_PriceChanged();
    partial void OnProd_ImageChanging(string value);
    partial void OnProd_ImageChanged();
    #endregion
		
		public Product()
		{
			this._Carts = new EntitySet<Cart>(new Action<Cart>(this.attach_Carts), new Action<Cart>(this.detach_Carts));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Product_Id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int Product_Id
		{
			get
			{
				return this._Product_Id;
			}
			set
			{
				if ((this._Product_Id != value))
				{
					this.OnProduct_IdChanging(value);
					this.SendPropertyChanging();
					this._Product_Id = value;
					this.SendPropertyChanged("Product_Id");
					this.OnProduct_IdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Prod_Name", DbType="VarChar(150)")]
		public string Prod_Name
		{
			get
			{
				return this._Prod_Name;
			}
			set
			{
				if ((this._Prod_Name != value))
				{
					this.OnProd_NameChanging(value);
					this.SendPropertyChanging();
					this._Prod_Name = value;
					this.SendPropertyChanged("Prod_Name");
					this.OnProd_NameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Prod_Description", DbType="VarChar(MAX)")]
		public string Prod_Description
		{
			get
			{
				return this._Prod_Description;
			}
			set
			{
				if ((this._Prod_Description != value))
				{
					this.OnProd_DescriptionChanging(value);
					this.SendPropertyChanging();
					this._Prod_Description = value;
					this.SendPropertyChanged("Prod_Description");
					this.OnProd_DescriptionChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Prod_Stock", DbType="Int")]
		public System.Nullable<int> Prod_Stock
		{
			get
			{
				return this._Prod_Stock;
			}
			set
			{
				if ((this._Prod_Stock != value))
				{
					this.OnProd_StockChanging(value);
					this.SendPropertyChanging();
					this._Prod_Stock = value;
					this.SendPropertyChanged("Prod_Stock");
					this.OnProd_StockChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Prod_Price", DbType="Float")]
		public System.Nullable<double> Prod_Price
		{
			get
			{
				return this._Prod_Price;
			}
			set
			{
				if ((this._Prod_Price != value))
				{
					this.OnProd_PriceChanging(value);
					this.SendPropertyChanging();
					this._Prod_Price = value;
					this.SendPropertyChanged("Prod_Price");
					this.OnProd_PriceChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Prod_Image", DbType="VarChar(MAX)")]
		public string Prod_Image
		{
			get
			{
				return this._Prod_Image;
			}
			set
			{
				if ((this._Prod_Image != value))
				{
					this.OnProd_ImageChanging(value);
					this.SendPropertyChanging();
					this._Prod_Image = value;
					this.SendPropertyChanged("Prod_Image");
					this.OnProd_ImageChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Product_Cart", Storage="_Carts", ThisKey="Product_Id", OtherKey="Product_Id")]
		public EntitySet<Cart> Carts
		{
			get
			{
				return this._Carts;
			}
			set
			{
				this._Carts.Assign(value);
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
		
		private void attach_Carts(Cart entity)
		{
			this.SendPropertyChanging();
			entity.Product = this;
		}
		
		private void detach_Carts(Cart entity)
		{
			this.SendPropertyChanging();
			entity.Product = null;
		}
	}
}
#pragma warning restore 1591
