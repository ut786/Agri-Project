﻿//------------------------------------------------------------------------------
// This is auto-generated code.
//------------------------------------------------------------------------------
// This code was generated by Entity Developer tool using EF Core template.
// Code is generated on: 2/6/2020 9:33:50 PM
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
    public partial class CITY {

        private ILazyLoader lazyLoader;
        protected CITY(ILazyLoader lazyLoader)
        {
            this.lazyLoader = lazyLoader;
        }
        public CITY()
        {
            this.ADVERTISEMENTs_CityId = new List<ADVERTISEMENT>();
            this.Users = new List<USER>();
            OnCreated();
        }

        public virtual short Id
        {
            get;
            set;
        }

        public virtual string Name
        {
            get;
            set;
        }

        public virtual decimal GLat
        {
            get;
            set;
        }

        public virtual decimal GLng
        {
            get;
            set;
        }

        public virtual IList<ADVERTISEMENT> ADVERTISEMENTs_CityId
        {
            get;
            set;
        }

        public virtual IList<USER> Users
        {
            get;
            set;
        }

        #region Extensibility Method Definitions

        partial void OnCreated();

        #endregion
    }

}
