﻿/*	
 * 	
 *  This file is part of libfintx.
 *  
 *  Copyright (c) 2016 - 2018 Torsten Klinger
 * 	E-Mail: torsten.klinger@googlemail.com
 * 	
 * 	libfintx is free software; you can redistribute it and/or
 *	modify it under the terms of the GNU Lesser General Public
 * 	License as published by the Free Software Foundation; either
 * 	version 2.1 of the License, or (at your option) any later version.
 *	
 * 	libfintx is distributed in the hope that it will be useful,
 * 	but WITHOUT ANY WARRANTY; without even the implied warranty of
 * 	MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the GNU
 * 	Lesser General Public License for more details.
 *	
 * 	You should have received a copy of the GNU Lesser General Public
 * 	License along with libfintx; if not, write to the Free Software
 * 	Foundation, Inc., 51 Franklin Street, Fifth Floor, Boston, MA 02110-1301 USA
 * 	
 */

/*
 *
 *	Based on Timotheus Pokorra's C# implementation of OpenPetraPlugin_BankimportCAMT
 *	available at https://github.com/SolidCharity/OpenPetraPlugin_BankimportCAMT/blob/master/Client/ParseCAMT.cs
 *
 */

using System;

namespace libfintx
{
    /// todoComment
    public class TTransaction
    {
        /// todoComment
        public DateTime valueDate;

        /// todoComment
        public DateTime inputDate;

        /// todoComment
        public decimal amount;

        /// todoComment
        public string text;

        /// todoComment
        public string typecode;

        /// todoComment
        public string description;

        /// <summary>
        /// BIC of the counterpart
        /// </summary>
        public string bankCode;

        /// <summary>
        /// IBAN of the counterpart
        /// </summary>
        public string accountCode;

        /// <summary>
        /// Name of the counterpart
        /// </summary>
        public string partnerName;

        public string endToEndId;

        public string mndtId;
        
        /// <summary>
        /// Unique Identifier
        /// </summary>
        public string id;

        public string pmtInfId;

        public string msgId;
    }
}
