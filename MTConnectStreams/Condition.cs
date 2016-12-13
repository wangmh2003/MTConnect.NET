﻿// Copyright (c) 2016 Feenux LLC, All Rights Reserved.

// This file is subject to the terms and conditions defined in
// file 'LICENSE.txt', which is part of this source code package.

using System.Xml.Serialization;

namespace MTConnect.MTConnectStreams
{
    /// <summary>
    /// An abstract XML Element. Replaced in the XML document by type(s) of Condition type Data Elements representing CONDITION category data items defined for a Device in the Device Information Model.
    /// There can be multiple types of Condition type XML Elements in a Condition container.
    /// </summary>
    public class Condition : DataItem
    {
        public Condition()
        {
            Category = DataItemCategory.CONDITION;
        }

        /// <summary>
        /// Value of the Condition (Normal, Warning, or Fault)
        /// </summary>
        [XmlIgnore]
        public ConditionValue ConditionValue { get; set; }

        [XmlAttribute("type")]
        public new string Type { get; set; }

        /// <summary>
        /// The native code (usually an alpha-numeric value) generated by the controller of a piece of equipment providing a reference identifier for a condition state or alarm.
        /// This is the same information an operator or maintenance personnel would see as a reference code designating a specific type of Condition when viewed at the piece of equipment.Usually this reference code is used to point to a more detailed description of the Condition.
        /// </summary>
        [XmlAttribute("nativeCode")]
        public string NativeCode { get; set; }

        /// <summary>
        /// If the data source assigns a severity level to a Condition, nativeSeverity is used to report that severity information to a client software application.
        /// </summary>
        [XmlAttribute("nativeSeverity")]
        public string NativeSeverity { get; set; }

        /// <summary>
        /// Qualifies the Condition and adds context or additional clarification.
        /// This optional attribute can be used to convey information such as HIGH or LOW type Warning and Fault condition to indicate differing types of condition states
        /// </summary>
        [XmlAttribute("qualifier")]
        public string Qualifier { get; set; }

        /// <summary>
        /// The type of statistical calculation specified for the DataItem defined in the Device Information Model that this Condition element represents.
        /// </summary>
        [XmlAttribute("statistic")]
        public string Statistic { get; set; }
    }
}