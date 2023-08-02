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

namespace Datos.DBConexion
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="Microproyecto_prog")]
	public partial class DBLibraryEntityDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void Insert_HabitacionXMotel(_HabitacionXMotel instance);
    partial void Update_HabitacionXMotel(_HabitacionXMotel instance);
    partial void Delete_HabitacionXMotel(_HabitacionXMotel instance);
    partial void InsertTipoHabitacion(TipoHabitacion instance);
    partial void UpdateTipoHabitacion(TipoHabitacion instance);
    partial void DeleteTipoHabitacion(TipoHabitacion instance);
    partial void InsertFormas_de_pago(Formas_de_pago instance);
    partial void UpdateFormas_de_pago(Formas_de_pago instance);
    partial void DeleteFormas_de_pago(Formas_de_pago instance);
    partial void InsertLista_Usuario(Lista_Usuario instance);
    partial void UpdateLista_Usuario(Lista_Usuario instance);
    partial void DeleteLista_Usuario(Lista_Usuario instance);
    partial void InsertLogMantenimiento_Tabla(LogMantenimiento_Tabla instance);
    partial void UpdateLogMantenimiento_Tabla(LogMantenimiento_Tabla instance);
    partial void DeleteLogMantenimiento_Tabla(LogMantenimiento_Tabla instance);
    partial void InsertMotel(Motel instance);
    partial void UpdateMotel(Motel instance);
    partial void DeleteMotel(Motel instance);
    partial void InsertPuntuacione(Puntuacione instance);
    partial void UpdatePuntuacione(Puntuacione instance);
    partial void DeletePuntuacione(Puntuacione instance);
    partial void InsertSectore(Sectore instance);
    partial void UpdateSectore(Sectore instance);
    partial void DeleteSectore(Sectore instance);
    #endregion
		
		public DBLibraryEntityDataContext() : 
				base(global::Datos.Properties.Settings.Default.Microproyecto_progConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public DBLibraryEntityDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DBLibraryEntityDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DBLibraryEntityDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DBLibraryEntityDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<_HabitacionXMotel> _HabitacionXMotels
		{
			get
			{
				return this.GetTable<_HabitacionXMotel>();
			}
		}
		
		public System.Data.Linq.Table<TipoHabitacion> TipoHabitacions
		{
			get
			{
				return this.GetTable<TipoHabitacion>();
			}
		}
		
		public System.Data.Linq.Table<Formas_de_pago> Formas_de_pagos
		{
			get
			{
				return this.GetTable<Formas_de_pago>();
			}
		}
		
		public System.Data.Linq.Table<Lista_Usuario> Lista_Usuarios
		{
			get
			{
				return this.GetTable<Lista_Usuario>();
			}
		}
		
		public System.Data.Linq.Table<LogMantenimiento_Tabla> LogMantenimiento_Tablas
		{
			get
			{
				return this.GetTable<LogMantenimiento_Tabla>();
			}
		}
		
		public System.Data.Linq.Table<Motel> Motels
		{
			get
			{
				return this.GetTable<Motel>();
			}
		}
		
		public System.Data.Linq.Table<Puntuacione> Puntuaciones
		{
			get
			{
				return this.GetTable<Puntuacione>();
			}
		}
		
		public System.Data.Linq.Table<Sectore> Sectores
		{
			get
			{
				return this.GetTable<Sectore>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.[_HabitacionXMotel]")]
	public partial class _HabitacionXMotel : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id_TipoHabXMotel;
		
		private decimal _Precio;
		
		private int _Id_Motel;
		
		private int _Id_TipoHabitaciones;
		
		private EntityRef<TipoHabitacion> _TipoHabitacion;
		
		private EntityRef<Motel> _Motel;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnId_TipoHabXMotelChanging(int value);
    partial void OnId_TipoHabXMotelChanged();
    partial void OnPrecioChanging(decimal value);
    partial void OnPrecioChanged();
    partial void OnId_MotelChanging(int value);
    partial void OnId_MotelChanged();
    partial void OnId_TipoHabitacionesChanging(int value);
    partial void OnId_TipoHabitacionesChanged();
    #endregion
		
		public _HabitacionXMotel()
		{
			this._TipoHabitacion = default(EntityRef<TipoHabitacion>);
			this._Motel = default(EntityRef<Motel>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id_TipoHabXMotel", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int Id_TipoHabXMotel
		{
			get
			{
				return this._Id_TipoHabXMotel;
			}
			set
			{
				if ((this._Id_TipoHabXMotel != value))
				{
					this.OnId_TipoHabXMotelChanging(value);
					this.SendPropertyChanging();
					this._Id_TipoHabXMotel = value;
					this.SendPropertyChanged("Id_TipoHabXMotel");
					this.OnId_TipoHabXMotelChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Precio", DbType="Money NOT NULL")]
		public decimal Precio
		{
			get
			{
				return this._Precio;
			}
			set
			{
				if ((this._Precio != value))
				{
					this.OnPrecioChanging(value);
					this.SendPropertyChanging();
					this._Precio = value;
					this.SendPropertyChanged("Precio");
					this.OnPrecioChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id_Motel", DbType="Int NOT NULL")]
		public int Id_Motel
		{
			get
			{
				return this._Id_Motel;
			}
			set
			{
				if ((this._Id_Motel != value))
				{
					if (this._Motel.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnId_MotelChanging(value);
					this.SendPropertyChanging();
					this._Id_Motel = value;
					this.SendPropertyChanged("Id_Motel");
					this.OnId_MotelChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id_TipoHabitaciones", DbType="Int NOT NULL")]
		public int Id_TipoHabitaciones
		{
			get
			{
				return this._Id_TipoHabitaciones;
			}
			set
			{
				if ((this._Id_TipoHabitaciones != value))
				{
					if (this._TipoHabitacion.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnId_TipoHabitacionesChanging(value);
					this.SendPropertyChanging();
					this._Id_TipoHabitaciones = value;
					this.SendPropertyChanged("Id_TipoHabitaciones");
					this.OnId_TipoHabitacionesChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="TipoHabitacion__HabitacionXMotel", Storage="_TipoHabitacion", ThisKey="Id_TipoHabitaciones", OtherKey="Id_TipoHabitaciones", IsForeignKey=true)]
		public TipoHabitacion TipoHabitacion
		{
			get
			{
				return this._TipoHabitacion.Entity;
			}
			set
			{
				TipoHabitacion previousValue = this._TipoHabitacion.Entity;
				if (((previousValue != value) 
							|| (this._TipoHabitacion.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._TipoHabitacion.Entity = null;
						previousValue._HabitacionXMotels.Remove(this);
					}
					this._TipoHabitacion.Entity = value;
					if ((value != null))
					{
						value._HabitacionXMotels.Add(this);
						this._Id_TipoHabitaciones = value.Id_TipoHabitaciones;
					}
					else
					{
						this._Id_TipoHabitaciones = default(int);
					}
					this.SendPropertyChanged("TipoHabitacion");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Motel__HabitacionXMotel", Storage="_Motel", ThisKey="Id_Motel", OtherKey="Id_Motel", IsForeignKey=true)]
		public Motel Motel
		{
			get
			{
				return this._Motel.Entity;
			}
			set
			{
				Motel previousValue = this._Motel.Entity;
				if (((previousValue != value) 
							|| (this._Motel.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Motel.Entity = null;
						previousValue._HabitacionXMotels.Remove(this);
					}
					this._Motel.Entity = value;
					if ((value != null))
					{
						value._HabitacionXMotels.Add(this);
						this._Id_Motel = value.Id_Motel;
					}
					else
					{
						this._Id_Motel = default(int);
					}
					this.SendPropertyChanged("Motel");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.TipoHabitacion")]
	public partial class TipoHabitacion : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id_TipoHabitaciones;
		
		private string _Tipo_Habitacion;
		
		private EntitySet<_HabitacionXMotel> @__HabitacionXMotels;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnId_TipoHabitacionesChanging(int value);
    partial void OnId_TipoHabitacionesChanged();
    partial void OnTipo_HabitacionChanging(string value);
    partial void OnTipo_HabitacionChanged();
    #endregion
		
		public TipoHabitacion()
		{
			this.@__HabitacionXMotels = new EntitySet<_HabitacionXMotel>(new Action<_HabitacionXMotel>(this.attach__HabitacionXMotels), new Action<_HabitacionXMotel>(this.detach__HabitacionXMotels));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id_TipoHabitaciones", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int Id_TipoHabitaciones
		{
			get
			{
				return this._Id_TipoHabitaciones;
			}
			set
			{
				if ((this._Id_TipoHabitaciones != value))
				{
					this.OnId_TipoHabitacionesChanging(value);
					this.SendPropertyChanging();
					this._Id_TipoHabitaciones = value;
					this.SendPropertyChanged("Id_TipoHabitaciones");
					this.OnId_TipoHabitacionesChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Tipo_Habitacion", DbType="NVarChar(25) NOT NULL", CanBeNull=false)]
		public string Tipo_Habitacion
		{
			get
			{
				return this._Tipo_Habitacion;
			}
			set
			{
				if ((this._Tipo_Habitacion != value))
				{
					this.OnTipo_HabitacionChanging(value);
					this.SendPropertyChanging();
					this._Tipo_Habitacion = value;
					this.SendPropertyChanged("Tipo_Habitacion");
					this.OnTipo_HabitacionChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="TipoHabitacion__HabitacionXMotel", Storage="__HabitacionXMotels", ThisKey="Id_TipoHabitaciones", OtherKey="Id_TipoHabitaciones")]
		public EntitySet<_HabitacionXMotel> _HabitacionXMotels
		{
			get
			{
				return this.@__HabitacionXMotels;
			}
			set
			{
				this.@__HabitacionXMotels.Assign(value);
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
		
		private void attach__HabitacionXMotels(_HabitacionXMotel entity)
		{
			this.SendPropertyChanging();
			entity.TipoHabitacion = this;
		}
		
		private void detach__HabitacionXMotels(_HabitacionXMotel entity)
		{
			this.SendPropertyChanging();
			entity.TipoHabitacion = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Formas_de_pago")]
	public partial class Formas_de_pago : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id_FormadePago;
		
		private string _Forma_pago;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnId_FormadePagoChanging(int value);
    partial void OnId_FormadePagoChanged();
    partial void OnForma_pagoChanging(string value);
    partial void OnForma_pagoChanged();
    #endregion
		
		public Formas_de_pago()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id_FormadePago", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int Id_FormadePago
		{
			get
			{
				return this._Id_FormadePago;
			}
			set
			{
				if ((this._Id_FormadePago != value))
				{
					this.OnId_FormadePagoChanging(value);
					this.SendPropertyChanging();
					this._Id_FormadePago = value;
					this.SendPropertyChanged("Id_FormadePago");
					this.OnId_FormadePagoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Forma_pago", DbType="NVarChar(25) NOT NULL", CanBeNull=false)]
		public string Forma_pago
		{
			get
			{
				return this._Forma_pago;
			}
			set
			{
				if ((this._Forma_pago != value))
				{
					this.OnForma_pagoChanging(value);
					this.SendPropertyChanging();
					this._Forma_pago = value;
					this.SendPropertyChanged("Forma_pago");
					this.OnForma_pagoChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Lista_Usuarios")]
	public partial class Lista_Usuario : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id_Usuario;
		
		private string _Nom_Usuario;
		
		private string _Psswd;
		
		private string _Tipo_usuario;
		
		private EntitySet<LogMantenimiento_Tabla> _LogMantenimiento_Tablas;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnId_UsuarioChanging(int value);
    partial void OnId_UsuarioChanged();
    partial void OnNom_UsuarioChanging(string value);
    partial void OnNom_UsuarioChanged();
    partial void OnPsswdChanging(string value);
    partial void OnPsswdChanged();
    partial void OnTipo_usuarioChanging(string value);
    partial void OnTipo_usuarioChanged();
    #endregion
		
		public Lista_Usuario()
		{
			this._LogMantenimiento_Tablas = new EntitySet<LogMantenimiento_Tabla>(new Action<LogMantenimiento_Tabla>(this.attach_LogMantenimiento_Tablas), new Action<LogMantenimiento_Tabla>(this.detach_LogMantenimiento_Tablas));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id_Usuario", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int Id_Usuario
		{
			get
			{
				return this._Id_Usuario;
			}
			set
			{
				if ((this._Id_Usuario != value))
				{
					this.OnId_UsuarioChanging(value);
					this.SendPropertyChanging();
					this._Id_Usuario = value;
					this.SendPropertyChanged("Id_Usuario");
					this.OnId_UsuarioChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Nom_Usuario", DbType="NVarChar(25) NOT NULL", CanBeNull=false)]
		public string Nom_Usuario
		{
			get
			{
				return this._Nom_Usuario;
			}
			set
			{
				if ((this._Nom_Usuario != value))
				{
					this.OnNom_UsuarioChanging(value);
					this.SendPropertyChanging();
					this._Nom_Usuario = value;
					this.SendPropertyChanged("Nom_Usuario");
					this.OnNom_UsuarioChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Psswd", DbType="NVarChar(25) NOT NULL", CanBeNull=false)]
		public string Psswd
		{
			get
			{
				return this._Psswd;
			}
			set
			{
				if ((this._Psswd != value))
				{
					this.OnPsswdChanging(value);
					this.SendPropertyChanging();
					this._Psswd = value;
					this.SendPropertyChanged("Psswd");
					this.OnPsswdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Tipo_usuario", DbType="NVarChar(25) NOT NULL", CanBeNull=false)]
		public string Tipo_usuario
		{
			get
			{
				return this._Tipo_usuario;
			}
			set
			{
				if ((this._Tipo_usuario != value))
				{
					this.OnTipo_usuarioChanging(value);
					this.SendPropertyChanging();
					this._Tipo_usuario = value;
					this.SendPropertyChanged("Tipo_usuario");
					this.OnTipo_usuarioChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Lista_Usuario_LogMantenimiento_Tabla", Storage="_LogMantenimiento_Tablas", ThisKey="Id_Usuario", OtherKey="Id_Usuario")]
		public EntitySet<LogMantenimiento_Tabla> LogMantenimiento_Tablas
		{
			get
			{
				return this._LogMantenimiento_Tablas;
			}
			set
			{
				this._LogMantenimiento_Tablas.Assign(value);
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
		
		private void attach_LogMantenimiento_Tablas(LogMantenimiento_Tabla entity)
		{
			this.SendPropertyChanging();
			entity.Lista_Usuario = this;
		}
		
		private void detach_LogMantenimiento_Tablas(LogMantenimiento_Tabla entity)
		{
			this.SendPropertyChanging();
			entity.Lista_Usuario = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.LogMantenimiento_Tabla")]
	public partial class LogMantenimiento_Tabla : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id_Tabla;
		
		private int _Id_Usuario;
		
		private string _Descripcion;
		
		private System.DateTime _Fecha;
		
		private EntityRef<Lista_Usuario> _Lista_Usuario;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnId_TablaChanging(int value);
    partial void OnId_TablaChanged();
    partial void OnId_UsuarioChanging(int value);
    partial void OnId_UsuarioChanged();
    partial void OnDescripcionChanging(string value);
    partial void OnDescripcionChanged();
    partial void OnFechaChanging(System.DateTime value);
    partial void OnFechaChanged();
    #endregion
		
		public LogMantenimiento_Tabla()
		{
			this._Lista_Usuario = default(EntityRef<Lista_Usuario>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id_Tabla", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int Id_Tabla
		{
			get
			{
				return this._Id_Tabla;
			}
			set
			{
				if ((this._Id_Tabla != value))
				{
					this.OnId_TablaChanging(value);
					this.SendPropertyChanging();
					this._Id_Tabla = value;
					this.SendPropertyChanged("Id_Tabla");
					this.OnId_TablaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id_Usuario", DbType="Int NOT NULL")]
		public int Id_Usuario
		{
			get
			{
				return this._Id_Usuario;
			}
			set
			{
				if ((this._Id_Usuario != value))
				{
					if (this._Lista_Usuario.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnId_UsuarioChanging(value);
					this.SendPropertyChanging();
					this._Id_Usuario = value;
					this.SendPropertyChanged("Id_Usuario");
					this.OnId_UsuarioChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Descripcion", DbType="NVarChar(200) NOT NULL", CanBeNull=false)]
		public string Descripcion
		{
			get
			{
				return this._Descripcion;
			}
			set
			{
				if ((this._Descripcion != value))
				{
					this.OnDescripcionChanging(value);
					this.SendPropertyChanging();
					this._Descripcion = value;
					this.SendPropertyChanged("Descripcion");
					this.OnDescripcionChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Fecha", DbType="DateTime NOT NULL")]
		public System.DateTime Fecha
		{
			get
			{
				return this._Fecha;
			}
			set
			{
				if ((this._Fecha != value))
				{
					this.OnFechaChanging(value);
					this.SendPropertyChanging();
					this._Fecha = value;
					this.SendPropertyChanged("Fecha");
					this.OnFechaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Lista_Usuario_LogMantenimiento_Tabla", Storage="_Lista_Usuario", ThisKey="Id_Usuario", OtherKey="Id_Usuario", IsForeignKey=true)]
		public Lista_Usuario Lista_Usuario
		{
			get
			{
				return this._Lista_Usuario.Entity;
			}
			set
			{
				Lista_Usuario previousValue = this._Lista_Usuario.Entity;
				if (((previousValue != value) 
							|| (this._Lista_Usuario.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Lista_Usuario.Entity = null;
						previousValue.LogMantenimiento_Tablas.Remove(this);
					}
					this._Lista_Usuario.Entity = value;
					if ((value != null))
					{
						value.LogMantenimiento_Tablas.Add(this);
						this._Id_Usuario = value.Id_Usuario;
					}
					else
					{
						this._Id_Usuario = default(int);
					}
					this.SendPropertyChanged("Lista_Usuario");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Motel")]
	public partial class Motel : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id_Motel;
		
		private string _Nombre;
		
		private string _Ubicacion;
		
		private string _Forma_pago;
		
		private string _Servicios;
		
		private int _Id_Sector;
		
		private EntitySet<_HabitacionXMotel> @__HabitacionXMotels;
		
		private EntitySet<Puntuacione> _Puntuaciones;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnId_MotelChanging(int value);
    partial void OnId_MotelChanged();
    partial void OnNombreChanging(string value);
    partial void OnNombreChanged();
    partial void OnUbicacionChanging(string value);
    partial void OnUbicacionChanged();
    partial void OnForma_pagoChanging(string value);
    partial void OnForma_pagoChanged();
    partial void OnServiciosChanging(string value);
    partial void OnServiciosChanged();
    partial void OnId_SectorChanging(int value);
    partial void OnId_SectorChanged();
    #endregion
		
		public Motel()
		{
			this.@__HabitacionXMotels = new EntitySet<_HabitacionXMotel>(new Action<_HabitacionXMotel>(this.attach__HabitacionXMotels), new Action<_HabitacionXMotel>(this.detach__HabitacionXMotels));
			this._Puntuaciones = new EntitySet<Puntuacione>(new Action<Puntuacione>(this.attach_Puntuaciones), new Action<Puntuacione>(this.detach_Puntuaciones));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id_Motel", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int Id_Motel
		{
			get
			{
				return this._Id_Motel;
			}
			set
			{
				if ((this._Id_Motel != value))
				{
					this.OnId_MotelChanging(value);
					this.SendPropertyChanging();
					this._Id_Motel = value;
					this.SendPropertyChanged("Id_Motel");
					this.OnId_MotelChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Nombre", DbType="NVarChar(25) NOT NULL", CanBeNull=false)]
		public string Nombre
		{
			get
			{
				return this._Nombre;
			}
			set
			{
				if ((this._Nombre != value))
				{
					this.OnNombreChanging(value);
					this.SendPropertyChanging();
					this._Nombre = value;
					this.SendPropertyChanged("Nombre");
					this.OnNombreChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Ubicacion", DbType="NVarChar(MAX) NOT NULL", CanBeNull=false)]
		public string Ubicacion
		{
			get
			{
				return this._Ubicacion;
			}
			set
			{
				if ((this._Ubicacion != value))
				{
					this.OnUbicacionChanging(value);
					this.SendPropertyChanging();
					this._Ubicacion = value;
					this.SendPropertyChanged("Ubicacion");
					this.OnUbicacionChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Forma_pago", DbType="NVarChar(25) NOT NULL", CanBeNull=false)]
		public string Forma_pago
		{
			get
			{
				return this._Forma_pago;
			}
			set
			{
				if ((this._Forma_pago != value))
				{
					this.OnForma_pagoChanging(value);
					this.SendPropertyChanging();
					this._Forma_pago = value;
					this.SendPropertyChanged("Forma_pago");
					this.OnForma_pagoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Servicios", DbType="NVarChar(25) NOT NULL", CanBeNull=false)]
		public string Servicios
		{
			get
			{
				return this._Servicios;
			}
			set
			{
				if ((this._Servicios != value))
				{
					this.OnServiciosChanging(value);
					this.SendPropertyChanging();
					this._Servicios = value;
					this.SendPropertyChanged("Servicios");
					this.OnServiciosChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id_Sector", DbType="Int NOT NULL")]
		public int Id_Sector
		{
			get
			{
				return this._Id_Sector;
			}
			set
			{
				if ((this._Id_Sector != value))
				{
					this.OnId_SectorChanging(value);
					this.SendPropertyChanging();
					this._Id_Sector = value;
					this.SendPropertyChanged("Id_Sector");
					this.OnId_SectorChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Motel__HabitacionXMotel", Storage="__HabitacionXMotels", ThisKey="Id_Motel", OtherKey="Id_Motel")]
		public EntitySet<_HabitacionXMotel> _HabitacionXMotels
		{
			get
			{
				return this.@__HabitacionXMotels;
			}
			set
			{
				this.@__HabitacionXMotels.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Motel_Puntuacione", Storage="_Puntuaciones", ThisKey="Id_Motel", OtherKey="Id_Motel")]
		public EntitySet<Puntuacione> Puntuaciones
		{
			get
			{
				return this._Puntuaciones;
			}
			set
			{
				this._Puntuaciones.Assign(value);
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
		
		private void attach__HabitacionXMotels(_HabitacionXMotel entity)
		{
			this.SendPropertyChanging();
			entity.Motel = this;
		}
		
		private void detach__HabitacionXMotels(_HabitacionXMotel entity)
		{
			this.SendPropertyChanging();
			entity.Motel = null;
		}
		
		private void attach_Puntuaciones(Puntuacione entity)
		{
			this.SendPropertyChanging();
			entity.Motel = this;
		}
		
		private void detach_Puntuaciones(Puntuacione entity)
		{
			this.SendPropertyChanging();
			entity.Motel = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Puntuaciones")]
	public partial class Puntuacione : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id_Puntuacion;
		
		private System.DateTime _Fecha;
		
		private int _Valoracion;
		
		private string _Resena;
		
		private int _Id_Motel;
		
		private EntityRef<Motel> _Motel;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnId_PuntuacionChanging(int value);
    partial void OnId_PuntuacionChanged();
    partial void OnFechaChanging(System.DateTime value);
    partial void OnFechaChanged();
    partial void OnValoracionChanging(int value);
    partial void OnValoracionChanged();
    partial void OnResenaChanging(string value);
    partial void OnResenaChanged();
    partial void OnId_MotelChanging(int value);
    partial void OnId_MotelChanged();
    #endregion
		
		public Puntuacione()
		{
			this._Motel = default(EntityRef<Motel>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id_Puntuacion", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int Id_Puntuacion
		{
			get
			{
				return this._Id_Puntuacion;
			}
			set
			{
				if ((this._Id_Puntuacion != value))
				{
					this.OnId_PuntuacionChanging(value);
					this.SendPropertyChanging();
					this._Id_Puntuacion = value;
					this.SendPropertyChanged("Id_Puntuacion");
					this.OnId_PuntuacionChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Fecha", DbType="Date NOT NULL")]
		public System.DateTime Fecha
		{
			get
			{
				return this._Fecha;
			}
			set
			{
				if ((this._Fecha != value))
				{
					this.OnFechaChanging(value);
					this.SendPropertyChanging();
					this._Fecha = value;
					this.SendPropertyChanged("Fecha");
					this.OnFechaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Valoracion", DbType="Int NOT NULL")]
		public int Valoracion
		{
			get
			{
				return this._Valoracion;
			}
			set
			{
				if ((this._Valoracion != value))
				{
					this.OnValoracionChanging(value);
					this.SendPropertyChanging();
					this._Valoracion = value;
					this.SendPropertyChanged("Valoracion");
					this.OnValoracionChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Resena", DbType="NVarChar(MAX) NOT NULL", CanBeNull=false)]
		public string Resena
		{
			get
			{
				return this._Resena;
			}
			set
			{
				if ((this._Resena != value))
				{
					this.OnResenaChanging(value);
					this.SendPropertyChanging();
					this._Resena = value;
					this.SendPropertyChanged("Resena");
					this.OnResenaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id_Motel", DbType="Int NOT NULL")]
		public int Id_Motel
		{
			get
			{
				return this._Id_Motel;
			}
			set
			{
				if ((this._Id_Motel != value))
				{
					if (this._Motel.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnId_MotelChanging(value);
					this.SendPropertyChanging();
					this._Id_Motel = value;
					this.SendPropertyChanged("Id_Motel");
					this.OnId_MotelChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Motel_Puntuacione", Storage="_Motel", ThisKey="Id_Motel", OtherKey="Id_Motel", IsForeignKey=true)]
		public Motel Motel
		{
			get
			{
				return this._Motel.Entity;
			}
			set
			{
				Motel previousValue = this._Motel.Entity;
				if (((previousValue != value) 
							|| (this._Motel.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Motel.Entity = null;
						previousValue.Puntuaciones.Remove(this);
					}
					this._Motel.Entity = value;
					if ((value != null))
					{
						value.Puntuaciones.Add(this);
						this._Id_Motel = value.Id_Motel;
					}
					else
					{
						this._Id_Motel = default(int);
					}
					this.SendPropertyChanged("Motel");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Sectores")]
	public partial class Sectore : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id_Sector;
		
		private string _Sector;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnId_SectorChanging(int value);
    partial void OnId_SectorChanged();
    partial void OnSectorChanging(string value);
    partial void OnSectorChanged();
    #endregion
		
		public Sectore()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id_Sector", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int Id_Sector
		{
			get
			{
				return this._Id_Sector;
			}
			set
			{
				if ((this._Id_Sector != value))
				{
					this.OnId_SectorChanging(value);
					this.SendPropertyChanging();
					this._Id_Sector = value;
					this.SendPropertyChanged("Id_Sector");
					this.OnId_SectorChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Sector", DbType="NVarChar(25) NOT NULL", CanBeNull=false)]
		public string Sector
		{
			get
			{
				return this._Sector;
			}
			set
			{
				if ((this._Sector != value))
				{
					this.OnSectorChanging(value);
					this.SendPropertyChanging();
					this._Sector = value;
					this.SendPropertyChanged("Sector");
					this.OnSectorChanged();
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
