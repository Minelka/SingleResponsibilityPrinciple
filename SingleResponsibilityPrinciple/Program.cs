using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleResponsibilityPrinciple
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }

        //YANLIŞ KULLANIM

        //public class Urun 
        //{
        //    public int Id { get; set; }

        //    public string Ad { get; set; }

        //    public decimal Fiyat { get; set; }

        //    public void UrunEkle() 
        //    {
        //        //ürün ekleme  işlemleri
        //    }

        //    public void UrunSil() 

        //    {
        //        //ürün silme  işlemleri
        //    }

        //    public void UrunGuncelle() 
        //    {
        //        //ürün güncelleme  işlemleri
        //    }

        //    public void UrunRaporuOlustur() 
        //    {
        //        //ürün rapor oluşturma  işlemleri
        //    }

        //DOĞRU KULLANIM

        public class Urun

        {
            public int Id { get; set; }

            public string Ad { get; set; }

            public decimal Fiyat { get; set; }


            public class UrunYonetimi
            {
                public void UrunEkle()
                {
                    //ürün ekleme  işlemleri
                }

                public void UrunSil()

                {
                    //ürün silme  işlemleri
                }

                public void UrunGuncelle()
                {
                    //ürün güncelleme  işlemleri
                }

            }

            public class UrunRaporYonetimi
            {
                public void UrunRaporuOlustur()
                {
                    //ürün rapor oluşturma  işlemleri
                }

            }

            //Liskov Substitution Principle
            //hatalı örnek
            //public class Konaklama 
            //{
            //    public virtual void sabahkahvaltısı() { }

            //    public virtual void aksamyamegi() { }
            //}

            //public class oda : Konaklama 
            //{
            //    public virtual void sabahkahvaltısı() { }

            //    public virtual void aksamyamegi() { throw new Exception(); } //Normal odada yok

            //}


            //public class suıtoda : Konaklama
            //{
            //    public virtual void sabahkahvaltısı() { }

            //    public virtual void aksamyamegi() {} 

            //}

            //doğru örnek
            public abstract class konaklama
            {
                public abstract void sabahkahvaltısı();
            }

            public class oda : konaklama
            {
                public override void sabahkahvaltısı() { }


            }

            public class suitoda : konaklama
            {
                public override void sabahkahvaltısı() { }

                public virtual void aksamyemegi() { }
            }

            // Interface Segregation Principle (ISP)
            //hatalı örnek
            public interface ITicaretServisi

            {

                void SiparisIsle();

                void MusteriSikayetYonet();

                void UrunStokGuncelle();

            }

            public class MusteriServisi : ITicaretServisi

            {

                public void MusteriSikayetYonet()

                {

                    throw new NotImplementedException();

                }

                public void SiparisIsle()

                {

                    throw new NotImplementedException();

                }

                public void UrunStokGuncelle()

                {

                    throw new NotImplementedException();

                }

            }

            //doğru örnek
            public interface IsipparisIslemeServisi
            {
                void SiparisIsle();
            }
            public interface ImusteriHizmetleri
            {
                void MusteriSikayetYonet();
            }

            public interface IurunYonetimServisi
            {
                void UrunStokGuncelle();
            }


            public class musterihizmetleri : ImusteriHizmetleri
            {
                public void MusteriSikayetYonet()
                {
                    throw new Exception();
                }
            }

            static void Main(string[] args)
            {
                IOdemeServisi nakitOdeme = new PayPalOdemeServisi();
                //  IOdemeServisi nakitOdeme = new NakitOdemeServisi();
                OdemeIslemleri odemeIslemleri = new OdemeIslemleri(nakitOdeme);
                odemeIslemleri.OdemeYap(12312312);

                Console.ReadKey();
            }
        }

        //yanlış örnek 
        #region MyRegion
        //public class PaypalOdemeServisi
        //{
        //    public void OdemeYap()
        //    {
        //    }
        //}
        //public class OdemeIslemleri
        //{
        //    private readonly PaypalOdemeServisi _paypalOdemeServisi;
        //    public OdemeIslemleri()
        //    {
        //        _paypalOdemeServisi = new PaypalOdemeServisi();//doğrudan bir bağımlılık
        //    }

        //    public void OdemeYap()
        //    {
        //        _paypalOdemeServisi.OdemeYap();
        //    }
        //} 
        #endregion

        //doğru kullanım 
        public interface IOdemeServisi
        {
            void OdemeYap(decimal tutar);
        }
        public class PayPalOdemeServisi : IOdemeServisi
        {
            public void OdemeYap(decimal tutar)
            {
                Console.WriteLine("paypal odemesi");
            }
        }
        public class NakitOdemeServisi : IOdemeServisi
        {
            public void OdemeYap(decimal tutar)
            {
                Console.WriteLine("nakit odeme");
            }
        }
        public class OdemeIslemleri
        {
            private readonly IOdemeServisi _odemeServisi;

            public OdemeIslemleri(IOdemeServisi odemeServisi)
            {
                _odemeServisi = odemeServisi;
            }
            public void OdemeYap(decimal tutar)
            {
                _odemeServisi.OdemeYap(tutar);
            }
        }
    }
}


