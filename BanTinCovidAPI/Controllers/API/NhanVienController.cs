using BanTinCovid.Models;
using BanTinCovidAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace BanTinCovidAPI.Controllers.API
{
    public class NhanVienController : ApiController
    {
        public IHttpActionResult GetAllNhanVien()
        {
            IList<NhanVienViewModel> nhanVienViewModels = null;

            using (var ctx = new BANTINCOVIDEntities())
            {
                nhanVienViewModels = ctx.NHANVIEN.Select(s => new NhanVienViewModel()
                {
                    MaNhanVien = s.MANHANVIEN,
                    cccd = s.CCCD, 
                    HoTen = s.HOTEN, 
                    SoDT = s.SODT, 
                    DiaChi = s.DIACHI,
                    email = s.EMAIL,
                    TrangThaiXoa = s.TrangThaiXoa,
                    MatKhau = s.MATKHAU,
                    NgaySinh = s.NGAYSINH



                }).ToList<NhanVienViewModel>();
            }

            if (nhanVienViewModels.Count == 0)
            {
                return NotFound();
            }

            return Ok(nhanVienViewModels);
        }
        //public IHttpActionResult GetAllTinTucByTheLoai(string maTheLoai)
        //{
        //    IList<TinTucViewModel> tinTuc = null;

        //    using (var ctx = new BANTINCOVIDEntities())
        //    {
        //        tinTuc = ctx.TINTUC.Where(s => s.MATHELOAI.ToLower() == maTheLoai.ToLower())
        //            .Select(s => new TinTucViewModel()
        //            {
        //                MaTinTuc = s.MATINTUC,
        //                TenTinTuc = s.TENTINTUC,
        //                MaTheLoai = s.MATHELOAI,
        //                NoiDung = s.NOIDUNG,
        //                NoiDungNgan = s.NOIDUNGNGAN,
        //                TacGia = s.TACGIA,
        //                MaNhanVien = s.MANHANVIEN,
        //                Ngay = s.NGAY
        //            }).ToList<TinTucViewModel>();
        //    }

        //    if (tinTuc.Count == 0)
        //    {
        //        return NotFound();
        //    }

        //    return Ok(tinTuc);
        //}
        public IHttpActionResult PostNewNhanVien(NhanVienViewModel nhanVienViewModels)
        {
            if (!ModelState.IsValid)
                return BadRequest("Invalid data.");

            using (var ctx = new BANTINCOVIDEntities())
            {
                ctx.NHANVIEN.Add(new NHANVIEN()
                {

                    MANHANVIEN = nhanVienViewModels.MaNhanVien,
                    CCCD = nhanVienViewModels.cccd,
                    HOTEN = nhanVienViewModels.HoTen,
                    SODT = nhanVienViewModels.SoDT,
                    DIACHI = nhanVienViewModels.DiaChi,
                    EMAIL = nhanVienViewModels.email,
                    TrangThaiXoa = nhanVienViewModels.TrangThaiXoa,
                    MATKHAU = nhanVienViewModels.MatKhau,
                    NGAYSINH = nhanVienViewModels.NgaySinh
                });
                ctx.SaveChanges();
            }

            return Ok();
        }
        public IHttpActionResult PutNhanVien(NhanVienViewModel nhanVienViewModels)
        {
            if (!ModelState.IsValid)
                return BadRequest("Not a valid model");

            using (var ctx = new BANTINCOVIDEntities())
            {
                var existingNhanVien = ctx.NHANVIEN.Where(s => s.MANHANVIEN == nhanVienViewModels.MaNhanVien)
                                                        .FirstOrDefault<NHANVIEN>();

                if (existingNhanVien != null)
                {
                    existingNhanVien.MANHANVIEN = nhanVienViewModels.MaNhanVien;
                    existingNhanVien.CCCD = nhanVienViewModels.cccd;
                    existingNhanVien.HOTEN = nhanVienViewModels.HoTen;
                    existingNhanVien.SODT = nhanVienViewModels.SoDT;
                    existingNhanVien.EMAIL = nhanVienViewModels.email;
                    existingNhanVien.TrangThaiXoa = nhanVienViewModels.TrangThaiXoa;
                    existingNhanVien.MATKHAU = nhanVienViewModels.MatKhau;
                    existingNhanVien.NGAYSINH = nhanVienViewModels.NgaySinh;
                    ctx.SaveChanges();
                }
                else
                {
                    return NotFound();
                }
            }
            return Ok();
        }
        public IHttpActionResult DeleteNhanVien(string maNhanVien)
        {
            if (maNhanVien == "")
                return BadRequest("Not a valid Ma Nhan Vien");

            using (var ctx = new BANTINCOVIDEntities())
            {
                var nhanvien = ctx.NHANVIEN
                    .Where(s => s.MANHANVIEN.ToLower() == maNhanVien.ToLower())
                    .FirstOrDefault();

                ctx.Entry(nhanvien).State = System.Data.Entity.EntityState.Deleted;
                ctx.SaveChanges();
            }

            return Ok();
        }
    }
}
