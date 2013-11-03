﻿using System;
using System.Collections.Generic;
using System.Xml.Linq;
using VKSharp.VK.Entities;
using VKSharp.VK.Interfaces;

namespace VKSharp.VK.EntityParsers {
    public class PrivacyParser:IVKEntityParser<Privacy> {
        private static readonly Lazy<PrivacyParser> Lazy = new Lazy<PrivacyParser>( () => new PrivacyParser() );
        public static PrivacyParser Instanse {
            get {
                return Lazy.Value;
            }
        }

        private PrivacyParser() {}

        public Privacy ParseFromXml(XNode node) {
            throw new NotImplementedException();
        }

        public Privacy[] ParseAllFromXml(IEnumerable<XNode> nodes) {
            throw new NotImplementedException();
        }
    }
}
