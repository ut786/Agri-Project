﻿//------------------------------------------------------------------------------
// This is auto-generated code.
//------------------------------------------------------------------------------
// This code was generated by Entity Developer tool using EF Core template.
// Code is generated on: 2/6/2020 9:30:53 PM
//
// Changes to this file may cause incorrect behavior and will be lost if
// the code is regenerated.
//------------------------------------------------------------------------------

using System;
using System.Data;
using System.ComponentModel;
using System.Linq;
using System.Linq.Expressions;
using System.Data.Common;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Infrastructure;

namespace EFarmerPkModelLibrary.Entities
{
    public partial class AGROITEM {

        private ILazyLoader lazyLoader;
        protected AGROITEM(ILazyLoader lazyLoader)
        {
            this.lazyLoader = lazyLoader;
        }
        public AGROITEM()
        {
            this.ADVERTISEMENTs_ItemId = new List<ADVERTISEMENT>();
            this.BUYERSADDAGROITEMTOINTERESTs_ItemId = new List<BUYERSADDAGROITEMTOINTEREST>();
            OnCreated();
        }

        public virtual int Id
        {
            get;
            set;
        }

        public virtual string Name
        {
            get;
            set;
        }

        public virtual string Uname
        {
            get;
            set;
        }

        public virtual string WeightScale
        {
            get;
            set;
        }

        public virtual string UWeightScale
        {
            get;
            set;
        }

        public virtual IList<ADVERTISEMENT> ADVERTISEMENTs_ItemId
        {
            get;
            set;
        }

        public virtual CATEGORY CATEGORY
        {
            get;
            set;
        }

        public virtual IList<BUYERSADDAGROITEMTOINTEREST> BUYERSADDAGROITEMTOINTERESTs_ItemId
        {
            get;
            set;
        }

        #region Extensibility Method Definitions

        partial void OnCreated();

        #endregion
    }

}
