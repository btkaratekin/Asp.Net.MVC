using OgrIsler.Business.Abstract;
using OgrIsler.Business.Concrete;
using OgrIsler.DataAccess.Concrete.EntityFrameWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OgrIsler.ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            IOgrBilgiService _OgrBilgiService = new OgrBilgiService(new OgrBilgiDal());

            foreach (var ogrBilgi in _OgrBilgiService.GetList())
            {
                Console.WriteLine("Öğrenci No:{0}\tAdı Soyadı:{1}\tCinsiyeti:{2}\tDoğum Tarihi:{3}",ogrBilgi.OgrNo,ogrBilgi.Adi+" "+ogrBilgi.Soyadi,ogrBilgi.Cinsiyet ? "Kız":"Erkek",ogrBilgi.Dtarih.ToShortDateString());
            }
            Console.ReadLine();
        }
    }
}
