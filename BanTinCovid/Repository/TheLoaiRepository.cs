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
    public class TheLoaiRepository
    {
        public HttpClient _client;
        public HttpResponseMessage _response;
        public TheLoaiRepository()
        {
            _client = new HttpClient();
            
            _client.BaseAddress = new Uri("https://localhost:44300/Api/");
            _client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

        }
        public async Task<List<TheLoaiViewModel>> getList()
        {
            _response = await _client.GetAsync("TheLoai");
            var json = await _response.Content.ReadAsStringAsync();
            var listNV = JsonConvert.DeserializeObject<List<TheLoaiViewModel>>(json);
            return listNV;
        }
        public void Add(TheLoaiViewModel TheLoai)
        {
            var theLoai = JsonConvert.SerializeObject(TheLoai);
            var buffer = Encoding.UTF8.GetBytes(theLoai);
            var byteContent = new ByteArrayContent(buffer);
            byteContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");
            _client.PostAsync("TheLoai", byteContent);
        }
        public void Delete(String maTheLoai)
        {
            _client.DeleteAsync("TheLoai?maTheLoai=" + maTheLoai);
        }
        public async Task<TheLoaiViewModel> GetTL(String maTheLoai)
        {
            _response = await _client.GetAsync("TheLoai");
            var json = await _response.Content.ReadAsStringAsync();
            var listNV = JsonConvert.DeserializeObject<List<TheLoaiViewModel>>(json);
            TheLoaiViewModel nv = listNV.Find(x => x.MaTheLoai == maTheLoai);
            return nv;
        }
        public void Update(TheLoaiViewModel TheLoai)
        {
            var theLoai = JsonConvert.SerializeObject(TheLoai);
            var buffer = Encoding.UTF8.GetBytes(theLoai);
            var byteContent = new ByteArrayContent(buffer);
            byteContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");
            _client.PutAsync("TheLoai", byteContent);

        }
    }
}
