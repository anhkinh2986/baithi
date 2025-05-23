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
	/// Instance class encapsulating : Server[@Name='']/ResourceGovernor/ResourcePool
	/// </summary>
	/// <inheritdoc/>
	[SfcElement( SfcElementFlags.Standalone )]
	public sealed partial class ResourcePool  : ISfcSupportsDesignMode
	{
		public ResourcePool() : base(){ }
		public ResourcePool(ResourceGovernor resourceGovernor, string name) : base()
		{
			ValidateName(name);
			this.key = new SimpleObjectKey(name);
			this.Parent = resourceGovernor;
		}
		[SfcObject(SfcObjectRelationship.ParentObject)]
		public ResourceGovernor Parent
		{
			get
			{
				CheckObjectState();
				return base.ParentColl.ParentInstance as ResourceGovernor;
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
						return -1;
					}
					else
					{
						return -1;
					}
				}
				else
				{
					switch(propertyName)
					{
						case "ID": return 0;
						case "IsSystemObject": return 1;
						case "MaximumCpuPercentage": return 2;
						case "MaximumMemoryPercentage": return 3;
						case "MinimumCpuPercentage": return 4;
						case "MinimumMemoryPercentage": return 5;
						case "PolicyHealthState": return 6;
						case "CapCpuPercentage": return 7;
						case "MaximumIopsPerVolume": return 8;
						case "MinimumIopsPerVolume": return 9;
					}
					return -1;
				}
			}
			static int [] versionCount = new int [] { 0, 0, 0, 7, 7, 8, 10, 10, 10, 10, 10, 10 };
			static int [] cloudVersionCount = new int [] { 0, 0, 0 };
			static int sqlDwPropertyCount = 0;
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
			};
			internal static StaticMetadata [] cloudStaticMetadata = 
			{
			};
			internal static StaticMetadata [] staticMetadata = 
			{
				new StaticMetadata("ID", false, true, typeof(System.Int32)),
				new StaticMetadata("IsSystemObject", false, true, typeof(System.Boolean)),
				new StaticMetadata("MaximumCpuPercentage", false, false, typeof(System.Int32)),
				new StaticMetadata("MaximumMemoryPercentage", false, false, typeof(System.Int32)),
				new StaticMetadata("MinimumCpuPercentage", false, false, typeof(System.Int32)),
				new StaticMetadata("MinimumMemoryPercentage", false, false, typeof(System.Int32)),
				new StaticMetadata("PolicyHealthState", true, false, typeof(Microsoft.SqlServer.Management.Dmf.PolicyHealthState)),
				new StaticMetadata("CapCpuPercentage", false, false, typeof(System.Int32)),
				new StaticMetadata("MaximumIopsPerVolume", false, false, typeof(System.Int32)),
				new StaticMetadata("MinimumIopsPerVolume", false, false, typeof(System.Int32)),
			};
		}
		[SfcProperty(SfcPropertyFlags.Standalone)]
		public System.Int32 CapCpuPercentage
		{
			get
			{
				return (System.Int32)this.Properties.GetValueWithNullReplacement("CapCpuPercentage");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("CapCpuPercentage", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.Standalone)]
		public System.Int32 ID
		{
			get
			{
				return (System.Int32)this.Properties.GetValueWithNullReplacement("ID");
			}
		}
		[SfcProperty(SfcPropertyFlags.Standalone)]
		public System.Boolean IsSystemObject
		{
			get
			{
				return (System.Boolean)this.Properties.GetValueWithNullReplacement("IsSystemObject");
			}
		}
		[SfcProperty(SfcPropertyFlags.Standalone)]
		public System.Int32 MaximumCpuPercentage
		{
			get
			{
				return (System.Int32)this.Properties.GetValueWithNullReplacement("MaximumCpuPercentage");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("MaximumCpuPercentage", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.Standalone)]
		public System.Int32 MaximumIopsPerVolume
		{
			get
			{
				return (System.Int32)this.Properties.GetValueWithNullReplacement("MaximumIopsPerVolume");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("MaximumIopsPerVolume", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.Standalone)]
		public System.Int32 MaximumMemoryPercentage
		{
			get
			{
				return (System.Int32)this.Properties.GetValueWithNullReplacement("MaximumMemoryPercentage");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("MaximumMemoryPercentage", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.Standalone)]
		public System.Int32 MinimumCpuPercentage
		{
			get
			{
				return (System.Int32)this.Properties.GetValueWithNullReplacement("MinimumCpuPercentage");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("MinimumCpuPercentage", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.Standalone)]
		public System.Int32 MinimumIopsPerVolume
		{
			get
			{
				return (System.Int32)this.Properties.GetValueWithNullReplacement("MinimumIopsPerVolume");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("MinimumIopsPerVolume", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.Standalone)]
		public System.Int32 MinimumMemoryPercentage
		{
			get
			{
				return (System.Int32)this.Properties.GetValueWithNullReplacement("MinimumMemoryPercentage");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("MinimumMemoryPercentage", value);
			}
		}
	}
}
