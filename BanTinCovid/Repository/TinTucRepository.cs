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
    public class TinTucRepository
    {
        public HttpClient _client;
        public HttpResponseMessage _response;
        public TinTucRepository()
        {
            _client = new HttpClient();
           
            _client.BaseAddress = new Uri("https://localhost:44300/Api/");
            _client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

        }
        public async Task<List<TinTucViewModel>> getList()
        {
            _response = await _client.GetAsync("TinTuc");
            var json = await _response.Content.ReadAsStringAsync();
            var listTT = JsonConvert.DeserializeObject<List<TinTucViewModel>>(json);
            return listTT;
        }
        public void Add(TinTucViewModel TinTuc)
        {
            var tinTuc = JsonConvert.SerializeObject(TinTuc);
            var buffer = Encoding.UTF8.GetBytes(tinTuc);
            var byteContent = new ByteArrayContent(buffer);
            byteContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");
            _client.PostAsync("TinTuc", byteContent);
        }
        public void Delete(int matintuc)
        {
            _client.DeleteAsync("TinTuc?maTinTuc=" + matintuc);
        }
        public async Task<TinTucViewModel> GetTT(int matintuc)
        {
            _response = await _client.GetAsync("TinTuc");
            var json = await _response.Content.ReadAsStringAsync();
            var listNV = JsonConvert.DeserializeObject<List<TinTucViewModel>>(json);
            TinTucViewModel nv = listNV.Find(x => x.MaTinTuc == matintuc); 
            return nv;
        }
        public async Task<List<TinTucViewModel>> GetTTByTheLoai(String maTheLoai)
        {
            _response = await _client.GetAsync("TinTuc?maTheLoai=" + maTheLoai);
            var json = await _response.Content.ReadAsStringAsync();
            var listNV = JsonConvert.DeserializeObject<List<TinTucViewModel>>(json);
            return listNV;
        }


        public void Update(TinTucViewModel tintuc)
        {

            var tinTuc = JsonConvert.SerializeObject(tintuc);
            var buffer = Encoding.UTF8.GetBytes(tinTuc);
            var byteContent = new ByteArrayContent(buffer);
            byteContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");
            _client.PutAsync("TinTuc", byteContent);

        }
    }
}
