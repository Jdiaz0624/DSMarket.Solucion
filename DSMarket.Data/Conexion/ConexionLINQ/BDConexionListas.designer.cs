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

namespace DSMarket.Data.Conexion.ConexionLINQ
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="DSMarket")]
	public partial class BDConexionListasDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    #endregion
		
		public BDConexionListasDataContext() : 
				base(global::DSMarket.Data.Properties.Settings.Default.DSMarketConnectionString1, mappingSource)
		{
			OnCreated();
		}
		
		public BDConexionListasDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public BDConexionListasDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public BDConexionListasDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public BDConexionListasDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="Listas.SP_CARGAR_LISTA_TIPO_PRODUCTO")]
		public ISingleResult<SP_CARGAR_LISTA_TIPO_PRODUCTOResult> SP_CARGAR_LISTA_TIPO_PRODUCTO([global::System.Data.Linq.Mapping.ParameterAttribute(Name="IdTipoproducto", DbType="Decimal(20,0)")] System.Nullable<decimal> idTipoproducto, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Descripcion", DbType="VarChar(100)")] string descripcion)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), idTipoproducto, descripcion);
			return ((ISingleResult<SP_CARGAR_LISTA_TIPO_PRODUCTOResult>)(result.ReturnValue));
		}
	}
	
	public partial class SP_CARGAR_LISTA_TIPO_PRODUCTOResult
	{
		
		private decimal _IdTipoproducto;
		
		private string _Descripcion;
		
		public SP_CARGAR_LISTA_TIPO_PRODUCTOResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IdTipoproducto", DbType="Decimal(20,0) NOT NULL")]
		public decimal IdTipoproducto
		{
			get
			{
				return this._IdTipoproducto;
			}
			set
			{
				if ((this._IdTipoproducto != value))
				{
					this._IdTipoproducto = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Descripcion", DbType="VarChar(100)")]
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
					this._Descripcion = value;
				}
			}
		}
	}
}
#pragma warning restore 1591