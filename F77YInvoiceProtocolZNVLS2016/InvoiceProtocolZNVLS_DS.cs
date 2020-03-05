using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Reflection;
using System.Runtime.Serialization;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace F77YInvoiceProtocolZNVLS2016
{
	[DesignerCategory("code")]
	[HelpKeyword("vs.data.DataSet")]
	[Serializable]
	[ToolboxItem(true)]
	[XmlRoot("InvoiceProtocolZNVLS_DS")]
	[XmlSchemaProvider("GetTypedDataSetSchema")]
	public class InvoiceProtocolZNVLS_DS : DataSet
	{
		private System.Data.SchemaSerializationMode _schemaSerializationMode;

		private InvoiceProtocolZNVLS_DS.Table0DataTable tableTable0;

		private InvoiceProtocolZNVLS_DS.Table1DataTable tableTable1;

		[DebuggerNonUserCode]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public new DataRelationCollection Relations
		{
			get
			{
				return base.Relations;
			}
		}

		[Browsable(true)]
		[DebuggerNonUserCode]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public override System.Data.SchemaSerializationMode SchemaSerializationMode
		{
			get
			{
				return this._schemaSerializationMode;
			}
			set
			{
				this._schemaSerializationMode = value;
			}
		}

		[Browsable(false)]
		[DebuggerNonUserCode]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public InvoiceProtocolZNVLS_DS.Table0DataTable Table0
		{
			get
			{
				return this.tableTable0;
			}
		}

		[Browsable(false)]
		[DebuggerNonUserCode]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public InvoiceProtocolZNVLS_DS.Table1DataTable Table1
		{
			get
			{
				return this.tableTable1;
			}
		}

		[DebuggerNonUserCode]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public new DataTableCollection Tables
		{
			get
			{
				return base.Tables;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public InvoiceProtocolZNVLS_DS()
		{
			this._schemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			base.BeginInit();
			this.InitClass();
			CollectionChangeEventHandler collectionChangeEventHandler = new CollectionChangeEventHandler(this.SchemaChanged);
			base.Tables.CollectionChanged += collectionChangeEventHandler;
			base.Relations.CollectionChanged += collectionChangeEventHandler;
			base.EndInit();
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected InvoiceProtocolZNVLS_DS(SerializationInfo info, StreamingContext context) : base(info, context, false)
		{
			this._schemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			if (!base.IsBinarySerialized(info, context))
			{
				string value = (string)info.GetValue("XmlSchema", typeof(string));
				if (base.DetermineSchemaSerializationMode(info, context) != System.Data.SchemaSerializationMode.IncludeSchema)
				{
					base.ReadXmlSchema(new XmlTextReader(new StringReader(value)));
				}
				else
				{
					DataSet dataSet = new DataSet();
					dataSet.ReadXmlSchema(new XmlTextReader(new StringReader(value)));
					if (dataSet.Tables["Table0"] != null)
					{
						base.Tables.Add(new InvoiceProtocolZNVLS_DS.Table0DataTable(dataSet.Tables["Table0"]));
					}
					if (dataSet.Tables["Table1"] != null)
					{
						base.Tables.Add(new InvoiceProtocolZNVLS_DS.Table1DataTable(dataSet.Tables["Table1"]));
					}
					base.DataSetName = dataSet.DataSetName;
					base.Prefix = dataSet.Prefix;
					base.Namespace = dataSet.Namespace;
					base.Locale = dataSet.Locale;
					base.CaseSensitive = dataSet.CaseSensitive;
					base.EnforceConstraints = dataSet.EnforceConstraints;
					base.Merge(dataSet, false, MissingSchemaAction.Add);
					this.InitVars();
				}
				base.GetSerializationData(info, context);
				CollectionChangeEventHandler collectionChangeEventHandler = new CollectionChangeEventHandler(this.SchemaChanged);
				base.Tables.CollectionChanged += collectionChangeEventHandler;
				this.Relations.CollectionChanged += collectionChangeEventHandler;
			}
			else
			{
				this.InitVars(false);
				CollectionChangeEventHandler collectionChangeEventHandler1 = new CollectionChangeEventHandler(this.SchemaChanged);
				this.Tables.CollectionChanged += collectionChangeEventHandler1;
				this.Relations.CollectionChanged += collectionChangeEventHandler1;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public override DataSet Clone()
		{
			InvoiceProtocolZNVLS_DS schemaSerializationMode = (InvoiceProtocolZNVLS_DS)base.Clone();
			schemaSerializationMode.InitVars();
			schemaSerializationMode.SchemaSerializationMode = this.SchemaSerializationMode;
			return schemaSerializationMode;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override XmlSchema GetSchemaSerializable()
		{
			MemoryStream memoryStream = new MemoryStream();
			base.WriteXmlSchema(new XmlTextWriter(memoryStream, null));
			memoryStream.Position = (long)0;
			return XmlSchema.Read(new XmlTextReader(memoryStream), null);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public static XmlSchemaComplexType GetTypedDataSetSchema(XmlSchemaSet xs)
		{
			XmlSchemaComplexType xmlSchemaComplexType;
			InvoiceProtocolZNVLS_DS invoiceProtocolZNVLSD = new InvoiceProtocolZNVLS_DS();
			XmlSchemaComplexType xmlSchemaComplexType1 = new XmlSchemaComplexType();
			XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
			XmlSchemaAny xmlSchemaAny = new XmlSchemaAny()
			{
				Namespace = invoiceProtocolZNVLSD.Namespace
			};
			xmlSchemaSequence.Items.Add(xmlSchemaAny);
			xmlSchemaComplexType1.Particle = xmlSchemaSequence;
			XmlSchema schemaSerializable = invoiceProtocolZNVLSD.GetSchemaSerializable();
			if (xs.Contains(schemaSerializable.TargetNamespace))
			{
				MemoryStream memoryStream = new MemoryStream();
				MemoryStream memoryStream1 = new MemoryStream();
				try
				{
					XmlSchema current = null;
					schemaSerializable.Write(memoryStream);
					IEnumerator enumerator = xs.Schemas(schemaSerializable.TargetNamespace).GetEnumerator();
					while (enumerator.MoveNext())
					{
						current = (XmlSchema)enumerator.Current;
						memoryStream1.SetLength((long)0);
						current.Write(memoryStream1);
						if (memoryStream.Length == memoryStream1.Length)
						{
							memoryStream.Position = (long)0;
							memoryStream1.Position = (long)0;
							while (true)
							{
								if ((memoryStream.Position == memoryStream.Length ? true : memoryStream.ReadByte() != memoryStream1.ReadByte()))
								{
									break;
								}
							}
							if (memoryStream.Position == memoryStream.Length)
							{
								xmlSchemaComplexType = xmlSchemaComplexType1;
								return xmlSchemaComplexType;
							}
						}
					}
				}
				finally
				{
					if (memoryStream != null)
					{
						memoryStream.Close();
					}
					if (memoryStream1 != null)
					{
						memoryStream1.Close();
					}
				}
			}
			xs.Add(schemaSerializable);
			xmlSchemaComplexType = xmlSchemaComplexType1;
			return xmlSchemaComplexType;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private void InitClass()
		{
			base.DataSetName = "InvoiceProtocolZNVLS_DS";
			base.Prefix = "";
			base.Namespace = "http://tempuri.org/InvoiceProtocolZNVLS_DS.xsd";
			base.EnforceConstraints = true;
			this.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			this.tableTable0 = new InvoiceProtocolZNVLS_DS.Table0DataTable();
			base.Tables.Add(this.tableTable0);
			this.tableTable1 = new InvoiceProtocolZNVLS_DS.Table1DataTable();
			base.Tables.Add(this.tableTable1);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override void InitializeDerivedDataSet()
		{
			base.BeginInit();
			this.InitClass();
			base.EndInit();
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		internal void InitVars()
		{
			this.InitVars(true);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		internal void InitVars(bool initTable)
		{
			this.tableTable0 = (InvoiceProtocolZNVLS_DS.Table0DataTable)base.Tables["Table0"];
			if ((!initTable ? false : this.tableTable0 != null))
			{
				this.tableTable0.InitVars();
			}
			this.tableTable1 = (InvoiceProtocolZNVLS_DS.Table1DataTable)base.Tables["Table1"];
			if ((!initTable ? false : this.tableTable1 != null))
			{
				this.tableTable1.InitVars();
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override void ReadXmlSerializable(XmlReader reader)
		{
			if (base.DetermineSchemaSerializationMode(reader) != System.Data.SchemaSerializationMode.IncludeSchema)
			{
				base.ReadXml(reader);
				this.InitVars();
			}
			else
			{
				this.Reset();
				DataSet dataSet = new DataSet();
				dataSet.ReadXml(reader);
				if (dataSet.Tables["Table0"] != null)
				{
					base.Tables.Add(new InvoiceProtocolZNVLS_DS.Table0DataTable(dataSet.Tables["Table0"]));
				}
				if (dataSet.Tables["Table1"] != null)
				{
					base.Tables.Add(new InvoiceProtocolZNVLS_DS.Table1DataTable(dataSet.Tables["Table1"]));
				}
				base.DataSetName = dataSet.DataSetName;
				base.Prefix = dataSet.Prefix;
				base.Namespace = dataSet.Namespace;
				base.Locale = dataSet.Locale;
				base.CaseSensitive = dataSet.CaseSensitive;
				base.EnforceConstraints = dataSet.EnforceConstraints;
				base.Merge(dataSet, false, MissingSchemaAction.Add);
				this.InitVars();
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private void SchemaChanged(object sender, CollectionChangeEventArgs e)
		{
			if (e.Action == CollectionChangeAction.Remove)
			{
				this.InitVars();
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override bool ShouldSerializeRelations()
		{
			return false;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private bool ShouldSerializeTable0()
		{
			return false;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private bool ShouldSerializeTable1()
		{
			return false;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override bool ShouldSerializeTables()
		{
			return false;
		}

		[Serializable]
		[XmlSchemaProvider("GetTypedTableSchema")]
		public class Table0DataTable : TypedTableBase<InvoiceProtocolZNVLS_DS.Table0Row>
		{
			private DataColumn columnADPRICE_SAL;

			private DataColumn columnADPRICE_SAL_SUM;

			private DataColumn columnADPRICE_SUP;

			private DataColumn columnADPRICE_SUP_SUM;

			private DataColumn columnGOODS_NAME;

			private DataColumn columnPRICE_PROD;

			private DataColumn columnPRICE_SAL;

			private DataColumn columnPRICE_SUP;

			private DataColumn columnPRODUCER_NAME;

			private DataColumn columnREGISTER_PRICE;

			private DataColumn columnSERIES_NAME;

			private InvoiceProtocolZNVLS_DS.Table0RowChangeEventHandler Table0RowChanged;

			private InvoiceProtocolZNVLS_DS.Table0RowChangeEventHandler Table0RowChanging;

			private InvoiceProtocolZNVLS_DS.Table0RowChangeEventHandler Table0RowDeleted;

			private InvoiceProtocolZNVLS_DS.Table0RowChangeEventHandler Table0RowDeleting;

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn ADPRICE_SAL_SUMColumn
			{
				get
				{
					return this.columnADPRICE_SAL_SUM;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn ADPRICE_SALColumn
			{
				get
				{
					return this.columnADPRICE_SAL;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn ADPRICE_SUP_SUMColumn
			{
				get
				{
					return this.columnADPRICE_SUP_SUM;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn ADPRICE_SUPColumn
			{
				get
				{
					return this.columnADPRICE_SUP;
				}
			}

			[Browsable(false)]
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public int Count
			{
				get
				{
					return base.Rows.Count;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn GOODS_NAMEColumn
			{
				get
				{
					return this.columnGOODS_NAME;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public InvoiceProtocolZNVLS_DS.Table0Row this[int index]
			{
				get
				{
					return (InvoiceProtocolZNVLS_DS.Table0Row)base.Rows[index];
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn PRICE_PRODColumn
			{
				get
				{
					return this.columnPRICE_PROD;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn PRICE_SALColumn
			{
				get
				{
					return this.columnPRICE_SAL;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn PRICE_SUPColumn
			{
				get
				{
					return this.columnPRICE_SUP;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn PRODUCER_NAMEColumn
			{
				get
				{
					return this.columnPRODUCER_NAME;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn REGISTER_PRICEColumn
			{
				get
				{
					return this.columnREGISTER_PRICE;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn SERIES_NAMEColumn
			{
				get
				{
					return this.columnSERIES_NAME;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public Table0DataTable()
			{
				base.TableName = "Table0";
				this.BeginInit();
				this.InitClass();
				this.EndInit();
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			internal Table0DataTable(DataTable table)
			{
				base.TableName = table.TableName;
				if (table.CaseSensitive != table.DataSet.CaseSensitive)
				{
					base.CaseSensitive = table.CaseSensitive;
				}
				if (table.Locale.ToString() != table.DataSet.Locale.ToString())
				{
					base.Locale = table.Locale;
				}
				if (table.Namespace != table.DataSet.Namespace)
				{
					base.Namespace = table.Namespace;
				}
				base.Prefix = table.Prefix;
				base.MinimumCapacity = table.MinimumCapacity;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected Table0DataTable(SerializationInfo info, StreamingContext context) : base(info, context)
			{
				this.InitVars();
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void AddTable0Row(InvoiceProtocolZNVLS_DS.Table0Row row)
			{
				base.Rows.Add(row);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public InvoiceProtocolZNVLS_DS.Table0Row AddTable0Row(string GOODS_NAME, string SERIES_NAME, string PRODUCER_NAME, string REGISTER_PRICE, string PRICE_PROD, string ADPRICE_SUP, string ADPRICE_SUP_SUM, string PRICE_SUP, string ADPRICE_SAL, string ADPRICE_SAL_SUM, string PRICE_SAL)
			{
				InvoiceProtocolZNVLS_DS.Table0Row table0Row = (InvoiceProtocolZNVLS_DS.Table0Row)base.NewRow();
				object[] gOODSNAME = new object[] { GOODS_NAME, SERIES_NAME, PRODUCER_NAME, REGISTER_PRICE, PRICE_PROD, ADPRICE_SUP, ADPRICE_SUP_SUM, PRICE_SUP, ADPRICE_SAL, ADPRICE_SAL_SUM, PRICE_SAL };
				table0Row.ItemArray = gOODSNAME;
				base.Rows.Add(table0Row);
				return table0Row;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public override DataTable Clone()
			{
				InvoiceProtocolZNVLS_DS.Table0DataTable table0DataTable = (InvoiceProtocolZNVLS_DS.Table0DataTable)base.Clone();
				table0DataTable.InitVars();
				return table0DataTable;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override DataTable CreateInstance()
			{
				return new InvoiceProtocolZNVLS_DS.Table0DataTable();
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override Type GetRowType()
			{
				return typeof(InvoiceProtocolZNVLS_DS.Table0Row);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
			{
				XmlSchemaComplexType xmlSchemaComplexType;
				XmlSchemaComplexType xmlSchemaComplexType1 = new XmlSchemaComplexType();
				XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
				InvoiceProtocolZNVLS_DS invoiceProtocolZNVLSD = new InvoiceProtocolZNVLS_DS();
				XmlSchemaAny xmlSchemaAny = new XmlSchemaAny()
				{
					Namespace = "http://www.w3.org/2001/XMLSchema",
					MinOccurs = new decimal(0),
					MaxOccurs = new decimal(-1, -1, -1, false, 0),
					ProcessContents = XmlSchemaContentProcessing.Lax
				};
				xmlSchemaSequence.Items.Add(xmlSchemaAny);
				XmlSchemaAny xmlSchemaAny1 = new XmlSchemaAny()
				{
					Namespace = "urn:schemas-microsoft-com:xml-diffgram-v1",
					MinOccurs = new decimal(1),
					ProcessContents = XmlSchemaContentProcessing.Lax
				};
				xmlSchemaSequence.Items.Add(xmlSchemaAny1);
				XmlSchemaAttribute xmlSchemaAttribute = new XmlSchemaAttribute()
				{
					Name = "namespace",
					FixedValue = invoiceProtocolZNVLSD.Namespace
				};
				xmlSchemaComplexType1.Attributes.Add(xmlSchemaAttribute);
				XmlSchemaAttribute xmlSchemaAttribute1 = new XmlSchemaAttribute()
				{
					Name = "tableTypeName",
					FixedValue = "Table0DataTable"
				};
				xmlSchemaComplexType1.Attributes.Add(xmlSchemaAttribute1);
				xmlSchemaComplexType1.Particle = xmlSchemaSequence;
				XmlSchema schemaSerializable = invoiceProtocolZNVLSD.GetSchemaSerializable();
				if (xs.Contains(schemaSerializable.TargetNamespace))
				{
					MemoryStream memoryStream = new MemoryStream();
					MemoryStream memoryStream1 = new MemoryStream();
					try
					{
						XmlSchema current = null;
						schemaSerializable.Write(memoryStream);
						IEnumerator enumerator = xs.Schemas(schemaSerializable.TargetNamespace).GetEnumerator();
						while (enumerator.MoveNext())
						{
							current = (XmlSchema)enumerator.Current;
							memoryStream1.SetLength((long)0);
							current.Write(memoryStream1);
							if (memoryStream.Length == memoryStream1.Length)
							{
								memoryStream.Position = (long)0;
								memoryStream1.Position = (long)0;
								while (true)
								{
									if ((memoryStream.Position == memoryStream.Length ? true : memoryStream.ReadByte() != memoryStream1.ReadByte()))
									{
										break;
									}
								}
								if (memoryStream.Position == memoryStream.Length)
								{
									xmlSchemaComplexType = xmlSchemaComplexType1;
									return xmlSchemaComplexType;
								}
							}
						}
					}
					finally
					{
						if (memoryStream != null)
						{
							memoryStream.Close();
						}
						if (memoryStream1 != null)
						{
							memoryStream1.Close();
						}
					}
				}
				xs.Add(schemaSerializable);
				xmlSchemaComplexType = xmlSchemaComplexType1;
				return xmlSchemaComplexType;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			private void InitClass()
			{
				this.columnGOODS_NAME = new DataColumn("GOODS_NAME", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnGOODS_NAME);
				this.columnSERIES_NAME = new DataColumn("SERIES_NAME", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnSERIES_NAME);
				this.columnPRODUCER_NAME = new DataColumn("PRODUCER_NAME", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnPRODUCER_NAME);
				this.columnREGISTER_PRICE = new DataColumn("REGISTER_PRICE", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnREGISTER_PRICE);
				this.columnPRICE_PROD = new DataColumn("PRICE_PROD", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnPRICE_PROD);
				this.columnADPRICE_SUP = new DataColumn("ADPRICE_SUP", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnADPRICE_SUP);
				this.columnADPRICE_SUP_SUM = new DataColumn("ADPRICE_SUP_SUM", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnADPRICE_SUP_SUM);
				this.columnPRICE_SUP = new DataColumn("PRICE_SUP", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnPRICE_SUP);
				this.columnADPRICE_SAL = new DataColumn("ADPRICE_SAL", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnADPRICE_SAL);
				this.columnADPRICE_SAL_SUM = new DataColumn("ADPRICE_SAL_SUM", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnADPRICE_SAL_SUM);
				this.columnPRICE_SAL = new DataColumn("PRICE_SAL", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnPRICE_SAL);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			internal void InitVars()
			{
				this.columnGOODS_NAME = base.Columns["GOODS_NAME"];
				this.columnSERIES_NAME = base.Columns["SERIES_NAME"];
				this.columnPRODUCER_NAME = base.Columns["PRODUCER_NAME"];
				this.columnREGISTER_PRICE = base.Columns["REGISTER_PRICE"];
				this.columnPRICE_PROD = base.Columns["PRICE_PROD"];
				this.columnADPRICE_SUP = base.Columns["ADPRICE_SUP"];
				this.columnADPRICE_SUP_SUM = base.Columns["ADPRICE_SUP_SUM"];
				this.columnPRICE_SUP = base.Columns["PRICE_SUP"];
				this.columnADPRICE_SAL = base.Columns["ADPRICE_SAL"];
				this.columnADPRICE_SAL_SUM = base.Columns["ADPRICE_SAL_SUM"];
				this.columnPRICE_SAL = base.Columns["PRICE_SAL"];
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
			{
				return new InvoiceProtocolZNVLS_DS.Table0Row(builder);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public InvoiceProtocolZNVLS_DS.Table0Row NewTable0Row()
			{
				return (InvoiceProtocolZNVLS_DS.Table0Row)base.NewRow();
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override void OnRowChanged(DataRowChangeEventArgs e)
			{
				base.OnRowChanged(e);
				if (this.Table0RowChanged != null)
				{
					this.Table0RowChanged(this, new InvoiceProtocolZNVLS_DS.Table0RowChangeEvent((InvoiceProtocolZNVLS_DS.Table0Row)e.Row, e.Action));
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override void OnRowChanging(DataRowChangeEventArgs e)
			{
				base.OnRowChanging(e);
				if (this.Table0RowChanging != null)
				{
					this.Table0RowChanging(this, new InvoiceProtocolZNVLS_DS.Table0RowChangeEvent((InvoiceProtocolZNVLS_DS.Table0Row)e.Row, e.Action));
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override void OnRowDeleted(DataRowChangeEventArgs e)
			{
				base.OnRowDeleted(e);
				if (this.Table0RowDeleted != null)
				{
					this.Table0RowDeleted(this, new InvoiceProtocolZNVLS_DS.Table0RowChangeEvent((InvoiceProtocolZNVLS_DS.Table0Row)e.Row, e.Action));
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override void OnRowDeleting(DataRowChangeEventArgs e)
			{
				base.OnRowDeleting(e);
				if (this.Table0RowDeleting != null)
				{
					this.Table0RowDeleting(this, new InvoiceProtocolZNVLS_DS.Table0RowChangeEvent((InvoiceProtocolZNVLS_DS.Table0Row)e.Row, e.Action));
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void RemoveTable0Row(InvoiceProtocolZNVLS_DS.Table0Row row)
			{
				base.Rows.Remove(row);
			}
		}

		public class Table0Row : DataRow
		{
			private InvoiceProtocolZNVLS_DS.Table0DataTable tableTable0;

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public string ADPRICE_SAL
			{
				get
				{
					string item;
					try
					{
						item = (string)base[this.tableTable0.ADPRICE_SALColumn];
					}
					catch (InvalidCastException invalidCastException)
					{
						throw new StrongTypingException("The value for column 'ADPRICE_SAL' in table 'Table0' is DBNull.", invalidCastException);
					}
					return item;
				}
				set
				{
					base[this.tableTable0.ADPRICE_SALColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public string ADPRICE_SAL_SUM
			{
				get
				{
					string item;
					try
					{
						item = (string)base[this.tableTable0.ADPRICE_SAL_SUMColumn];
					}
					catch (InvalidCastException invalidCastException)
					{
						throw new StrongTypingException("The value for column 'ADPRICE_SAL_SUM' in table 'Table0' is DBNull.", invalidCastException);
					}
					return item;
				}
				set
				{
					base[this.tableTable0.ADPRICE_SAL_SUMColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public string ADPRICE_SUP
			{
				get
				{
					string item;
					try
					{
						item = (string)base[this.tableTable0.ADPRICE_SUPColumn];
					}
					catch (InvalidCastException invalidCastException)
					{
						throw new StrongTypingException("The value for column 'ADPRICE_SUP' in table 'Table0' is DBNull.", invalidCastException);
					}
					return item;
				}
				set
				{
					base[this.tableTable0.ADPRICE_SUPColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public string ADPRICE_SUP_SUM
			{
				get
				{
					string item;
					try
					{
						item = (string)base[this.tableTable0.ADPRICE_SUP_SUMColumn];
					}
					catch (InvalidCastException invalidCastException)
					{
						throw new StrongTypingException("The value for column 'ADPRICE_SUP_SUM' in table 'Table0' is DBNull.", invalidCastException);
					}
					return item;
				}
				set
				{
					base[this.tableTable0.ADPRICE_SUP_SUMColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public string GOODS_NAME
			{
				get
				{
					string item;
					try
					{
						item = (string)base[this.tableTable0.GOODS_NAMEColumn];
					}
					catch (InvalidCastException invalidCastException)
					{
						throw new StrongTypingException("The value for column 'GOODS_NAME' in table 'Table0' is DBNull.", invalidCastException);
					}
					return item;
				}
				set
				{
					base[this.tableTable0.GOODS_NAMEColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public string PRICE_PROD
			{
				get
				{
					string item;
					try
					{
						item = (string)base[this.tableTable0.PRICE_PRODColumn];
					}
					catch (InvalidCastException invalidCastException)
					{
						throw new StrongTypingException("The value for column 'PRICE_PROD' in table 'Table0' is DBNull.", invalidCastException);
					}
					return item;
				}
				set
				{
					base[this.tableTable0.PRICE_PRODColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public string PRICE_SAL
			{
				get
				{
					string item;
					try
					{
						item = (string)base[this.tableTable0.PRICE_SALColumn];
					}
					catch (InvalidCastException invalidCastException)
					{
						throw new StrongTypingException("The value for column 'PRICE_SAL' in table 'Table0' is DBNull.", invalidCastException);
					}
					return item;
				}
				set
				{
					base[this.tableTable0.PRICE_SALColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public string PRICE_SUP
			{
				get
				{
					string item;
					try
					{
						item = (string)base[this.tableTable0.PRICE_SUPColumn];
					}
					catch (InvalidCastException invalidCastException)
					{
						throw new StrongTypingException("The value for column 'PRICE_SUP' in table 'Table0' is DBNull.", invalidCastException);
					}
					return item;
				}
				set
				{
					base[this.tableTable0.PRICE_SUPColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public string PRODUCER_NAME
			{
				get
				{
					string item;
					try
					{
						item = (string)base[this.tableTable0.PRODUCER_NAMEColumn];
					}
					catch (InvalidCastException invalidCastException)
					{
						throw new StrongTypingException("The value for column 'PRODUCER_NAME' in table 'Table0' is DBNull.", invalidCastException);
					}
					return item;
				}
				set
				{
					base[this.tableTable0.PRODUCER_NAMEColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public string REGISTER_PRICE
			{
				get
				{
					string item;
					try
					{
						item = (string)base[this.tableTable0.REGISTER_PRICEColumn];
					}
					catch (InvalidCastException invalidCastException)
					{
						throw new StrongTypingException("The value for column 'REGISTER_PRICE' in table 'Table0' is DBNull.", invalidCastException);
					}
					return item;
				}
				set
				{
					base[this.tableTable0.REGISTER_PRICEColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public string SERIES_NAME
			{
				get
				{
					string item;
					try
					{
						item = (string)base[this.tableTable0.SERIES_NAMEColumn];
					}
					catch (InvalidCastException invalidCastException)
					{
						throw new StrongTypingException("The value for column 'SERIES_NAME' in table 'Table0' is DBNull.", invalidCastException);
					}
					return item;
				}
				set
				{
					base[this.tableTable0.SERIES_NAMEColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			internal Table0Row(DataRowBuilder rb) : base(rb)
			{
				this.tableTable0 = (InvoiceProtocolZNVLS_DS.Table0DataTable)base.Table;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsADPRICE_SAL_SUMNull()
			{
				return base.IsNull(this.tableTable0.ADPRICE_SAL_SUMColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsADPRICE_SALNull()
			{
				return base.IsNull(this.tableTable0.ADPRICE_SALColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsADPRICE_SUP_SUMNull()
			{
				return base.IsNull(this.tableTable0.ADPRICE_SUP_SUMColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsADPRICE_SUPNull()
			{
				return base.IsNull(this.tableTable0.ADPRICE_SUPColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsGOODS_NAMENull()
			{
				return base.IsNull(this.tableTable0.GOODS_NAMEColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsPRICE_PRODNull()
			{
				return base.IsNull(this.tableTable0.PRICE_PRODColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsPRICE_SALNull()
			{
				return base.IsNull(this.tableTable0.PRICE_SALColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsPRICE_SUPNull()
			{
				return base.IsNull(this.tableTable0.PRICE_SUPColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsPRODUCER_NAMENull()
			{
				return base.IsNull(this.tableTable0.PRODUCER_NAMEColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsREGISTER_PRICENull()
			{
				return base.IsNull(this.tableTable0.REGISTER_PRICEColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsSERIES_NAMENull()
			{
				return base.IsNull(this.tableTable0.SERIES_NAMEColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetADPRICE_SAL_SUMNull()
			{
				base[this.tableTable0.ADPRICE_SAL_SUMColumn] = Convert.DBNull;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetADPRICE_SALNull()
			{
				base[this.tableTable0.ADPRICE_SALColumn] = Convert.DBNull;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetADPRICE_SUP_SUMNull()
			{
				base[this.tableTable0.ADPRICE_SUP_SUMColumn] = Convert.DBNull;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetADPRICE_SUPNull()
			{
				base[this.tableTable0.ADPRICE_SUPColumn] = Convert.DBNull;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetGOODS_NAMENull()
			{
				base[this.tableTable0.GOODS_NAMEColumn] = Convert.DBNull;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetPRICE_PRODNull()
			{
				base[this.tableTable0.PRICE_PRODColumn] = Convert.DBNull;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetPRICE_SALNull()
			{
				base[this.tableTable0.PRICE_SALColumn] = Convert.DBNull;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetPRICE_SUPNull()
			{
				base[this.tableTable0.PRICE_SUPColumn] = Convert.DBNull;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetPRODUCER_NAMENull()
			{
				base[this.tableTable0.PRODUCER_NAMEColumn] = Convert.DBNull;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetREGISTER_PRICENull()
			{
				base[this.tableTable0.REGISTER_PRICEColumn] = Convert.DBNull;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetSERIES_NAMENull()
			{
				base[this.tableTable0.SERIES_NAMEColumn] = Convert.DBNull;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public class Table0RowChangeEvent : EventArgs
		{
			private DataRowAction eventAction;

			private InvoiceProtocolZNVLS_DS.Table0Row eventRow;

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataRowAction Action
			{
				get
				{
					return this.eventAction;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public InvoiceProtocolZNVLS_DS.Table0Row Row
			{
				get
				{
					return this.eventRow;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public Table0RowChangeEvent(InvoiceProtocolZNVLS_DS.Table0Row row, DataRowAction action)
			{
				this.eventRow = row;
				this.eventAction = action;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public delegate void Table0RowChangeEventHandler(object sender, InvoiceProtocolZNVLS_DS.Table0RowChangeEvent e);

		[Serializable]
		[XmlSchemaProvider("GetTypedTableSchema")]
		public class Table1DataTable : TypedTableBase<InvoiceProtocolZNVLS_DS.Table1Row>
		{
			private DataColumn columnDIR;

			private DataColumn columnFR_NAME;

			private DataColumn columnTO_NAME;

			private InvoiceProtocolZNVLS_DS.Table1RowChangeEventHandler Table1RowChanged;

			private InvoiceProtocolZNVLS_DS.Table1RowChangeEventHandler Table1RowChanging;

			private InvoiceProtocolZNVLS_DS.Table1RowChangeEventHandler Table1RowDeleted;

			private InvoiceProtocolZNVLS_DS.Table1RowChangeEventHandler Table1RowDeleting;

			[Browsable(false)]
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public int Count
			{
				get
				{
					return base.Rows.Count;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn DIRColumn
			{
				get
				{
					return this.columnDIR;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn FR_NAMEColumn
			{
				get
				{
					return this.columnFR_NAME;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public InvoiceProtocolZNVLS_DS.Table1Row this[int index]
			{
				get
				{
					return (InvoiceProtocolZNVLS_DS.Table1Row)base.Rows[index];
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn TO_NAMEColumn
			{
				get
				{
					return this.columnTO_NAME;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public Table1DataTable()
			{
				base.TableName = "Table1";
				this.BeginInit();
				this.InitClass();
				this.EndInit();
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			internal Table1DataTable(DataTable table)
			{
				base.TableName = table.TableName;
				if (table.CaseSensitive != table.DataSet.CaseSensitive)
				{
					base.CaseSensitive = table.CaseSensitive;
				}
				if (table.Locale.ToString() != table.DataSet.Locale.ToString())
				{
					base.Locale = table.Locale;
				}
				if (table.Namespace != table.DataSet.Namespace)
				{
					base.Namespace = table.Namespace;
				}
				base.Prefix = table.Prefix;
				base.MinimumCapacity = table.MinimumCapacity;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected Table1DataTable(SerializationInfo info, StreamingContext context) : base(info, context)
			{
				this.InitVars();
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void AddTable1Row(InvoiceProtocolZNVLS_DS.Table1Row row)
			{
				base.Rows.Add(row);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public InvoiceProtocolZNVLS_DS.Table1Row AddTable1Row(string FR_NAME, string TO_NAME, string DIR)
			{
				InvoiceProtocolZNVLS_DS.Table1Row fRNAME = (InvoiceProtocolZNVLS_DS.Table1Row)base.NewRow();
				fRNAME.ItemArray = new object[] { FR_NAME, TO_NAME, DIR };
				base.Rows.Add(fRNAME);
				return fRNAME;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public override DataTable Clone()
			{
				InvoiceProtocolZNVLS_DS.Table1DataTable table1DataTable = (InvoiceProtocolZNVLS_DS.Table1DataTable)base.Clone();
				table1DataTable.InitVars();
				return table1DataTable;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override DataTable CreateInstance()
			{
				return new InvoiceProtocolZNVLS_DS.Table1DataTable();
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override Type GetRowType()
			{
				return typeof(InvoiceProtocolZNVLS_DS.Table1Row);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
			{
				XmlSchemaComplexType xmlSchemaComplexType;
				XmlSchemaComplexType xmlSchemaComplexType1 = new XmlSchemaComplexType();
				XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
				InvoiceProtocolZNVLS_DS invoiceProtocolZNVLSD = new InvoiceProtocolZNVLS_DS();
				XmlSchemaAny xmlSchemaAny = new XmlSchemaAny()
				{
					Namespace = "http://www.w3.org/2001/XMLSchema",
					MinOccurs = new decimal(0),
					MaxOccurs = new decimal(-1, -1, -1, false, 0),
					ProcessContents = XmlSchemaContentProcessing.Lax
				};
				xmlSchemaSequence.Items.Add(xmlSchemaAny);
				XmlSchemaAny xmlSchemaAny1 = new XmlSchemaAny()
				{
					Namespace = "urn:schemas-microsoft-com:xml-diffgram-v1",
					MinOccurs = new decimal(1),
					ProcessContents = XmlSchemaContentProcessing.Lax
				};
				xmlSchemaSequence.Items.Add(xmlSchemaAny1);
				XmlSchemaAttribute xmlSchemaAttribute = new XmlSchemaAttribute()
				{
					Name = "namespace",
					FixedValue = invoiceProtocolZNVLSD.Namespace
				};
				xmlSchemaComplexType1.Attributes.Add(xmlSchemaAttribute);
				XmlSchemaAttribute xmlSchemaAttribute1 = new XmlSchemaAttribute()
				{
					Name = "tableTypeName",
					FixedValue = "Table1DataTable"
				};
				xmlSchemaComplexType1.Attributes.Add(xmlSchemaAttribute1);
				xmlSchemaComplexType1.Particle = xmlSchemaSequence;
				XmlSchema schemaSerializable = invoiceProtocolZNVLSD.GetSchemaSerializable();
				if (xs.Contains(schemaSerializable.TargetNamespace))
				{
					MemoryStream memoryStream = new MemoryStream();
					MemoryStream memoryStream1 = new MemoryStream();
					try
					{
						XmlSchema current = null;
						schemaSerializable.Write(memoryStream);
						IEnumerator enumerator = xs.Schemas(schemaSerializable.TargetNamespace).GetEnumerator();
						while (enumerator.MoveNext())
						{
							current = (XmlSchema)enumerator.Current;
							memoryStream1.SetLength((long)0);
							current.Write(memoryStream1);
							if (memoryStream.Length == memoryStream1.Length)
							{
								memoryStream.Position = (long)0;
								memoryStream1.Position = (long)0;
								while (true)
								{
									if ((memoryStream.Position == memoryStream.Length ? true : memoryStream.ReadByte() != memoryStream1.ReadByte()))
									{
										break;
									}
								}
								if (memoryStream.Position == memoryStream.Length)
								{
									xmlSchemaComplexType = xmlSchemaComplexType1;
									return xmlSchemaComplexType;
								}
							}
						}
					}
					finally
					{
						if (memoryStream != null)
						{
							memoryStream.Close();
						}
						if (memoryStream1 != null)
						{
							memoryStream1.Close();
						}
					}
				}
				xs.Add(schemaSerializable);
				xmlSchemaComplexType = xmlSchemaComplexType1;
				return xmlSchemaComplexType;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			private void InitClass()
			{
				this.columnFR_NAME = new DataColumn("FR_NAME", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnFR_NAME);
				this.columnTO_NAME = new DataColumn("TO_NAME", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnTO_NAME);
				this.columnDIR = new DataColumn("DIR", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnDIR);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			internal void InitVars()
			{
				this.columnFR_NAME = base.Columns["FR_NAME"];
				this.columnTO_NAME = base.Columns["TO_NAME"];
				this.columnDIR = base.Columns["DIR"];
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
			{
				return new InvoiceProtocolZNVLS_DS.Table1Row(builder);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public InvoiceProtocolZNVLS_DS.Table1Row NewTable1Row()
			{
				return (InvoiceProtocolZNVLS_DS.Table1Row)base.NewRow();
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override void OnRowChanged(DataRowChangeEventArgs e)
			{
				base.OnRowChanged(e);
				if (this.Table1RowChanged != null)
				{
					this.Table1RowChanged(this, new InvoiceProtocolZNVLS_DS.Table1RowChangeEvent((InvoiceProtocolZNVLS_DS.Table1Row)e.Row, e.Action));
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override void OnRowChanging(DataRowChangeEventArgs e)
			{
				base.OnRowChanging(e);
				if (this.Table1RowChanging != null)
				{
					this.Table1RowChanging(this, new InvoiceProtocolZNVLS_DS.Table1RowChangeEvent((InvoiceProtocolZNVLS_DS.Table1Row)e.Row, e.Action));
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override void OnRowDeleted(DataRowChangeEventArgs e)
			{
				base.OnRowDeleted(e);
				if (this.Table1RowDeleted != null)
				{
					this.Table1RowDeleted(this, new InvoiceProtocolZNVLS_DS.Table1RowChangeEvent((InvoiceProtocolZNVLS_DS.Table1Row)e.Row, e.Action));
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override void OnRowDeleting(DataRowChangeEventArgs e)
			{
				base.OnRowDeleting(e);
				if (this.Table1RowDeleting != null)
				{
					this.Table1RowDeleting(this, new InvoiceProtocolZNVLS_DS.Table1RowChangeEvent((InvoiceProtocolZNVLS_DS.Table1Row)e.Row, e.Action));
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void RemoveTable1Row(InvoiceProtocolZNVLS_DS.Table1Row row)
			{
				base.Rows.Remove(row);
			}
		}

		public class Table1Row : DataRow
		{
			private InvoiceProtocolZNVLS_DS.Table1DataTable tableTable1;

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public string DIR
			{
				get
				{
					string item;
					try
					{
						item = (string)base[this.tableTable1.DIRColumn];
					}
					catch (InvalidCastException invalidCastException)
					{
						throw new StrongTypingException("The value for column 'DIR' in table 'Table1' is DBNull.", invalidCastException);
					}
					return item;
				}
				set
				{
					base[this.tableTable1.DIRColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public string FR_NAME
			{
				get
				{
					string item;
					try
					{
						item = (string)base[this.tableTable1.FR_NAMEColumn];
					}
					catch (InvalidCastException invalidCastException)
					{
						throw new StrongTypingException("The value for column 'FR_NAME' in table 'Table1' is DBNull.", invalidCastException);
					}
					return item;
				}
				set
				{
					base[this.tableTable1.FR_NAMEColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public string TO_NAME
			{
				get
				{
					string item;
					try
					{
						item = (string)base[this.tableTable1.TO_NAMEColumn];
					}
					catch (InvalidCastException invalidCastException)
					{
						throw new StrongTypingException("The value for column 'TO_NAME' in table 'Table1' is DBNull.", invalidCastException);
					}
					return item;
				}
				set
				{
					base[this.tableTable1.TO_NAMEColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			internal Table1Row(DataRowBuilder rb) : base(rb)
			{
				this.tableTable1 = (InvoiceProtocolZNVLS_DS.Table1DataTable)base.Table;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsDIRNull()
			{
				return base.IsNull(this.tableTable1.DIRColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsFR_NAMENull()
			{
				return base.IsNull(this.tableTable1.FR_NAMEColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsTO_NAMENull()
			{
				return base.IsNull(this.tableTable1.TO_NAMEColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetDIRNull()
			{
				base[this.tableTable1.DIRColumn] = Convert.DBNull;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetFR_NAMENull()
			{
				base[this.tableTable1.FR_NAMEColumn] = Convert.DBNull;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetTO_NAMENull()
			{
				base[this.tableTable1.TO_NAMEColumn] = Convert.DBNull;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public class Table1RowChangeEvent : EventArgs
		{
			private DataRowAction eventAction;

			private InvoiceProtocolZNVLS_DS.Table1Row eventRow;

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataRowAction Action
			{
				get
				{
					return this.eventAction;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public InvoiceProtocolZNVLS_DS.Table1Row Row
			{
				get
				{
					return this.eventRow;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public Table1RowChangeEvent(InvoiceProtocolZNVLS_DS.Table1Row row, DataRowAction action)
			{
				this.eventRow = row;
				this.eventAction = action;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public delegate void Table1RowChangeEventHandler(object sender, InvoiceProtocolZNVLS_DS.Table1RowChangeEvent e);
	}
}