using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace PikkaTech.Fundus.FolderManager.WinForms
{
    public class Configuration
    {
        public string DefaultSolutionsFolderName    {get;set;} = "Solutions";
        public string IconFolder                    {get;set;} = @"C:\pikkatech.eu\Resources\Images\ICO";
        public string PikkaTechAppDataFolder        {get;set;} = "PikkaTech";
        public string FundusDataFolder              {get;set;} = "Fundus";
        public string FolderManagerDataFolder       {get;set;} = "DataManager";
        public string RemoveJunkFileName            {get;set;} = "remove_junk.bat";

        public XElement ToXElement()
        {
            XElement x = new XElement("Configuration");

            x.Add(new XElement("DefaultSolutionsFolderName",    this.DefaultSolutionsFolderName));
            x.Add(new XElement("IconFolder",                    this.IconFolder));
            x.Add(new XElement("PikkaTechAppDataFolder",        this.PikkaTechAppDataFolder));
            x.Add(new XElement("FundusDataFolder",              this.FundusDataFolder));
            x.Add(new XElement("FolderManagerDataFolder",       this.FolderManagerDataFolder));
            x.Add(new XElement("RemoveJunkFileName",            this.RemoveJunkFileName));

            return x;
        }

        public static Configuration FromXElement(XElement x)
        {
            Configuration config = new Configuration();

            config.DefaultSolutionsFolderName   = x.Element("DefaultSolutionsFolderName").Value;
            config.IconFolder                   = x.Element("IconFolder").Value;
            config.PikkaTechAppDataFolder       = x.Element("PikkaTechAppDataFolder").Value;
            config.FundusDataFolder             = x.Element("FundusDataFolder").Value;
            config.FolderManagerDataFolder      = x.Element("FolderManagerDataFolder").Value;
            config.RemoveJunkFileName           = x.Element("RemoveJunkFileName").Value;

            return config;
        }
    }
}
