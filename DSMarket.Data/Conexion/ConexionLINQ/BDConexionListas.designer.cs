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
				base(global::DSMarket.Data.Properties.Settings.Default.DSMarketConnectionString5, mappingSource)
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
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="Listas.SP_BUSCA_LISTA_TIPO_SUPLIDOR")]
		public ISingleResult<SP_BUSCA_LISTA_TIPO_SUPLIDORResult> SP_BUSCA_LISTA_TIPO_SUPLIDOR()
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())));
			return ((ISingleResult<SP_BUSCA_LISTA_TIPO_SUPLIDORResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="Listas.SP_LISTADO_CATEGORIAS")]
		public ISingleResult<SP_LISTADO_CATEGORIASResult> SP_LISTADO_CATEGORIAS([global::System.Data.Linq.Mapping.ParameterAttribute(Name="IdTipoProducto", DbType="Decimal(20,0)")] System.Nullable<decimal> idTipoProducto)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), idTipoProducto);
			return ((ISingleResult<SP_LISTADO_CATEGORIASResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="Listas.SP_LISTADO_UNIDAD_MEDIDA")]
		public ISingleResult<SP_LISTADO_UNIDAD_MEDIDAResult> SP_LISTADO_UNIDAD_MEDIDA()
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())));
			return ((ISingleResult<SP_LISTADO_UNIDAD_MEDIDAResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="Listas.SP_CARGAR_LISTA_MODELOS")]
		public ISingleResult<SP_CARGAR_LISTA_MODELOSResult> SP_CARGAR_LISTA_MODELOS([global::System.Data.Linq.Mapping.ParameterAttribute(Name="IdMarca", DbType="Decimal(20,0)")] System.Nullable<decimal> idMarca)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), idMarca);
			return ((ISingleResult<SP_CARGAR_LISTA_MODELOSResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="Listas.SP_LISTAS_SUPLIDORES")]
		public ISingleResult<SP_LISTAS_SUPLIDORESResult> SP_LISTAS_SUPLIDORES([global::System.Data.Linq.Mapping.ParameterAttribute(Name="IdTipoSuplidor", DbType="Decimal(20,0)")] System.Nullable<decimal> idTipoSuplidor)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), idTipoSuplidor);
			return ((ISingleResult<SP_LISTAS_SUPLIDORESResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="Listas.SP_BUSCA_COMPROBANTE_FISCALES")]
		public ISingleResult<SP_BUSCA_COMPROBANTE_FISCALESResult> SP_BUSCA_COMPROBANTE_FISCALES()
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())));
			return ((ISingleResult<SP_BUSCA_COMPROBANTE_FISCALESResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="Listas.SP_BUSCA_LISTA_COMPROBANTE_NULOS")]
		public ISingleResult<SP_BUSCA_LISTA_COMPROBANTE_NULOSResult> SP_BUSCA_LISTA_COMPROBANTE_NULOS()
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())));
			return ((ISingleResult<SP_BUSCA_LISTA_COMPROBANTE_NULOSResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="Listas.SP_LISTADO_TIPO_IDENTIFICACION")]
		public ISingleResult<SP_LISTADO_TIPO_IDENTIFICACIONResult> SP_LISTADO_TIPO_IDENTIFICACION()
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())));
			return ((ISingleResult<SP_LISTADO_TIPO_IDENTIFICACIONResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="Listas.SP_BUSCA_TIPO_VENTA")]
		public ISingleResult<SP_BUSCA_TIPO_VENTAResult> SP_BUSCA_TIPO_VENTA()
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())));
			return ((ISingleResult<SP_BUSCA_TIPO_VENTAResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="Listas.SP_CANTIDAD_DIAS")]
		public ISingleResult<SP_CANTIDAD_DIASResult> SP_CANTIDAD_DIAS()
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())));
			return ((ISingleResult<SP_CANTIDAD_DIASResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="Listas.SP_BUSCA_LISTADO_ESTATUS_FACTURACION")]
		public ISingleResult<SP_BUSCA_LISTADO_ESTATUS_FACTURACIONResult> SP_BUSCA_LISTADO_ESTATUS_FACTURACION()
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())));
			return ((ISingleResult<SP_BUSCA_LISTADO_ESTATUS_FACTURACIONResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="Listas.SP_LISTADO_NIVEL_ACCESO")]
		public ISingleResult<SP_LISTADO_NIVEL_ACCESOResult> SP_LISTADO_NIVEL_ACCESO()
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())));
			return ((ISingleResult<SP_LISTADO_NIVEL_ACCESOResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="Listas.SP_LISTA_USUARIOS")]
		public ISingleResult<SP_LISTA_USUARIOSResult> SP_LISTA_USUARIOS()
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())));
			return ((ISingleResult<SP_LISTA_USUARIOSResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="Listas.SP_BUSCA_LISTA_TIPO_MAIL")]
		public ISingleResult<SP_BUSCA_LISTA_TIPO_MAILResult> SP_BUSCA_LISTA_TIPO_MAIL()
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())));
			return ((ISingleResult<SP_BUSCA_LISTA_TIPO_MAILResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="Listas.SP_LISTADO_TIPO_PAGO")]
		public ISingleResult<SP_LISTADO_TIPO_PAGOResult> SP_LISTADO_TIPO_PAGO([global::System.Data.Linq.Mapping.ParameterAttribute(Name="IdTipoPago", DbType="Decimal(20,0)")] System.Nullable<decimal> idTipoPago)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), idTipoPago);
			return ((ISingleResult<SP_LISTADO_TIPO_PAGOResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="Listas.SP_CARGAR_MARCAS")]
		public ISingleResult<SP_CARGAR_MARCASResult> SP_CARGAR_MARCAS([global::System.Data.Linq.Mapping.ParameterAttribute(Name="IdCategoria", DbType="Decimal(20,0)")] System.Nullable<decimal> idCategoria)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), idCategoria);
			return ((ISingleResult<SP_CARGAR_MARCASResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="Listas.SP_LISTADO_BIENES_SERVICIOS")]
		public ISingleResult<SP_LISTADO_BIENES_SERVICIOSResult> SP_LISTADO_BIENES_SERVICIOS()
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())));
			return ((ISingleResult<SP_LISTADO_BIENES_SERVICIOSResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="Listas.SP_LISTADO_TIPO_RETENCION_ISR")]
		public ISingleResult<SP_LISTADO_TIPO_RETENCION_ISRResult> SP_LISTADO_TIPO_RETENCION_ISR()
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())));
			return ((ISingleResult<SP_LISTADO_TIPO_RETENCION_ISRResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="Listas.SP_BUSCA_LISTA_TIPO_INGRESOS")]
		public ISingleResult<SP_BUSCA_LISTA_TIPO_INGRESOSResult> SP_BUSCA_LISTA_TIPO_INGRESOS()
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())));
			return ((ISingleResult<SP_BUSCA_LISTA_TIPO_INGRESOSResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="Listas.SP_MOSTRAR_LISTADO_TIPO_ANULACION")]
		public ISingleResult<SP_MOSTRAR_LISTADO_TIPO_ANULACIONResult> SP_MOSTRAR_LISTADO_TIPO_ANULACION()
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())));
			return ((ISingleResult<SP_MOSTRAR_LISTADO_TIPO_ANULACIONResult>)(result.ReturnValue));
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
	
	public partial class SP_BUSCA_LISTA_TIPO_SUPLIDORResult
	{
		
		private decimal _IdTipoSuplidor;
		
		private string _Descripcion;
		
		public SP_BUSCA_LISTA_TIPO_SUPLIDORResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IdTipoSuplidor", DbType="Decimal(20,0) NOT NULL")]
		public decimal IdTipoSuplidor
		{
			get
			{
				return this._IdTipoSuplidor;
			}
			set
			{
				if ((this._IdTipoSuplidor != value))
				{
					this._IdTipoSuplidor = value;
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
	
	public partial class SP_LISTADO_CATEGORIASResult
	{
		
		private decimal _IdCategoria;
		
		private string _Descripcion;
		
		public SP_LISTADO_CATEGORIASResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IdCategoria", DbType="Decimal(20,0) NOT NULL")]
		public decimal IdCategoria
		{
			get
			{
				return this._IdCategoria;
			}
			set
			{
				if ((this._IdCategoria != value))
				{
					this._IdCategoria = value;
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
	
	public partial class SP_LISTADO_UNIDAD_MEDIDAResult
	{
		
		private decimal _IdUnidadMedida;
		
		private string _Descripcion;
		
		public SP_LISTADO_UNIDAD_MEDIDAResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IdUnidadMedida", DbType="Decimal(20,0) NOT NULL")]
		public decimal IdUnidadMedida
		{
			get
			{
				return this._IdUnidadMedida;
			}
			set
			{
				if ((this._IdUnidadMedida != value))
				{
					this._IdUnidadMedida = value;
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
	
	public partial class SP_CARGAR_LISTA_MODELOSResult
	{
		
		private decimal _IdModelo;
		
		private string _Descripcion;
		
		public SP_CARGAR_LISTA_MODELOSResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IdModelo", DbType="Decimal(20,0) NOT NULL")]
		public decimal IdModelo
		{
			get
			{
				return this._IdModelo;
			}
			set
			{
				if ((this._IdModelo != value))
				{
					this._IdModelo = value;
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
	
	public partial class SP_LISTAS_SUPLIDORESResult
	{
		
		private decimal _IdSuplidor;
		
		private string _Nombre;
		
		public SP_LISTAS_SUPLIDORESResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IdSuplidor", DbType="Decimal(20,0) NOT NULL")]
		public decimal IdSuplidor
		{
			get
			{
				return this._IdSuplidor;
			}
			set
			{
				if ((this._IdSuplidor != value))
				{
					this._IdSuplidor = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Nombre", DbType="VarChar(100)")]
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
					this._Nombre = value;
				}
			}
		}
	}
	
	public partial class SP_BUSCA_COMPROBANTE_FISCALESResult
	{
		
		private decimal _IdComprobante;
		
		private string _Comprbante;
		
		public SP_BUSCA_COMPROBANTE_FISCALESResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IdComprobante", DbType="Decimal(20,0) NOT NULL")]
		public decimal IdComprobante
		{
			get
			{
				return this._IdComprobante;
			}
			set
			{
				if ((this._IdComprobante != value))
				{
					this._IdComprobante = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Comprbante", DbType="VarChar(100)")]
		public string Comprbante
		{
			get
			{
				return this._Comprbante;
			}
			set
			{
				if ((this._Comprbante != value))
				{
					this._Comprbante = value;
				}
			}
		}
	}
	
	public partial class SP_BUSCA_LISTA_COMPROBANTE_NULOSResult
	{
		
		private int _IdComprobanteNulo;
		
		private string _Descripcion;
		
		public SP_BUSCA_LISTA_COMPROBANTE_NULOSResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IdComprobanteNulo", DbType="Int NOT NULL")]
		public int IdComprobanteNulo
		{
			get
			{
				return this._IdComprobanteNulo;
			}
			set
			{
				if ((this._IdComprobanteNulo != value))
				{
					this._IdComprobanteNulo = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Descripcion", DbType="VarChar(5)")]
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
	
	public partial class SP_LISTADO_TIPO_IDENTIFICACIONResult
	{
		
		private int _IdTipoIdentificacion;
		
		private string _TipoIdentificacion;
		
		public SP_LISTADO_TIPO_IDENTIFICACIONResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IdTipoIdentificacion", DbType="Int NOT NULL")]
		public int IdTipoIdentificacion
		{
			get
			{
				return this._IdTipoIdentificacion;
			}
			set
			{
				if ((this._IdTipoIdentificacion != value))
				{
					this._IdTipoIdentificacion = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TipoIdentificacion", DbType="VarChar(100)")]
		public string TipoIdentificacion
		{
			get
			{
				return this._TipoIdentificacion;
			}
			set
			{
				if ((this._TipoIdentificacion != value))
				{
					this._TipoIdentificacion = value;
				}
			}
		}
	}
	
	public partial class SP_BUSCA_TIPO_VENTAResult
	{
		
		private int _IdTipoVenta;
		
		private string _TipoVenta;
		
		public SP_BUSCA_TIPO_VENTAResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IdTipoVenta", DbType="Int NOT NULL")]
		public int IdTipoVenta
		{
			get
			{
				return this._IdTipoVenta;
			}
			set
			{
				if ((this._IdTipoVenta != value))
				{
					this._IdTipoVenta = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TipoVenta", DbType="VarChar(100)")]
		public string TipoVenta
		{
			get
			{
				return this._TipoVenta;
			}
			set
			{
				if ((this._TipoVenta != value))
				{
					this._TipoVenta = value;
				}
			}
		}
	}
	
	public partial class SP_CANTIDAD_DIASResult
	{
		
		private int _IdCantidadDias;
		
		private string _CantidadDias;
		
		public SP_CANTIDAD_DIASResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IdCantidadDias", DbType="Int NOT NULL")]
		public int IdCantidadDias
		{
			get
			{
				return this._IdCantidadDias;
			}
			set
			{
				if ((this._IdCantidadDias != value))
				{
					this._IdCantidadDias = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CantidadDias", DbType="VarChar(10)")]
		public string CantidadDias
		{
			get
			{
				return this._CantidadDias;
			}
			set
			{
				if ((this._CantidadDias != value))
				{
					this._CantidadDias = value;
				}
			}
		}
	}
	
	public partial class SP_BUSCA_LISTADO_ESTATUS_FACTURACIONResult
	{
		
		private decimal _IdEstatusFacturacion;
		
		private string _Estatus;
		
		public SP_BUSCA_LISTADO_ESTATUS_FACTURACIONResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IdEstatusFacturacion", DbType="Decimal(20,0) NOT NULL")]
		public decimal IdEstatusFacturacion
		{
			get
			{
				return this._IdEstatusFacturacion;
			}
			set
			{
				if ((this._IdEstatusFacturacion != value))
				{
					this._IdEstatusFacturacion = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Estatus", DbType="VarChar(100)")]
		public string Estatus
		{
			get
			{
				return this._Estatus;
			}
			set
			{
				if ((this._Estatus != value))
				{
					this._Estatus = value;
				}
			}
		}
	}
	
	public partial class SP_LISTADO_NIVEL_ACCESOResult
	{
		
		private decimal _IdNivelAcceso;
		
		private string _Descripcion;
		
		public SP_LISTADO_NIVEL_ACCESOResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IdNivelAcceso", DbType="Decimal(20,0) NOT NULL")]
		public decimal IdNivelAcceso
		{
			get
			{
				return this._IdNivelAcceso;
			}
			set
			{
				if ((this._IdNivelAcceso != value))
				{
					this._IdNivelAcceso = value;
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
	
	public partial class SP_LISTA_USUARIOSResult
	{
		
		private System.Nullable<decimal> _IdUsuario;
		
		private string _Persona;
		
		public SP_LISTA_USUARIOSResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IdUsuario", DbType="Decimal(20,0)")]
		public System.Nullable<decimal> IdUsuario
		{
			get
			{
				return this._IdUsuario;
			}
			set
			{
				if ((this._IdUsuario != value))
				{
					this._IdUsuario = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Persona", DbType="VarChar(100)")]
		public string Persona
		{
			get
			{
				return this._Persona;
			}
			set
			{
				if ((this._Persona != value))
				{
					this._Persona = value;
				}
			}
		}
	}
	
	public partial class SP_BUSCA_LISTA_TIPO_MAILResult
	{
		
		private System.Nullable<int> _IdTipoMail;
		
		private string _TipoMail;
		
		public SP_BUSCA_LISTA_TIPO_MAILResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IdTipoMail", DbType="Int")]
		public System.Nullable<int> IdTipoMail
		{
			get
			{
				return this._IdTipoMail;
			}
			set
			{
				if ((this._IdTipoMail != value))
				{
					this._IdTipoMail = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TipoMail", DbType="VarChar(100)")]
		public string TipoMail
		{
			get
			{
				return this._TipoMail;
			}
			set
			{
				if ((this._TipoMail != value))
				{
					this._TipoMail = value;
				}
			}
		}
	}
	
	public partial class SP_LISTADO_TIPO_PAGOResult
	{
		
		private decimal _IdTipoPago;
		
		private string _TipoPago;
		
		private System.Nullable<bool> _BloqueaMonto;
		
		private System.Nullable<bool> _ImpuestoAdicional;
		
		private System.Nullable<bool> _PorcentajeEntero;
		
		private System.Nullable<decimal> _Valor;
		
		public SP_LISTADO_TIPO_PAGOResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IdTipoPago", DbType="Decimal(20,0) NOT NULL")]
		public decimal IdTipoPago
		{
			get
			{
				return this._IdTipoPago;
			}
			set
			{
				if ((this._IdTipoPago != value))
				{
					this._IdTipoPago = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TipoPago", DbType="VarChar(100)")]
		public string TipoPago
		{
			get
			{
				return this._TipoPago;
			}
			set
			{
				if ((this._TipoPago != value))
				{
					this._TipoPago = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_BloqueaMonto", DbType="Bit")]
		public System.Nullable<bool> BloqueaMonto
		{
			get
			{
				return this._BloqueaMonto;
			}
			set
			{
				if ((this._BloqueaMonto != value))
				{
					this._BloqueaMonto = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ImpuestoAdicional", DbType="Bit")]
		public System.Nullable<bool> ImpuestoAdicional
		{
			get
			{
				return this._ImpuestoAdicional;
			}
			set
			{
				if ((this._ImpuestoAdicional != value))
				{
					this._ImpuestoAdicional = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PorcentajeEntero", DbType="Bit")]
		public System.Nullable<bool> PorcentajeEntero
		{
			get
			{
				return this._PorcentajeEntero;
			}
			set
			{
				if ((this._PorcentajeEntero != value))
				{
					this._PorcentajeEntero = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Valor", DbType="Decimal(20,2)")]
		public System.Nullable<decimal> Valor
		{
			get
			{
				return this._Valor;
			}
			set
			{
				if ((this._Valor != value))
				{
					this._Valor = value;
				}
			}
		}
	}
	
	public partial class SP_CARGAR_MARCASResult
	{
		
		private decimal _IdMarca;
		
		private string _Descripcion;
		
		public SP_CARGAR_MARCASResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IdMarca", DbType="Decimal(20,0) NOT NULL")]
		public decimal IdMarca
		{
			get
			{
				return this._IdMarca;
			}
			set
			{
				if ((this._IdMarca != value))
				{
					this._IdMarca = value;
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
	
	public partial class SP_LISTADO_BIENES_SERVICIOSResult
	{
		
		private int _IdTipoBienesServicio;
		
		private string _Descripcion;
		
		public SP_LISTADO_BIENES_SERVICIOSResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IdTipoBienesServicio", DbType="Int NOT NULL")]
		public int IdTipoBienesServicio
		{
			get
			{
				return this._IdTipoBienesServicio;
			}
			set
			{
				if ((this._IdTipoBienesServicio != value))
				{
					this._IdTipoBienesServicio = value;
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
	
	public partial class SP_LISTADO_TIPO_RETENCION_ISRResult
	{
		
		private System.Nullable<int> _IdTipoRetencionISR;
		
		private string _Descripcion;
		
		private System.Nullable<bool> _Estatus;
		
		public SP_LISTADO_TIPO_RETENCION_ISRResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IdTipoRetencionISR", DbType="Int")]
		public System.Nullable<int> IdTipoRetencionISR
		{
			get
			{
				return this._IdTipoRetencionISR;
			}
			set
			{
				if ((this._IdTipoRetencionISR != value))
				{
					this._IdTipoRetencionISR = value;
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Estatus", DbType="Bit")]
		public System.Nullable<bool> Estatus
		{
			get
			{
				return this._Estatus;
			}
			set
			{
				if ((this._Estatus != value))
				{
					this._Estatus = value;
				}
			}
		}
	}
	
	public partial class SP_BUSCA_LISTA_TIPO_INGRESOSResult
	{
		
		private int _IdTipoIngreso;
		
		private string _Descripcion;
		
		public SP_BUSCA_LISTA_TIPO_INGRESOSResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IdTipoIngreso", DbType="Int NOT NULL")]
		public int IdTipoIngreso
		{
			get
			{
				return this._IdTipoIngreso;
			}
			set
			{
				if ((this._IdTipoIngreso != value))
				{
					this._IdTipoIngreso = value;
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
	
	public partial class SP_MOSTRAR_LISTADO_TIPO_ANULACIONResult
	{
		
		private decimal _IdTipoAnulacion;
		
		private string _Descripcion;
		
		public SP_MOSTRAR_LISTADO_TIPO_ANULACIONResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IdTipoAnulacion", DbType="Decimal(20,0) NOT NULL")]
		public decimal IdTipoAnulacion
		{
			get
			{
				return this._IdTipoAnulacion;
			}
			set
			{
				if ((this._IdTipoAnulacion != value))
				{
					this._IdTipoAnulacion = value;
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
