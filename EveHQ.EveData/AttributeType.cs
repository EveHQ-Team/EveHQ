﻿// ==============================================================================
// 
// EveHQ - An Eve-Online™ character assistance application
// Copyright © 2005-2015  EveHQ Development Team
//   
// This file is part of EveHQ.
//  
// The source code for EveHQ is free and you may redistribute 
// it and/or modify it under the terms of the MIT License. 
// 
// Refer to the NOTICES file in the root folder of EVEHQ source
// project for details of 3rd party components that are covered
// under their own, separate licenses.
// 
// EveHQ is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the MIT 
// license below for details.
// 
// ------------------------------------------------------------------------------
// 
// The MIT License (MIT)
// 
// Copyright © 2005-2015  EveHQ Development Team
// 
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
// 
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
// THE SOFTWARE.
// 
// ==============================================================================

using System;
using ProtoBuf;

namespace EveHQ.EveData
{
    /// <summary>
    ///     Defines an Eve attribute type.
    /// </summary>
    [ProtoContract, Serializable]
    public class AttributeType
    {
        /// <summary>
        ///     Gets or sets the attribute ID.
        /// </summary>
        [ProtoMember(1)]
        public int AttributeId { get; set; }

        /// <summary>
        ///     Gets or sets the attribute name.
        /// </summary>
        [ProtoMember(2)]
        public string AttributeName { get; set; }

        /// <summary>
        ///     Gets or sets the display name of the attribute.
        /// </summary>
        [ProtoMember(3)]
        public string DisplayName { get; set; }

        /// <summary>
        ///     Gets or sets the unit id of the attribute.
        /// </summary>
        [ProtoMember(4)]
        public int UnitId { get; set; }

        /// <summary>
        ///     Gets or sets the category id of the attribute.
        /// </summary>
        [ProtoMember(5)]
        public int CategoryId { get; set; }
    }
}