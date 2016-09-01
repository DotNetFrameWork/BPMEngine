﻿using Org.Reddragonit.BpmEngine.Attributes;
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace Org.Reddragonit.BpmEngine.Elements.Processes
{
    [XMLTag("bpmn","laneSet")]
    internal class LaneSet : AParentElement
    {
        public LaneSet(XmlElement elem)
            : base(elem){}
    }
}