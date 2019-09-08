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
    [DefaultProperty(nameof(Adi))]
    //[DefaultListViewOptions(MasterDetailMode.ListViewOnly, false, NewItemRowPosition.None)]
    //[Persistent("DatabaseTableName")]
    // Specify more UI options using a declarative approach (https://documentation.devexpress.com/#eXpressAppFramework/CustomDocument112701).
    public class Stoklar : XPObject
    { // Inherit from a different class to provide a custom primary key, concurrency and deletion behavior, etc. (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument113146.aspx).
        public Stoklar(Session session)
            : base(session)
        {
        }
        public override void AfterConstruction()
        {
            base.AfterConstruction();
            
        }

        MediaDataObject _Resim;
        string _Barkod;
        string _Kodu;
        Kategoriler _KategoriID;
        VergiUygulama _SatisDahil;
        VergiUygulama _AlisDahil;
        VergiOranlari _SatisVergi;
        VergiOranlari _AlisVergi;
        Dovizler _SatisDoviz;
        double _SatisFiyati;
        Dovizler _AlisDoviz;
        double _AlisFiyati;
        Birimler _BirimID;
        StokTipi _Tipi;
        string _Adi;

        [Size(SizeAttribute.DefaultStringMappingFieldSize)]
        public string Adi
        {
            get => _Adi;
            set => SetPropertyValue(nameof(Adi), ref _Adi, value);
        }
        [Size(SizeAttribute.DefaultStringMappingFieldSize)]
        public string Kodu
        {
            get => _Kodu;
            set => SetPropertyValue(nameof(Kodu), ref _Kodu, value);
        }

        [Size(SizeAttribute.DefaultStringMappingFieldSize)]
        public string Barkod
        {
            get => _Barkod;
            set => SetPropertyValue(nameof(Barkod), ref _Barkod, value);
        }

        public StokTipi Tipi
        {
            get => _Tipi;
            set => SetPropertyValue(nameof(Tipi), ref _Tipi, value);
        }

        public Birimler BirimID
        {
            get => _BirimID;
            set => SetPropertyValue(nameof(BirimID), ref _BirimID, value);
        }

        public double AlisFiyati
        {
            get => _AlisFiyati;
            set => SetPropertyValue(nameof(AlisFiyati), ref _AlisFiyati, value);
        }

        public Dovizler AlisDoviz
        {
            get => _AlisDoviz;
            set => SetPropertyValue(nameof(AlisDoviz), ref _AlisDoviz, value);
        }

        public VergiOranlari AlisVergi
        {
            get => _AlisVergi;
            set => SetPropertyValue(nameof(AlisVergi), ref _AlisVergi, value);
        }

        public VergiUygulama AlisDahil
        {
            get => _AlisDahil;
            set => SetPropertyValue(nameof(AlisDahil), ref _AlisDahil, value);
        }

        public double SatisFiyati
        {
            get => _SatisFiyati;
            set => SetPropertyValue(nameof(SatisFiyati), ref _SatisFiyati, value);
        }

        public Dovizler SatisDoviz
        {
            get => _SatisDoviz;
            set => SetPropertyValue(nameof(SatisDoviz), ref _SatisDoviz, value);
        }


        public VergiOranlari SatisVergi
        {
            get => _SatisVergi;
            set => SetPropertyValue(nameof(SatisVergi), ref _SatisVergi, value);
        }

        public VergiUygulama SatisDahil
        {
            get => _SatisDahil;
            set => SetPropertyValue(nameof(SatisDahil), ref _SatisDahil, value);
        }

        [Association("Kategoriler-Stoklars")]
        public Kategoriler KategoriID
        {
            get => _KategoriID;
            set => SetPropertyValue(nameof(KategoriID), ref _KategoriID, value);
        }

        
        public MediaDataObject Resim
        {
            get => _Resim;
            set => SetPropertyValue(nameof(Resim), ref _Resim, value);
        }
    }
    public enum StokTipi
    {
        [XafDisplayName("Stoklu Ürünler")]
        Malzeme,
        [XafDisplayName("Stoksuz Ürünler (Hizmet/Danışmanlık)")]
        Hizmet
    }
    public enum VergiUygulama
    {
        [XafDisplayName("KDV Hariç")]
        Haric,
        [XafDisplayName("KDV Dahil")]
        Dahil,
    }
}