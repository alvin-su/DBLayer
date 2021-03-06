﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using DBLayer.Persistence.Configuration.AtomSource;

namespace DBLayer.Persistence.Configuration
{
    public class AtomSourceSection : ConfigurationSection
    {
        public const string SectionName = "atom/datasource";

        private const string xmlnsXmlKey = "xmlns";

        [ConfigurationProperty(xmlnsXmlKey, IsRequired = false, DefaultValue = "urn:datasource")]
        public string Xmlns
        {
            get { return (string)this[xmlnsXmlKey]; }
            set { this[xmlnsXmlKey] = value; }
        }


        [ConfigurationProperty(AtomSourceElementCollection.CollectionXmlName, IsRequired = true)]
        public AtomSourceElementCollection AtomDataSources
        {
            get { return this[AtomSourceElementCollection.CollectionXmlName] as AtomSourceElementCollection; }
            set
            {
                this[AtomSourceElementCollection.CollectionXmlName] = value;
            }
        }
    }
}
