using ePlus.CommonEx.Reporting;
using ePlus.MetaData.Client;
using ePlus.MetaData.Core;
using System;
using System.Data.SqlClient;
using System.IO;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Xml;

namespace F77YInvoiceProtocolZNVLS2019
{
	public class InvoiceRating : AbstractDocumentReport, IExternalDocumentPrintForm, IExternalReport, IDocumentPrintForm
	{
		private const string CACHE_FOLDER = "Cache";

		private string connectionString;

		private string folderPath;

		public string GroupName
		{
			get
			{
				return string.Empty;
			}
		}

		public string PluginCode
		{
			get
			{
				return "INVOICE";
			}
		}

		public string ReportName
		{
			get
			{
				return "Протокол согласования цен ЖНВЛП Здоровье";
			}
		}

		public InvoiceRating()
		{
		}

		private void CreateStoredProc(string connectionString, string ResourceName)
		{
			StreamReader streamReader = new StreamReader(base.GetType().Assembly.GetManifestResourceStream(ResourceName), Encoding.GetEncoding(1251));
			try
			{
				string[] strArrays = Regex.Split(streamReader.ReadToEnd(), "^GO.*$", RegexOptions.Multiline);
				SqlCommand sqlCommand = null;
				string[] strArrays1 = strArrays;
				for (int i = 0; i < (int)strArrays1.Length; i++)
				{
					string str = strArrays1[i];
					if (str != string.Empty)
					{
						SqlConnection sqlConnection = new SqlConnection(connectionString);
						try
						{
							sqlCommand = new SqlCommand(str, sqlConnection);
							sqlConnection.Open();
							sqlCommand.ExecuteNonQuery();
						}
						finally
						{
							if (sqlConnection != null)
							{
								((IDisposable)sqlConnection).Dispose();
							}
						}
					}
				}
			}
			finally
			{
				if (streamReader != null)
				{
					((IDisposable)streamReader).Dispose();
				}
			}
		}

		private void CreateStoredProcs()
		{
			string[] manifestResourceNames = base.GetType().Assembly.GetManifestResourceNames();
			for (int i = 0; i < (int)manifestResourceNames.Length; i++)
			{
				string str = manifestResourceNames[i];
				if (str.EndsWith(".sql"))
				{
					this.CreateStoredProc(this.connectionString, str);
				}
			}
		}

		public void Execute(string connectionString, string folderPath)
		{
			this.connectionString = connectionString;
			this.folderPath = folderPath;
			this.CreateStoredProcs();
			this.ExtractReport();
		}

		private void ExtractReport()
		{
			string str = Path.Combine(this.folderPath, "Cache");
			if (!Directory.Exists(str))
			{
				Directory.CreateDirectory(str);
			}
			StreamReader streamReader = new StreamReader(base.GetType().Assembly.GetManifestResourceStream("F77YInvoiceProtocolZNVLS2019.F77YInvoiceProtocolZNVLS2019.rdlc"));
			try
			{
				StreamWriter streamWriter = new StreamWriter(Path.Combine(str, "F77YInvoiceProtocolZNVLS2019.rdlc"));
				try
				{
					streamWriter.Write(streamReader.ReadToEnd());
				}
				finally
				{
					if (streamWriter != null)
					{
						((IDisposable)streamWriter).Dispose();
					}
				}
			}
			finally
			{
				if (streamReader != null)
				{
					((IDisposable)streamReader).Dispose();
				}
			}
		}

		public override IReportForm GetReportForm(DataRowItem dataRowItem)
		{
			XmlDocument xmlDocument = new XmlDocument();
			Utils.AddNode(Utils.AddNode(xmlDocument, "XML"), "ID_GLOBAL", dataRowItem.Guid);
			ReportFormNew reportFormNew = new ReportFormNew();
			reportFormNew.ReportFormName = this.ReportName;
			reportFormNew.ReportPath = Path.Combine(Path.Combine(this.folderPath, "Cache"), "F77YInvoiceProtocolZNVLS2019.rdlc");
			reportFormNew.LoadData("REPEX_INVOICE_PROTOCOL_ZNVLS", xmlDocument.InnerXml);
			reportFormNew.BindDataSource("InvoiceProtocolZNVLS_DS_Table0", 1);
			reportFormNew.BindDataSource("InvoiceProtocolZNVLS_DS_Table1", 0);
			return reportFormNew;
		}
	}
}