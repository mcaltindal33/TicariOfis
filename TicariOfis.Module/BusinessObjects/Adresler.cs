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
    //[ImageName("BO_Contact")]
    //[DefaultProperty("DisplayMemberNameForLookupEditorsOfThisType")]
    //[DefaultListViewOptions(MasterDetailMode.ListViewOnly, false, NewItemRowPosition.None)]
    //[Persistent("DatabaseTableName")]
    // Specify more UI options using a declarative approach (https://documentation.devexpress.com/#eXpressAppFramework/CustomDocument112701).
    public class Adresler : XPObject
    {
        string _Telefon;
        AdresTurleri _TurID;
        Ulkeler _UlkeID;
        Sehirler _SehirID;
        string _Ilce;
        string _Semt;
        string _BinaNo;
        string _Bina;
        string _CdSokak;
        string _Mahalle;
        public const string _AdresBirlestirme = "Concat([Mahalle],' ',[CdSokak],' ',[Bina],' ',[BinaNo],' ',[Semt],' ',[Ilce],' ',[SehirID.Tanim],' ',[UlkeID.Tanim])";
        public Adresler(Session session)
            : base(session)
        {
        }
        public override void AfterConstruction()
        {
            base.AfterConstruction();
        }

        [XafDisplayName("Adresi Türü"), Index(0)]
        public AdresTurleri TurID
        {
            get => _TurID;
            set => SetPropertyValue(nameof(TurID), ref _TurID, value);
        }

        [Size(SizeAttribute.DefaultStringMappingFieldSize)]
        [XafDisplayName("Mahalle"), Index(1)]
        [VisibleInListView(false)]
        public string Mahalle
        {
            get => _Mahalle;
            set => SetPropertyValue(nameof(Mahalle), ref _Mahalle, value);
        }

        [Size(SizeAttribute.DefaultStringMappingFieldSize)]
        [XafDisplayName("Cadde Sokak"), Index(2)]
        [VisibleInListView(false)]
        public string CdSokak
        {
            get => _CdSokak;
            set => SetPropertyValue(nameof(CdSokak), ref _CdSokak, value);
        }

        [Size(SizeAttribute.DefaultStringMappingFieldSize)]
        [XafDisplayName("Bina"), Index(3)]
        [VisibleInListView(false)]
        public string Bina
        {
            get => _Bina;
            set => SetPropertyValue(nameof(Bina), ref _Bina, value);
        }

        [Size(SizeAttribute.DefaultStringMappingFieldSize)]
        [XafDisplayName("Bina No"), Index(4)]
        [VisibleInListView(false)]
        public string BinaNo
        {
            get => _BinaNo;
            set => SetPropertyValue(nameof(BinaNo), ref _BinaNo, value);
        }

        [Size(SizeAttribute.DefaultStringMappingFieldSize)]
        [XafDisplayName("Semt"), Index(5)]
        [VisibleInListView(false)]
        public string Semt
        {
            get => _Semt;
            set => SetPropertyValue(nameof(Semt), ref _Semt, value);
        }

        [Size(SizeAttribute.DefaultStringMappingFieldSize)]
        [XafDisplayName("İlçe"), Index(6)]
        [VisibleInListView(false)]
        public string Ilce
        {
            get => _Ilce;
            set => SetPropertyValue(nameof(Ilce), ref _Ilce, value);
        }
        [XafDisplayName("Şehir"), Index(7)]
        [VisibleInListView(false)]
        public Sehirler SehirID
        {
            get => _SehirID;
            set => SetPropertyValue(nameof(SehirID), ref _SehirID, value);
        }

        [XafDisplayName("Ülke"), Index(8)]
        [VisibleInListView(false)]
        public Ulkeler UlkeID
        {
            get => _UlkeID;
            set => SetPropertyValue(nameof(UlkeID), ref _UlkeID, value);
        }
        
        [Size(SizeAttribute.DefaultStringMappingFieldSize)]
        [XafDisplayName("Telefon"), Index(9)]
        public string Telefon
        {
            get => _Telefon;
            set => SetPropertyValue(nameof(Telefon), ref _Telefon, value);
        }

        [PersistentAlias(_AdresBirlestirme)]
        [XafDisplayName("Adres"), Index(0)]
        [VisibleInDetailView(false)]
        public string Tanim => (string)EvaluateAlias(nameof(Tanim));
    }
}