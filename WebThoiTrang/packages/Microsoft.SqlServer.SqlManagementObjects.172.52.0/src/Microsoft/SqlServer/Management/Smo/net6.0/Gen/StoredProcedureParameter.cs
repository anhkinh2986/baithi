/*
**** This file has been automatically generated. Do not attempt to modify manually! ****
*/
/*
**** The generated file is compatible with SFC attribute (metadata) requirement ****
*/
using System;
using System.Collections;
using System.Net;
using Microsoft.SqlServer.Management.Sdk.Sfc.Metadata;
using Microsoft.SqlServer.Management.Sdk.Sfc;
using Microsoft.SqlServer.Management.Common;

namespace Microsoft.SqlServer.Management.Smo
{
	/// <summary>
	/// Instance class encapsulating : Server[@Name='']/Database/StoredProcedure/Param
	/// </summary>
	/// <inheritdoc/>
	[SfcElement( SfcElementFlags.Standalone | SfcElementFlags.SqlAzureDatabase )]
	public sealed partial class StoredProcedureParameter  : ISfcSupportsDesignMode
	{
		public StoredProcedureParameter() : base(){ }
		public StoredProcedureParameter(StoredProcedure storedProcedure, string name) : base()
		{
			ValidateName(name);
			this.key = new SimpleObjectKey(name);
			this.Parent = storedProcedure;
		}
		[SfcObject(SfcObjectRelationship.ParentObject, SfcObjectFlags.Design)]
		public StoredProcedure Parent
		{
			get
			{
				CheckObjectState();
				return base.ParentColl.ParentInstance as StoredProcedure;
			}
			set{SetParentImpl(value);}
		}
		/// <summary>
		/// This object extend ISfcSupportsDesignMode.
		/// </summary>
		bool ISfcSupportsDesignMode.IsDesignMode
		{
			get
			{
				// call the base class 
				return IsDesignMode;
			}
		}
		internal override SqlPropertyMetadataProvider GetPropertyMetadataProvider()
		{
			return new PropertyMetadataProvider(this.ServerVersion,this.DatabaseEngineType, this.DatabaseEngineEdition);
		}
		internal class PropertyMetadataProvider : SqlPropertyMetadataProvider
		{
			internal PropertyMetadataProvider(Common.ServerVersion version,DatabaseEngineType databaseEngineType, DatabaseEngineEdition databaseEngineEdition) : base(version,databaseEngineType, databaseEngineEdition)
			{
			}
			public override int PropertyNameToIDLookup(string propertyName)
			{
				if(this.DatabaseEngineType == DatabaseEngineType.SqlAzureDatabase)
				{
					if(this.DatabaseEngineEdition == DatabaseEngineEdition.SqlDataWarehouse)
					{
						switch(propertyName)
						{
							case "DataType": return 0;
							case "DataTypeSchema": return 1;
							case "DefaultValue": return 2;
							case "HasDefaultValue": return 3;
							case "ID": return 4;
							case "IsCursorParameter": return 5;
							case "IsOutputParameter": return 6;
							case "IsReadOnly": return 7;
							case "Length": return 8;
							case "NumericPrecision": return 9;
							case "NumericScale": return 10;
							case "SystemType": return 11;
							case "UserType": return 12;
						}
						return -1;
					}
					else
					{
						switch(propertyName)
						{
							case "DataType": return 0;
							case "DataTypeSchema": return 1;
							case "DefaultValue": return 2;
							case "HasDefaultValue": return 3;
							case "ID": return 4;
							case "IsCursorParameter": return 5;
							case "IsOutputParameter": return 6;
							case "IsReadOnly": return 7;
							case "Length": return 8;
							case "NumericPrecision": return 9;
							case "NumericScale": return 10;
							case "SystemType": return 11;
							case "UserType": return 12;
							case "XmlDocumentConstraint": return 13;
							case "XmlSchemaNamespace": return 14;
							case "XmlSchemaNamespaceSchema": return 15;
						}
						return -1;
					}
				}
				else
				{
					switch(propertyName)
					{
						case "DataType": return 0;
						case "DataTypeSchema": return 1;
						case "DefaultValue": return 2;
						case "ID": return 3;
						case "IsOutputParameter": return 4;
						case "Length": return 5;
						case "NumericPrecision": return 6;
						case "NumericScale": return 7;
						case "SystemType": return 8;
						case "HasDefaultValue": return 9;
						case "IsCursorParameter": return 10;
						case "XmlDocumentConstraint": return 11;
						case "XmlSchemaNamespace": return 12;
						case "XmlSchemaNamespaceSchema": return 13;
						case "IsReadOnly": return 14;
						case "UserType": return 15;
					}
					return -1;
				}
			}
			static int [] versionCount = new int [] { 9, 9, 14, 16, 16, 16, 16, 16, 16, 16, 16, 16 };
			static int [] cloudVersionCount = new int [] { 16, 16, 16 };
			static int sqlDwPropertyCount = 13;
			public override int Count
			{
				get
				{
					if(this.DatabaseEngineType == DatabaseEngineType.SqlAzureDatabase)
					{
						if(this.DatabaseEngineEdition == DatabaseEngineEdition.SqlDataWarehouse)
						{
							return sqlDwPropertyCount;
						}
						else
						{
							int index = (currentVersionIndex < cloudVersionCount.Length) ? currentVersionIndex : cloudVersionCount.Length - 1;
							return cloudVersionCount[index];
						}
					}
					 else 
					{
						int index = (currentVersionIndex < versionCount.Length) ? currentVersionIndex : versionCount.Length - 1;
						return versionCount[index];
					}
				}
			}
			protected override int[] VersionCount
			{
				get
				{
					if(this.DatabaseEngineType == DatabaseEngineType.SqlAzureDatabase)
					{
						if(this.DatabaseEngineEdition == DatabaseEngineEdition.SqlDataWarehouse)
						{
							 return new int[] { sqlDwPropertyCount }; 
						}
						else
						{
							 return cloudVersionCount; 
						}
					}
					 else 
					{
						 return versionCount;  
					}
				}
			}
			new internal static int[] GetVersionArray(DatabaseEngineType databaseEngineType, DatabaseEngineEdition databaseEngineEdition)
			{
				if(databaseEngineType == DatabaseEngineType.SqlAzureDatabase)
				{
					if(databaseEngineEdition == DatabaseEngineEdition.SqlDataWarehouse)
					{
						 return new int[] { sqlDwPropertyCount }; 
					}
					else
					{
						 return cloudVersionCount; 
					}
				}
				 else 
				{
					 return versionCount;  
				}
			}
			public override StaticMetadata GetStaticMetadata(int id)
			{
				if(this.DatabaseEngineType == DatabaseEngineType.SqlAzureDatabase)
				{
					if(this.DatabaseEngineEdition == DatabaseEngineEdition.SqlDataWarehouse)
					{
						 return sqlDwStaticMetadata[id]; 
					}
					else
					{
						 return cloudStaticMetadata[id]; 
					}
				}
				 else 
				{
					return staticMetadata[id];
				}
			}
			new internal static StaticMetadata[] GetStaticMetadataArray(DatabaseEngineType databaseEngineType, DatabaseEngineEdition databaseEngineEdition)
			{
				if(databaseEngineType == DatabaseEngineType.SqlAzureDatabase)
				{
					if(databaseEngineEdition == DatabaseEngineEdition.SqlDataWarehouse)
					{
						 return sqlDwStaticMetadata; 
					}
					else
					{
						 return cloudStaticMetadata;
					}
				}
				 else 
				{
					return staticMetadata;
				}
			}
			internal static StaticMetadata [] sqlDwStaticMetadata = 
			{
				new StaticMetadata("DataType", false, false, typeof(System.String)),
				new StaticMetadata("DataTypeSchema", false, false, typeof(System.String)),
				new StaticMetadata("DefaultValue", false, false, typeof(System.String)),
				new StaticMetadata("HasDefaultValue", false, false, typeof(System.Boolean)),
				new StaticMetadata("ID", false, true, typeof(System.Int32)),
				new StaticMetadata("IsCursorParameter", false, false, typeof(System.Boolean)),
				new StaticMetadata("IsOutputParameter", false, false, typeof(System.Boolean)),
				new StaticMetadata("IsReadOnly", false, false, typeof(System.Boolean)),
				new StaticMetadata("Length", false, false, typeof(System.Int32)),
				new StaticMetadata("NumericPrecision", false, false, typeof(System.Int32)),
				new StaticMetadata("NumericScale", false, false, typeof(System.Int32)),
				new StaticMetadata("SystemType", false, true, typeof(System.String)),
				new StaticMetadata("UserType", false, true, typeof(System.String)),
			};
			internal static StaticMetadata [] cloudStaticMetadata = 
			{
				new StaticMetadata("DataType", false, false, typeof(System.String)),
				new StaticMetadata("DataTypeSchema", false, false, typeof(System.String)),
				new StaticMetadata("DefaultValue", false, false, typeof(System.String)),
				new StaticMetadata("HasDefaultValue", false, false, typeof(System.Boolean)),
				new StaticMetadata("ID", false, true, typeof(System.Int32)),
				new StaticMetadata("IsCursorParameter", false, false, typeof(System.Boolean)),
				new StaticMetadata("IsOutputParameter", false, false, typeof(System.Boolean)),
				new StaticMetadata("IsReadOnly", false, false, typeof(System.Boolean)),
				new StaticMetadata("Length", false, false, typeof(System.Int32)),
				new StaticMetadata("NumericPrecision", false, false, typeof(System.Int32)),
				new StaticMetadata("NumericScale", false, false, typeof(System.Int32)),
				new StaticMetadata("SystemType", false, true, typeof(System.String)),
				new StaticMetadata("UserType", false, true, typeof(System.String)),
				new StaticMetadata("XmlDocumentConstraint", false, false, typeof(Microsoft.SqlServer.Management.Smo.XmlDocumentConstraint)),
				new StaticMetadata("XmlSchemaNamespace", false, false, typeof(System.String)),
				new StaticMetadata("XmlSchemaNamespaceSchema", false, false, typeof(System.String)),
			};
			internal static StaticMetadata [] staticMetadata = 
			{
				new StaticMetadata("DataType", false, false, typeof(System.String)),
				new StaticMetadata("DataTypeSchema", false, false, typeof(System.String)),
				new StaticMetadata("DefaultValue", false, false, typeof(System.String)),
				new StaticMetadata("ID", false, true, typeof(System.Int32)),
				new StaticMetadata("IsOutputParameter", false, false, typeof(System.Boolean)),
				new StaticMetadata("Length", false, false, typeof(System.Int32)),
				new StaticMetadata("NumericPrecision", false, false, typeof(System.Int32)),
				new StaticMetadata("NumericScale", false, false, typeof(System.Int32)),
				new StaticMetadata("SystemType", false, true, typeof(System.String)),
				new StaticMetadata("HasDefaultValue", false, false, typeof(System.Boolean)),
				new StaticMetadata("IsCursorParameter", false, false, typeof(System.Boolean)),
				new StaticMetadata("XmlDocumentConstraint", false, false, typeof(Microsoft.SqlServer.Management.Smo.XmlDocumentConstraint)),
				new StaticMetadata("XmlSchemaNamespace", false, false, typeof(System.String)),
				new StaticMetadata("XmlSchemaNamespaceSchema", false, false, typeof(System.String)),
				new StaticMetadata("IsReadOnly", false, false, typeof(System.Boolean)),
				new StaticMetadata("UserType", false, true, typeof(System.String)),
			};
		}
		[SfcProperty(SfcPropertyFlags.Design |SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone)]
		public System.Boolean IsCursorParameter
		{
			get
			{
				return (System.Boolean)this.Properties.GetValueWithNullReplacement("IsCursorParameter");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("IsCursorParameter", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.Design |SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone)]
		public System.Boolean IsOutputParameter
		{
			get
			{
				return (System.Boolean)this.Properties.GetValueWithNullReplacement("IsOutputParameter");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("IsOutputParameter", value);
			}
		}

		public StoredProcedureParameter(StoredProcedure storedProcedure, System.String name, DataType dataType)
		{
			ValidateName(name);
			this.key = new SimpleObjectKey(name);
			this.Parent = storedProcedure;
			this.DataType = dataType;
		}
		
	}

}
