﻿/*	
	Crash - Controlling application for Burn
    Copyright (C) 2016  Norwegian Radiation Protection Authority

    This program is free software: you can redistribute it and/or modify
    it under the terms of the GNU General Public License as published by
    the Free Software Foundation, either version 3 of the License, or
    (at your option) any later version.

    This program is distributed in the hope that it will be useful,
    but WITHOUT ANY WARRANTY; without even the implied warranty of
    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
    GNU General Public License for more details.

    You should have received a copy of the GNU General Public License
    along with this program.  If not, see <http://www.gnu.org/licenses/>.
*/
// Authors: Dag robole,

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.Xml.Serialization;

namespace crash
{
    [Serializable()]
    public class Detector
    {
        public string Name;
        public string SerialNumber;
        public string Type;
        public int MaxChannels;
    }

    [Serializable()]
    public class Settings
    {        
        public List<Detector> Detectors = new List<Detector>();
        public string DefaultDetector;
        public string DefaultDetectorType;
        public int DefaultNrChannels;
        public string SessionDirectory;
        public string LastIP;
        public string LastPort;
    }    
}
