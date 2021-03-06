﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using DBLayer.Persistence.Configuration.Base;

namespace DBLayer.Persistence.Configuration.Property
{
    [ConfigurationCollection(typeof(AddElement),AddItemName=AddElement.ElementXmlName)]
    public class AddElementCollection : ConfigurationElementCollection<string, AddElement>
    {
        #region 基本配置
        public const string CollectionXmlName = "settings";

        /// <summary>
        /// 获得 <see cref="T:System.Configuration.ConfigurationElementCollection"/>类型.
        /// </summary>
        /// <returns>
        ///  <see cref="T:System.Configuration.ConfigurationElementCollectionType"/> 类型集合
        /// </returns>
        public override ConfigurationElementCollectionType CollectionType
        {
            get { return ConfigurationElementCollectionType.AddRemoveClearMap; }
        }

        /// <summary>
        /// 获取用于识别这个元素在配置文件中的集合在派生类中重写时名称。
        /// </summary>
        /// <returns>
        /// 集合的名称，否则，一个空字符串。默认是一个空字符串。
        /// </returns>
        protected override string ElementName
        {
            get { return CollectionXmlName; }
        }


        protected override string GetElementKey(AddElement element)
        {
            return element.ToString();
        }


        
        #endregion
    }
}
