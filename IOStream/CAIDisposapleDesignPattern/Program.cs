using System;
using System.Net.Http;

namespace CAIDisposapleDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1) not recommnded
            //CurrencyService currencyService = new CurrencyService();
            //var result = currencyService.GetCurrencies();
            //currencyService.Dispose();
            //Console.WriteLine(result);

            // 2) recommended
            //CurrencyService currencyService = new CurrencyService();

            //try
            //{
            //    var result = currencyService.GetCurrencies();
            //    Console.WriteLine(result);
            //}
            //catch (Exception)
            //{

            //    Console.WriteLine("error");
            //}
            //finally
            //{
            //    currencyService.Dispose();
            //}
            //Console.ReadLine();

            // 3) more recommended
            using (CurrencyService currencyService = new CurrencyService())
            {
                var result = currencyService.GetCurrencies();
                Console.WriteLine(result);
                Console.ReadLine();
            }
        }
    }

    public class CurrencyService : IDisposable
    {
        private readonly HttpClient httpClient;
        private bool _disposeed = false;
        public CurrencyService()
        {
            httpClient = new HttpClient();
        }
        ~CurrencyService()
        {
            //clear unmanaged object ***
            Dispose(false);
            Console.WriteLine("finalizer");
        }
        // disposing=true => (dispose manage + unmanaged code)
        // disposing=false => (dispose unmanaged code + larg fields)
        protected virtual void Dispose(bool disposing)
        {
            if (_disposeed) return;
            //disposing logic 
            if (disposing)
            {
                //dispose manage resource
                httpClient.Dispose();
                Console.WriteLine("managed code");
            }
            //unmanged object ***
            //set larg file to null
            _disposeed = true;
            Console.WriteLine("unmanaged");
        }
        public void Dispose()
        {
            //dispose called 100%
            Dispose(true);
            //so no need to call finalazer
            GC.SuppressFinalize(this);
        }

        public string GetCurrencies()
        {
            var url = "https://coinbase.com/api/v2/currencies";
            var result = httpClient.GetStringAsync(url).Result;
            return result;
        }
    }
}
