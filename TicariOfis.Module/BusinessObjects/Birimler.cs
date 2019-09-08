using DevExpress.Persistent.Base;
using DevExpress.Xpo;
using System;
using System.ComponentModel;
using System.Linq;

namespace TicariOfis.Module.BusinessObjects
{
    [DefaultClassOptions]
    [DefaultProperty("Adi")]
    public class Birimler : XPObject
    { 
        public Birimler(Session session)
            : base(session)
        {
        }
        public override void AfterConstruction()
        {
            base.AfterConstruction();
            // Place your initialization code here (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument112834.aspx).
        }

        string _Aciklama;
        string _Adi;

        [Size(SizeAttribute.DefaultStringMappingFieldSize)]
        public string Adi
        {
            get => _Adi;
            set => SetPropertyValue(nameof(Adi), ref _Adi, value);
        }

        [Size(SizeAttribute.DefaultStringMappingFieldSize)]
        public string Aciklama
        {
            get => _Aciklama;
            set => SetPropertyValue(nameof(Aciklama), ref _Aciklama, value);
        }
    }
}