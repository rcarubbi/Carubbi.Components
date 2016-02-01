﻿using System.Configuration;

namespace Carubbi.Mainframe.Config
{
    /// <summary>
    /// Coleção de Seções de Configuração "Terminal"
    /// </summary>
    [ConfigurationCollection(typeof(MainframeConfigElement), AddItemName = "Terminal", CollectionType = ConfigurationElementCollectionType.BasicMap)]
    public class MainframeConfigCollection : ConfigurationElementCollection
    {
        
        public override ConfigurationElementCollectionType CollectionType
        {
            get { return ConfigurationElementCollectionType.BasicMap; }
        }

        protected override ConfigurationElement CreateNewElement()
        {
            return new MainframeConfigElement();
        }

        protected override object GetElementKey(ConfigurationElement element)
        {
            return ((MainframeConfigElement)element).Nome;
        }

        public MainframeConfigElement this[int index]
        {
            get { return (MainframeConfigElement)BaseGet(index); }
        }

        protected override string ElementName
        {
            get { return "Terminal"; }
        }
    }



}
