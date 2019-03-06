﻿/*
 * Copyright 2015-2019 Mohawk College of Applied Arts and Technology
 * Copyright 2019-2019 SanteSuite Contributors (See NOTICE)
 * 
 * Licensed under the Apache License, Version 2.0 (the "License"); you 
 * may not use this file except in compliance with the License. You may 
 * obtain a copy of the License at 
 * 
 * http://www.apache.org/licenses/LICENSE-2.0 
 * 
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS, WITHOUT
 * WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied. See the 
 * License for the specific language governing permissions and limitations under 
 * the License.
 * 
 * User: justi
 * Date: 2019-1-12
 */
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace SanteDB.ReportR.Model
{
    /// <summary>
    /// Identifies a report
    /// </summary>
    [XmlType(nameof(ReportDescriptionDefinition), Namespace = "http://santedb.org/mobile/reporting")]
    [JsonObject(nameof(ReportDescriptionDefinition))]
    public class ReportDescriptionDefinition
    {

        /// <summary>
        /// Gets or sets the name
        /// </summary>
        [XmlAttribute("id"), JsonProperty("id")]
        public Guid Id { get; set; }

        /// <summary>
        /// Gets or sets the name
        /// </summary>
        [XmlAttribute("name"), JsonProperty("name")]
        public String Name { get; set; }

        /// <summary>
        /// Gets or sets the name
        /// </summary>
        [XmlAttribute("title"), JsonProperty("title")]
        public String Title { get; set; }

        /// <summary>
        /// Aurhors
        /// </summary>
        [XmlElement("author"), JsonProperty("authors")]
        public List<string> Authors { get; set; }

        /// <summary>
        /// Description
        /// </summary>
        [XmlElement("description"), JsonProperty("description")]
        public string Description { get; set; }
    }
}