using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http.Headers;
using BanTinCovid.Models;
using Newtonsoft.Json;

namespace BanTinCovid.Reponsitory
{
    public class TinhHinhChungRepository
    {
        public HttpClient _client;
        public HttpResponseMessage _response;
        public TinhHinhChungRepository()
        {
            _client = new HttpClient();
            
            _client.BaseAddress = new Uri("https://localhost:44300/Api/");
            _client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

        }
        public async Task<List<TinhHinhChungViewModel>> getList()
        {
            _response = await _client.GetAsync("TinhHinhChung");
            var json = await _response.Content.ReadAsStringAsync();
            var listNV = JsonConvert.DeserializeObject<List<TinhHinhChungViewModel>>(json);
            return listNV;
        }
        public void Add(TinhHinhChungViewModel TinhHinhChung)
        {
            var tinhHinhChung = JsonConvert.SerializeObject(TinhHinhChung);
            var buffer = Encoding.UTF8.GetBytes(tinhHinhChung);
            var byteContent = new ByteArrayContent(buffer);
            byteContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");
            _client.PostAsync("TinhHinhChung", byteContent);



        }
        public void Delete(DateTime ngay)
        {
            _client.DeleteAsync("TinhHinhChung?ngay=" + ngay);

        }
        public async Task<TinhHinhChungViewModel> GetTHC(DateTime ngay)
        {

            _response = await _client.GetAsync("TinhHinhChung");
            var json = await _response.Content.ReadAsStringAsync();
            var listTHC = JsonConvert.DeserializeObject<List<TinhHinhChungViewModel>>(json);
            TinhHinhChungViewModel thc = listTHC.Find(x => x.Ngay == ngay);
            return thc;

        }
        public void Update(TinhHinhChungViewModel TinhHinhChung)
        {
            var tinhHinhChung = JsonConvert.SerializeObject(TinhHinhChung);
            var buffer = Encoding.UTF8.GetBytes(tinhHinhChung);
            var byteContent = new ByteArrayContent(buffer);
            byteContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");
            _client.PutAsync("TinhHinhChung", byteContent);

        }
    }
}
