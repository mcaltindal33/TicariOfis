using System;
using System.Linq;
using System.Text;
using DevExpress.Xpo;
using DevExpress.ExpressApp;
using System.ComponentModel;
using DevExpress.ExpressApp.DC;
using DevExpress.Data.Filtering;
using DevExpress.Persistent.Base;
using System.Collections.Generic;
using DevExpress.ExpressApp.Model;
using DevExpress.Persistent.BaseImpl;
using DevExpress.Persistent.Validation;

namespace TicariOfis.Module.BusinessObjects
{
    [DefaultClassOptions]
    [DefaultProperty(nameof(Tanim))]
    public class AdresTurleri : XPObject
    { 
        public AdresTurleri(Session session)
            : base(session)
        {
        }
        public override void AfterConstruction()
        {
            base.AfterConstruction();
        }

        string _Aciklama;
        string _Tanim;

        [Size(SizeAttribute.DefaultStringMappingFieldSize)]
        public string Tanim
        {
            get => _Tanim;
            set => SetPropertyValue(nameof(Tanim), ref _Tanim, value);
        }
        
        [Size(300)]
        [ModelDefault("RowCount","0")]
        [ImmediatePostData]
        public string Aciklama
        {
            get => _Aciklama;
            set => SetPropertyValue(nameof(Aciklama), ref _Aciklama, value);
        }
    }
}