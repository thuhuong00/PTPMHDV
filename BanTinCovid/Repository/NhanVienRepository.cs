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
    public class NhanVienRepository
    {
        public HttpClient _client;
        public HttpResponseMessage _response;
        public NhanVienViewModel _nhanVienModel;
        public NhanVienRepository()
        {
            _client = new HttpClient();
       
            _client.BaseAddress = new Uri("https://localhost:44300/Api/");
            _client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

        }
         public async Task<List<NhanVienViewModel>> getList()
        {
            _response = await _client.GetAsync("NhanVien");
            var json = await _response.Content.ReadAsStringAsync();
            var listNV = JsonConvert.DeserializeObject<List<NhanVienViewModel>>(json);
            return listNV;
        }
        public void Add(NhanVienViewModel nhanvien)
        {
            var nhanVien = JsonConvert.SerializeObject(nhanvien);
            var buffer = Encoding.UTF8.GetBytes(nhanVien);
            var byteContent = new ByteArrayContent(buffer);
            byteContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");
            _client.PostAsync("NhanVien", byteContent);
        }
        public void Delete (String manhanvien)
        {
            _client.DeleteAsync("NhanVien?maNhanVien="+manhanvien);
        }
        public async Task<NhanVienViewModel> GetNV(String manhanvien)
        {
            //_response = await _client.GetAsync("NhanVien"+manhanvien);
            //var json = await _response.Content.ReadAsStringAsync();
            //var listNV = JsonConvert.DeserializeObject<NhanVienViewModel>(json);
            //return listNV;
            _response = await _client.GetAsync("NhanVien");
            var json = await _response.Content.ReadAsStringAsync();
            var listNV = JsonConvert.DeserializeObject<List<NhanVienViewModel>>(json);
            NhanVienViewModel nv = listNV.Find(x => x.MaNhanVien == manhanvien);
            return nv;
        }
            public void Update(NhanVienViewModel nhanvien)
        {

            var nhanVien = JsonConvert.SerializeObject(nhanvien);
            var buffer = Encoding.UTF8.GetBytes(nhanVien);
            var byteContent = new ByteArrayContent(buffer);
            byteContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");
            _client.PutAsync("NhanVien", byteContent);

        }
    }
}
