﻿//------------------------------------------------------------------------------
// This is auto-generated code.
//------------------------------------------------------------------------------
// This code was generated by Entity Developer tool using EF Core template.
// Code is generated on: 2/6/2020 9:30:53 PM
//
// Changes to this file may cause incorrect behavior and will be lost if
// the code is regenerated.
//------------------------------------------------------------------------------

using Microsoft.EntityFrameworkCore.Infrastructure;
using System.Collections.Generic;

namespace EFarmerPkModelLibrary.Entities
{
    public partial class USER
    {

        public USER()
        {
            this.PostedAdvertisements = new List<ADVERTISEMENT>();
            this.InterestedAdvertisements = new List<BUYERADDSDIFFERENTADSTOFAV>();
            this.InterestedAgroItems = new List<BUYERSADDAGROITEMTOINTEREST>();
            this.FavoriteBuyers = new List<SELLERSFAVORITESBUYER>();
            this.FavoriteSellers = new List<SELLERSFAVORITESBUYER>();
            OnCreated();
        }
        private ILazyLoader lazyLoader;
        protected USER(ILazyLoader lazyLoader)
        {
            this.lazyLoader = lazyLoader;
        }
        public virtual long Id
        {
            get;
            set;
        }

        public virtual string FName
        {
            get;
            set;
        }

        public virtual string LName
        {
            get;
            set;
        }

        public virtual string CCompanyCode
        {
            get;
            set;
        }

        public virtual string CCountryCode
        {
            get;
            set;
        }

        public virtual string CPhone
        {
            get;
            set;
        }

        public virtual string Address
        {
            get;
            set;
        }

        public virtual decimal? GLat
        {
            get;
            set;
        }

        public virtual decimal? GLng
        {
            get;
            set;
        }

        public virtual bool BuyerFlag
        {
            get;
            set;
        }

        public virtual bool SellerFlag
        {
            get;
            set;
        }

        public virtual IList<ADVERTISEMENT> PostedAdvertisements
        {
            get;
            set;
        }

        public virtual IList<BUYERADDSDIFFERENTADSTOFAV> InterestedAdvertisements
        {
            get;
            set;
        }

        public virtual IList<BUYERSADDAGROITEMTOINTEREST> InterestedAgroItems
        {
            get;
            set;
        }

        public virtual IList<SELLERSFAVORITESBUYER> FavoriteBuyers
        {
            get;
            set;
        }

        public virtual IList<SELLERSFAVORITESBUYER> FavoriteSellers
        {
            get;
            set;
        }

        public virtual CITY City
        {
            get; set;
        }

        #region Extensibility Method Definitions

        partial void OnCreated();

        #endregion
    }

}
